using MassK.BL;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public string Name { get; private set; }
        public int MyProperty { get; set; }
        public List<Product> Products
        {
            get
            {
                if (_products is null)
                {
                    _products = Load<Product>(_xDocument.Root);
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
                    _keyboardItems = Load<KeyboardItem>(_xDocument.Root);
                }
                return _keyboardItems;
            }
            set => _keyboardItems = value;
        }
        private List<KeyboardItem> _keyboardItems;

        private string _fileName = default;
        private XDocument _xDocument = default;
        
        
        public Project() { }
        public Project(string fileName)
        {
            _fileName = fileName;

            if (File.Exists(fileName))
            {
                _xDocument = XDocument.Load(fileName);
                Products = Load<Product>(_xDocument.Root);
                KeyboardItems = Load<KeyboardItem>(_xDocument.Root);
                Name = Path.GetFileNameWithoutExtension(fileName);
            }
        }
        //private void

        /// <summary>
        ///  Сохранить в файл.
        /// </summary>
        public void Save()
        {
            XElement xProd = SaveListObjects<Product>(_products);
            XElement xKb = SaveListObjects<KeyboardItem>(_keyboardItems);
            XElement root = new XElement("Project");
            root.Add(xProd);
            root.Add(xKb);            
           _xDocument = new XDocument(root);
            _xDocument.Save(_fileName);
        }


        private static XElement SaveListObjects<T>(List<T> data) where T : class
        {
            Type type = typeof(T);
            XElement root = new XElement($"List{type.Name}");
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
            return root;
        }




        /// <summary>
        /// Загрузить из фала 
        /// </summary>
        //private void Load(XElement root)
        //{

        //   XElement xeListObjectsRoot = root.Element($"{}")
        //    Products = GetListObjectsFromElement(xeListObjectsRoot);
        //    KeyboardItems = GetListObjectsFromElement(xeListObjectsRoot);
        //    /// Собираем объекты в список
        //    List<T> GetListObjectsFromElement(XElement objListRoot)
        //    {
        //        List<T> buffer = new List<T>();
        //        foreach (XElement element in objListRoot.Elements())
        //        {
        //            T itm = GetObjectFromElement(xeListObjectsRoot);
        //            if (itm != null) objects.Add(itm);
        //        }

        //        T GetObjectFromElement(XElement objRoot)
        //        {
        //            Type type = typeof(T);
        //            T item = new T();
        //            foreach (var child_element in objRoot.Elements())
        //            {
        //                if (type.GetProperty(child_element.Name.LocalName) is PropertyInfo prop)
        //                {
        //                    if (prop.PropertyType.IsValueType)
        //                    {
        //                        try
        //                        {
        //                            prop.SetValue(item, Convert.ChangeType(child_element.Value, prop.PropertyType));
        //                        }
        //                        catch
        //                        {
        //                            item = null;
        //                            break;
        //                        }
        //                    }
        //                    else
        //                        prop.SetValue(item, child_element.Value);
        //                }
        //            }
        //            return item;
        //        }
        //        return buffer;
        //    }
        //}

        private static List<T> Load<T>(XElement root) where T : class, new()
        {
            List<T> objects = new List<T>();
            string objName = typeof(T).Name;
            XElement xeListObjects = root.Element($"List{objName}");
            if (xeListObjects !=null)
            {
            objects = GetListObjectsFromElement(xeListObjects);
            }
            return objects;


            /// Собираем объекты в список
            List<T> GetListObjectsFromElement(XElement objListRoot)
            {
                List<T> buffer = new List<T>();
                foreach (XElement element in objListRoot.Elements())
                {
                    T itm = GetObjectFromElement(element);
                    if (itm != null) buffer.Add(itm);
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
        }


        private static List<T> Load<T>(string path) where T : class, new()
        {
            // string path = Path.Combine(SettingManager.SettingPath, $"{typeof(T).Name}.xml");
            List<T> buffer = new List<T>();

            if (!File.Exists(path))
            {
                throw new ApplicationException("File not exist!");
                //   SaveListObjects(buffer, path);
                //  return buffer;
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
        //    private static void Save<T>(List<T> data, string path) where T : class
        //    {
        //        XElement root = new XElement("Data");
        //        Type type = typeof(T);
        //        List<PropertyInfo> props = (from prop in type.GetProperties()
        //                                    let prop_type = prop.PropertyType
        //                                    where prop_type.IsValueType || prop_type == typeof(string)
        //                                    select prop).ToList();

        //        foreach (T item in data)
        //        {
        //            XElement element = new XElement(type.Name);

        //            foreach (var prop in props)
        //            {
        //                if (prop.PropertyType != typeof(Image) && prop.GetCustomAttribute(typeof(NonSaveAttribute)) == null)
        //                {
        //                    element.Add(new XElement(
        //                        prop.Name,
        //                        prop.GetValue(item)?.ToString() ?? ""));
        //                }
        //            }

        //            root.Add(element);
        //        }

        //        XDocument x_doc = new XDocument(root);

        //        if (!Directory.Exists(SettingPath))
        //            Directory.CreateDirectory(SettingPath);

        //        x_doc.Save(Path.Combine(SettingPath, $"{type.Name}.xml"));
        //    }
    }
}

