using MassK.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK
{
    public partial class FormCategoryProducts : Form
    {
        internal List<ProductCategory> Categories { get; set; }

        public FormCategoryProducts()
        {
            InitializeComponent();
            dataGrid.RowHeadersVisible = false;
            dataGrid.DataError += DataGrid_DataError;
            //SettingManager.Load<>
            //  dataGrid.Columns.Add("ID", "ID");
            // dataGrid.Columns.Add("Category", "Категория");
            //  dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Ошибка таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
         //   e.Cancel = true; 
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // dataGrid.Rows.Add();
            int id = Categories.OrderByDescending(i => i.ID).FirstOrDefault()?.ID ?? 0;
            
            Categories.Add(new ProductCategory() { ID = ++id, Category = "" });

            SetDataSource();
        }

        private void SetDataSource()
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = Categories;
        }


        private void FormCategoryProducts_Load(object sender, EventArgs e)
        {
            //BindingSource source = new BindingSource();
            //source.cha
            //source.DataSource = users;
            //dataGridView1.DataSource = source;

            dataGrid.DataSource = Categories;
            dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {           
            Categories.RemoveAll(x => string.IsNullOrWhiteSpace(x.Category) || string.IsNullOrWhiteSpace(x.ID.ToString()));
           SettingManager.Save(Categories);
           Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count> 0)
            {
             int id =(int) dataGrid.SelectedRows[0].Cells[0].Value  ;
                Categories.RemoveAll(x => x.ID == id);
                SetDataSource();
            }
        }
    }
}
