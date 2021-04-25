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
          
             if (fd.ShowDialog() != DialogResult.OK ||  !File.Exists(fd.FileName))
            {  throw new BException("File not found"); }
            else
            {
                XL.xlBook book =new XL.xlBook(fd.FileName);
                Products = GetProducts(book.GetListObj("Products"));
                book.Close();   
            }
        }

        private List<Product> GetProducts(ListObject listObject)
        {
            List<Product> products = new List<Product>();
            foreach(Excel.ListRow row in listObject.ListRows)
            {
                string idText = row.Range[1, 1].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(idText))
                {
                    string pictureName = row.Range[1, 5].Value?.ToString() ?? "";
                    string pictureFileName = GetFileName(pictureName);
                    Bitmap picture;
                    if (File.Exists(pictureFileName))
                    {
                        picture = new Bitmap(pictureFileName);
                    }
                    else
                    {
                        picture = default;
                    }
                    products.Add(new Product()
                    {
                        ID = int.TryParse(idText, out int id) ? id : 0,
                        Code = row.Range[1, 2].Value?.ToString() ?? "",
                        Name = row.Range[1, 3].Value?.ToString() ?? "",
                        PictureID = row.Range[1, 4].Value?.ToString() ?? "",
                        ImagePicture = pictureName,
                        Picture = picture ,
                        Number = int.TryParse(row.Range[1, 7].Value?.ToString() ?? "", out int num) ? num : 0,
                        Category = row.Range[1, 8].Value?.ToString() ?? "",
                    }) ;
                }
            }
            return products;
        }

        private string GetFileName(string pictureName)
        {            
            string directory = SettingManager.ImagePath;         
            string  filename = Path.Combine(directory, pictureName+".png");
            return filename;
        }
    }
}
