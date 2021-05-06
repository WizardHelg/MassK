using MassK.BL;
using MassK.Data;
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
            panel1.BackColor = StyleUI.FrameBlueColor;
            panel2.BackColor = StyleUI.FrameBlueColor;
            _images = ImageManager.GetImages();
            SetDataGrid();
            
            //dataGrid.DataError += DataGrid_DataError;
        }
        private void SetData()
        {
            FillDataGrid(_images);
        }
        private void FormPictureDirectory_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private string[] Categories()
        {
            return _images.GroupBy(im => im.Group).Select(x => x.Key).ToArray();
        }

        private void SetDataGrid()
        {
          //  List<ProductCategory> imagesCategories = SettingManager.Load<ProductCategory>();
            dataGrid.Columns.Add("id", "ID");
            DataGridViewComboBoxColumn cboxColumn = new DataGridViewComboBoxColumn()
            {
                Name = "group",
                HeaderText = "Группа картинок",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                FlatStyle = FlatStyle.Flat
            };
            dataGrid.Columns.Add(cboxColumn);
            cboxColumn.Items.AddRange(Categories());

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
            dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FillDataGrid(List<ImageItem> images)
        {
            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();
            foreach (ImageItem item in images)
            {
              int ix =  dataGrid.Rows.Add(item.Id, item.Group, item.Name, item.Picture);
                if (item.IsUserFile)
                {
                    dataGrid.Rows[ix].DefaultCellStyle.BackColor = StyleUI.LightGrayColor;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Все файлы | *.*", Multiselect = true , Title = "Выберите файлы изображений" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] files = ofd.FileNames;
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    string extention = fi.Extension.ToLower();
                    if (ImageManager.ImageExtentions.Contains(extention, StringComparer.InvariantCultureIgnoreCase))
                    {
                        string pathNewImg = ImageManager.ImportUserPicture(file, SettingManager.UserPictures);
                        int idNewItm = ImageManager.GetFreeId(_images);
                        _images.Add(new ImageItem() { Path = pathNewImg, Id = idNewItm });
                    }
                }
                SettingManager.Save(_images);
                SetData();
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {

        }
        private string ImageFilter()
        {
            string filter = "Файлы изображений";
            string extentions = "";
           foreach(string extention in ImageManager.ImageExtentions)
            {                
                extentions += $"*{extention}, ";
            }
            extentions = extentions.Remove(extentions.Length - 2, 2);
             filter += $"({extentions}) | {extentions}";
            return filter;
        }


        private void BtnLogo_Click(object sender, EventArgs e)
        {
            string filter = ImageFilter();
            OpenFileDialog ofd = new OpenFileDialog() { Filter = filter, Multiselect = false, Title = "Выберите файл логотипа" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName;
                string newItm = ImageManager.ImportUserPicture(file, SettingManager.UserPictures);

               ImageItem imageItem = _images.Find(x => x.Group == "Логотип");
                if (imageItem == null) _images.Remove(imageItem);

                string name = Path.GetFileNameWithoutExtension(file);
                _images.Add(new ImageItem() { Name = name, Group= "Логотип", Id = 0, Path = file } );
                SettingManager.Save(_images);
            }
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
                    if (!ImageManager.ImageExtentions.Contains(extention)) continue;
                    string newItm = ImageManager.ImportUserPicture(file, SettingManager.UserPictures);
                    int idNewItm = ImageManager.GetFreeId(_images);
                    _images.Add(new ImageItem() { Path = newItm, Id = idNewItm });
                }
                SettingManager.Save(_images);
                SetData();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _images.Clear();

            foreach (DataGridViewRow row in dataGrid.Rows)
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
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedCells.Count > 0)
            {
                string path = dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[3].Value?.ToString() ?? "";
                if (File.Exists(path))
                {
                    dataGrid.Rows.Remove(dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex]);
                    _images.RemoveAll(x => x.Path == path);
                    SettingManager.Save(_images);
                    //File.Delete(path);
                    MessageBox.Show($"Файл :{path}. Был удален!", "Изображение удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _images = PictureDictionary.GetAllImages();
            SettingManager.Save(_images);
            _images = ImageManager.LoadPictures();           
            SetData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        //{
        //}
    }
}
