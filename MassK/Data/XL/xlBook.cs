using MassK.Exceptions;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace MassK.Data.XL
{
    class xlBook
    {
        public Excel.Workbook WBook { get; set; }
        public Excel.Application XlApp { get; set; }


        public xlBook(string filname)
        {
            XlApp = new Excel.Application();
            XlApp.Visible = true;
            WBook = XlApp.Workbooks.Open(Filename: filname, UpdateLinks: false);
        }

        public Excel.ListObject GetListObj(string name)
        {
            foreach (Excel.Worksheet sh in WBook.Worksheets)
            {
                foreach (Excel.ListObject lo in sh.ListObjects)
                {
                    if (lo.Name == name) return lo;
                }
            }
            throw new BException($"listObj {name } not found ! ");
        }

        public void Close()
        {
            WBook.Close(false);
            XlApp.Quit();
            Marshal.ReleaseComObject(XlApp);
        }
    }
}
