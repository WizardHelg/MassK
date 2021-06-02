using MassK.BL;
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
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace MassK.UI.Forms
{
    public partial class FormAddScalesConnection : Form
    {
        readonly List<ScaleInfo> _scale_infos;
        public FormAddScalesConnection(List<ScaleInfo> scaleInfos)
        {
            InitializeComponent();
            _scale_infos = scaleInfos;
            CBoxConnectionType.SelectedIndexChanged += CBoxConnectionType_SelectedIndexChanged;
        }

        private void CBoxConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mode = CBoxConnectionType.SelectedIndex;
            int portLableX = 490 - 297 * mode;
            bool ipBlockVisible = mode == 0;

            TBoxIp.Visible = ipBlockVisible;
            IP.Visible = ipBlockVisible;
            TBoxPort.Visible = ipBlockVisible;
            COMPortComboBox.Visible = !ipBlockVisible;
            PortNumber.Location = new Point(portLableX, 13);
        }

        protected override void OnLoad(EventArgs e)
        {
            COMPortComboBox.Items.AddRange(SerialPort.GetPortNames());
            CBoxConnectionType.SelectedIndex = 0;
            LangPack.Translate(this);
            TBoxIp.Mask = @"###\.###\.###\.###";
            base.OnLoad(e);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            void ShowError(string message)
            {
                MessageBox.Show(message, LangPack.GetText("MSGBoxHeader"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }

            string ip, port;
            bool isEthernet = CBoxConnectionType.SelectedIndex == 0;
            if (isEthernet)
            {
                ip = TBoxIp.Text.Replace(" ", "");

                string pattern = @"\d+\.\d+\.\d+\.\d+";
                if (!Regex.IsMatch(ip, pattern))
                {
                    ShowError(LangPack.GetText("WrongIP"));
                    return;
                }

                port = TBoxPort.Text;
            }
            else
            {
                ip = "";
                port = COMPortComboBox.Text;
            }


            if (string.IsNullOrWhiteSpace(port))
            {
                ShowError(LangPack.GetText("PortIsEmpty"));
                return;
            }

            string connection;
            if (isEthernet)
                connection = $"{ip}:{port}";
            else
                connection = port;

            if(_scale_infos.Any(si => si.Connection == connection))
            {
                ShowError(LangPack.GetText("ScaleExists"));
                return;
            }

            _scale_infos.Add(new ScaleInfo()
            {
                Connection = connection,
                Name = TBoxName.Text
            });
        }

        private void TBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
