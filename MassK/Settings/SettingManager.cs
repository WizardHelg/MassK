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

namespace MassK.Settings
{
    static class SettingManager
    {
        public static string RootPath { get; set; } = Application.StartupPath;
        public static string LangPath { get; set; } = Path.Combine(RootPath, "Lang");
        public static string ImagePath { get; set; } = Path.Combine(RootPath, "Images");
        public static string ProgrammPictures { get; set; } = Path.Combine(ImagePath, "ProgrammPictures");
        public static string UserPictures { get; set; } = Path.Combine(ImagePath, "UserPictures");
        public static string LogoPath { get; set; } = Path.Combine(ImagePath, "Logo");
        public static string RusImagePath { get; set; } = Path.Combine(ProgrammPictures, "RUS");
        public static string EngImagePath { get; set; } = Path.Combine(ProgrammPictures, "ENG");
        public static string DefaultImagesPath => (Lang == "Русский") ? RusImagePath : EngImagePath;
        public static string SettingPath { get; set; } = Path.Combine(RootPath, "Settings");

        private static List<EncodingInfo> _encoding_infos = Encoding.GetEncodings().ToList();
        private static EncodingInfo _code_page;

        /// <summary>
        /// Номер кодовой страницы. 0 если используется кодировка по умолчанию;
        /// </summary>
        public static int CodePage => _code_page?.CodePage ?? 0;

        /// <summary>
        /// Сохраненное в настройках имя кодовой страницы
        /// </summary>
        public static string NameCodePage
        {
            get
            {
                if (_lang != "Русский")
                    return _code_page?.Name ?? "";
                else
                    return _code_page?.DisplayName ?? "";
            }
            set
            {
                if (_lang != "Русский")
                    _code_page = _encoding_infos.Find(x => x.Name == value);
                else
                    _code_page = _encoding_infos.Find(x => x.DisplayName == value);

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

        static bool _plu_numeration;
        public static bool PLUNumeration
        {
            get => _plu_numeration;
            set
            {
                _plu_numeration = value;
                SaveToXml("PLUNumeration", $"{value}");
            }
        }

        /// <summary>
        /// Считать настройки
        /// </summary>
        public static void ReadSettings()
        {
            if (!Directory.Exists(UserPictures))
                Directory.CreateDirectory(UserPictures);

            if (!Directory.Exists(LogoPath))
                Directory.CreateDirectory(LogoPath);

            if (!Directory.Exists(SettingPath))
                Directory.CreateDirectory(SettingPath);


            var root = GetSettingXML().Root;
            _lang = root.Element("Lang")?.Value;

            int.TryParse(root.Element("CodePage")?.Value, out int code_page);
            _code_page = _encoding_infos.Find(x => x.CodePage == code_page);

            bool.TryParse(root.Element("PLUNumeration")?.Value, out bool plu_num);
            _plu_numeration = plu_num;

            _categories = Load<ProductCategory>();
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
            if(_lang != "Русский")
                return Encoding.GetEncodings().OrderBy(item => item.Name).Select(item => item.Name);
            else
                return Encoding.GetEncodings().OrderBy(item => item.DisplayName).Select(item => item.DisplayName);
        }

        /// <summary>
        /// Загрузает список объектов типа T из папки указнной в свойсте SettingPath из файла с именем название_типа_T.xml
        /// </summary>
        /// <typeparam name="T">Тип класса, из которого сохранятся только свойста с типом ValueType и string</typeparam>
        /// <returns></returns>
        public static List<T> Load<T>() where T: class, new()
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

        /// <summary>
        /// Сохраняет список классов в xml в папку указанную в свойстве SettigPath с именем: название_типа_Т.xml
        /// </summary>
        /// <typeparam name="T">Тип класса, из которого сохранятся только свойста с типом ValueType и string</typeparam>
        /// <param name="data"></param>
        public static void Save<T>(List<T> data) where T: class
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

                foreach(var prop in props)
                {
                    if (prop.PropertyType != typeof(Image) )
                    {
                        element.Add(new XElement(
                            prop.Name,
                            prop.GetValue(item)?.ToString()??""));
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
}
