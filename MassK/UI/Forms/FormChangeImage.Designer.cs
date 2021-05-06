
namespace MassK.UI.Forms
{
    partial class FormChangeImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeImage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.dataGrid = new MassK.UI.Controls.CustomDataGrid();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Location = new System.Drawing.Point(3, 556);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 93);
            this.panel2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F);
            this.textBox1.Location = new System.Drawing.Point(234, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Найти по наименованию";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Location = new System.Drawing.Point(478, 55);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(136, 30);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "Выбрать";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.LbProductName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnHelp);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 58);
            this.panel1.TabIndex = 17;
            // 
            // LbProductName
            // 
            this.LbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbProductName.AutoEllipsis = true;
            this.LbProductName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbProductName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbProductName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbProductName.Location = new System.Drawing.Point(223, 21);
            this.LbProductName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LbProductName.Name = "LbProductName";
            this.LbProductName.Size = new System.Drawing.Size(257, 18);
            this.LbProductName.TabIndex = 1;
            this.LbProductName.Text = "товар";
            this.LbProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Картинка для товара:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHelp.BackColor = System.Drawing.Color.White;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHelp.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnHelp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnHelp.Location = new System.Drawing.Point(490, 14);
            this.BtnHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(121, 32);
            this.BtnHelp.TabIndex = 0;
            this.BtnHelp.Text = "Справка";
            this.BtnHelp.UseVisualStyleBackColor = false;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(7, 65);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(617, 490);
            this.dataGrid.TabIndex = 15;
            // 
            // FormChangeImage
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormChangeImage";
            this.Text = "Картинки для товаров";
            this.Load += new System.EventHandler(this.FormChangeImage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnSave;
        private Controls.CustomDataGrid dataGrid;
        private System.Windows.Forms.Label LbProductName;
    }
}