using MassK.Settings;
using MassK.UI.LangPacks;
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
    public partial class FormDescription : Form
    {
       readonly private List<Image> _images;
        int _ix = 0;
        public FormDescription()
        {
            InitializeComponent();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _images = new List<Image>();
        }

        protected override void OnLoad(EventArgs e)
        {
            LangPack.Translate(this);

            string path = SettingManager.PresentationPath;
            foreach (string file in Directory.GetFiles(path, "*.png"))
            {
                Image img = GetImage(file);
                if (img != null)
                {
                    _images.Add(img);
                }
            }

            chkShow.Checked = !SettingManager.ShowDiscription;
            if (_images.Count > 0)
            {
                pictureBox.Image = _images.First();
                SetButtons();
            }
            else
            {
                MessageBox.Show("Slides of presentation not found!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }



        private void SetButtons()
        {
            int imgCount = _images.Count;
            if (imgCount < 1) return;
            //rdo1.Width
            double controlsWidth = 21 * imgCount;
            int controlsLeft = (int)Math.Round((panel2.Width - controlsWidth) / 2);
            for (int i = 1; i <= _images.Count; i++)
            {
                RadioButton rdo = default;
                if (i > 1)
                {
                    rdo = new RadioButton()
                    {
                        Name = $"rdo{ i}",
                        Text = "",
                        Height = rdo1.Height,
                        Top = rdo1.Top,
                        Width = rdo1.Width
                    };
                    rdo.Anchor = AnchorStyles.Bottom;
                    panel2.Controls.Add(rdo);
                }
                else
                {
                    rdo = rdo1;
                }
                rdo.Size = new Size(20, 20);
                rdo.Tag = i;
                rdo.Left = controlsLeft + (rdo1.Width * (i - 1));
                rdo.Click += Rdo_Click;
            }
        }

        private void Rdo_Click(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            if (!rdo.Checked)
            {
                return;
            }
            int num = (int)rdo.Tag;
            ShowItm(num);
        }



        private void ChangeItm(int ix)
        {
            if (ix > _images.Count)
            {
                ix = 1;
            }
            else if (ix < 1)
            {
                ix = _images.Count;
            }
            ShowItm(ix);
        }

        private void ShowItm(int ix)
        {
            if (ix <= _images.Count && ix > 0)
            {
                pictureBox.Image = _images[ix - 1];
                _ix = ix;
            }
        }

        private Image GetImage(string filename)
        {
            Image image = default;
            if (File.Exists(filename))
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                    image = Image.FromStream(fs);
            return image;
        }

        private void ShowChanged(object sender, EventArgs e)
        {
            SettingManager.ShowDiscription = !chkShow.Checked;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {

        }


        //private void FormDescription_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.Right)
        //    {
        //        ChangeItm(_ix + 1);
        //    }
        //    else if (e.KeyData == Keys.Left)
        //    {
        //        ChangeItm(_ix - 1);
        //    }
        //}
    }
}
