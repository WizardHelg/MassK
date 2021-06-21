using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using MassK.BL;
using System.Drawing;
using System.Text;
using System.Diagnostics;

namespace MassK.Settings
{
    static class SettingManager
    {
        public static string RootPath
        {
            get
            {
                if (string.IsNullOrEmpty(_rootPath))
                    _rootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Massa-K", "SL Scales Keyboard Editor");
                
                return _rootPath;
            }
        }
        private static string _rootPath;

        //public static string AppPath
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(_appPath))
        //        {
        //            _appPath = Application.StartupPath;
        //        }
        //        return _appPath;
        //    }
        //}
        private static string _appPath;

        public static string LangPath
        {
            get
            {
                if (string.IsNullOrEmpty(_langPath))
                {
                    _langPath = GetExistPath(Path.Combine(RootPath, "Lang")); 
                }
                return _langPath;
            }
        }
        private static string _langPath;

        public static string Projects
        {
            get
            {
                if (string.IsNullOrEmpty(_projects))
                {
                    _projects = GetExistPath(Path.Combine(RootPath, "Projects"));
                }
                return _projects;
            }
        }
        private static string _projects;

        public static string FlagPath
        {
            get
            {
                if (string.IsNullOrEmpty(_flagPath))
                {
                    _flagPath = GetExistPath(Path.Combine(Settings.SettingManager.LangPath, "Flags"));
                }
                return _flagPath;
            }
        }
        private static string _flagPath;

        public static string ImagePath
        {
            get
            {
                if (string.IsNullOrEmpty(_imagePath))
                {
                    _imagePath = GetExistPath(Path.Combine(RootPath, "Images"));
                }
                return _imagePath;
            }
        }
        private static string _imagePath;

        public static string ProgrammPictures
        {
            get
            {
                if (string.IsNullOrEmpty(_programmPictures))
                {
                    _programmPictures = GetExistPath(Path.Combine(ImagePath, "ProgrammPictures"));
                }
                return _programmPictures;
            }
        }
        private static string _programmPictures;

        public static string UserPictures
        {
            get
            {
                if (string.IsNullOrEmpty(_userPictures))
                {
                    _userPictures = GetExistPath(Path.Combine(ImagePath, "UserPictures"));
                }
                return _userPictures;
            }
        }
        private static string _userPictures;

        public static string LogoPath
        {
            get
            {
                if (string.IsNullOrEmpty(_logoPath))
                {
                    _logoPath = GetExistPath(Path.Combine(ImagePath, "Logo"));
                }
                return _logoPath;
            }
        }
        private static string _logoPath;

        public static string RusImagePath
        {
            get
            {
                if (string.IsNullOrEmpty(_rusImagePath))
                {
                    _rusImagePath = GetExistPath(Path.Combine(ProgrammPictures, "RUS"));
                }
                return _rusImagePath;
            }
        }
        private static string _rusImagePath;


        public static string EngImagePath
        {
            get
            {
                if (string.IsNullOrEmpty(_engImagePath))
                {
                    _engImagePath = GetExistPath(Path.Combine(ProgrammPictures, "ENG"));
                }
            
                return _engImagePath;
            }
        }
        private static string _engImagePath;

        public static string SettingPath
        {
            get
            {
                if (string.IsNullOrEmpty(_settingPath))
                {
                    _settingPath = GetExistPath(Path.Combine(RootPath, "Settings"));
                }

                return _settingPath;
            }
        }
        private static string _settingPath;

        public static string PresentationPath
        {
            get
            {
                if (string.IsNullOrEmpty(_presentationPath))
                {
                    _presentationPath = GetExistPath(Path.Combine(RootPath, "Presentation"));
                }

                return _presentationPath;
            }
        }
        private static string _presentationPath;

        public static string DefaultImagesPath => (Lang == "Русский") ? RusImagePath : EngImagePath;

