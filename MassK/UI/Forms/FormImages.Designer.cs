
namespace MassK.UI.Forms
{
    partial class FormImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImages));
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBoxFields = new System.Windows.Forms.ComboBox();
            this.TboxFilter = new System.Windows.Forms.TextBox();
            this.InField = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonLogo = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.CBoxFields);
            this.panel2.Controls.Add(this.TboxFilter);
            this.panel2.Controls.Add(this.InField);
            this.panel2.Controls.Add(this.Find);
            this.panel2.Location = new System.Drawing.Point(3, 574);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 64);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // CBoxFields
            // 
            this.CBoxFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CBoxFields.Font = new System.Drawing.Font("Verdana", 12F);
            this.CBoxFields.FormattingEnabled = true;
            this.CBoxFields.Location = new System.Drawing.Point(774, 20);
            this.CBoxFields.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CBoxFields.Name = "CBoxFields";
            this.CBoxFields.Size = new System.Drawing.Size(224, 26);
            this.CBoxFields.TabIndex = 3;
            // 
            // TboxFilter
            // 
            this.TboxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TboxFilter.Font = new System.Drawing.Font("Verdana", 12F);
            this.TboxFilter.Location = new System.Drawing.Point(80, 21);
            this.TboxFilter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TboxFilter.Name = "TboxFilter";
            this.TboxFilter.Size = new System.Drawing.Size(373, 27);
            this.TboxFilter.TabIndex = 2;
            // 
            // InField
            // 
            this.InField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InField.AutoSize = true;
            this.InField.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InField.Font = new System.Drawing.Font("Verdana", 12F);
            this.InField.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InField.Location = new System.Drawing.Point(699, 23);
            this.InField.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InField.Name = "InField";
            this.InField.Size = new System.Drawing.Size(64, 18);
            this.InField.TabIndex = 1;
            this.InField.Text = "в поле";
            this.InField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Find
            // 
            this.Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Find.AutoSize = true;
            this.Find.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Find.Font = new System.Drawing.Font("Verdana", 12F);
            this.Find.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Find.Location = new System.Drawing.Point(10, 24);
            this.Find.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(57, 18);
            this.Find.TabIndex = 1;
            this.Find.Text = "Найти";
            this.Find.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.ButtonHelp);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 58);
            this.panel1.TabIndex = 13;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoEllipsis = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(17, 11);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(859, 39);
            this.Title.TabIndex = 1;
            this.Title.Text = "Библиотека картинок";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHelp.BackColor = System.Drawing.Color.White;
            this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonHelp.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonHelp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonHelp.Location = new System.Drawing.Point(898, 14);
            this.ButtonHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(106, 30);
            this.ButtonHelp.TabIndex = 0;
            this.ButtonHelp.Text = "Справка";
            this.ButtonHelp.UseVisualStyleBackColor = false;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonAdd.ForeColor = System.Drawing.Color.Black;
            this.ButtonAdd.Location = new System.Drawing.Point(8, 66);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(129, 30);
            this.ButtonAdd.TabIndex = 14;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonDelete.ForeColor = System.Drawing.Color.Black;
            this.ButtonDelete.Location = new System.Drawing.Point(149, 66);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(129, 30);
            this.ButtonDelete.TabIndex = 14;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonLogo
            // 
            this.ButtonLogo.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogo.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonLogo.ForeColor = System.Drawing.Color.Black;
            this.ButtonLogo.Location = new System.Drawing.Point(290, 66);
            this.ButtonLogo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonLogo.Name = "ButtonLogo";
            this.ButtonLogo.Size = new System.Drawing.Size(129, 30);
            this.ButtonLogo.TabIndex = 14;
            this.ButtonLogo.Text = "Логотип";
            this.ButtonLogo.UseVisualStyleBackColor = false;
            this.ButtonLogo.Click += new System.EventHandler(this.ButtonLogo_Click);
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
            this.dataGrid.Location = new System.Drawing.Point(2, 102);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1018, 536);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_ColumnHeaderMouseClick);
            // 
            // FormImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 643);
            this.Controls.Add(this.ButtonLogo);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGrid);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(815, 633);
            this.Name = "FormImages";
            this.Text = "Библиотека картинок";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Controls.CustomDataGrid dataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBoxFields;
        private System.Windows.Forms.TextBox TboxFilter;
        private System.Windows.Forms.Label InField;
        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonLogo;
    }
}