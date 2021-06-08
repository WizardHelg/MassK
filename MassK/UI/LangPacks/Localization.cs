using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MassK.UI.LangPacks
{
    public class Localization
    {
        public string Name { get; private set; }
        public string NameLocal { get; private set; }
        public string CodePage { get; private set; }
        //public Image Flag 
        //{ get; private set; }

        public XElement Root { get; private set; }
        // public static XElement Root { get => _root; private set => _root = value; }
        //private static XElement _root;

        public Localization(XElement root)
        {
            Root = root;
            Name =root.Element("Name")?.Value ?? "";
            NameLocal = root.Element("NameLocal")?.Value ?? "";
        }

        public Image GetFlag(string path)
        {
            Image image = default;
            string filename = Path.Combine(path, $"{Name}.png");
            if (File.Exists(filename))
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                  image = Image.FromStream(fs);
            return image;
        }
    }
}
