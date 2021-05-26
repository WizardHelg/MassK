
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
            this.TboxFilter = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Label();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbProductName = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.ButtonHelp = new System.Windows.Forms.Button();
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.TboxFilter);
            this.panel2.Controls.Add(this.Find);
            this.panel2.Controls.Add(this.ButtonSelect);
            this.panel2.Location = new System.Drawing.Point(3, 556);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 93);
            this.panel2.TabIndex = 16;
            // 
            // TboxFilter
            // 
            this.TboxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TboxFilter.Font = new System.Drawing.Font("Verdana", 12F);
            this.TboxFilter.Location = new System.Drawing.Point(234, 21);
            this.TboxFilter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TboxFilter.Name = "TboxFilter";
            this.TboxFilter.Size = new System.Drawing.Size(645, 27);
            this.TboxFilter.TabIndex = 2;
            this.TboxFilter.TextChanged += new System.EventHandler(this.TboxFilter_TextChanged);
            // 
            // Find
            // 
            this.Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Find.AutoSize = true;
            this.Find.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Find.Font = new System.Drawing.Font("Verdana", 12F);
            this.Find.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Find.Location = new System.Drawing.Point(11, 24);
            this.Find.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(213, 18);
            this.Find.TabIndex = 1;
            this.Find.Text = "Найти по наименованию";
            this.Find.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSelect.BackColor = System.Drawing.Color.White;
            this.ButtonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSelect.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonSelect.ForeColor = System.Drawing.Color.Black;
            this.ButtonSelect.Location = new System.Drawing.Point(743, 55);
            this.ButtonSelect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(136, 30);
            this.ButtonSelect.TabIndex = 19;
            this.ButtonSelect.Text = "Выбрать";
            this.ButtonSelect.UseVisualStyleBackColor = false;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.LbProductName);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.ButtonHelp);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 58);
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
            this.LbProductName.Size = new System.Drawing.Size(522, 18);
            this.LbProductName.TabIndex = 1;
            this.LbProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            this.Title.AutoEllipsis = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(17, 21);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(196, 18);
            this.Title.TabIndex = 1;
            this.Title.Text = "Картинка для товара:";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHelp.BackColor = System.Drawing.Color.White;
            this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonHelp.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonHelp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonHelp.Location = new System.Drawing.Point(755, 14);
            this.ButtonHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(121, 32);
            this.ButtonHelp.TabIndex = 0;
            this.ButtonHelp.Text = "Справка";
            this.ButtonHelp.UseVisualStyleBackColor = false;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(7, 65);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(882, 490);
            this.dataGrid.TabIndex = 15;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            this.dataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_ColumnHeaderMouseClick);
            // 
            // FormChangeImage
            // 
            this.AcceptButton = this.ButtonSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormChangeImage";
            this.Text = "Картинки для товаров";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TboxFilter;
        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button ButtonSelect;
        private UI.Controls.CustomDataGrid dataGrid;
        private System.Windows.Forms.Label LbProductName;
    }
}