using MassK.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MassK.Settings
{
    class Project
    {
        public string Name { get; set; }
        public int MyProperty { get; set; }
        public List<Product> Products
        {
            get
            {
                if (_products is null)
                {
                    _products = Load<Product>(_xDocument);
                }
                return _products;
            }
            set => _products = value;
        }
        private List<Product> _products;
        public List<KeyboardItem> KeyboardItems
        {
            get
            {
                if (_keyboardItems is null)
                {
                    _keyboardItems = Load<KeyboardItem>(_xDocument);
                }
                return _keyboardItems;
            }
            set => _keyboardItems = value;
        }
        private List<KeyboardItem> _keyboardItems;

        private string _fileName = default;
        private XDocument _xDocument = default;
        public Project(string fileName)
        {
            _fileName = fileName;
            _xDocument = XDocument.Load(fileName);
            //List<Product> products = Load<Product>(fileName);
            //List<KeyboardItem> keyboardItems = Load<KeyboardItem>(fileName);            
        }
        //private void

        /// <summary>
        ///  Сохранить в файл.
        /// </summary>
        public void Save()
        {

        }

        /// <summary>
        /// Загрузить из фала 
        /// </summary>
        private void Load()
        {

        }

        private static List<T> Load<T>(XDocument xDoc) where T : class, new()
        {
            List<T> objects = new List<T>();
            string objName = typeof(T).Name;
            XElement xeListObjectsRoot = xDoc.Root.Element(objName);
            if (xeListObjectsRoot == null)
            {
                throw new ApplicationException($"Элемент {objName} не сохранен в проекте");
            }
            #region
            /*
            XElement xeListObjectsRoot = GetElement(xDoc.Root, objName);
             XElement GetElement(XElement root, string name)
            {
                foreach (var element in root.Elements())
                {
                    if (element.Name == name)
                    {
                        return element;
                    }
                }
                throw new ApplicationException($"Элемент {name} не сохранен в проекте");
            }
        */
            #endregion

            objects = GetListObjectsFromElement(xeListObjectsRoot);

            /// Собираем объекты в список
            List<T> GetListObjectsFromElement(XElement objListRoot)
            {
                List<T> buffer = new List<T>();
                foreach (XElement element in objListRoot.Elements())
                {
                    T itm = GetObjectFromElement(xeListObjectsRoot);
                    if (itm != null) objects.Add(itm);
                }

                T GetObjectFromElement(XElement objRoot)
                {
                    Type type = typeof(T);
                    T item = new T();
                    foreach (var child_element in objRoot.Elements())
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
                    return item;
                }
                return buffer;
            }

            return objects;
        }
        private static List<T> Load<T>(string path) where T : class, new()
        {
            // string path = Path.Combine(SettingManager.SettingPath, $"{typeof(T).Name}.xml");
            List<T> buffer = new List<T>();

            if (!File.Exists(path))
            {
                Save(buffer, path);
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
        private static void Save<T>(List<T> data, string path) where T : class
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
}
}
