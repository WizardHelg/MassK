using MassK.BL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MassK.Settings;
using MassK.UI.LangPacks;
using DGASMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode;
using DGVTBColumn = System.Windows.Forms.DataGridViewTextBoxColumn;
using DGVIColumn = System.Windows.Forms.DataGridViewImageColumn;
using DGVCBColumn = System.Windows.Forms.DataGridViewComboBoxColumn;
using DGVColumn = System.Windows.Forms.DataGridViewColumn;
using ScaleFileNum = MassK.Data.ConnectionManager.RAWFiles.ScaleFileNum;
using System.Reflection;


namespace MassK.UI.Forms
{
    public partial class FormChangeImage : Form
    {
        readonly KeyboardItem _kbItem;
        List<ImageItem> _images;
        List<ImageItem> _buffer;
        readonly PulsTimer _timer = new PulsTimer();
        readonly BindingSource _binding = new BindingSource();

        internal FormChangeImage(KeyboardItem kbItem)
        {
            InitializeComponent();
            _kbItem = kbItem;
            LbProductName.Text = _kbItem.Name;
            _timer.Interval = 500;
        }

        protected override void OnLoad(EventArgs e)
        {
            _images = ImageManager.LoadPictures(SettingManager.DefaultImagesPath);
            _images.AddRange(ImageManager.LoadPictures(SettingManager.UserPictures));
            SetDataGrid();
            LangPack.Translate(this, dataGrid);
            dataGrid.DataSource = _binding;
            _buffer = new List<ImageItem>(_images);
            _binding.DataSource = _buffer;
            base.OnLoad(e);
        }

        private void SetDataGrid()
        {
            dataGrid.Columns.Clear();
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                (typeof(DGVTBColumn), "ID", "ID картинки", "ID", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Group", "Группа картики", "Group", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Name", "Имя картинки", "Name", true, DGASMode.Fill, true),
                (typeof(DGVIColumn), "Picture", "Картинка", "Picture", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Path", "Path", "Path", true, DGASMode.AllCells, false),
            };

            foreach (var item in DGSetting)
            {
                DGVColumn col = Activator.CreateInstance(item.Type) as DGVColumn;
                col.Name = item.Name;
                col.HeaderText = item.HeaderText;
                col.DataPropertyName = item.DataPropertyName;
                col.ReadOnly = item.ReadOnly;
                col.AutoSizeMode = item.AutoSizeMode;
                col.Visible = item.Visible;
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns.Add(col);
            }

            ((DGVIColumn)dataGrid.Columns["Picture"]).ImageLayout = DataGridViewImageCellLayout.Zoom;


            foreach (var name in new[] { "ID", "Group", "Name" })
                dataGrid.Columns[name].CellTemplate.Style.BackColor = Color.LightGray;
        }

        private void DataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGVColumn column = dataGrid.Columns[e.ColumnIndex];
            if (column.Name == "Picture")
                return;

            SortOrder sort_order = column.HeaderCell.SortGlyphDirection;
            ClearSortGlyph();

            Type type = typeof(ImageItem);
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
        public void PulsAction()
        {
            ClearSortGlyph();
            string filter_text = TboxFilter.Text.ToLower();

            if (string.IsNullOrWhiteSpace(filter_text))
            {
                _buffer = new List<ImageItem>(_images);
                _binding.DataSource = _buffer;
                return;
            }

            _buffer = new List<ImageItem>();
            foreach (var img in _images)
            {
                if (img.Name.ToLower().Contains(filter_text))
                    _buffer.Add(img);
            }

            _binding.DataSource = _buffer;
        }



        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            if(dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGrid.SelectedRows[0];
                int id = (int)row.Cells["ID"].Value;
                ImageItem image = _images.Find(i => i.ID == id);
                _kbItem.PictureID = image.ID;
                _kbItem.PictureName = image.Name;
                _kbItem.ImagePath = image.Path;
                _kbItem.Picture = image.Picture;
                DialogResult = DialogResult.OK;
            }
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGrid.Rows[e.RowIndex];
            int id = (int)row.Cells["ID"].Value;
            ImageItem image = _images.Find(i => i.ID == id);
            _kbItem.PictureID = image.ID;
            _kbItem.PictureName = image.Name;
            _kbItem.ImagePath = image.Path;
            _kbItem.Picture = image.Picture;
            DialogResult = DialogResult.OK;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            base.OnKeyDown(e);
        }

      
    }
}
