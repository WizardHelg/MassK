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
        [DisplayName("ID - товара")]
        public int ProductID { get; set; }

        /// <summary>
        /// Код товара
        /// </summary>
        [DisplayName("Code - товара")]
        public string Code { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        [DisplayName("PLU")]
        public string PLU { get; set; }

        /// <summary>
        /// ID картинки
        /// </summary>
        [DisplayName("Наименование товара")]
        public string ProducеName { get; set; }
        
        /// <summary>
        /// № товара 
        /// </summary>
        [DisplayName("№")]
        public int Number { get; set; }

        /// <summary>
        /// Наименование категории 
        /// </summary>
        [DisplayName("Выбранные")]
        public bool Selected { get; set; }

    }
}
