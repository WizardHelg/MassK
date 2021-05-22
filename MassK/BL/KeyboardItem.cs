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
        public int ID { get; set; }

        /// <summary>
        /// Код товара
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ID картинки
        /// </summary>
        public int PictureID { get; set; }

        /// <summary>
        ///  Изображение
        /// </summary>
        public string PictureName { get; set; }

        /// <summary>
        /// Графическое изображение товара
        /// </summary>
        public Image Picture { get; set; }

        /// <summary>
        /// № товара 
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Наименование категории 
        /// </summary>
        public string Category { get; set;}
        public int CategoryID { get; set; }
        public string ImagePath { get; set; }
    }
}
