using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace MassK.BL
{
    /// <summary>
    /// Элемент библиотеки картинок
    /// </summary>
  public  class ImageItem
    {

        public int ID { get; set; }

        public string Group { get; set; } = "";

        public string Name { get; set; } = "";

        public string Path { get; set; } = "";

        public Image Picture { get; set; }
    }
}
