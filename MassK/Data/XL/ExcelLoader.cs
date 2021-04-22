using IsuzuDraft.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Excel = fd
            }

            Products = GetProducts()
        }

        public void 
    }
}
