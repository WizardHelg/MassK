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
    public partial class FormMain : Form
    {
        Point oldPos;
        bool isDragging = false;
        Point oldMouse;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
  
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            this.isDragging = true;
            this.oldPos = this.Location;
            this.oldMouse = e.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.isDragging)
            {
                this.Location = new Point(oldPos.X + (e.X - oldMouse.X), oldPos.Y + (e.Y - oldMouse.Y));
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
             this.isDragging = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            MinimizeBox = true;
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            new FormProductDirectory().Show();
        }

        private void BtnPictureDirectory_Click(object sender, EventArgs e)
        {
            new FormPictureDirectory().Show();
        }

        private void BtnWeighingMachins_Click(object sender, EventArgs e)
        {
            new FormWeighingMachins().Show();
        }
    }
}
