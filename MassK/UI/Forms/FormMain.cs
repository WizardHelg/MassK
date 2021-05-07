
using MassK.BL;
using MassK.Data;
using MassK.LangPacks;
using MassK.UI;
using MassK.UI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MassK
{
    /// <summary>
    ///  Форма редактор клавиатуры
    /// </summary>
    public partial class FormMain : Form
    {
        readonly Properties.Settings settings = Properties.Settings.Default;

        public FormMain()
        {
            InitializeComponent();
            SetStyle();
            FillLangs();
            FillCodePage();
            dataGrid.RowHeadersVisible = false;
            SetDataGrid();
            FillFields();
        }

        private void FillCodePage()
        {
            foreach ((string name, int codePage) codePage in ProjectMandger.CodePages)
                CBoxCode.Items.Add(codePage.name);
            CBoxCode.Text = ProjectMandger.CodePageName;
        }

        private void SetStyle()
        {
            panel1.BackColor = StyleUI.FrameBlueColor;
            panel2.BackColor = StyleUI.FrameBlueColor;
        }

        private void SetLang()
        {
            ProjectMandger.SetCurrentLang();
            ProjectMandger.LangPack.SetText(this);
        }

        private void FillLangs()
        {
            CbxLang.Items.Clear();
            foreach (string lang in ProjectMandger.LangPaksList)
            {
                CbxLang.Items.Add(lang);
            }
            CbxLang.Text = ProjectMandger.CurrentLang;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetEnabledControls(false);
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            ChangeProduct();
        }

        private void BtnPictureDirectory_Click(object sender, EventArgs e)
        {
            new FormPictureDirectory(ProjectMandger.LangPack).Show();
        }

        private void BtnWeighingMachins_Click(object sender, EventArgs e)
        {
            FormWeighingMachins formWeighingMachins = new FormWeighingMachins(ProjectMandger.LangPack);

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
            ProjectMandger.CurrentLang = curLang;
            SetLang();
        }

        private void FillDataGrid(List<KeyboardItem> products)
        {
            dataGrid.Columns[0].DataPropertyName = "ID";
            dataGrid.Columns[1].DataPropertyName = "Code";
            dataGrid.Columns[2].DataPropertyName = "Name";
            dataGrid.Columns[3].DataPropertyName = "PictureID";
            dataGrid.Columns[4].DataPropertyName = "PictureName";
            dataGrid.Columns[5].DataPropertyName = "Picture";
            dataGrid.Columns[6].DataPropertyName = "Number";
            dataGrid.Columns[7].DataPropertyName = "Category";
            dataGrid.DataSource = products;

            dataGrid.Columns[8].Visible = false;
            dataGrid.Columns[9].Visible = false;
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
            FormSetProductNumber form = new FormSetProductNumber() { ProductNumber = (ProductNumber)settings.TypeProductNumber };
            if (form.ShowDialog() == DialogResult.OK)
            {
                settings.TypeProductNumber = (byte)form.ProductNumber;
                settings.Save();
                BlockImages();
            }
        }


        private void BlockImages()
        {
            if (settings.TypeProductNumber == (byte)ProductNumber.PLU)
            {
                dataGrid.Columns[6].InheritedStyle.BackColor = StyleUI.LightGrayColor;
                dataGrid.Columns[6].ReadOnly = true;
            }
            else
            {
                dataGrid.Columns[6].InheritedStyle.BackColor = Color.White;
                dataGrid.Columns[6].ReadOnly = false;
            }
        }

        private void SetDataGrid()
        {
            dataGrid.Columns.Clear();
            ///  dataGrid.DataError += CustomDataGrid_DataError;
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
                HeaderText = "Категория",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                FlatStyle = FlatStyle.Flat
            };
            foreach (ProductCategory category in ProjectMandger.ProductCategories)
            {
                cboxColumn.Items.Add(category.Category);
            }

            dataGrid.Columns.Add(cboxColumn);
            dataGrid.RowTemplate.MinimumHeight = 50;
            dataGrid.Columns[0].ReadOnly = true;
            dataGrid.Columns[0].CellTemplate.Style.BackColor = StyleUI.LightGrayColor;

            dataGrid.Columns[1].ReadOnly = true;
            dataGrid.Columns[1].CellTemplate.Style.BackColor = StyleUI.LightGrayColor;
            dataGrid.Columns[2].ReadOnly = true;
            dataGrid.Columns[2].CellTemplate.Style.BackColor = StyleUI.LightGrayColor;
            dataGrid.Columns[3].ReadOnly = true;
            dataGrid.Columns[4].ReadOnly = true;
            dataGrid.Columns[5].ReadOnly = true;

            dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BlockImages();
        }


        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Rows[e.RowIndex].Cells[0].Value == null) ChangeProduct(e.RowIndex);
            else if (e.ColumnIndex > 2 && e.ColumnIndex < 6) ChangeImage(e.RowIndex);
            else if (e.ColumnIndex == 7) ChangeCategories();
        }


        private void ChangeImage(int rowIndex)
        {
            FormChangeImage form = new FormChangeImage();
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
                                KeyboardItem keyboardItem = ProjectMandger.KeyboardItems.First(x => x.ID == idFind);
                                if (keyboardItem != null)
                                {
                                    keyboardItem.ImagePath = form.SelectedImage.Path;
                                    keyboardItem.PictureName = form.SelectedImage.Name;
                                    keyboardItem.PictureID = form.SelectedImage.Id;
                                    keyboardItem.Picture = form.SelectedImage.Picture;
                                    SetDataGrid();
                                    FillDataGrid(ProjectMandger.KeyboardItems);
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
            FormProductDirectory form = new FormProductDirectory(ProjectMandger.LangPack);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        /// <summary>
        ///  Установить активность элементов
        /// </summary>
        /// <param name="enabled"></param>
        private void SetEnabledControls(bool enabled)
        {
            BtnUnloadToWeighing.Enabled = enabled;
            BtnSaveToUsb.Enabled = enabled;
            BtnProducts.Enabled = enabled;
            CBoxFields.Enabled = enabled;
            сохранитьПроектВПКToolStripMenuItem.Enabled = enabled;
            TboxFilter.Enabled  = enabled;
            ChkBoxShowProducts.Enabled = enabled;
        }

        private void сохранитьПроектВПКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectMandger.SaveToLocal();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }


        private void загрузитьПроектИзПКToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if ( ProjectMandger.LoadLocalProject())
            {
                SetKeyboardItems();
            }
        }

        private void SetKeyboardItems()
        {
            SetEnabledControls(true);
            ProjectMandger.GetImages(ProjectMandger.KeyboardItems);
            SetDataGrid();
            FillDataGrid(ProjectMandger.KeyboardItems);
        }
        private void BtnUnloadToWeighing_Click(object sender, EventArgs e)
        {
          
        }


        private void загрузитьДанныеСUSBFlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectMandger.KeyboardItems = ProjectMandger.LoadFromUsb();
                SetEnabledControls(false);
                SetKeyboardItems();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось загрусить данные с USB.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void загрузитьДанныеИзВесовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void CBoxCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectMandger.CodePageName = CBoxCode.Text;
        }


        private void BtnSaveToUsb_Click(object sender, EventArgs e)
        {
            ProjectMandger.SaveToUsb();
        }

        #region  Справка 
        private void BtnHelp_Click(object sender, EventArgs e)
        {

        }
        private void MenuDescription_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region Фильтрация DataGrid
    


        Dictionary<string, int> fields;
        private Dictionary<string, int> GetFields()
        {
            if (fields is null)
            {
                fields = new Dictionary<string, int>();
                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    fields.Add(column.HeaderText, fields.Count);
                }
            }
            return fields;
        }

        private void FillFields()
        {
            fields = GetFields();
            foreach (string field in fields.Keys)
            {
                CBoxFields.Items.Add(field);
            }
            CBoxFields.SelectedIndex = 0;
        }

        private void TboxFilter_TextChanged(object sender, EventArgs e)
        {

            //string selectedField = CBoxFields.Text;
            //string rowFilter = string.Format("[{0}] = '{1}'", selectedField, TboxFilter.Text) ;
            //DataTable table =(DataTable) dataGrid.DataSource;
            // table.DefaultView.RowFilter = rowFilter;
        }

        #endregion
    }
}

