using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK.UI.Forms
{
    public partial class FormHelp : Form
    {
        public string HelpText
        {
            set
            {
                string val = value;
                try
                {
                    if (val.StartsWith(@"{\rtf1"))
                    {
                        // Форматированный текст
                        TextBox.Rtf = val;
                    }
                    else
                    {
                        val = val.Trim(new char[] { '\n', '\r',' ','\\' });
                        string rtfHelpFile = Path.Combine(Settings.SettingManager.LangPath, val);
                        if (File.Exists(rtfHelpFile))
                        {
                            FileInfo fi = new FileInfo(rtfHelpFile);
                            if (fi.Extension.ToLower() != ".rtf") 
                            {
                                throw new ApplicationException($"Help file is not in the correct format! \rFile: {rtfHelpFile}"); 
                            };
                            TextBox.LoadFile(rtfHelpFile);
                        }
                        else
                        {
                            TextBox.Text = val;
                        }
                    }
                }
                catch (Exception ex)
                {
                    TextBox.Text = $"{LangPacks.LangPack.GetText("Error")}\r\n" +
                                    $"{ex.Message}\r\r\n" +
                                    $"\"{val}\"";
                }
            }
        }

        public FormHelp()
        {
            InitializeComponent();
            TextBox.ReadOnly = true;
        }


    }
}
