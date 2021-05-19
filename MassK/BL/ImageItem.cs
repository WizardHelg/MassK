using System.ComponentModel;
using System.Drawing;

namespace MassK.BL
{
    /// <summary>
    /// Элемент библиотеки картинок
    /// </summary>
  public  class ImageItem
    {

        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Группа картинок")]
        public string Group { get; set; } = "";

        [DisplayName("Наименование картинки")]
        public string Name { get; set; } = "";

        [DisplayName("Путь")]
        public string Path { get; set; } = "";

        [DisplayName("Картинка")]
        public Image Picture { get; set; }

        public bool IsUserFile { get; set; } = false;
    }
}