//private void загрузитьИзExcelToolStripMenuItem_Click(object sender, EventArgs e)
//{
//    dataGrid.Columns.Clear();

//    SetDataGrid();
//    FillDataGrid(ProjectMandger.KeyboardItems);
//}

//private static Dictionary<string, string> Fields = new Dictionary<string, string>()
//{
//    {"Наименование товара", "Name" },
//    {"ID - товара",     "ID" },
//    {"Code - товара",   "Code" },
//    {"ID - картинки",   "PictureID" },
//    {"№",               "Number" },
//    {"Категория",       "Category" },
//};

//private static Dictionary<string, int> Fields = new Dictionary<string, int>()
//{
//    {"ID - товара",         0},
//    {"Наименование товара", 1 },
//    {"Code - товара",       2 },
//    {"ID - картинки",       3},
//    {"Наименование картинки", 4},
//    {"№",                   7},
//    {"Категория",           8}
//};

//SaveFileDialog sfd = new SaveFileDialog()
//{
//    InitialDirectory = SettingManager.SettingPath,
//    Filter = "XML|*.xml"
//};
//try
//{
//    if (sfd.ShowDialog() == DialogResult.OK)
//    {
//        SettingManager.Save<KeyboardItem>(_KeyboardItems, sfd.FileName);
//        MessageBox.Show(sfd.FileName, "Проект Сохранен", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//}
//catch (Exception ex)
//{
//    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
//}