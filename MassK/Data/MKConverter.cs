using MassK.BL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK.Data
{
    static class MKConverter
    {
        enum BitMaskProd
        {
            CodeLenght = 15,
            GoodsTypeId = 0x100
        }

        /// <summary>
        /// Считывает файлы продуктов и PLU
        /// </summary>
        /// <param name="prodPath">Путь к файлу продуктов</param>
        /// <param name="pluPath">Путь к файлу PLU</param>
        /// <param name="CodePage">Кодовая страница. Если 0, то используется страница по умолчанию</param>
        /// <returns>Список продуктов</returns>
        public static List<Product> ProdFromDat(string prodPath, string pluPath, int CodePage = 0)
        {
            
            Encoding encoding = CodePage > 0 ? Encoding.GetEncoding(CodePage) : Encoding.Default;
            Dictionary<uint, Product> buffer = new Dictionary<uint, Product>();

            long file_lenght;
            long next_record;
            using(FileStream fs = new FileStream(prodPath, FileMode.Open))
            using(BinaryReader br = new BinaryReader(fs, encoding))
            {
                file_lenght = fs.Length;
                fs.Position = 14;

                do
                {
                    uint id = br.ReadUInt32();
                    next_record = br.ReadUInt16() + fs.Position;
                    long text_position = br.ReadByte() + fs.Position;
                    uint bit_mask = br.ReadUInt32();

                    if ((bit_mask & (uint)BitMaskProd.GoodsTypeId) == 0)
                    {
                        ushort lenght = (ushort)(bit_mask & (uint)BitMaskProd.CodeLenght);
                        byte[] temp = br.ReadBytes(lenght);
                        string code = encoding.GetString(temp);

                        fs.Position = text_position;
                        lenght = br.ReadUInt16();
                        temp = br.ReadBytes(lenght);
                        string name = encoding.GetString(temp).Replace("|", Environment.NewLine);

                        buffer.Add(id, new Product()
                        {
                            ID = (int)id,
                            Code = code,
                            Name = name
                        });
                    }

                    fs.Position = next_record;
                } while (fs.Position < file_lenght);
            }

            using (FileStream fs = new FileStream(pluPath, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs, encoding))
            {
                file_lenght = fs.Length;
                fs.Position = 14;

                do
                {
                    uint id = br.ReadUInt32();
                    next_record = br.ReadUInt16() + fs.Position;

                    byte[] temp = new byte[8];
                    fs.Read(temp, 0, 6);
                    long plu = BitConverter.ToInt64(temp, 0);

                    if(buffer.TryGetValue(br.ReadUInt32(), out Product product))
                        product.PLU = plu.ToString();

                    fs.Position = next_record;
                } while (fs.Position < file_lenght);
            }

            return buffer.Values.ToList();
        }

      

        /// <summary>
        /// Загружает файл клавиатуры
        /// </summary>
        /// <param name="kbPath">Путь к файлу клавиатуры</param>
        /// <param name="CodePage">Кодовая страница. Если 0, то используется страница по умолчанию</param>
        /// <returns>Список клавиш</returns>
        public static List<KeyboardItem> KBFromDat(string kbPath, int CodePage = 0)
        {
            Encoding encoding = CodePage > 0 ? Encoding.GetEncoding(CodePage) : Encoding.Default;
            List<KeyboardItem> keyboards = new List<KeyboardItem>();

            long file_lenght;
            long next_record;
            using (FileStream fs = new FileStream(kbPath, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs, encoding))
            {
                file_lenght = fs.Length;
                fs.Position = 14;

                do
                {
                    int id = br.ReadInt32();
                    next_record = br.ReadUInt32() + fs.Position;
                    if (id == 0)
                    {
                        fs.Position = next_record;
                        continue;
                    }
                    int pic_id = br.ReadInt32();

                    fs.Position = br.ReadUInt32() + fs.Position; //перепрыгиваем картинку
                    int number = br.ReadInt32();
                    int category_id = br.ReadInt32();
                    ushort lenght = br.ReadUInt16();
                    string category_name = encoding.GetString(br.ReadBytes(lenght));

                    keyboards.Add(new KeyboardItem()
                    {
                        ID = id,
                        PictureID = pic_id,
                        Number = number,
                        CategoryID = category_id,
                        Category = category_name
                    });

                    fs.Position = next_record;
                } while (fs.Position < file_lenght);
            }

            return keyboards;
        }

        /// <summary>
        /// Сохраняет файл клавиатуры
        /// </summary>
        /// <param name="keyboard">Список клавиш</param>
        /// <param name="saveDirectory">Папка куда сохранять</param>
        /// <param name="logoPath">Путь к логотипу. Если путь равен null то логотип не запишется</param>
        /// <param name="CodePage">Кодовая страница. Если 0, то используется страница по умолчанию</param>
        public static void KBToDat(List<KeyboardItem> keyboard, string saveDirectory, string logoPath = null, int CodePage = 0)
        {
            Encoding encoding = CodePage > 0 ? Encoding.GetEncoding(CodePage) : Encoding.Default;
            long version = -1;
            string last_file = null;
            
           //Directory.GetDirectory(saveDirectory)
            
            foreach(var file in Directory.GetFiles( saveDirectory, "64PC*.dat"))
            {
                string file_name = Path.GetFileNameWithoutExtension(file);
                if(file_name.Length == 14 && long.TryParse(file_name.Substring(4, 10), out long result) && result > version)
                {
                    version = result;
                    last_file = file;
                }
            }    
 
            version++;

            
            using(FileStream fs = new FileStream(Path.Combine(saveDirectory, $"64PC{version:D10}.dat"), FileMode.OpenOrCreate))
            using(BinaryWriter bw = new BinaryWriter(fs, encoding))
            {
                byte[] buffer = encoding.GetBytes($"64PC{version:D10}");
                bw.Write(buffer);

                byte[] pic_data;
                if (logoPath != null)
                { 
                    using (FileStream pfs = new FileStream(logoPath, FileMode.Open))
                    {
                        pic_data = new byte[pfs.Length];
                        pfs.Read(pic_data, 0, pic_data.Length);
                    }

                    bw.Write(0);
                    bw.Write(2 + pic_data.Length);
                    bw.Write(0);
                    bw.Write(pic_data.Length);
                    bw.Write(pic_data);
                }
                
                foreach (var key in keyboard)
                {
                    
                    using (FileStream pfs = new FileStream(key.ImagePath, FileMode.Open))
                    {
                        pic_data = new byte[pfs.Length];
                        pfs.Read(pic_data, 0, pic_data.Length);
                    }
                    byte[] category = encoding.GetBytes(key.Category);

                    bw.Write(key.ID);
                    bw.Write(16 + pic_data.Length + category.Length);
                    bw.Write(key.PictureID);
                    bw.Write(pic_data.Length);
                    bw.Write(pic_data);
                    bw.Write(key.Number);
                    bw.Write(key.CategoryID);
                    bw.Write((ushort)category.Length);
                    bw.Write(category);
                }

            }

            if (File.Exists(last_file))
                File.Delete(last_file);
        }
    }
}
