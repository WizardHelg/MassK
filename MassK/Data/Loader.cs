using MassK.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassK.Data
{
   abstract class Loader
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        public List<KeyboardItem> Products { get; set; }

        public abstract void Load();
    }
}
