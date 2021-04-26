
using MassK.BL;
using MassK.Data;
using MassK.LangPacks;
using MassK.UI;
using MassK.UI.Forms;
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
        
        List<ProductCategory> _categories;
        List<Product> _products;

        public FormMain()
        {
            InitializeComponent();
            panel1.BackColor = StyleUI.FrameColor;
            panel2.BackColor = StyleUI.FrameColor;

            string cur_lang = settings.Lang;
            FillLangs(_langPack);

            LangPack.Load(SettingManager.LangPath);
            SetLang(cur_lang);
                       
            customDataGrid.RowHeadersVisible = false;

            _categories = SettingManager.Load<ProductCategory>();
            if (_categories == null) _categories = new List<ProductCategory>();

            SetDataGrid();
            customDataGrid.RowCount = 20;
            customDataGrid.ColumnCount = 8;
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
            FormWeighingMachins formWeighingMachins = new FormWeighingMachins(_langPack);

            List<WeighingMachine> weighingMachines = SettingManager.Load<WeighingMachine>();
            if (weighingMachines != null)
            {
                formWeighingMachins.WeighingMachines = weighingMachines;
            }

            formWeighingMachins.FormClosing += FormWeighingMachins_FormClosing;
            formWeighingMachins.Show();
        }

        private void FormWeighingMachins_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormWeighingMachins form = (FormWeighingMachins)sender;
            if (form.DialogResult == DialogResult.OK)
                SettingManager.Save(form.WeighingMachines);
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
            _products = loader.Products;
            SetDataGrid();
            FillDataGrid(_products);
        }

        private void FillDataGrid(List<Product> products)
        {           
            foreach (Product product in products)
            {
                DataGridViewRow row = customDataGrid.Rows[customDataGrid.Rows.Add()];
                FillRow(product, row);
            }
        }

        private void FillRow(Product product, DataGridViewRow row)
        {
            row.Cells[0].Value = product.ID;
            row.Cells[1].Value = product.Code;
            row.Cells[2].Value = product.Name;
            row.Cells[3].Value = product.PictureID;
            row.Cells[4].Value = product.PictureName;
            row.Cells[5].Value = product.Picture;
            row.Cells[6].Value = product.Number;
            row.Cells[7].Value = product.Category;
        }

        private void CustomDataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        public void SetHeaderNames()
        {
            //customDataGrid.Columns[0].Name = "ID";
            //customDataGrid.Columns[1].Name = "Code - товара";
            //customDataGrid.Columns[2].Name = "Наименование товара";
            //customDataGrid.Columns[3].Name = "ID - картинки";
            //customDataGrid.Columns[4].Name = "Имя картинки";
            //customDataGrid.Columns[5].Name = "Картинка";
            //customDataGrid.Columns[6].Name = "№";
            //customDataGrid.Columns[7].Name = "Категория";
           
        }

        private void загрузитьПроектИзПКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // BtnFile_Click();
        }

        private void категорииТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ProductCategory> categories = SettingManager.Load<ProductCategory>();
            FormCategoryProducts formCategoryProducts = new FormCategoryProducts() { Categories = categories };
            if (formCategoryProducts.ShowDialog() == DialogResult.OK)
            {
                SettingManager.Save(formCategoryProducts.Categories);
            }
        }


        /// <summary>
        ///  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void номераТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetProductNumber form = new FormSetProductNumber();
           if ( form.ShowDialog()== DialogResult.OK)
            {
                //form.ProductNumber
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }


        private void SetDataGrid()
        {
            customDataGrid.Rows.Clear();
            customDataGrid.DataError += CustomDataGrid_DataError;
            customDataGrid.ShowCellErrors = false;
            customDataGrid.Columns.Add("id", "ID");
            customDataGrid.Columns.Add("code", "Code - товара");
            customDataGrid.Columns.Add("name", "Наименование товара");
            customDataGrid.Columns.Add("pictureid", "ID - картинки");
            customDataGrid.Columns.Add("picturename", "Имя картинки");
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn(false)
            {
                Name = "picture",
                HeaderText = "Картинка"
            };
            customDataGrid.Columns.Add(imageColumn);
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            customDataGrid.Columns.Add("number", "№");
            DataGridViewComboBoxColumn cboxColumn = new DataGridViewComboBoxColumn()
            {
                Name = "group",
                HeaderText = "Категория"
            };
            foreach (ProductCategory category in _categories)
            {
                cboxColumn.Items.Add(category.Category);
            }

            customDataGrid.Columns.Add(cboxColumn);            
            customDataGrid.RowTemplate.MinimumHeight = 50;
            // customDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            customDataGrid.Columns[0].ReadOnly = true;
            customDataGrid.Columns[1].ReadOnly = true;
            customDataGrid.Columns[2].ReadOnly = true;

            customDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customDataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customDataGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
