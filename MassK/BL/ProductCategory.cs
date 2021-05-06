using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassK.BL
{

    /// <summary>
    ///  Категории товаров. ThisProgramm\Settings\ProductCategory.xml
    /// </summary>
    class ProductCategory
    {
        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("Категория")]
        public string Category { get; set; } 

    }
}
