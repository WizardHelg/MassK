using MassK.Data;
using MassK.Exceptions;
using MassK.UI.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK.BL
{
    class ProjectMandger
    {
        public static readonly Properties.Settings settings = Properties.Settings.Default;

        public EventHandler Update;

        /// <summary>
        /// Класс 
        /// </summary>
        public static LangPacks.LangPack LangPack
        {
            get
            {
                LangPacks.LangPack.Load(SettingManager.LangPath);
                return LangPacks.LangPack.Lang;
            }
        }

        /// <summary>
        /// Выбранный язык 
        /// </summary>
        public static string CurrentLang
        {
            get => settings.Lang;
            set { settings.Lang = value; settings.Save(); }
        }


        //private static LangPacks.LangPack _LangPack;

        public static List<KeyboardItem> LoadFromUsb()
        {
            try
            {
                string usbRootPath = UsbDisk.FindUsbPath();
                string file = Path.Combine(usbRootPath, $"01PC0000000000.dat");

                List<KeyboardItem> keyboardItems = MKConverter.KBFromDat(file, 0);
                // SetKeyboardItems(_KeyboardItems);
                MessageBox.Show(file, "Проект загружен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return keyboardItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось найти USB с проектом", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            throw new BException("Проект отсутствует");
        }
        public static List<KeyboardItem> LoadFromProject()
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = SettingManager.SettingPath,
                Multiselect = false,
                Filter = "XML|*.xml"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<KeyboardItem> keyboardItems = SettingManager.Load(ofd.FileName);
                // SetKeyboardItems(keyboardItems);
                MessageBox.Show(ofd.FileName, "Проект загружен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return keyboardItems;
            }
            throw new BException("Проект отсутствует");
        }

        ///
        private static void SaveProject(List<KeyboardItem> keyboardItems)
        {

            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = SettingManager.SettingPath,
                Filter = "XML|*.xml"
            };
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    SettingManager.Save<KeyboardItem>(keyboardItems, sfd.FileName);
                    MessageBox.Show(sfd.FileName, "Проект Сохранен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void GetImages(List<KeyboardItem> keyboardItems)
        {
            foreach (KeyboardItem itm in keyboardItems)
            {
                if (string.IsNullOrEmpty(itm.ImagePath)) continue;
                if (File.Exists(itm.ImagePath))
                {
                    itm.Picture = new Bitmap(itm.ImagePath);
                }
            }
        }


        //public static void ChangeImage(int rowIndex)
        //{
        //    FormChangeImage form = new FormChangeImage(_images);
        //    if (form.ShowDialog() == DialogResult.OK)
        //    {
        //        if (form.SelectedImage != null)
        //        {
        //            if (dataGrid.SelectedCells.Count > 0)
        //            {
        //                string idKeyboardItm = dataGrid.Rows[dataGrid.SelectedCells[0].RowIndex].Cells[0].Value?.ToString() ?? "";

        //                if (!string.IsNullOrEmpty(idKeyboardItm))
        //                {
        //                    if (int.TryParse(idKeyboardItm, out int idFind))
        //                    {
        //                        KeyboardItem keyboardItem = _KeyboardItems.First(x => x.ID == idFind);
        //                        if (keyboardItem != null)
        //                        {
        //                            keyboardItem.ImagePath = form.SelectedImage.Path;
        //                            keyboardItem.PictureName = form.SelectedImage.Name;
        //                            keyboardItem.Picture = form.SelectedImage.Picture;
        //                            SetDataGrid();
        //                            FillDataGrid(_KeyboardItems);
        //                        }

        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

    }
}
