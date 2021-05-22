
using MassK.BL;
using MassK.Data;
using MassK.UI.LangPacks;
using MassK.UI;
using MassK.UI.Forms;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MassK.Settings;

using DGASMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode;
using DGVTBColumn = System.Windows.Forms.DataGridViewTextBoxColumn;
using DGVIColumn = System.Windows.Forms.DataGridViewImageColumn;
using DGVCBColumn = System.Windows.Forms.DataGridViewComboBoxColumn;
using DGVColumn = System.Windows.Forms.DataGridViewColumn;
using ScaleFileNum = MassK.Data.ConnectionMenager.RAWFiles.ScaleFileNum;

using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Reflection;

namespace MassK.UI.Forms
{
    public partial class FormMain : Form
    {
        List<KeyboardItem> _buffer = new List<KeyboardItem>();

        List<Product> _products = new List<Product>();
        List<KeyboardItem> _keyboard = new List<KeyboardItem>();

        BindingSource _combo_box_column_binding = new BindingSource();
        BindingSource _binding = new BindingSource();
        bool _is_initial = false;
        PulsTimer _timer = new PulsTimer();

        public FormMain() => InitializeComponent();

        protected override void OnLoad(EventArgs e)
        {
            _is_initial = true;
            
            FillLangs();      
            FillCodePage();
            SetDataGrid();
            dataGrid.DataError += DataGrid_DataError;
            dataGrid.DataSource = _binding;
            FillFilter();

            LockControl(LockContolEnum.All);

            LangPack.Translate(this, dataGrid, FillFilter, FillCodePage);
            base.OnLoad(e);
            _is_initial = false;
        }

        private void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                _buffer[e.RowIndex].Category = "";
                return;
            }

