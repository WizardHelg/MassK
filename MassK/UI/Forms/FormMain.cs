
using MassK.BL;
using MassK.Data;
using MassK.LangPacks;
using MassK.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MassK
{
    public partial class FormMain : Form
    {
        private LangPack _langPack;
        readonly Properties.Settings settings = Properties.Settings.Default;

        public FormMain()
        {
           InitializeComponent();
            panel1.BackColor = StyleUI.FrameColor;
            panel2.BackColor = StyleUI.FrameColor;

            SetDataGrid();
           string cur_lang = settings.Lang;
           LangPack.Load(SettingManager.LangPath);
           SetLang(cur_lang);
           FillLangs(_langPack);
        }

        private void SetDataGrid()
        {
            customDataGrid.DataError += CustomDataGrid_DataError;
            customDataGrid.ShowCellErrors = false;
            customDataGrid.RowHeadersVisible = false;
            customDataGrid.RowCount = 10 ;
            customDataGrid.ColumnCount = 8 ;
            customDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SetHeaderNames();
        }

        private void CustomDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void SetLang(string cur_lang)
        {
            if (!string.IsNullOrEmpty(LangPack.GetLangNames().Find(x => x == cur_lang)))
                LangPack.SetLang(cur_lang);
            else
                LangPack.SetCurrentCultureLang();

            _langPack = LangPack.Lang;
            if (_langPack != null)
            {
                _langPack.SetText(this);
            }
        }

        private void FillLangs(LangPack langPack)
        {
            CbxLang.Items.Clear();
            foreach (string lang in LangPack.GetLangNames())
            {
                CbxLang.Items.Add(lang);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
          
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            new FormProductDirectory(_langPack).Show();
        }

        private void BtnPictureDirectory_Click(object sender, EventArgs e)
        {
            new FormPictureDirectory(_langPack).Show();
        }

        private void BtnWeighingMachins_Click(object sender, EventArgs e)
        {
            new FormWeighingMachins(_langPack).Show();
        }

        private void CbxLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curLang = CbxLang.Items[CbxLang.SelectedIndex].ToString();
            string findLang = LangPack.GetLangNames().Find(x => x == curLang);
            if (!string.IsNullOrEmpty(findLang))
            {
                settings.Lang = findLang;
                settings.Save();
                SetLang(findLang);
            }
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            customDataGrid.Columns.Clear();
            
            Loader loader = new ExcelLoader();
            loader.Load();
                      
            customDataGrid.DataSource = loader.Products;
            SetHeaderNames();
            
            /// FillDataGrid(loader.Products);
        }

        private void FillDataGrid(List<Product> products)
        {
            foreach (Product product in products)
            {
                DataGridViewRow row = new DataGridViewRow();
                FillRow(product,row);
                customDataGrid.Rows.Add(row);
                
            }
        }

        private void FillRow(Product product, DataGridViewRow row)
        {
            row.Cells[0].Value = product.ID;
            row.Cells[1].Value = product.Code;
            row.Cells[2].Value = product.Name;
            row.Cells[3].Value = product.PictureID;
            row.Cells[4].Value = product.ImagePicture;
            row.Cells[5].Value = product.Picture;
            row.Cells[6].Value = product.Number;
            row.Cells[7].Value = product.Category;
        }

        public void SetHeaderNames()
        {
            customDataGrid.Columns[0].Name = "ID";
            customDataGrid.Columns[1].Name = "Code - товара";
            customDataGrid.Columns[2].Name = "Наименование товара";
            customDataGrid.Columns[3].Name = "ID - картинки";
            customDataGrid.Columns[4].Name = "Имя картинки";
            customDataGrid.Columns[5].Name = "Картинка";
            customDataGrid.Columns[6].Name = "№";
            customDataGrid.Columns[7].Name = "Категория";


            customDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customDataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


        }
            public void SetHeaders()
       {
            DataGridViewColumn columnId = new DataGridViewColumn() 
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID",
                CellTemplate = new DataGridViewTextBoxCell()
            }; 
            customDataGrid.Columns.Add(columnId);
            DataGridViewColumn columnCode = new DataGridViewColumn()
            {
                Name = "Code",
                DataPropertyName = "Code",
                HeaderText = "Code - товара",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            customDataGrid.Columns.Add(columnCode);

            DataGridViewColumn columnName = new DataGridViewColumn () 
            {
                Name = "ProductName",
                DataPropertyName = "Name",
                HeaderText = "Наименование товара",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            customDataGrid.Columns.Add(columnName);

            DataGridViewColumn  columnIdPicture = new DataGridViewColumn () 
            {
                Name = "IdPicture",
                DataPropertyName = "PictureID",
                HeaderText = "ID - картинки",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            customDataGrid.Columns.Add(columnIdPicture);
            DataGridViewColumn  columnPictureName = new DataGridViewColumn () 
            {
                Name = "PictureName",
                DataPropertyName = "ImagePicture",
                HeaderText = "Имя картинки",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            customDataGrid.Columns.Add(columnPictureName);

            DataGridViewColumn columnPicture = new DataGridViewColumn()
            {
                Name = "Picture",
                DataPropertyName = "Picture",
                HeaderText = "Картинка",
                CellTemplate = new DataGridViewImageCell()
            };
            customDataGrid.Columns.Add(columnPicture);
            DataGridViewColumn  columnNumber = new DataGridViewColumn ()
            {
                Name = "Number",
                DataPropertyName = "Number",
                HeaderText = "№",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            customDataGrid.Columns.Add(columnNumber);

            DataGridViewColumn  columnCategory = new DataGridViewColumn ()
            {
                Name = "Category",
                DataPropertyName = "Category",
                HeaderText = "Категория",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            customDataGrid.Columns.Add(columnCategory);
        }

        private void загрузитьПроектИзПКToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // BtnFile_Click();
        }
    }
}
