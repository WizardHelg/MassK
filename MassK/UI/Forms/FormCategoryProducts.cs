using MassK.BL;
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
            panel1.BackColor = StyleUI.FrameBlueColor;
            panel2.BackColor = StyleUI.FrameBlueColor;           
        }

        private void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Ошибка таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
         //   e.Cancel = true; 
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
          
            int id = Categories.OrderByDescending(i => i.ID).FirstOrDefault()?.ID ?? 0;
            
            Categories.Add(new ProductCategory() { ID = ++id, Category = "" });
            SetDataSource();
        }

        private void SetDataSource()
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = Categories;
            dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void FormCategoryProducts_Load(object sender, EventArgs e)
        {
            SetDataSource();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {           
            Categories.RemoveAll(x => string.IsNullOrWhiteSpace(x.Category) || string.IsNullOrWhiteSpace(x.ID.ToString()));
           SettingManager.Save(Categories);
           Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedCells.Count> 0)
            {
             int id =(int) dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[0].Value  ;
                Categories.RemoveAll(x => x.ID == id);
                SetDataSource();
            }
        }
    }
}
