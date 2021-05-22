using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassK.BL
{
    class Product
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
        public string PLU { get; set; }

        /// <summary>
        /// ID картинки
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Наименование категории 
        /// </summary>
        public bool Selected { get; set; }

    }
}
