using MassK.LangPacks;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MassK
{
    public partial class FormMain : Form
    {
        private readonly LangPack _langPack;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(LangPack langPack)
        {
            _langPack = langPack;
            langPack.SetText(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
  
        private void BtnProducts_Click(object sender, EventArgs e)
        {
            new FormProductDirectory(_langPack).Show();
        }

        private void BtnPictureDirectory_Click(object sender, EventArgs e)
        {
            new FormPictureDirectory(_langPack).Show();
        }

        private void BtnWeighingMachins_Click(object sender, EventArgs e)
        {
            new FormWeighingMachins(_langPack).Show();
        }
    }
}
