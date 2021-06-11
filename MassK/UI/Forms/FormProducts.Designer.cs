
namespace MassK.UI.Forms
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowUncheckedProducts = new System.Windows.Forms.CheckBox();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.CBoxFields = new System.Windows.Forms.ComboBox();
            this.TboxFilter = new System.Windows.Forms.TextBox();
            this.InField = new System.Windows.Forms.Label();
            this.FindProducts = new System.Windows.Forms.Label();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.ShowUncheckedProducts);
            this.panel2.Controls.Add(this.ButtonApply);
            this.panel2.Controls.Add(this.CBoxFields);
            this.panel2.Controls.Add(this.TboxFilter);
            this.panel2.Controls.Add(this.InField);
            this.panel2.Controls.Add(this.FindProducts);
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F);
            this.panel2.Location = new System.Drawing.Point(0, 547);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 104);
            this.panel2.TabIndex = 15;
            // 
            // ShowUncheckedProducts
            // 
            this.ShowUncheckedProducts.AutoSize = true;
            this.ShowUncheckedProducts.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowUncheckedProducts.ForeColor = System.Drawing.Color.White;
            this.ShowUncheckedProducts.Location = new System.Drawing.Point(25, 69);
            this.ShowUncheckedProducts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ShowUncheckedProducts.Name = "ShowUncheckedProducts";
            this.ShowUncheckedProducts.Size = new System.Drawing.Size(294, 22);
            this.ShowUncheckedProducts.TabIndex = 4;
            this.ShowUncheckedProducts.Text = "Показать не выбранные товары";
            this.ShowUncheckedProducts.UseVisualStyleBackColor = true;
            this.ShowUncheckedProducts.Visible = false;
            // 
            // ButtonApply
            // 
            this.ButtonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonApply.BackColor = System.Drawing.Color.White;
            this.ButtonApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonApply.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonApply.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonApply.Location = new System.Drawing.Point(554, 61);
            this.ButtonApply.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(162, 30);
            this.ButtonApply.TabIndex = 0;
            this.ButtonApply.Text = "Применить";
            this.ButtonApply.UseVisualStyleBackColor = false;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // CBoxFields
            // 
            this.CBoxFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBoxFields.BackColor = System.Drawing.SystemColors.Window;
            this.CBoxFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxFields.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBoxFields.FormattingEnabled = true;
            this.CBoxFields.Location = new System.Drawing.Point(505, 17);
            this.CBoxFields.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CBoxFields.Name = "CBoxFields";
            this.CBoxFields.Size = new System.Drawing.Size(209, 26);
            this.CBoxFields.TabIndex = 3;
            this.CBoxFields.SelectedIndexChanged += new System.EventHandler(this.CBoxFields_SelectedIndexChanged);
            // 
            // TboxFilter
            // 
            this.TboxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TboxFilter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TboxFilter.Location = new System.Drawing.Point(129, 17);
            this.TboxFilter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TboxFilter.Name = "TboxFilter";
            this.TboxFilter.Size = new System.Drawing.Size(277, 27);
            this.TboxFilter.TabIndex = 2;
            this.TboxFilter.TextChanged += new System.EventHandler(this.TboxFilter_TextChanged);
            // 
            // InField
            // 
            this.InField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InField.AutoSize = true;
            this.InField.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InField.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InField.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InField.Location = new System.Drawing.Point(431, 20);
            this.InField.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InField.Name = "InField";
            this.InField.Size = new System.Drawing.Size(64, 18);
            this.InField.TabIndex = 1;
            this.InField.Text = "в поле";
            this.InField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FindProducts
            // 
            this.FindProducts.AutoSize = true;
            this.FindProducts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FindProducts.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindProducts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FindProducts.Location = new System.Drawing.Point(12, 20);
            this.FindProducts.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FindProducts.Name = "FindProducts";
            this.FindProducts.Size = new System.Drawing.Size(110, 18);
            this.FindProducts.TabIndex = 1;
            this.FindProducts.Text = "Найти товар";
            this.FindProducts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHelp.BackColor = System.Drawing.Color.White;
            this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonHelp.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonHelp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonHelp.Location = new System.Drawing.Point(584, 14);
            this.ButtonHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(129, 30);
            this.ButtonHelp.TabIndex = 0;
            this.ButtonHelp.Text = "Справка";
            this.ButtonHelp.UseVisualStyleBackColor = false;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.ButtonHelp);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 55);
            this.panel1.TabIndex = 14;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoEllipsis = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Title.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(13, 13);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(561, 32);
            this.Title.TabIndex = 1;
            this.Title.Text = "Выбор товаров для клавиатуры";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
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
            this.dataGrid.Location = new System.Drawing.Point(2, 57);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(727, 489);
            this.dataGrid.TabIndex = 12;
            this.dataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_ColumnHeaderMouseClick);
            // 
            // FormProducts
            // 
            this.AcceptButton = this.ButtonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormProducts";
            this.Text = "Справочник товаров";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ShowUncheckedProducts;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.ComboBox CBoxFields;
        private System.Windows.Forms.TextBox TboxFilter;
        private System.Windows.Forms.Label InField;
        private System.Windows.Forms.Label FindProducts;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private UI.Controls.CustomDataGrid dataGrid;
    }
}