
namespace MassK.UI.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ButtonProducts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowProductsWithoutPicturies = new System.Windows.Forms.CheckBox();
            this.CBoxFields = new System.Windows.Forms.ComboBox();
            this.TboxFilter = new System.Windows.Forms.TextBox();
            this.InField = new System.Windows.Forms.Label();
            this.FindProduct = new System.Windows.Forms.Label();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.ButtonSaveToUsb = new System.Windows.Forms.Button();
            this.ButtonUploadToScales = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.ToolStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuFile_LoadFromScales = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFile_LoadFromUSB = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFile_SaveToPC = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFile_LoadFromPC = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenuSettings_ScalesTable = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings_ProductNumeration = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings_ProductCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings_PictureLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.CbxLang = new System.Windows.Forms.ToolStripComboBox();
            this.MenuDescription = new System.Windows.Forms.ToolStripButton();
            this.CBoxCode = new System.Windows.Forms.ToolStripComboBox();
            this.dataGrid = new MassK.UI.Controls.CustomDataGrid();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonProducts
            // 
            this.ButtonProducts.BackColor = System.Drawing.Color.Transparent;
            this.ButtonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProducts.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonProducts.ForeColor = System.Drawing.Color.Black;
            this.ButtonProducts.Location = new System.Drawing.Point(9, 110);
            this.ButtonProducts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonProducts.Name = "ButtonProducts";
            this.ButtonProducts.Size = new System.Drawing.Size(114, 29);
            this.ButtonProducts.TabIndex = 6;
            this.ButtonProducts.Text = "Товары";
            this.ButtonProducts.UseVisualStyleBackColor = false;
            this.ButtonProducts.Click += new System.EventHandler(this.ButtonProducts_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.ShowProductsWithoutPicturies);
            this.panel2.Controls.Add(this.CBoxFields);
            this.panel2.Controls.Add(this.TboxFilter);
            this.panel2.Controls.Add(this.InField);
            this.panel2.Controls.Add(this.FindProduct);
            this.panel2.Location = new System.Drawing.Point(3, 567);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 58);
            this.panel2.TabIndex = 11;
            // 
            // ShowProductsWithoutPicturies
            // 
            this.ShowProductsWithoutPicturies.AutoSize = true;
            this.ShowProductsWithoutPicturies.Font = new System.Drawing.Font("Verdana", 12F);
            this.ShowProductsWithoutPicturies.ForeColor = System.Drawing.Color.White;
            this.ShowProductsWithoutPicturies.Location = new System.Drawing.Point(12, 19);
            this.ShowProductsWithoutPicturies.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ShowProductsWithoutPicturies.Name = "ShowProductsWithoutPicturies";
            this.ShowProductsWithoutPicturies.Size = new System.Drawing.Size(284, 22);
            this.ShowProductsWithoutPicturies.TabIndex = 4;
            this.ShowProductsWithoutPicturies.Text = "Показать товары без картинок";
            this.ShowProductsWithoutPicturies.UseVisualStyleBackColor = true;
            // 
            // CBoxFields
            // 
            this.CBoxFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CBoxFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxFields.Font = new System.Drawing.Font("Verdana", 12F);
            this.CBoxFields.FormattingEnabled = true;
            this.CBoxFields.Location = new System.Drawing.Point(814, 17);
            this.CBoxFields.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CBoxFields.Name = "CBoxFields";
            this.CBoxFields.Size = new System.Drawing.Size(213, 26);
            this.CBoxFields.TabIndex = 3;
            this.CBoxFields.SelectedIndexChanged += new System.EventHandler(this.CBoxFields_SelectedIndexChanged);
            // 
            // TboxFilter
            // 
            this.TboxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TboxFilter.Location = new System.Drawing.Point(441, 17);
            this.TboxFilter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TboxFilter.Name = "TboxFilter";
            this.TboxFilter.Size = new System.Drawing.Size(273, 27);
            this.TboxFilter.TabIndex = 2;
            this.TboxFilter.TextChanged += new System.EventHandler(this.TboxFilter_TextChanged);
            // 
            // InField
            // 
            this.InField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InField.AutoSize = true;
            this.InField.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InField.Font = new System.Drawing.Font("Verdana", 12F);
            this.InField.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InField.Location = new System.Drawing.Point(743, 21);
            this.InField.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InField.Name = "InField";
            this.InField.Size = new System.Drawing.Size(64, 18);
            this.InField.TabIndex = 1;
            this.InField.Text = "в поле";
            this.InField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FindProduct
            // 
            this.FindProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FindProduct.AutoSize = true;
            this.FindProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FindProduct.Font = new System.Drawing.Font("Verdana", 12F);
            this.FindProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FindProduct.Location = new System.Drawing.Point(320, 21);
            this.FindProduct.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FindProduct.Name = "FindProduct";
            this.FindProduct.Size = new System.Drawing.Size(110, 18);
            this.FindProduct.TabIndex = 1;
            this.FindProduct.Text = "Найти товар";
            this.FindProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHelp.BackColor = System.Drawing.Color.White;
            this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonHelp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonHelp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonHelp.Location = new System.Drawing.Point(916, 14);
            this.ButtonHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(111, 30);
            this.ButtonHelp.TabIndex = 0;
            this.ButtonHelp.Text = "Справка";
            this.ButtonHelp.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(109)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.ButtonHelp);
            this.panel1.Location = new System.Drawing.Point(3, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 58);
            this.panel1.TabIndex = 10;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoEllipsis = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Title.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(20, 17);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(865, 27);
            this.Title.TabIndex = 1;
            this.Title.Text = "Редактор клавиатуры весов самообслуживания";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonSaveToUsb
            // 
            this.ButtonSaveToUsb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveToUsb.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSaveToUsb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSaveToUsb.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonSaveToUsb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ButtonSaveToUsb.Location = new System.Drawing.Point(832, 630);
            this.ButtonSaveToUsb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonSaveToUsb.Name = "ButtonSaveToUsb";
            this.ButtonSaveToUsb.Size = new System.Drawing.Size(198, 31);
            this.ButtonSaveToUsb.TabIndex = 9;
            this.ButtonSaveToUsb.Text = "Записать на USB";
            this.ButtonSaveToUsb.UseVisualStyleBackColor = false;
            this.ButtonSaveToUsb.Click += new System.EventHandler(this.ButtonSaveToUsb_Click);
            // 
            // ButtonUploadToScales
            // 
            this.ButtonUploadToScales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUploadToScales.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUploadToScales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUploadToScales.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonUploadToScales.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ButtonUploadToScales.Location = new System.Drawing.Point(624, 630);
            this.ButtonUploadToScales.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonUploadToScales.Name = "ButtonUploadToScales";
            this.ButtonUploadToScales.Size = new System.Drawing.Size(198, 31);
            this.ButtonUploadToScales.TabIndex = 9;
            this.ButtonUploadToScales.Text = "Выгрузить в весы";
            this.ButtonUploadToScales.UseVisualStyleBackColor = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuSettings,
            this.CbxLang,
            this.MenuDescription,
            this.CBoxCode});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.MenuStrip.Size = new System.Drawing.Size(1045, 48);
            this.MenuStrip.TabIndex = 13;
            this.MenuStrip.Text = "toolStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile_LoadFromScales,
            this.MenuFile_LoadFromUSB,
            this.MenuFile_SaveToPC,
            this.MenuFile_LoadFromPC});
            this.MenuFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuFile.Image = ((System.Drawing.Image)(resources.GetObject("MenuFile.Image")));
            this.MenuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(80, 45);
            this.MenuFile.Text = "Файл";
            // 
            // MenuFile_LoadFromScales
            // 
            this.MenuFile_LoadFromScales.Name = "MenuFile_LoadFromScales";
            this.MenuFile_LoadFromScales.Size = new System.Drawing.Size(330, 22);
            this.MenuFile_LoadFromScales.Text = "Загрузить данные из весов";
            // 
            // MenuFile_LoadFromUSB
            // 
            this.MenuFile_LoadFromUSB.Name = "MenuFile_LoadFromUSB";
            this.MenuFile_LoadFromUSB.Size = new System.Drawing.Size(330, 22);
            this.MenuFile_LoadFromUSB.Text = "Загрузить данные с USB-Flash";
            this.MenuFile_LoadFromUSB.Click += new System.EventHandler(this.MenuFile_LoadFromUSB_Click);
            // 
            // MenuFile_SaveToPC
            // 
            this.MenuFile_SaveToPC.Name = "MenuFile_SaveToPC";
            this.MenuFile_SaveToPC.Size = new System.Drawing.Size(330, 22);
            this.MenuFile_SaveToPC.Text = "Сохранить проект в ПК";
            this.MenuFile_SaveToPC.Click += new System.EventHandler(this.MenuFile_SaveToPC_Click);
            // 
            // MenuFile_LoadFromPC
            // 
            this.MenuFile_LoadFromPC.Name = "MenuFile_LoadFromPC";
            this.MenuFile_LoadFromPC.Size = new System.Drawing.Size(330, 22);
            this.MenuFile_LoadFromPC.Text = "Загрузить проект из ПК";
            this.MenuFile_LoadFromPC.Click += new System.EventHandler(this.MenuFile_LoadFromPC_Click);
            // 
            // MenuSettings
            // 
            this.MenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettings_ScalesTable,
            this.MenuSettings_ProductNumeration,
            this.MenuSettings_ProductCategories,
            this.MenuSettings_PictureLibrary});
            this.MenuSettings.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuSettings.Image = ((System.Drawing.Image)(resources.GetObject("MenuSettings.Image")));
            this.MenuSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(124, 45);
            this.MenuSettings.Text = "Настройка";
            // 
            // MenuSettings_ScalesTable
            // 
            this.MenuSettings_ScalesTable.Name = "MenuSettings_ScalesTable";
            this.MenuSettings_ScalesTable.Size = new System.Drawing.Size(254, 22);
            this.MenuSettings_ScalesTable.Text = "Таблица весов";
            this.MenuSettings_ScalesTable.Click += new System.EventHandler(this.MenuSettings_ScalesTable_Click);
            // 
            // MenuSettings_ProductNumeration
            // 
            this.MenuSettings_ProductNumeration.Name = "MenuSettings_ProductNumeration";
            this.MenuSettings_ProductNumeration.Size = new System.Drawing.Size(254, 22);
            this.MenuSettings_ProductNumeration.Text = "Номера товаров";
            this.MenuSettings_ProductNumeration.Click += new System.EventHandler(this.MenuSettings_ProductNumeration_Click);
            // 
            // MenuSettings_ProductCategories
            // 
            this.MenuSettings_ProductCategories.Name = "MenuSettings_ProductCategories";
            this.MenuSettings_ProductCategories.Size = new System.Drawing.Size(254, 22);
            this.MenuSettings_ProductCategories.Text = "Категории товаров";
            this.MenuSettings_ProductCategories.Click += new System.EventHandler(this.MenuSettings_ProductCategories_Click);
            // 
            // MenuSettings_PictureLibrary
            // 
            this.MenuSettings_PictureLibrary.Name = "MenuSettings_PictureLibrary";
            this.MenuSettings_PictureLibrary.Size = new System.Drawing.Size(254, 22);
            this.MenuSettings_PictureLibrary.Text = "Библиотека картинок";
            this.MenuSettings_PictureLibrary.Click += new System.EventHandler(this.MenuSettings_PictureLibrary_Click);
            // 
            // CbxLang
            // 
            this.CbxLang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CbxLang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbxLang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxLang.Name = "CbxLang";
            this.CbxLang.Size = new System.Drawing.Size(170, 48);
            this.CbxLang.SelectedIndexChanged += new System.EventHandler(this.CbxLang_SelectedIndexChanged);
            this.CbxLang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxLang_KeyPress);
            // 
            // MenuDescription
            // 
            this.MenuDescription.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuDescription.Image = ((System.Drawing.Image)(resources.GetObject("MenuDescription.Image")));
            this.MenuDescription.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuDescription.Name = "MenuDescription";
            this.MenuDescription.Size = new System.Drawing.Size(110, 45);
            this.MenuDescription.Text = "Описание";
            // 
            // CBoxCode
            // 
            this.CBoxCode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CBoxCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBoxCode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBoxCode.Name = "CBoxCode";
            this.CBoxCode.Size = new System.Drawing.Size(380, 48);
            this.CBoxCode.SelectedIndexChanged += new System.EventHandler(this.CBoxCode_SelectedIndexChanged);
            this.CBoxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBoxCode_KeyPress);
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
            this.dataGrid.Location = new System.Drawing.Point(5, 143);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.ShowCellErrors = false;
            this.dataGrid.Size = new System.Drawing.Size(1038, 423);
            this.dataGrid.TabIndex = 5;
            this.dataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentDoubleClick);
            this.dataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_ColumnHeaderMouseClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 666);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ButtonProducts);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonUploadToScales);
            this.Controls.Add(this.ButtonSaveToUsb);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormMain";
            this.Text = "Редактор клавиатуры весов";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonProducts;
        private UI.Controls.CustomDataGrid dataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ShowProductsWithoutPicturies;
        private System.Windows.Forms.ComboBox CBoxFields;
        private System.Windows.Forms.TextBox TboxFilter;
        private System.Windows.Forms.Label InField;
        private System.Windows.Forms.Label FindProduct;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ButtonSaveToUsb;
        private System.Windows.Forms.Button ButtonUploadToScales;
        private System.Windows.Forms.ToolStrip MenuStrip;
        private System.Windows.Forms.ToolStripDropDownButton MenuFile;
        private System.Windows.Forms.ToolStripDropDownButton MenuSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuFile_LoadFromScales;
        private System.Windows.Forms.ToolStripMenuItem MenuFile_LoadFromUSB;
        private System.Windows.Forms.ToolStripMenuItem MenuFile_SaveToPC;
        private System.Windows.Forms.ToolStripMenuItem MenuFile_LoadFromPC;
        private System.Windows.Forms.ToolStripComboBox CbxLang;
        private System.Windows.Forms.ToolStripButton MenuDescription;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings_ScalesTable;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings_ProductNumeration;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings_ProductCategories;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings_PictureLibrary;
        private System.Windows.Forms.ToolStripComboBox CBoxCode;
    }
}

