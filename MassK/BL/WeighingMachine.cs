using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassK.BL
{
    // Весы
   public class WeighingMachine
    {
        [DisplayName("Выгрузить")]
        public bool Unload { get; set; } = false;

        [DisplayName("Загрузить")]
        public bool Load { get; set; } = false;

        [DisplayName("Наименование весов")]
        public string  Name { get; set; }

        [DisplayName("Номер весов")]
        public int  Number { get; set; }

        [DisplayName("Соединение")]
        public string IP{ get; set; }

        [DisplayName("Состояние")]
        public string State { get; set; } = "Не в сети";

        [DisplayName("Дата последнего обмена")]
        public DateTime DateConnection { get; set; }

    }
}
