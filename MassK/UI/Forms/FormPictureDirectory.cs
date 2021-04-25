﻿using MassK.LangPacks;
using MassK.UI;
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
    public partial class FormPictureDirectory : Form
    {
        public FormPictureDirectory()
        {
        }

        public FormPictureDirectory(LangPack langPack)
       {        
            langPack.SetText(this);
                InitializeComponent();
            panel1.BackColor = StyleUI.FrameColor;
            panel2.BackColor = StyleUI.FrameColor;
        }

        private void FormPictureDirectory_Load(object sender, EventArgs e)
        {

        }
    }
}