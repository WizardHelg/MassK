using MassK.LangPacks;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MassK
{
    public partial class FormMain : Form
    {
        private  LangPack _langPack;
        readonly Properties.Settings settings = Properties.Settings.Default;

        public FormMain()
        {
            InitializeComponent();
            string cur_lang = settings.Lang;
            SetText(cur_lang);
            FillLangs(_langPack);
        }

        private void SetText(string cur_lang)
        {
            LangPack.Load(Directory.GetCurrentDirectory());
            if (!string.IsNullOrEmpty(LangPack.GetLangNames().Find(x => x == cur_lang)))
                LangPack.SetLang(cur_lang);
            else
                LangPack.SetCurrentCultureLang();

            _langPack = LangPack.Lang;
            if (_langPack != null)
            {
            _langPack.SetText(this);
            }
        }

        private void FillLangs(LangPack langPack)
        {
            CbxLang.Items.Clear();
            foreach (string lang in LangPack.GetLangNames())
            {
                CbxLang.Items.Add(lang);
            }
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

        private void CbxLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string curLang = CbxLang.Items[CbxLang.SelectedIndex].ToString();
            string findLang = LangPack.GetLangNames().Find(x => x == curLang);
            if (!string.IsNullOrEmpty(findLang))
            {
                SetText(findLang);
            }
        }
    }
}
