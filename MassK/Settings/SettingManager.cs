using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using MassK.BL;
using System.Drawing;

namespace MassK
{
    static class SettingManager
    {
        //public static string L { get; set; } = Directory.GetCurrentDirectory();
        public static readonly Properties.Settings settings = Properties.Settings.Default;
        public static string RootPath { get; set; } = Application.StartupPath;
        public static string LangPath { get; set; } = Path.Combine(RootPath, "Lang");
        public static string ImagePath { get; set; } = Path.Combine(RootPath, "Images");
        public static string ProgrammPictures { get; set; } = Path.Combine(ImagePath, "ProgrammPictures");
        public static string UserPictures { get; set; } = Path.Combine(ImagePath, "UserPictures");
        public static string LogoPath { get; set; } = Path.Combine(ImagePath, "Logo");
        public static string RusImagePath { get; set; } = Path.Combine(ProgrammPictures, "RUS");
        public static string EngImagePath { get; set; } = Path.Combine(ProgrammPictures, "ENG");
        public static string DefaultImagesPath { 
            get
            {
                _DefaultImagesPath = (settings.Lang == "Русский")? RusImagePath : EngImagePath;
                return _DefaultImagesPath;
            }
            set
            {
                _DefaultImagesPath = value;
            } 
        }
       static string  _DefaultImagesPath;

        public static string SettingPath { get; set; } = Path.Combine(RootPath, "Settings");

        /// <summary>
        /// Загружает базовые настройки из файла BaseSetting.xml
        /// </summary>
        public static void LoadBase(string path = "")
        {
            if (path == "")
                path = Path.Combine(Application.StartupPath, "Settings", "BaseSetting.xml");

            if (!File.Exists(path))
                return;

            Type type = typeof(SettingManager);
            XDocument x_doc = XDocument.Load(path);

            foreach (var element in x_doc.Root.Elements())
            {
                if (type.GetProperty(element.Name.LocalName) is PropertyInfo prop)
                    prop.SetValue(null, Convert.ChangeType(element.Value, prop.PropertyType));
            }
        }

        /// <summary>
        /// Сохраняет базовые настройки в файл BaseSetting.xml
        /// </summary>
        public static void SaveBase()
        {
            XElement root = new XElement("Data");
            Type type = typeof(SettingManager);
            List<PropertyInfo> props = (from prop in type.GetProperties()
                                        let prop_type = prop.PropertyType
                                        where prop_type.IsValueType || prop_type == typeof(string)
                                        select prop).ToList();

            foreach (var prop in props)
                root.Add(new XElement(
                    prop.Name,
                    prop.GetValue(null).ToString()));

            XDocument x_doc = new XDocument(root);

            string path = string.IsNullOrEmpty(SettingPath) ?
                            Path.Combine(Application.StartupPath, "Settings", "BaseSetting.xml") :
                            SettingPath;


            if (!Directory.Exists(SettingPath))
                Directory.CreateDirectory(SettingPath);

            x_doc.Save(Path.Combine(SettingPath, "BaseSetting.xml"));
        }

        /// <summary>
        /// Загрузает список объектов типа T из папки указнной в свойсте SettingPath из файла с именем название_типа_T.xml
        /// </summary>
        /// <typeparam name="T">Тип класса, из которого сохранятся только свойста с типом ValueType и string</typeparam>
        /// <returns></returns>
        public static List<T> Load<T>() where T: class, new()
        {
            string path = Path.Combine(SettingPath, $"{typeof(T).Name}.xml");
            if (!File.Exists(path))
                return null;

            Type type = typeof(T);
            List<T> buffer = new List<T>();
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

            return buffer.Count > 0 ? buffer : null;
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

     
        internal static void Save<T>(List<T> data, string fileName)
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
                    if (prop.PropertyType != typeof(Image))
                    {
                        element.Add(new XElement(
                            prop.Name,
                            prop.GetValue(item)?.ToString() ?? ""));
                    }
                }

                root.Add(element);
            }

            XDocument x_doc = new XDocument(root);

            //if (!Directory.Exists(SettingPath))
            //    Directory.CreateDirectory(SettingPath);
            x_doc.Save(fileName);
          
        }

        public static List<KeyboardItem> Load(string path)
        {           
            if (!File.Exists(path))
                return null;

            Type type = typeof(KeyboardItem);
            List<KeyboardItem> buffer = new List<KeyboardItem>();
            XDocument x_doc = XDocument.Load(path);

            foreach (var elemet in x_doc.Root.Elements())
            {
                KeyboardItem item = new KeyboardItem();
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

            return buffer.Count > 0 ? buffer : null;
        }

    }
}
