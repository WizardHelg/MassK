using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassK.BL
{
    class KeyboardItem
    {
        /// <summary>
        /// ID товара
        /// </summary>
       [DisplayName ("ID")]
        public int ID { get; set; }

        /// <summary>
        /// Код товара
        /// </summary>
        [DisplayName("Code - товара")]
        public string Code { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
         [DisplayName ("Наименование товара")]
        public string Name { get; set; }

        /// <summary>
        /// ID картинки
        /// </summary>
        [DisplayName("ID - картинки")]
        public string PictureID { get; set; }

        /// <summary>
        ///  Изображение
        /// </summary>
        [DisplayName("Имя картинки")]
        public string PictureName { get; set; }

        /// <summary>
        /// Графическое изображение товара
        /// </summary>
        [DisplayName("Картинка")]
        public Image Picture { get; set; }

        /// <summary>
        /// № товара 
        /// </summary>
        [DisplayName("№")]
        public int Number { get; set; }

        /// <summary>
        /// Наименование категории 
        /// </summary>
        [DisplayName("Категория")]
        public string Category { get; set;}


        public string ImagePath { get; set; }
    }
}
