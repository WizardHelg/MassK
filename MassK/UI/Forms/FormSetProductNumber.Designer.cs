
namespace MassK.UI.Forms
{
    partial class FormSetProductNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetProductNumber));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RBtnPLU = new System.Windows.Forms.RadioButton();
            this.RBtnOperator = new System.Windows.Forms.RadioButton();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.RBtnPLU);
            this.panel1.Controls.Add(this.RBtnOperator);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 109);
            this.panel1.TabIndex = 0;
            // 
            // RBtnPLU
            // 
            this.RBtnPLU.Font = new System.Drawing.Font("Verdana", 12F);
            this.RBtnPLU.Location = new System.Drawing.Point(112, 59);
            this.RBtnPLU.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RBtnPLU.Name = "RBtnPLU";
            this.RBtnPLU.Size = new System.Drawing.Size(190, 36);
            this.RBtnPLU.TabIndex = 0;
            this.RBtnPLU.TabStop = true;
            this.RBtnPLU.Text = "Использовать PLU";
            this.RBtnPLU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBtnPLU.UseVisualStyleBackColor = true;
            this.RBtnPLU.CheckedChanged += new System.EventHandler(this.RBtnPLU_CheckedChanged);
            // 
            // RBtnOperator
            // 
            this.RBtnOperator.Font = new System.Drawing.Font("Verdana", 12F);
            this.RBtnOperator.Location = new System.Drawing.Point(112, 15);
            this.RBtnOperator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RBtnOperator.Name = "RBtnOperator";
            this.RBtnOperator.Size = new System.Drawing.Size(178, 36);
            this.RBtnOperator.TabIndex = 0;
            this.RBtnOperator.TabStop = true;
            this.RBtnOperator.Text = "Ввод оператором";
            this.RBtnOperator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBtnOperator.UseVisualStyleBackColor = true;
            this.RBtnOperator.CheckedChanged += new System.EventHandler(this.RBtnOperator_CheckedChanged);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnHelp.Location = new System.Drawing.Point(8, 124);
            this.BtnHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(125, 32);
            this.BtnHelp.TabIndex = 4;
            this.BtnHelp.Text = "Справка";
            this.BtnHelp.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(144, 124);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(125, 32);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(279, 124);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(125, 32);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Отменить";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // FormSetProductNumber
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(415, 162);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormSetProductNumber";
            this.Text = "Выбрать способ установки номера товара";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.RadioButton RBtnPLU;
        private System.Windows.Forms.RadioButton RBtnOperator;
    }
}