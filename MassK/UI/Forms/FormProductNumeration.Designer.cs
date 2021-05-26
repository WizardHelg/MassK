
namespace MassK.UI.Forms
{
    partial class FormProductNumeration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductNumeration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PLU = new System.Windows.Forms.RadioButton();
            this.Operator = new System.Windows.Forms.RadioButton();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.PLU);
            this.panel1.Controls.Add(this.Operator);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 109);
            this.panel1.TabIndex = 0;
            // 
            // PLU
            // 
            this.PLU.Font = new System.Drawing.Font("Verdana", 12F);
            this.PLU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PLU.Location = new System.Drawing.Point(112, 59);
            this.PLU.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PLU.Name = "PLU";
            this.PLU.Size = new System.Drawing.Size(185, 36);
            this.PLU.TabIndex = 0;
            this.PLU.TabStop = true;
            this.PLU.Text = "Использовать PLU";
            this.PLU.UseVisualStyleBackColor = true;
            // 
            // Operator
            // 
            this.Operator.Font = new System.Drawing.Font("Verdana", 12F);
            this.Operator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Operator.Location = new System.Drawing.Point(112, 15);
            this.Operator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(178, 36);
            this.Operator.TabIndex = 0;
            this.Operator.TabStop = true;
            this.Operator.Text = "Ввод оператором";
            this.Operator.UseVisualStyleBackColor = true;
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonHelp.Location = new System.Drawing.Point(8, 124);
            this.ButtonHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(125, 32);
            this.ButtonHelp.TabIndex = 4;
            this.ButtonHelp.Text = "Справка";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Location = new System.Drawing.Point(279, 126);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(125, 32);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // FormProductNumeration
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 162);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormProductNumeration";
            this.Text = "Выбрать способ установки номера товара";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.RadioButton PLU;
        private System.Windows.Forms.RadioButton Operator;
    }
}