            if (e.ColumnIndex == 6)
                MessageBox.Show(LangPack.GetText("MainFormWrongProductNumber"), LangPack.GetText("MSGBoxHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillLangs()
        {
            CbxLang.Items.Clear();
            foreach (string lang in LangPack.GetLangNames())
                CbxLang.Items.Add(lang);

            CbxLang.Text = SettingManager.Lang;
        }

        private void FillCodePage()
        {
            CBoxCode.Items.Clear();
            foreach (var codePage in SettingManager.GetCodePages())
                CBoxCode.Items.Add(codePage);
            CBoxCode.Text = SettingManager.NameCodePage;
        }

        private void SetDataGrid()
        {
            dataGrid.Columns.Clear();

            dataGrid.AutoGenerateColumns = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ShowCellErrors = false;
            dataGrid.RowTemplate.MinimumHeight = 50;

            var DGSetting = new List<(Type Type,
                                      string Name,
                                      string HeaderText,
                                      string DataPropertyName,
                                      bool ReadOnly,
                                      DGASMode AutoSizeMode,
                                      bool Visible)>()
            {
                (typeof(DGVTBColumn), "ID", "ID товара", "ID", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Code", "Code товара", "Code", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Name", "Наименование товара", "Name", true, DGASMode.Fill, true),
                (typeof(DGVTBColumn), "PictureId", "ID картинки", "PictureID", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "PictureName", "Имя картинки", "PictureName", true, DGASMode.AllCells, true),
                (typeof(DGVIColumn), "Picture", "Картинка", "Picture", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Number", "№", "Number", false, DGASMode.AllCells, true),
                (typeof(DGVCBColumn), "Category", "Категория", "Category", false, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "CategoryID", "CategoryID", "CategoryID", true, DGASMode.AllCells, false),
                (typeof(DGVTBColumn), "ImagePath", "ImagePath", "ImagePath", true, DGASMode.AllCells, false)
            };

            foreach(var item in DGSetting)
            {
                DGVColumn col = Activator.CreateInstance(item.Type) as DGVColumn;
                col.Name = item.Name;
                col.HeaderText = item.HeaderText;
                col.DataPropertyName = item.DataPropertyName;
                col.ReadOnly = item.ReadOnly;
                col.AutoSizeMode = item.AutoSizeMode;
                col.Visible = item.Visible;
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
                dataGrid.Columns.Add(col);
            }

            ((DGVIColumn)dataGrid.Columns["Picture"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            var combo_box_column = dataGrid.Columns["Category"] as DGVCBColumn;
            combo_box_column.MaxDropDownItems = 64;
            combo_box_column.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            combo_box_column.FlatStyle = FlatStyle.Flat;
            combo_box_column.ValueMember = "Category";
            _combo_box_column_binding.DataSource = SettingManager.Categories;
            combo_box_column.DataSource = _combo_box_column_binding;

            foreach (var name in new[] { "ID", "Code", "Name" })
                dataGrid.Columns[name].CellTemplate.Style.BackColor = Color.LightGray;

            PLUNumeration();
        }

        private void FillFilter()
        {
            CBoxFields.Items.Clear();
            foreach (var name in new[] { "ID", "Code", "Name", "PictureId", "PictureName" })
                CBoxFields.Items.Add(dataGrid.Columns[name].HeaderText);

            if (CBoxFields.Items.Count > 0)
                CBoxFields.SelectedIndex = 0;
        }

        private void PLUNumeration()
        {
            (bool ReadOnly, Color Color) value = SettingManager.PLUNumeration ? (true, Color.LightGray) : (false, Color.White);
            DGVColumn column = dataGrid.Columns["Number"];
            column.ReadOnly = value.ReadOnly;
            column.DefaultCellStyle.BackColor = value.Color;
        }


        #region old code

        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Получить строку, ID, kbItem
            DataGridViewRow row = dataGrid.Rows[e.RowIndex];
            int id = (int)row.Cells["ID"].Value;
            KeyboardItem kb_item = _keyboard.Find(k => k.ID == id);

            var form = new FormChangeImage(kb_item);
            if(form.ShowDialog() == DialogResult.OK)
            {
                _binding.ResetBindings(false);
            }
            //ФОрма изменения картинки
            //Если окей, то ребинд. Если слетает сортировка, то похер пока что.

            //if (dataGrid.Rows[e.RowIndex].Cells[0].Value == null) ChangeProduct(e.RowIndex);
            //else if (e.ColumnIndex > 2 && e.ColumnIndex < 6) ChangeImage(e.RowIndex);
            //else if (e.ColumnIndex == 7) ChangeCategories();
        }


        private void ChangeImage(int rowIndex)
        {
            //FormChangeImage form = new FormChangeImage();
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    if (form.SelectedImage != null)
            //    {
            //        if (dataGrid.SelectedCells.Count > 0)
            //        {
            //            string idKeyboardItm = dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[0].Value?.ToString() ?? "";

            //            if (!string.IsNullOrEmpty(idKeyboardItm))
            //            {
            //                if (int.TryParse(idKeyboardItm, out int idFind))
            //                {
            //                    KeyboardItem keyboardItem = ProjectMandger.KeyboardItems.First(x => x.ID == idFind);
            //                    if (keyboardItem != null)
            //                    {
            //                        keyboardItem.ImagePath = form.SelectedImage.Path;
            //                        keyboardItem.PictureName = form.SelectedImage.Name;
            //                        keyboardItem.PictureID = form.SelectedImage.Id;
            //                        keyboardItem.Picture = form.SelectedImage.Picture;
            //                        SetDataGrid();
            //                        SetSorceDataGrid(ProjectMandger.KeyboardItems);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
        }

        #endregion

        private void CBoxCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingManager.NameCodePage = CBoxCode.Text;
        }

        private void CbxLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_is_initial) return;

            string lang = CbxLang.Text;
            SettingManager.Lang = lang;
            LangPack.SetLang(lang);
            LangPack.Translate(this, dataGrid, FillFilter, FillCodePage);
        }

        private void CbxLang_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;
        private void CBoxCode_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void MenuSettings_ProductCategories_Click(object sender, EventArgs e)
        {
            var form = new FormProductCategories();
            if(form.ShowDialog() == DialogResult.OK)
            {
                _combo_box_column_binding.DataSource = SettingManager.Categories;
                _combo_box_column_binding.ResetBindings(false);
            }
        }

        private void MenuFile_LoadFromUSB_Click(object sender, EventArgs e)
        {
            string usb_path = ConnectionMenager.USB.FindUsbPath();
            if(usb_path == null)
            {
                MessageBox.Show(LangPack.GetText("MainFormNotFoundUSB"), LangPack.GetText("MSGBoxHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var prod_path = ConnectionMenager.RAWFiles.GetScaleFileName(ScaleFileNum.PROD, usb_path, true);
            var plu_path = ConnectionMenager.RAWFiles.GetScaleFileName(ScaleFileNum.PLU, usb_path, true);

            if(!File.Exists(prod_path) || !File.Exists(plu_path))
            {
                MessageBox.Show(LangPack.GetText("MainFormWrongUSBData"), LangPack.GetText("MSGBoxHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClearSortAndFilter();
            _buffer.Clear();
            _keyboard.Clear();
            _binding.ResetBindings(false);

            _products = MKConverter.ProdFromDat(prod_path, plu_path);
            LockControl(LockContolEnum.ExceptProd);
            MessageBox.Show(LangPack.GetText("MainFormUSBDataLoaded"), LangPack.GetText("MSGBoxHeader"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonProducts_Click(object sender, EventArgs e)
        {
            var form = new FormProducts(_products, _keyboard);
            if (form.ShowDialog() == DialogResult.OK && _keyboard.Count > 0)
            {
                ClearSortAndFilter();
                _buffer = new List<KeyboardItem>(_keyboard);
                _binding.DataSource = _buffer;
                LockControl(LockContolEnum.Nothing);
            }
        }

        private void ClearSortAndFilter()
        {
            ClearSortGlyph();
            TboxFilter.Text = "";
        }


        enum LockContolEnum
        {
            All,
            ExceptProd,
            Nothing
        }

        private void LockControl(LockContolEnum lockContol)
        {
            bool main_flag;
            if (lockContol != LockContolEnum.Nothing)
                main_flag = false;
            else
                main_flag = true;


            ButtonUploadToScales.Enabled = main_flag;
            ButtonSaveToUsb.Enabled = main_flag;            
            CBoxFields.Enabled = main_flag;
            MenuFile_SaveToPC.Enabled = main_flag;
            TboxFilter.Enabled = main_flag;
            ShowProductsWithoutPicturies.Enabled = main_flag;

            ButtonProducts.Enabled = lockContol != LockContolEnum.All ? true : false;
            MenuFile_LoadFromPC.Enabled = CheckProjectonPC();
        }

        private void ButtonSaveToUsb_Click(object sender, EventArgs e)
        {
            //Проставить ID категориям
            //Проверить все значения
            //Записать на диск
            int c = _keyboard.Count;
        }

        private void MenuSettings_ProductNumeration_Click(object sender, EventArgs e)
        {
            var form = new FormProductNumeration();
            if(form.ShowDialog() == DialogResult.OK)
                PLUNumeration();
        }

        private void MenuFile_SaveToPC_Click(object sender, EventArgs e)
        {
            SettingManager.Save(_products);
            SettingManager.Save(_keyboard);

            MenuFile_LoadFromPC.Enabled = true;
        }

        private bool CheckProjectonPC()
        {
            if (File.Exists(Path.Combine(SettingManager.SettingPath, "Product.xml"))
                && File.Exists(Path.Combine(SettingManager.SettingPath, "KeyBoardItem.xml")))
                return true;
            else
                return false;
        }
        private void MenuFile_LoadFromPC_Click(object sender, EventArgs e)
        {
            _products = SettingManager.Load<Product>();
            _keyboard = SettingManager.Load<KeyboardItem>();

            foreach (var item in _keyboard)
                if(File.Exists(item.ImagePath))
                    using (FileStream fs = new FileStream(item.ImagePath, FileMode.Open))
                        item.Picture = Image.FromStream(fs);

            _buffer = new List<KeyboardItem>(_keyboard);
            _binding.DataSource = _buffer;
            LockControl(LockContolEnum.Nothing);
        }

        private void DataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGVColumn column = dataGrid.Columns[e.ColumnIndex];
            if (column.Name == "Picture"
                || column.Name == "Number"
                || column.Name == "Category")
                return;

            SortOrder sort_order = column.HeaderCell.SortGlyphDirection;
            ClearSortGlyph();

            Type type = typeof(KeyboardItem);
            PropertyInfo propertyInfo = type.GetProperty(column.DataPropertyName);

            switch (sort_order)
            {
                case SortOrder.None:
                    _binding.DataSource = _buffer.OrderBy(prod => propertyInfo.GetValue(prod));
                    column.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                    break;
                case SortOrder.Ascending:
                    _binding.DataSource = _buffer.OrderByDescending(prod => propertyInfo.GetValue(prod));
                    column.HeaderCell.SortGlyphDirection = SortOrder.Descending;
                    break;
                case SortOrder.Descending:
                    _binding.DataSource = _buffer;
                    column.HeaderCell.SortGlyphDirection = SortOrder.None;
                    break;
            }
        }
        private void ClearSortGlyph()
        {
            foreach (DGVColumn col in dataGrid.Columns)
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
        }
        private void TboxFilter_TextChanged(object sender, EventArgs e) => _timer.Puls(PulsAction);
        private void CBoxFields_SelectedIndexChanged(object sender, EventArgs e) => _timer.Puls(PulsAction);
        public void PulsAction()
        {
            ClearSortGlyph();
            string filter_text = TboxFilter.Text.ToLower();

            if (string.IsNullOrWhiteSpace(filter_text))
            {
                _buffer = new List<KeyboardItem>(_keyboard);
                _binding.DataSource = _buffer;
                return;
            }

            Type type = typeof(KeyboardItem);
            PropertyInfo propertyInfo = type.GetProperty(new Func<string>(() =>
            {
                foreach (DGVColumn col in dataGrid.Columns)
                    if (col.HeaderText == CBoxFields.Text)
                        return col.DataPropertyName;

                return "";
            }).Invoke());

            _buffer = new List<KeyboardItem>();

            foreach (var kbi in _keyboard)
            {
                string str = propertyInfo.GetValue(kbi)?.ToString();
                if (str.ToLower().Contains(filter_text))
                    _buffer.Add(kbi);
            }

            _binding.DataSource = _buffer;
        }

        private void MenuSettings_PictureLibrary_Click(object sender, EventArgs e)
        {
            var form = new FormImages();
            form.ShowDialog();
        }

        private void MenuSettings_ScalesTable_Click(object sender, EventArgs e)
        {
            var form = new FormScalesTable();
            form.ShowDialog();
        }
    }
}
