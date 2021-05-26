using MassK.BL;
using MassK.Data;
using MassK.UI.LangPacks;
using MassK.UI;
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
using System.Reflection;

namespace MassK.UI.Forms
{
    public partial class FormImages : Form
    {
        List<ImageItem> _images;
        BindingSource _binding = new BindingSource();

        public FormImages() => InitializeComponent();

        protected override void OnLoad(EventArgs e)
        {
            _images = ImageManager.LoadPictures(SettingManager.UserPictures);
            _images.AddRange(ImageManager.LoadPictures(SettingManager.LogoPath));
            SetDataGrid();
            LangPack.Translate(this, dataGrid, FillFilter);
            dataGrid.DataSource = _binding;
            _binding.DataSource = _images;
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
                (typeof(DGVTBColumn), "Name", "Имя картинки", "Name", false, DGASMode.Fill, true),
                (typeof(DGVIColumn), "Picture", "Картинка", "Picture", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Path", "Path", "Path", true, DGASMode.AllCells, false),
                (typeof(DGVTBColumn), "Group", "Group", "Group", true, DGASMode.AllCells, false)
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
                dataGrid.Columns.Add(col);
            }

            ((DGVIColumn)dataGrid.Columns["Picture"]).ImageLayout = DataGridViewImageCellLayout.Zoom;


            foreach (var name in new[] { "ID" })
                dataGrid.Columns[name].CellTemplate.Style.BackColor = Color.LightGray;
        }

        private void FillFilter()
        {
            CBoxFields.Items.Clear();
            foreach (var name in new[] { "ID", "Name", "Picture" })
                CBoxFields.Items.Add(dataGrid.Columns[name].HeaderText);

            if (CBoxFields.Items.Count > 0)
                CBoxFields.SelectedIndex = 0;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = ImageManager.ImageFilter(),
                Multiselect = false,
                Title = LangPack.GetText("ImportPicture")
            };

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                int id = ImageManager.GetFreeId(_images);
                var image_file = ImageManager.ImportPicture(dialog.FileName, SettingManager.UserPictures, id);
                using(FileStream fs = new FileStream(image_file.Path, FileMode.Open))
                    _images.Add(new ImageItem()
                    {
                        ID = id,
                        Group = "User",
                        Name = image_file.Name,
                        Path = image_file.Path,
                        Picture = Image.FromStream(fs)
                    });

                _binding.ResetBindings(false);
            }
        }


        private void ButtonLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = ImageManager.ImageFilter(),
                Multiselect = false,
                Title = LangPack.GetText("ImportLogo")
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var image_file = ImageManager.ImportPicture(dialog.FileName, SettingManager.LogoPath, 0, true);
                using (FileStream fs = new FileStream(image_file.Path, FileMode.Open))
                    _images.Add(new ImageItem()
                    {
                        ID = 0,
                        Group = "User",
                        Name = "Logo",
                        Path = image_file.Path,
                        Picture = Image.FromStream(fs)
                    });
                _binding.ResetBindings(false);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid.SelectedRows)
                {
                    var image = _images.Find(i => i.ID == (int)row.Cells["ID"].Value);
                    try
                    {
                        File.Delete(image.Path);
                    }
                    catch
                    {
                        return;
                    }
                    _images.Remove(image);
                }

                _binding.ResetBindings(false);
            }
        }

        private void DataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGVColumn column = dataGrid.Columns[e.ColumnIndex];
            if (column.Name == "Picture")
                return;

            SortOrder sort_order = column.HeaderCell.SortGlyphDirection;
            ClearSortSortGlyph();

            Type type = typeof(ImageItem);
            PropertyInfo propertyInfo = type.GetProperty(column.DataPropertyName);

            switch (sort_order)
            {
                case SortOrder.None:
                    _binding.DataSource = _images.OrderBy(prod => propertyInfo.GetValue(prod));
                    column.HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                    break;
                case SortOrder.Ascending:
                    _binding.DataSource = _images.OrderByDescending(prod => propertyInfo.GetValue(prod));
                    column.HeaderCell.SortGlyphDirection = SortOrder.Descending;
                    break;
                case SortOrder.Descending:
                    _binding.DataSource = _images;
                    column.HeaderCell.SortGlyphDirection = SortOrder.None;
                    break;
            }
        }

        private void ClearSortSortGlyph()
        {
            foreach (DGVColumn col in dataGrid.Columns)
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            base.OnKeyDown(e);
        }
    }
}
