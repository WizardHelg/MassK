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

namespace MassK.UI.Forms
{
    public partial class FormChangeImage : Form
    {
        private List<ImageItem> images;
        public ImageItem SelectedImage { get; private set; }

        public FormChangeImage()
        {
            InitializeComponent();
            panel1.BackColor = StyleUI.FrameBlueColor;
            panel2.BackColor = StyleUI.FrameBlueColor;
        }

        public FormChangeImage(List<ImageItem> images)
        {
            InitializeComponent();
            panel1.BackColor = StyleUI.FrameBlueColor;
            panel2.BackColor = StyleUI.FrameBlueColor;
            this.images = images;
        }

        private void FormChangeImage_Load(object sender, EventArgs e)
        {
            SetDataGrid();
            FillDataGrid(this.images);
        }

        private void FillDataGrid(List<ImageItem> images)
        {
            dataGrid.DataSource = null;
            //dataGrid.DataSource = images;
            foreach (ImageItem item in images)
            {
                dataGrid.Rows.Add(item.Id, item.Group, item.Name, item.Path, item.Picture);
            }
        }

        private void SetDataGrid()
        {
            dataGrid.Columns.Add("id", "ID");
            dataGrid.Columns.Add("group", "Группа картинок");
            dataGrid.Columns.Add("name", "Наименование картинки");
            dataGrid.Columns.Add("path", "Путь");
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn(false)
            {
                Name = "picture",
                HeaderText = "Картинка"
            };
            dataGrid.Columns.Add(imageColumn);
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowTemplate.MinimumHeight = 50;
            dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedCells.Count > 0)
            {
                string idText = dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[0].Value?.ToString() ?? "";
                if (int.TryParse(idText, out int id))
                {
                    SelectedImage = images.First(x => x.Id == id);
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
