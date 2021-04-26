using MassK.BL;
using MassK.LangPacks;
using MassK.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK
{
    public partial class FormPictureDirectory : Form
    {
        List<ImageItem> _images;


        public FormPictureDirectory(LangPack langPack)
        {
            langPack.SetText(this);
            InitializeComponent();
            panel1.BackColor = StyleUI.FrameColor;
            panel2.BackColor = StyleUI.FrameColor;

            SetDataGrid();
        }

        private void FormPictureDirectory_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
        
            Ookii.Dialogs.WinForms.VistaFolderBrowserDialog ofd = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string folder = ofd.SelectedPath;
                string[] files = Directory.GetFiles(folder);
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    string extention = fi.Extension.ToLower();
                    if (extention != ".png" && extention != ".jpg") continue;
                    ImageManager.ImportPicture(file);

                }
                SetData();
            }
        }

        private void SetData()
        {
            _images = ImageManager.LoadPictures();
            //_images = SettingManager.Load<ImageItem>();
            //if (_images is null) _images = new List<ImageItem>();
            // string[] files = Directory.GetFiles(SettingManager.ImagePath);
            // foreach (string file in files)
            // {
            //     FileInfo fi = new FileInfo(file);
            //     string extention = fi.Extension.ToLower();
            //     if (extention != ".png") continue;

            //     Image picture = new Bitmap(file);

            //     ImageItem item = _images.Find(x => x.Path == file) ?? default;
            //     if (item is null)
            //     {
            //         item = new ImageItem()
            //         {
            //             Id = ImageManager.GetFreeId(_images),                        
            //             Name = Path.GetFileNameWithoutExtension(file),
            //             Path = file,
            //             Picture = picture
            //         };
            //         _images.Add(item);
            //     }
            //     else
            //     {
            //         item.Picture = picture;
            //     }
            // }

            FillDataGrid(_images);
        }
        private void SetDataGrid()
        {
            List<ProductCategory> productCategories = SettingManager.Load<ProductCategory>();
            dataGrid.Columns.Add("id", "ID");
            DataGridViewComboBoxColumn cboxColumn = new DataGridViewComboBoxColumn()
            {
                Name = "group",
                HeaderText = "Группа картинок"
            };
            dataGrid.Columns.Add(cboxColumn);

            foreach (ProductCategory category in productCategories)
                cboxColumn.Items.Add(category.Category);

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
            //dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;            
            dataGrid.RowTemplate.MinimumHeight = 50;

            dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "PNG | *.png", Multiselect = true };
            if (ofd.ShowDialog() == DialogResult.OK)
            {                
                string[] files = ofd.FileNames;
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    string extention = fi.Extension.ToLower();
                    if (ImageManager.ImageExtentions.Contains(extention,StringComparer.InvariantCultureIgnoreCase) )
                    {
                        ImageManager.ImportPicture(file);
                    }
                }
                SetData();
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogo_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _images.Clear();

            foreach (DataGridViewRow row in  dataGrid.Rows)
            {
                string idText = row.Cells[0].Value?.ToString() ?? "0";
                string path = row.Cells[3].Value?.ToString() ?? "";
                if (string.IsNullOrEmpty(path)) continue;

                ImageItem imageItem = new ImageItem()
                {
                    Id = int.Parse(idText),
                    Group = row.Cells[1].Value?.ToString() ?? "",
                    Name = row.Cells[2].Value?.ToString() ?? "",
                    Path = path
                };
                _images.Add(imageItem);
            }
            SettingManager.Save(_images);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                string path = dataGrid.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
                if (File.Exists(path))
                {
                    dataGrid.Rows.Remove(dataGrid.SelectedRows[0]);
                    _images.RemoveAll(x => x.Path == path);

                    File.Delete(path);
                    MessageBox.Show($"Файл :{path}. Был удален!", "Изображение удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
