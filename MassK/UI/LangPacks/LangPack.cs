using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Globalization;

//Формат языкового пакета.
//<Name> - обязателен, без него пакет не загрузится
//<?xml version="1.0"?>
//<LangPack xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
//  <Name>russian</Name>
//  <Form1>
//    <label1>Надписька</label1>
//    <button1>Занрузить языки</button1>
//	<button2>Перевод формы</button2>
//	<button3>Еще один тест</button3>
//  </Form1>
//  <Messages>
//    <Alarm>Всё, пришел всем писец!</Alarm>
//  </Messages>
//</LangPack>

namespace MassK.LangPacks
{
    public class LangPack
    {
        readonly static Dictionary<string, LangPack> _lang_packs = new Dictionary<string, LangPack>();

        /// <summary>
        /// Текущий языкыковой пакет
        /// </summary>
        public static LangPack Lang { get; private set; }

        /// <summary>
        /// Загрузить языковые пакеты
        /// </summary>
        /// <param name="langPath">Путь к папке содержащий xml языковые пакеты</param>
        public static void Load(string langPath)
        {
            foreach(var file in new DirectoryInfo(langPath).GetFiles("*.xml", SearchOption.TopDirectoryOnly))
            {
                XDocument x_doc = XDocument.Load(file.FullName);
                if(x_doc.Root.Element("Name") is XElement element && !_lang_packs.ContainsKey(element.Value))
                    _lang_packs.Add(element.Value, new LangPack(x_doc));
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
        public static string SetCurrentCultureLang()
        {
            CultureInfo ci = CultureInfo.CurrentUICulture;
            string lang_name = ci.NativeName
                                 .Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries)[0];
            lang_name = $"{lang_name.Substring(0, 1).ToUpper()}{lang_name.Substring(1, lang_name.Length - 1)}";
            _lang_packs.TryGetValue(lang_name, out LangPack lang_pack);
            Lang = lang_pack;
            return lang_name;
        }

        /// <summary>
        /// Установить языковой пакет по имени
        /// </summary>
        /// <param name="langName"></param>
        public static void SetLang(string langName)
        {
            _lang_packs.TryGetValue(langName, out LangPack lang_pack);
            Lang = lang_pack;
        }

        XDocument _x_doc;
        private LangPack() { }
        private LangPack(XDocument xDoc) => _x_doc = xDoc;

        /// <summary>
        /// Установить свойство Text контролов на форме
        /// </summary>
        /// <param name="form"></param>
        public void SetText(Form form)
        {
            if(_x_doc?.Root.Element("Texts") is XElement root)
                foreach (Control control in GetControls(form))
                    if (root.Elements().FirstOrDefault(xe => xe.Name == control.Name) is XElement element)
                        control.Text = element.Value;
        }

        /// <summary>
        /// Получить текст
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetText(string name)
        {
            if(_x_doc?.Root.Element("Messages") is XElement messages)
                return messages.Element(name)?.Value;

            return null;
        }

        private List<Control> GetControls(Control root)
        {
            List<Control> buffer = new List<Control>();

            foreach(Control control in root.Controls)
            {
                if (control.Name != "")
                {
                buffer.Add(control);
                buffer.AddRange(GetControls(control));
                }
            }

            return buffer;
        }
    }
}
