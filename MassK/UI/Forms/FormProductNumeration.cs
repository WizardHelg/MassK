using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MassK.Settings;

namespace MassK.UI.Forms
{
    public partial class FormProductNumeration : Form
    {
        public FormProductNumeration() => InitializeComponent();

        protected override void OnLoad(EventArgs e)
        {
            LangPacks.LangPack.Translate(this);
            if (SettingManager.PLUNumeration)
                PLU.Checked = true;
            else
                Operator.Checked = true;

            base.OnLoad(e);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SettingManager.PLUNumeration = PLU.Checked;
            DialogResult = DialogResult.OK;
        }
    }
}
