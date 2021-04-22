using Excel = Microsoft.Office.Interop.Excel;

namespace MassK.Data.XL
{
    class xlBook
    {
        public Excel.Workbook WBook { get; set; }  

        public xlBook(string filname)
        {
            WBook = Excel.Workbook    
        }


    }
}
