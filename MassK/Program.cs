using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MassK.UI.LangPacks;
using MassK.Settings;
using MassK.Data;
using System.Net;
using System.Net.Sockets;

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
            InitServices();
            Application.Run(new UI.Forms.FormMain());
        }

        private static void InitServices()
        {
            SettingManager.ReadSettings();
            LangPack.Load(SettingManager.LangPath);
            if (!LangPack.SetLang(SettingManager.Lang))
                SettingManager.Lang = LangPack.SetCurrentCultureLang();
        } 
    }
}
