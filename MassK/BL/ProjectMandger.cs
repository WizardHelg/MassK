using MassK.Data;
using MassK.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MassK.BL
{
    class ProjectMandger
    {
        public static readonly Properties.Settings settings = Properties.Settings.Default;
        public delegate void Update();
        public static event Update UpdateKeyboardItems;

        /// <summary>
        /// Класс 
        /// </summary>
        public static LangPacks.LangPack LangPack
        {
            get
            {
                if (LangPacks.LangPack.Lang == null)
                {
                    LoadLangPack();
                    LangPacks.LangPack.SetLang(CurrentLang);
                }
                return LangPacks.LangPack.Lang;
            }
        }


        public static void LoadLangPack()
        {
            LangPacks.LangPack.Load(SettingManager.LangPath);
        }

        public static List<string> LangPaksList
        {
            get
            {
                if (_LangPaksList is null)
                {
                    LoadLangPack();
                    _LangPaksList = LangPacks.LangPack.GetLangNames();
                }
                return _LangPaksList;
            }
        }
        static List<string> _LangPaksList;

        /// <summary>
        /// Выбранный язык 
        /// </summary>
        public static string CurrentLang
        {
            get => settings.Lang;
            set
            {
                settings.Lang = value;
                settings.Save();
            }
        }

        public static List<ProductCategory> ProductCategories
        {
            get
            {
                if (_ProductCategories is null)
                {
                    _ProductCategories = SettingManager.Load<ProductCategory>();
                    if (_ProductCategories == null) _ProductCategories = new List<ProductCategory>();


                }
                return _ProductCategories;
            }
            set
            {
                _ProductCategories = value;
            }
        }
        static List<ProductCategory> _ProductCategories;

        public static List<ImageItem> Images
        {
            get
            {
                if (_Images is null)
                {
                    _Images = ImageManager.GetImages();
                }
                return _Images;
            }
            set
            {
                _Images = value;
            }
        }
        static List<ImageItem> _Images;
        


        public static List<(string name, int codePage)> CodePages
        {
            get => MKConverter.GetCodePages();
        }
        public static string CodePageName
        {
            get
            {
                if (string.IsNullOrEmpty(_CodePageName))
                {
                    _CodePageName = settings.CodePageName;
                    if (string.IsNullOrEmpty(_CodePageName))
                    {
                        _CodePage = Encoding.Default.CodePage;
                        _CodePageName = CodePages.Find(x => x.codePage == Encoding.Default.CodePage).name;
                        if (string.IsNullOrEmpty(_CodePageName))
                        {
                            _CodePageName = "";
                        }
                    }
                }
                return _CodePageName;
            }
            set
            {
                _CodePageName = value;
                _CodePage = CodePages.Find(x => x.name == _CodePageName).codePage;
                settings.CodePageName = _CodePageName;
                settings.Save();
            }
        }
        static string _CodePageName;
        static int _CodePage = 0;


       public static List<KeyboardItem> KeyboardItems
        {
            get
            {
                if (_KeyboardItems is null) _KeyboardItems = new List<KeyboardItem>();
                return _KeyboardItems;
            }
            set => _KeyboardItems = value;
        }
        static List<KeyboardItem> _KeyboardItems;

        public static List<Product> Products
        {
            get
            {
                if (_Products is null) _Products = new List<Product>();
                return _Products;
            }
            set => _Products = value;
        }
        static List<Product> _Products;


        internal static void SetCurrentLang()
        {
            if (string.IsNullOrEmpty(LangPaksList.Find(x => x == CurrentLang)))
                CurrentLang = LangPacks.LangPack.SetCurrentCultureLang();
            LangPacks.LangPack.SetLang(CurrentLang);
        }


        public static List<KeyboardItem> LoadFromUsb()
        {
            try
            {
                string usbRootPath = UsbDirectory.FindUsbPath();
                string file = Path.Combine(usbRootPath, $"05PC0000000000.dat");

                List<KeyboardItem> keyboardItems = MKConverter.KBFromDat(file, _CodePage);
                MessageBox.Show(file, "Проект загружен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return keyboardItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось найти USB с проектом", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            throw new BException("Проект отсутствует");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyboardItems"></param>
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

        /// <summary>
        ///  Сохранить в Usb
        /// </summary>
        internal static void SaveToUsb()
        {
           if ( KeyboardItems.Count != 0)
            {
                string usbRootPath = UsbDirectory.FindUsbPath();
                string logo = Images.Find(x => x.Id == 0)?.Path ??"";
                MKConverter.KBToDat(KeyboardItems, usbRootPath, logo , _CodePage);
                MessageBox.Show("Успешно", "Проект сохранен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Элементы клавиатуры отсутствуют", "Не удалось сохранить проект", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static bool LoadLocalProject()
        {
             KeyboardItems = SettingManager.Load<KeyboardItem>();
            return KeyboardItems.Count != 0;
        }

        public static bool Get()
        {
          //  MKConverter.ProdPLUFromDat(files[0], files[4]);
            return true;
        }

        /// <summary>
        /// Сохранить проект в XML
        /// </summary>
        internal static void SaveToLocal()
        {
            SettingManager.Save(KeyboardItems);

        }
    }
}


 //public static List<KeyboardItem> LoadFromProject()
        //{
        //    OpenFileDialog ofd = new OpenFileDialog()
        //    {
        //        InitialDirectory = SettingManager.SettingPath,
        //        Multiselect = false,
        //        Filter = "XML|*.xml"
        //    };

        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        List<KeyboardItem> keyboardItems = SettingManager.Load(ofd.FileName);
        //        // SetKeyboardItems(keyboardItems);
        //        MessageBox.Show(ofd.FileName, "Проект загружен", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return keyboardItems;
        //    }
        //    throw new BException("Проект отсутствует");
        //}

        ///
        //private static void SaveProject(List<KeyboardItem> keyboardItems)
        //{

        //    SaveFileDialog sfd = new SaveFileDialog()
        //    {
        //        InitialDirectory = SettingManager.SettingPath,
        //        Filter = "XML|*.xml"
        //    };
        //    try
        //    {
        //        if (sfd.ShowDialog() == DialogResult.OK)
        //        {

        //            SettingManager.Save<KeyboardItem>(keyboardItems, sfd.FileName);
        //            MessageBox.Show(sfd.FileName, "Проект Сохранен", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}




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