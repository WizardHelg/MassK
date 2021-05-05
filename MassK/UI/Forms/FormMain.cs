
using MassK.BL;
using MassK.Data;
using MassK.LangPacks;
using MassK.UI;
using MassK.UI.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MassK
{
    public partial class FormMain : Form
    {
        private LangPack _langPack;
        readonly Properties.Settings settings = Properties.Settings.Default;

        List<ProductCategory> _categories;
        List<KeyboardItem> _KeyboardItems;
        List<ImageItem> _images;

        private static Dictionary<string, string> Fields = new Dictionary<string, string>()
        {
            {"Наименование товара","Name" },
            {"ID - товара","ID" },
            {"Code - товара","Code" },
            {"ID - картинки","PictureID" },
            {"№","Number" },
            {"Категория","Category" },
        };


        public FormMain()
        {
            InitializeComponent();
            panel1.BackColor = StyleUI.FrameBlueColor;
            panel2.BackColor = StyleUI.FrameBlueColor;

            string cur_lang = settings.Lang;
            FillLangs(_langPack);

            LangPack.Load(SettingManager.LangPath);
            SetLang(cur_lang);

            dataGrid.RowHeadersVisible = false;

            _categories = SettingManager.Load<ProductCategory>();
            if (_categories == null) _categories = new List<ProductCategory>();

            _images = ImageManager.LoadPictures();


            SetDataGrid();
            dataGrid.RowCount = 10;
            dataGrid.ColumnCount = 8;

            foreach (string field in Fields.Keys)
            {
                CBoxFields.Items.Add(field);
            }
            CBoxFields.SelectedIndex = 0;
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
            ChangeProduct();
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



        private void FillDataGrid(List<KeyboardItem> products)
        {
            foreach (KeyboardItem product in products)
            {
                DataGridViewRow row = dataGrid.Rows[dataGrid.Rows.Add()];
                FillRow(product, row);
            }
        }

        private void FillRow(KeyboardItem product, DataGridViewRow row)
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



        private void загрузитьИзExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();

            Loader loader = new ExcelLoader();
            loader.Load();
            _KeyboardItems = loader.KeyboardItems;
            SetDataGrid();
            FillDataGrid(_KeyboardItems);
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
            if (form.ShowDialog() == DialogResult.OK)
            {
                //form.ProductNumber
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }


        private void SetDataGrid()
        {
            dataGrid.Columns.Clear();
            //dataGrid.Rows.Clear();
            dataGrid.DataError += CustomDataGrid_DataError;
            dataGrid.ShowCellErrors = false;
            dataGrid.Columns.Add("id", "ID");
            dataGrid.Columns.Add("code", "Code - товара");
            dataGrid.Columns.Add("name", "Наименование товара");
            dataGrid.Columns.Add("pictureid", "ID - картинки");
            dataGrid.Columns.Add("picturename", "Имя картинки");
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn(false)
            {
                Name = "picture",
                HeaderText = "Картинка"
            };
            dataGrid.Columns.Add(imageColumn);
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGrid.Columns.Add("number", "№");
            DataGridViewComboBoxColumn cboxColumn = new DataGridViewComboBoxColumn()
            {
                Name = "group",
                HeaderText = "Категория"
            };
            foreach (ProductCategory category in _categories)
            {
                cboxColumn.Items.Add(category.Category);
            }

            dataGrid.Columns.Add(cboxColumn);
            dataGrid.RowTemplate.MinimumHeight = 50;
            // customDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid.Columns[0].ReadOnly = true;
            dataGrid.Columns[1].ReadOnly = true;
            dataGrid.Columns[2].ReadOnly = true;

            dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }


        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Rows[e.RowIndex].Cells[0].Value == null) ChangeProduct(e.RowIndex);
            else if (e.ColumnIndex > 2 && e.ColumnIndex < 6) ChangeImage(e.RowIndex);
            else if (e.ColumnIndex == 7) ChangeCategories();
        }


        private void ChangeImage(int rowIndex)
        {
            FormChangeImage form = new FormChangeImage(_images);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.SelectedImage != null)
                {
                    if (dataGrid.SelectedCells.Count > 0)
                    {
                        string idKeyboardItm = dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[0].Value?.ToString() ?? "";

                        if (!string.IsNullOrEmpty(idKeyboardItm))
                        {
                            if (int.TryParse(idKeyboardItm, out int idFind))
                            {
                                KeyboardItem keyboardItem = _KeyboardItems.First(x => x.ID == idFind);
                                if (keyboardItem != null)
                                {
                                    keyboardItem.ImagePath = form.SelectedImage.Path;
                                    keyboardItem.PictureName = form.SelectedImage.Name;
                                    keyboardItem.Picture = form.SelectedImage.Picture;
                                    SetDataGrid();
                                    FillDataGrid(_KeyboardItems);
                                }

                            }
                        }
                    }
                }
            }
        }
        private void ChangeCategories()
        {
            FormCategoryProducts form = new FormCategoryProducts();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void ChangeProduct(int rowIndex = -1)
        {
            if (rowIndex == -1) rowIndex = dataGrid.RowCount;
            FormProductDirectory form = new FormProductDirectory(_langPack);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void сохранитьПроектВПКToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = SettingManager.SettingPath,
                Filter = "XML|*.xml"
            };
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    SettingManager.Save<KeyboardItem>(_KeyboardItems, sfd.FileName);
                    MessageBox.Show(sfd.FileName, "Проект Сохранен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void загрузитьПроектИзПКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = SettingManager.SettingPath,
                Multiselect = false,
                Filter = "XML|*.xml"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _KeyboardItems = SettingManager.Load(ofd.FileName);
                GetImages(_KeyboardItems);
                SetDataGrid();
                FillDataGrid(_KeyboardItems);
                MessageBox.Show(ofd.FileName, "Проект загружен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GetImages(List<KeyboardItem> keyboardItems)
        {
            foreach (KeyboardItem itm in keyboardItems)
            {
                if (string.IsNullOrEmpty(itm.ImagePath)) continue;
                if (File.Exists(itm.ImagePath))
                {
                    itm.Picture = new Bitmap(itm.ImagePath);
                }
            }
        }

        private void CbxLang_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
