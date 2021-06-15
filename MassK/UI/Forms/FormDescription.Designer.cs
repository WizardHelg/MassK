
namespace MassK.UI.Forms
{
    partial class FormDescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDescription));
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.chkShow);
            this.panel2.Controls.Add(this.rdo1);
            this.panel2.Controls.Add(this.ButtonExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 624);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 58);
            this.panel2.TabIndex = 17;
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(6, 33);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(274, 22);
            this.chkShow.TabIndex = 25;
            this.chkShow.TabStop = false;
            this.chkShow.Text = "Не показывать при открытии.";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.ShowChanged);
            // 
            // rdo1
            // 
            this.rdo1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rdo1.Checked = true;
            this.rdo1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdo1.FlatAppearance.BorderSize = 2;
            this.rdo1.Location = new System.Drawing.Point(488, 14);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(14, 13);
            this.rdo1.TabIndex = 24;
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.BackColor = System.Drawing.Color.White;
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.ForeColor = System.Drawing.Color.Black;
            this.ButtonExit.Location = new System.Drawing.Point(895, 11);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(137, 37);
            this.ButtonExit.TabIndex = 20;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 58);
            this.panel1.TabIndex = 18;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.pictureBox);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 58);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1050, 566);
            this.ContentPanel.TabIndex = 19;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1050, 566);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // FormDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonExit;
            this.ClientSize = new System.Drawing.Size(1050, 682);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDescription";
            this.Text = "Описание";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.CheckBox chkShow;
    }
}