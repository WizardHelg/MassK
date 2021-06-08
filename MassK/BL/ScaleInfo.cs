using MassK.Settings;
using MassK.UI.LangPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MassK.BL
{
    // Весы
    public class ScaleInfo
    {
        public bool Unload { get; set; } = false;
        public bool Load { get; set; } = false;
        public string  Name { get; set; }
        public int  Number { get; set; }
        public string Connection{ get; set; }

        [NonSave]
        public bool State { get; set; } = false;

        [NonSave]
        public string TextState => State ? LangPack.GetText("Online") : LangPack.GetText("Offline");

        public DateTime DataExchangeDate { get; set; }

        public static implicit operator IPEndPoint(ScaleInfo scaleInfo)
        {
            string[] buffer = scaleInfo.Connection.Split(':');
            if (buffer.Length < 2)
                return null;

            return new IPEndPoint(IPAddress.Parse(buffer[0]), int.Parse(buffer[1]));
        }
    }
}