        //public static string RootPath { get; set; } = Application.StartupPath;
        //public static string LangPath { get; set; } = Path.Combine(RootPath, "Lang");
        //public static string Projects { get; set; } = Path.Combine(RootPath, "Projects");
        //public static string FlagPath { get; set; } = Path.Combine(Settings.SettingManager.LangPath, "Flags");
        //public static string ImagePath { get; set; } = Path.Combine(RootPath, "Images");
        //public static string ProgrammPictures { get; set; } = Path.Combine(ImagePath, "ProgrammPictures");
        //public static string UserPictures { get; set; } = Path.Combine(ImagePath, "UserPictures");
        //public static string LogoPath { get; set; } = Path.Combine(ImagePath, "Logo");
        //public static string RusImagePath { get; set; } = Path.Combine(ProgrammPictures, "RUS");
        //public static string EngImagePath { get; set; } = Path.Combine(ProgrammPictures, "ENG");
        //public static string DefaultImagesPath => (Lang == "Русский") ? RusImagePath : EngImagePath;
        //public static string SettingPath { get; set; } = Path.Combine(RootPath, "Settings");
        //public static string PresentationPath { get; set; } = Path.Combine(RootPath, "Presentation");

        private static readonly List<EncodingInfo> _encoding_infos = Encoding.GetEncodings().ToList();
        private static EncodingInfo _code_page;

        /// <summary>
        /// Номер кодовой страницы. 0 если используется кодировка по умолчанию;
        /// </summary>
        public static int CodePage => _code_page?.CodePage ?? 0;
        internal static void SetCodePage(string codePage)
        {
            if (string.IsNullOrEmpty(codePage)) return;
            EncodingInfo info = _encoding_infos.Find(x => x.CodePage.ToString() == codePage);
            if (info != null)
            {
                _code_page = info;
                SaveToXml("CodePage", $"{_code_page.CodePage}");
            }
        }
     
        private static string _lang;
        /// <summary>
        /// Сохраненный в настройках язык
        /// </summary>
        public static string Lang
        {
            get => _lang;
            set
            {
                _lang = value;
                SaveToXml("Lang", value);
            }
        }

        static List<ProductCategory> _categories;
        public static List<ProductCategory> Categories
        {
            get
            {
                List<ProductCategory> buffer = new List<ProductCategory>();
                _categories.ForEach(c => buffer.Add(c.Clone()));
                return buffer;
            }

            set
            {
                _categories = value;
                Save(_categories);
            }
        }

        static List<ScaleInfo> _scale_infos;
        public static List<ScaleInfo> ScaleInfos
        {
            get => _scale_infos;
            set
            {
                _scale_infos = value;
                Save(_scale_infos);
            }
        }
        public static void ReloadScaleInfos() => _scale_infos = Load<ScaleInfo>();

        static bool _plu_numeration;

        /// <summary>
        ///  Параметр приложения. Plu \ оператор
        /// </summary>
        public static bool PLUNumeration
        {
            get => _plu_numeration;
            set
            {
                _plu_numeration = value;
                SaveToXml("PLUNumeration", $"{value}");
            }
        }

        public static bool _show_discription;

        /// <summary>
        ///  Параметр приложения. Предлагать показать окно с описанием приложения при запуске программы
        /// </summary>
        public static bool ShowDiscription
        {
            get => _show_discription;
            set
            {
                _show_discription = value;
                SaveToXml("ShowDiscription", $"{value}");
            }
        }

        private static string  GetExistPath(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }

        /// <summary>
        /// Считать настройки
        /// </summary>
        public static void ReadSettings()
        {
            //if (!Directory.Exists(UserPictures))
            //    Directory.CreateDirectory(UserPictures);

            //if (!Directory.Exists(LogoPath))
            //    Directory.CreateDirectory(LogoPath);

            //if (!Directory.Exists(SettingPath))
            //    Directory.CreateDirectory(SettingPath);


            var root = GetSettingXML().Root;
            _lang = root.Element("Lang")?.Value;

            int.TryParse(root.Element("CodePage")?.Value, out int code_page);
            _code_page = _encoding_infos.Find(x => x.CodePage == code_page);

            bool.TryParse(root.Element("PLUNumeration")?.Value, out bool plu_num);
            _plu_numeration = plu_num;

            bool.TryParse(root.Element("ShowDiscription")?.Value, out bool sh_discript);
                _show_discription = sh_discript;            
                if (root.Element("ShowDiscription")?.Value is null)
                {
                    ShowDiscription = true;                    
                }
            

            _categories = Load<ProductCategory>();
            _scale_infos = Load<ScaleInfo>();
        }

