using MassK.BL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MassK.UI.Forms
{
    public partial class FormChangeImage : Form
    {    
        public ImageItem SelectedImage { get; private set; }

        public FormChangeImage()
        {
            InitializeComponent();
            panel1.BackColor = StyleUI.FrameBlueColor;
            panel2.BackColor = StyleUI.FrameBlueColor;
        }

        private void FormChangeImage_Load(object sender, EventArgs e)
        {
            SetDataGrid();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dataGrid.DataSource = null;
           
            dataGrid.Columns[0].DataPropertyName = "ID";
            dataGrid.Columns[1].DataPropertyName = "Группа картинок";
            dataGrid.Columns[2].DataPropertyName = "Наименование картинки";
            dataGrid.Columns[3].DataPropertyName = "Картинка";
           
            dataGrid.DataSource = ProjectMandger.Images;

            //foreach (ImageItem item in ProjectMandger.Images)
            //{
            //    dataGrid.Rows.Add(item.Id, item.Group, item.Name,  item.Picture);
            //}
        }

        private void SetDataGrid()
        {
            dataGrid.Columns.Add("id", "ID");
            dataGrid.Columns.Add("group", "Группа картинок");
            dataGrid.Columns.Add("name", "Наименование картинки");
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn(false)
            {
                Name = "picture",
                HeaderText = "Картинка"
            };
            dataGrid.Columns.Add(imageColumn);
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowTemplate.MinimumHeight = 70;
            dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedCells.Count > 0)
            {
                string idText = dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[0].Value?.ToString() ?? "";
                if (int.TryParse(idText, out int id))
                {
                    SelectedImage = ProjectMandger.Images.First(x => x.Id == id);
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
