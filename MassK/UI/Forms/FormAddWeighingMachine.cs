using MassK.LangPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK
{
    public partial class FormAddWeighingMachine : Form
    {
      
               
        public string Connection { get; internal set; }

        public string Name { get; internal set; }
        public string Port { get; internal set; }
        public string IpAddress { get; internal set; }

       

        LangPack _langPack;
        public FormAddWeighingMachine(LangPack langPack)
        {
            _langPack = langPack;
            InitializeComponent();
            langPack.SetText(this);
            TBoxIp.Mask = @"###\.###\.###\.###";
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            Connection = CBoxConnectionType.Text;
            IpAddress = TBoxIp.Text;
            Port = TBoxPort.Text;
            Name = TBoxName.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
        }

        private void FormAddWeighingMachine_Load(object sender, EventArgs e)
        {
            CBoxConnectionType.Items.Add("Ethernet");
            CBoxConnectionType.Items.Add("COM");
        }
    }
}