        private static XDocument GetSettingXML()
        {
            string path = Path.Combine(SettingPath, "Setting.xml");
            if (File.Exists(path))
                return XDocument.Load(path);
            else
            {
                XElement root = new XElement("settings",
                    new XElement("Lang"),
                    new XElement("CodePage"),
                    new XElement("PLUNumeration"));
                XDocument x_doc = new XDocument(root);
                x_doc.Save(path);
                return x_doc;
            }
        }

        private static void SaveToXml(string name, string value)
        {
            if (value is null) return;
            var x_doc = GetSettingXML();
            if (x_doc.Root.Element(name) is XElement element)
                element.Value = value;

            x_doc.Save(Path.Combine(SettingPath, "Setting.xml"));
        }

        /// <summary>
        /// Список кодовых страниц
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetCodePages()
        {
            if (_lang != "Русский")
                return Encoding.GetEncodings().OrderBy(item => item.Name).Select(item => item.Name);
            else
                return Encoding.GetEncodings().OrderBy(item => item.DisplayName).Select(item => item.DisplayName);
        }

        /// <summary>
        /// Загрузает список объектов типа T из папки указнной в свойсте SettingPath из файла с именем название_типа_T.xml
        /// </summary>
        /// <typeparam name="T">Тип класса, из которого сохранятся только свойста с типом ValueType и string</typeparam>
        /// <returns></returns>
        public static List<T> Load<T>() where T : class, new()
        {
            string path = Path.Combine(SettingPath, $"{typeof(T).Name}.xml");
            List<T> buffer = new List<T>();

            if (!File.Exists(path))
            {
                Save(buffer);
                return buffer;
            }

            Type type = typeof(T);
            XDocument x_doc = XDocument.Load(path);

            foreach (var elemet in x_doc.Root.Elements())
            {
                T item = new T();
                foreach (var child_element in elemet.Elements())
                {
                    if (type.GetProperty(child_element.Name.LocalName) is PropertyInfo prop)
                    {
                        if (prop.PropertyType.IsValueType)
                        {
                            try
                            {
                                prop.SetValue(item, Convert.ChangeType(child_element.Value, prop.PropertyType));
                            }
                            catch
                            {
                                item = null;
                                break;
                            }
                        }
                        else
                            prop.SetValue(item, child_element.Value);
                    }
                }

                if (item != null)
                    buffer.Add(item);
            }

            return buffer;
        }

        private static Dictionary<string, string> _codePages = new Dictionary<string, string>()
        {
            {"Русский","1251" },
            {"Казахстан","1251" },
            {"Болгария","1251" },
            {"Кыргызстан","1251" },
            {"Узбекистан","1251" },
            {"English","1252" },
            {"Latvian","1257" },
            {"Тунис","1252" },
            {"French","1252" },
            {"Азербайджан","1254" },
            {"Turkmen","1250" },
            {"Georgian","1250" },
            {"Armenian","1250" },
        };
        /// <summary>
        /// Сохраняет список классов в xml в папку указанную в свойстве SettigPath с именем: название_типа_Т.xml
        /// </summary>
        /// <typeparam name="T">Тип класса, из которого сохранятся только свойста с типом ValueType и string</typeparam>
        /// <param name="data"></param>
        public static void Save<T>(List<T> data) where T : class
        {
            XElement root = new XElement("Data");
            Type type = typeof(T);
            List<PropertyInfo> props = (from prop in type.GetProperties()
                                        let prop_type = prop.PropertyType
                                        where prop_type.IsValueType || prop_type == typeof(string)
                                        select prop).ToList();

            foreach (T item in data)
            {
                XElement element = new XElement(type.Name);

                foreach (var prop in props)
                {
                    if (prop.PropertyType != typeof(Image) && prop.GetCustomAttribute(typeof(NonSaveAttribute)) == null)
                    {
                        element.Add(new XElement(
                            prop.Name,
                            prop.GetValue(item)?.ToString() ?? ""));
                    }
                }

                root.Add(element);
            }

            XDocument x_doc = new XDocument(root);

            if (!Directory.Exists(SettingPath))
                Directory.CreateDirectory(SettingPath);

            x_doc.Save(Path.Combine(SettingPath, $"{type.Name}.xml"));
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    class NonSaveAttribute : Attribute
    {

    }
}
