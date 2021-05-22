using MassK.UI.LangPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK.UI.Forms
{
    public partial class FormAddScalesConnection : Form
    {
        public string Connection { get; internal set; }
        public string NameMachine { get; internal set; }
        public string Port { get; internal set; }
        public string IpAddress { get; internal set; }

        public FormAddScalesConnection()
        {
            InitializeComponent();
            LangPack.Translate(this);
        }

        public FormAddScalesConnection(LangPack langPack)
        {
            InitializeComponent();
            //langPack.Translate(this);
            TBoxIp.Mask = @"###\.###\.###\.###";
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //Connection = CBoxConnectionType.Text;
            //IpAddress = TBoxIp.Text;
            //Port = TBoxPort.Text;
            //NameMachine = TBoxName.Text;

            //DialogResult = DialogResult.OK;
            //Close();
        }

        private void FormAddWeighingMachine_Load(object sender, EventArgs e)
        {
            //CBoxConnectionType.Items.Add("Ethernet");
            //CBoxConnectionType.Items.Add("COM");
            //CBoxConnectionType.SelectedIndex = 0;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
        }
    }
}
