﻿using System;
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
    public partial class FormHelp : Form
    {
        public string HelpText {
            get => TextBox.Text;            
            set => TextBox.Text = value; }

        public FormHelp()
        {
            InitializeComponent();
        }
        

        private void ButtonExit_Click(object sender, EventArgs e)
        {

        }
    }
}
