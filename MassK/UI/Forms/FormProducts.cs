using MassK.BL;
using MassK.UI.LangPacks;
using MassK.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using DGASMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode;
using DGVTBColumn = System.Windows.Forms.DataGridViewTextBoxColumn;
using DGVChBColumn = System.Windows.Forms.DataGridViewCheckBoxColumn;
using DGVColumn = System.Windows.Forms.DataGridViewColumn;
using System.Reflection;

namespace MassK.UI.Forms
{
    public partial class FormProducts : Form
    {
        List<Product> _products;
        List<Product> _buffer;
        List<KeyboardItem> _keyboard;
        
        BindingSource _binding = new BindingSource();

        PulsTimer _timer = new PulsTimer();

        internal FormProducts(List<Product> products, List<KeyboardItem> keyboards)
        {
            InitializeComponent();
            _products = products;
            _keyboard = keyboards;
            _buffer = new List<Product>(_products);
            _timer.Interval = 500;
        }
        

        protected override void OnLoad(EventArgs e)
        {
            SetDataGrid();
            LangPack.Translate(this, dataGrid, FillFilter);
            SetCheckedOnLoad();
            _binding.DataSource = _buffer;
            dataGrid.DataSource = _binding;
            _binding.ResetBindings(false);
            base.OnLoad(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _timer.Dispose();
            base.OnClosing(e);            
        }

        private void SetDataGrid()
        {
            dataGrid.Columns.Clear();

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
                (typeof(DGVTBColumn), "ID", "ID товара", "ID", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Code", "Code товара", "Code", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "PLU", "PLU товара", "PLU", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Name", "Наименование товара", "Name", true, DGASMode.Fill, true),
                (typeof(DGVChBColumn), "Selected", "Выбран", "Selected", false, DGASMode.ColumnHeader, true)
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

            foreach (var name in new[] { "ID", "Code", "PLU", "Name" })
                dataGrid.Columns[name].CellTemplate.Style.BackColor = Color.LightGray;
        }

        private void FillFilter()
        {
            CBoxFields.Items.Clear();
            foreach (DGVColumn col in dataGrid.Columns)
                if(col.Name != "Selected")
                    CBoxFields.Items.Add(col.HeaderText);

            if (CBoxFields.Items.Count > 0)
                CBoxFields.SelectedIndex = 0;
        }

        private void SetCheckedOnLoad()
        {
            foreach(var product in _products)
                if (_keyboard.Find(i => i.ID == product.ID) is KeyboardItem kbi)
                    product.Selected = true;
        }

        //Обработчики
        private void ButtonApply_Click(object sender, EventArgs e)
        {
            foreach(var prod in _products)
                if (prod.Selected && _keyboard.Find(k => k.ID == prod.ID) == null)
                {
                    _keyboard.Add(new KeyboardItem()
                    {
                        ID = prod.ID,
                        Code = prod.Code,
                        Name = prod.Name
                    });
                }
                else if(!prod.Selected && _keyboard.Find(k => k.ID == prod.ID) is KeyboardItem item)
                {
                    _keyboard.Remove(item);
                }

            DialogResult = DialogResult.OK;
        }

        private void dataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGVColumn column = dataGrid.Columns[e.ColumnIndex];
            if (column.Name == "Selected")
                return;

            SortOrder sort_order = column.HeaderCell.SortGlyphDirection;
            ClearSortSortGlyph();

            Type type = typeof(Product);
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

        private void ClearSortSortGlyph()
        {
            foreach (DGVColumn col in dataGrid.Columns)
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
        }

        private void TboxFilter_TextChanged(object sender, EventArgs e) => _timer.Puls(PulsAction);
        private void CBoxFields_SelectedIndexChanged(object sender, EventArgs e) => _timer.Puls(PulsAction);

        public void PulsAction()
        {
            ClearSortSortGlyph();
            string filter_text = TboxFilter.Text.ToLower();

            if (string.IsNullOrWhiteSpace(filter_text))
            {
                _buffer = new List<Product>(_products);
                _binding.DataSource = _buffer;
                return;
            }

            Type type = typeof(Product);
            PropertyInfo propertyInfo = type.GetProperty(new Func<string>(() =>
            {
                foreach (DGVColumn col in dataGrid.Columns)
                    if (col.HeaderText == CBoxFields.Text)
                        return col.DataPropertyName;

                return "";
            }).Invoke());

            _buffer = new List<Product>();

            foreach (var prod in _products)
                if (propertyInfo.GetValue(prod) is string str && str.ToLower().Contains(filter_text))
                    _buffer.Add(prod);

            _binding.DataSource = _buffer;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            base.OnKeyDown(e);
        }
    }
}
