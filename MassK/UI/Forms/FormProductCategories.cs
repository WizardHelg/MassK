using MassK.BL;
using MassK.Settings;
using MassK.UI.LangPacks;
using MassK.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DGASMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode;
using DGVTBColumn = System.Windows.Forms.DataGridViewTextBoxColumn;
using DGVIColumn = System.Windows.Forms.DataGridViewImageColumn;
using DGVCBColumn = System.Windows.Forms.DataGridViewComboBoxColumn;
using DGVColumn = System.Windows.Forms.DataGridViewColumn;

namespace MassK.UI.Forms
{
    public partial class FormProductCategories : Form
    {
        List<ProductCategory> _categories = SettingManager.Categories;
        BindingSource _binding = new BindingSource();

        public FormProductCategories() => InitializeComponent();

        protected override void OnLoad(EventArgs e)
        {
            SetDataGrid();
            LangPack.Translate(this, dataGrid);

            _binding.DataSource = _categories;
            dataGrid.DataSource = _binding;
            dataGrid.DataError += DataGrid_DataError;
            base.OnLoad(e);
        }

        private void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void SetDataGrid()
        {
            dataGrid.Columns.Clear();
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AutoGenerateColumns = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ShowCellErrors = false;

            var DGSetting = new List<(Type Type,
                                      string Name,
                                      string HeaderText,
                                      string DataPropertyName,
                                      bool ReadOnly,
                                      DGASMode AutoSizeMode,
                                      bool Visible)>()
            {
                (typeof(DGVTBColumn), "ID", "ID", "ID", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Category", "Категория", "Category", false, DGASMode.Fill, true),
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
                col.ValueType = typeof(string);
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
                dataGrid.Columns.Add(col);
            }


            foreach (var name in new[] { "ID" })
                dataGrid.Columns[name].CellTemplate.Style.BackColor = Color.LightGray;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            int id = _categories.OrderByDescending(i => i.ID).FirstOrDefault()?.ID ?? 0;           
            _categories.Add(new ProductCategory() { ID = ++id, Category = "" });
            _binding.ResetBindings(false);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dataGrid.SelectedRows)
                    _categories.RemoveAll(p => p.ID == (int)row.Cells["ID"].Value);

                _binding.ResetBindings(false);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(_categories.All(c => !string.IsNullOrWhiteSpace(c.Category)))
            {
                SettingManager.Categories = _categories;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(LangPack.GetText("ProductCategoryFormWrongValues"), LangPack.GetText("MSGBoxHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
