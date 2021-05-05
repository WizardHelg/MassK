using MassK.BL;
using MassK.Exceptions;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MassK.Data
{
    class ExcelLoader : Loader
    {
        public override void Load()
        {
            OpenFileDialog fd = new OpenFileDialog()
            {
                Filter = "Документ Excel|*.xls*|All files|*.*",
                Title = "Выберите Книгу Excel c данными для клавиатуры весов."
            };

            if (fd.ShowDialog() != DialogResult.OK || !File.Exists(fd.FileName))
            { return; } //throw new BException("File not found"); }
            else
            {
                XL.XlBook book = new XL.XlBook(fd.FileName);
                KeyboardItems = GetProducts(book.GetListObj("Products"));
                book.Close();
            }
        }

        private List<KeyboardItem> GetProducts(ListObject listObject)
        {
            List<KeyboardItem> products = new List<KeyboardItem>();
            List<ImageItem> images = ImageManager.LoadPictures();

            foreach (Excel.ListRow row in listObject.ListRows)
            {
                string idText = row.Range[1, 1].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(idText))
                {
                    Bitmap picture = default;
                    ImageItem img = default;
                    string pictureId = row.Range[1, 4].Value?.ToString() ?? "";


                    if (int.TryParse(pictureId, out int idimg))
                    {
                        img = (string.IsNullOrWhiteSpace(pictureId)) ? default : images.First(x => x.Id == idimg) ;
                    }

                    string path = "";
                    if (!string.IsNullOrEmpty(img?.Path ?? ""))
                    {
                        if (File.Exists(img.Path))
                        {
                            picture = new Bitmap(img.Path);
                            path = img.Path;
                        }
                    }

                    products.Add(new KeyboardItem()
                    {
                        ID = int.TryParse(idText, out int id) ? id : 0,
                        Code = row.Range[1, 2].Value?.ToString() ?? "",
                        Name = row.Range[1, 3].Value?.ToString() ?? "",
                        PictureID = row.Range[1, 4].Value?.ToString() ?? "",
                        PictureName = row.Range[1, 5].Value?.ToString() ?? "",
                        Picture = picture,
                        Number = int.TryParse(row.Range[1, 7].Value?.ToString() ?? "", out int num) ? num : 0,
                        Category = row.Range[1, 8].Value?.ToString() ?? "",
                        ImagePath = path
                    }) ;
                }
            }
            return products;
        }

        //private string GetFileName(string pictureName)
        //{            
        //    string directory = SettingManager.ImagePath;         
        //    string  filename = Path.Combine(directory, pictureName+".png");
        //    return filename;
        //}
    }
}
