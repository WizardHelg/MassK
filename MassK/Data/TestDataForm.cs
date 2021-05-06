using MassK.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK.Data
{
    public partial class TestDataForm : Form
    {
        public TestDataForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var usbs = MKConverter.GetUSBS();
            //List<KeyboardItem> keyboard = new List<KeyboardItem>()
            //{
            //    new KeyboardItem()
            //    {
            //        CategoryID = 1,
            //        Category = "Какахи",
            //        ID = 6,
            //        Number = 6,
            //        PictureID = 1,
            //        ImagePath = @"C:\Users\wizar\YandexDisk\Разработка\МАССА-К\Картинки RUS_290421\1_Овощи_Авокадо.png"
            //    },
            //    new KeyboardItem()
            //    {
            //        CategoryID = 1,
            //        Category = "Мочахи",
            //        ID = 7,
            //        Number = 7,
            //        PictureID = 2,
            //        ImagePath = @"C:\Users\wizar\YandexDisk\Разработка\МАССА-К\Картинки RUS_290421\2_Овощи_Баклажаны.png"
            //    }
            //};

            //MKConverter.KBToDat(keyboard, usbs[0], null);
            MKConverter.KBFromDat(@"D:\64PC0000000000.dat");

            //var files = Directory.GetFiles(@"D:\");


            //MKConverter.ProdPLUFromDat(files[0], files[4]);
            //MKConverter.Test();
        }
    }
}
