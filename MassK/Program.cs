using MassK.LangPacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            LangPack.SetLang("");
            LangPack.Load("");
            
            FormMain formMain = new FormMain(LangPack.Lang);
            Application.Run(formMain);
        }
    }
}
