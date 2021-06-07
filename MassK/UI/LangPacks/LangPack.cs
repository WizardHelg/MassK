using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Globalization;
using System.Drawing;

namespace MassK.UI.LangPacks
{
    public class LangPack
    {
        readonly static Dictionary<string, XElement> _lang_packs = new Dictionary<string, XElement>();
        private static XElement _lang;
        //public static Dictionary<string, string> Langs = new Dictionary<string, string>()
        //{
        //    {"",""},
        //    {"",""},
        //    {"",""},
        //    {"",""}
        //};
        public static Dictionary<string, string> Countres = new Dictionary<string, string>()
        {
            {"Армения",""},
            {"Азербайджан",""},
            {"Россия",""},
            {"Франция",""},
            {"Казахстан",""},
            {"Латвия",""},
            {"Тунис",""},
            {"Болгария",""},
            {"Туркменистан",""},
            {"Грузия",""},
            {"Кыргызстан",""},
            {"Кот-д'Ивуар",""},
            {"Узбекистан",""},
        };

        /// <summary>
        /// Загрузить языковые пакеты
        /// </summary>
        /// <param name="langPath">Путь к папке содержащий xml языковые пакеты</param>
        public static void Load(string langPath)
        {
            foreach (var file in Directory.EnumerateFiles(langPath, "*.xml", SearchOption.TopDirectoryOnly))
            {
                var x_doc = XDocument.Load(file);
                if (x_doc.Root.Element("Name") is XElement element && !_lang_packs.ContainsKey(element.Value))
                    _lang_packs.Add(element.Value, x_doc.Root);
            }
        }

        /// <summary>
        /// Список загруженных языковых пакетов
        /// </summary>
        /// <returns></returns>
        public static List<string> GetLangNames() => _lang_packs.Keys.ToList();


        /// <summary>
        /// Установить языковой пакет в соответствии с культурой установленной в системе
        /// </summary>
        /// <returns>Имя установленного языка</returns>
        public static string SetCurrentCultureLang()
        {
            var ci = CultureInfo.CurrentUICulture;
            var lang_name = ci.NativeName.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries)[0];
            lang_name = $"{lang_name.Substring(0, 1).ToUpper()}{lang_name.Substring(1, lang_name.Length - 1)}";
            _lang_packs.TryGetValue(lang_name, out XElement lang_pack);
            _lang = lang_pack;
            return _lang?.Element("Name").Value ?? "";
        }

        /// <summary>
        /// Установить языковой пакет по имени
        /// </summary>
        /// <param name="langName"></param>
        /// <returns>true если указанный язык есть в списке языков</returns>
        public static bool SetLang(string langName)
        {
            _lang_packs.TryGetValue(langName, out XElement lang_pack);
            _lang = lang_pack;
            return _lang != null;
        }

        /// <summary>
        /// Установить свойство Text контролов на форме
        /// </summary>
        /// <param name="form"></param>
        public static void Translate(Form form, DataGridView dgv = null, params Action[] addActions)
        {
            if (_lang?.Element(form.GetType().Name) is XElement form_element)
            {
                foreach (Control control in GetControls(form))
                    if (form_element.Element(control.Name) is XElement element)
                        control.Text = element.Value;

                if (form.Controls.ContainsKey("MenuStrip"))
                    ///if (form_element s(menu_item.Name))
                    ///ToDo исключение если нет элемента
                    foreach (ToolStripItem menu_item in GetMenu(form.Controls["MenuStrip"]))
                        if (!string.IsNullOrEmpty(menu_item.Name))
                        {
                            if (form_element.Element(menu_item.Name) is XElement element)
                                menu_item.Text = element.Value;
                        }

                if (form_element.Element("Caption") is XElement caption)
                    form.Text = caption.Value;

                if (dgv != null)
                    foreach (DataGridViewColumn col in dgv.Columns)
                        if (form_element.Element($"DataGridView_{col.Name}") is XElement element)
                            col.HeaderText = element.Value;

                foreach (var action in addActions)
                    action();
            }
        }

        /// <summary>
        /// Получить текст
        /// </summary>
        /// <param name="name">Имя текстовой записи</param>
        /// <returns>Текс</returns>
        public static string GetText(string name)
        {
            if (_lang?.Element("Texts") is XElement text)
                return text.Element(name)?.Value;

            return null;
        }

        private static List<Control> GetControls(Control root)
        {
            List<Control> buffer = new List<Control>();

            foreach (Control control in root.Controls)
                if (control.Name != "")
                {
                    buffer.Add(control);
                    buffer.AddRange(GetControls(control));
                }

            return buffer;
        }

        private static List<ToolStripItem> GetMenu(Control root)
        {
            var ts = root as ToolStrip;
            var buffer = new List<ToolStripItem>();
            foreach (ToolStripItem item in ts.Items)
            {
                buffer.Add(item);
                if (item is ToolStripDropDownButton drop_button)
                    foreach (ToolStripItem sub_item in drop_button.DropDownItems)
                        buffer.Add(sub_item);
            }
            return buffer;
        }

        public static Image GetPicture(string lang)
        {
            Image image = default;
            string filename = Path.Combine(Settings.SettingManager.LangPath,"Flags", $"{lang} .png") ;
            if (File.Exists(filename))
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                    image = Image.FromStream(fs);
            return image;
        }

        internal static string GetCodePage()
        {
            string codepage = default;


            //codepage = 
            return codepage;
        }
    }
}
