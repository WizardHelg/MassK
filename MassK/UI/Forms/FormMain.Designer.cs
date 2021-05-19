
namespace MassK
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
            this.BtnProducts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChkBoxShowProducts = new System.Windows.Forms.CheckBox();
            this.CBoxFields = new System.Windows.Forms.ComboBox();
            this.TboxFilter = new System.Windows.Forms.TextBox();
            this.LbField = new System.Windows.Forms.Label();
            this.LbFindProduct = new System.Windows.Forms.Label();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbTitleMain = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnSaveToUsb = new System.Windows.Forms.Button();
            this.BtnUnloadToWeighing = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.загрузитьДанныеИзВесовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеСUSBFlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПроектВПКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьПроектИзПКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.таблицаВесовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номераТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.библиотекаКартинокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbxLang = new System.Windows.Forms.ToolStripComboBox();
            this.MenuDescription = new System.Windows.Forms.ToolStripButton();
            this.CBoxCode = new System.Windows.Forms.ToolStripComboBox();
            this.dataGrid = new MassK.UI.Controls.CustomDataGrid();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnProducts
            // 
            this.BtnProducts.BackColor = System.Drawing.Color.Transparent;
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnProducts.ForeColor = System.Drawing.Color.Black;
            this.BtnProducts.Location = new System.Drawing.Point(9, 110);
            this.BtnProducts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(114, 29);
            this.BtnProducts.TabIndex = 6;
            this.BtnProducts.Text = "Товары";
            this.BtnProducts.UseVisualStyleBackColor = false;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.ChkBoxShowProducts);
            this.panel2.Controls.Add(this.CBoxFields);
            this.panel2.Controls.Add(this.TboxFilter);
            this.panel2.Controls.Add(this.LbField);
            this.panel2.Controls.Add(this.LbFindProduct);
            this.panel2.Location = new System.Drawing.Point(3, 567);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 58);
            this.panel2.TabIndex = 11;
            // 
            // ChkBoxShowProducts
            // 
            this.ChkBoxShowProducts.AutoSize = true;
            this.ChkBoxShowProducts.Font = new System.Drawing.Font("Verdana", 12F);
            this.ChkBoxShowProducts.ForeColor = System.Drawing.Color.White;
            this.ChkBoxShowProducts.Location = new System.Drawing.Point(12, 19);
            this.ChkBoxShowProducts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ChkBoxShowProducts.Name = "ChkBoxShowProducts";
            this.ChkBoxShowProducts.Size = new System.Drawing.Size(284, 22);
            this.ChkBoxShowProducts.TabIndex = 4;
            this.ChkBoxShowProducts.Text = "Показать товары без картинок";
            this.ChkBoxShowProducts.UseVisualStyleBackColor = true;
            // 
            // CBoxFields
            // 
            this.CBoxFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CBoxFields.Font = new System.Drawing.Font("Verdana", 12F);
            this.CBoxFields.FormattingEnabled = true;
            this.CBoxFields.Location = new System.Drawing.Point(814, 17);
            this.CBoxFields.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CBoxFields.Name = "CBoxFields";
            this.CBoxFields.Size = new System.Drawing.Size(213, 26);
            this.CBoxFields.TabIndex = 3;
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
            // LbField
            // 
            this.LbField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LbField.AutoSize = true;
            this.LbField.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbField.Font = new System.Drawing.Font("Verdana", 12F);
            this.LbField.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbField.Location = new System.Drawing.Point(743, 21);
            this.LbField.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LbField.Name = "LbField";
            this.LbField.Size = new System.Drawing.Size(64, 18);
            this.LbField.TabIndex = 1;
            this.LbField.Text = "в поле";
            this.LbField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LbFindProduct
            // 
            this.LbFindProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LbFindProduct.AutoSize = true;
            this.LbFindProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbFindProduct.Font = new System.Drawing.Font("Verdana", 12F);
            this.LbFindProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbFindProduct.Location = new System.Drawing.Point(320, 21);
            this.LbFindProduct.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LbFindProduct.Name = "LbFindProduct";
            this.LbFindProduct.Size = new System.Drawing.Size(110, 18);
            this.LbFindProduct.TabIndex = 1;
            this.LbFindProduct.Text = "Найти товар";
            this.LbFindProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHelp.BackColor = System.Drawing.Color.White;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHelp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnHelp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnHelp.Location = new System.Drawing.Point(916, 14);
            this.BtnHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(111, 30);
            this.BtnHelp.TabIndex = 0;
            this.BtnHelp.Text = "Справка";
            this.BtnHelp.UseVisualStyleBackColor = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.LbTitleMain);
            this.panel1.Controls.Add(this.BtnHelp);
            this.panel1.Location = new System.Drawing.Point(3, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 58);
            this.panel1.TabIndex = 10;
            // 
            // LbTitleMain
            // 
            this.LbTitleMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTitleMain.AutoEllipsis = true;
            this.LbTitleMain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbTitleMain.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbTitleMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbTitleMain.Location = new System.Drawing.Point(20, 17);
            this.LbTitleMain.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LbTitleMain.Name = "LbTitleMain";
            this.LbTitleMain.Size = new System.Drawing.Size(865, 27);
            this.LbTitleMain.TabIndex = 1;
            this.LbTitleMain.Text = "Редактор клавиатуры весов самообслуживания";
            this.LbTitleMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            // 
            // BtnSaveToUsb
            // 
            this.BtnSaveToUsb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveToUsb.BackColor = System.Drawing.Color.Transparent;
            this.BtnSaveToUsb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveToUsb.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnSaveToUsb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnSaveToUsb.Location = new System.Drawing.Point(832, 630);
            this.BtnSaveToUsb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSaveToUsb.Name = "BtnSaveToUsb";
            this.BtnSaveToUsb.Size = new System.Drawing.Size(198, 31);
            this.BtnSaveToUsb.TabIndex = 9;
            this.BtnSaveToUsb.Text = "Записать на USB";
            this.BtnSaveToUsb.UseVisualStyleBackColor = false;
            this.BtnSaveToUsb.Click += new System.EventHandler(this.BtnSaveToUsb_Click);
            // 
            // BtnUnloadToWeighing
            // 
            this.BtnUnloadToWeighing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUnloadToWeighing.BackColor = System.Drawing.Color.Transparent;
            this.BtnUnloadToWeighing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUnloadToWeighing.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnUnloadToWeighing.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnUnloadToWeighing.Location = new System.Drawing.Point(624, 630);
            this.BtnUnloadToWeighing.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnUnloadToWeighing.Name = "BtnUnloadToWeighing";
            this.BtnUnloadToWeighing.Size = new System.Drawing.Size(198, 31);
            this.BtnUnloadToWeighing.TabIndex = 9;
            this.BtnUnloadToWeighing.Text = "Выгрузить в весы";
            this.BtnUnloadToWeighing.UseVisualStyleBackColor = false;
            this.BtnUnloadToWeighing.Click += new System.EventHandler(this.BtnUnloadToWeighing_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuSettings,
            this.CbxLang,
            this.MenuDescription,
            this.CBoxCode});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1045, 48);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьДанныеИзВесовToolStripMenuItem,
            this.загрузитьДанныеСUSBFlashToolStripMenuItem,
            this.сохранитьПроектВПКToolStripMenuItem,
            this.загрузитьПроектИзПКToolStripMenuItem});
            this.MenuFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuFile.Image = ((System.Drawing.Image)(resources.GetObject("MenuFile.Image")));
            this.MenuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(80, 45);
            this.MenuFile.Text = "Файл";
            // 
            // загрузитьДанныеИзВесовToolStripMenuItem
            // 
            this.загрузитьДанныеИзВесовToolStripMenuItem.Name = "загрузитьДанныеИзВесовToolStripMenuItem";
            this.загрузитьДанныеИзВесовToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.загрузитьДанныеИзВесовToolStripMenuItem.Text = "Загрузить данные из весов ";
            this.загрузитьДанныеИзВесовToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДанныеИзВесовToolStripMenuItem_Click);
            // 
            // загрузитьДанныеСUSBFlashToolStripMenuItem
            // 
            this.загрузитьДанныеСUSBFlashToolStripMenuItem.Name = "загрузитьДанныеСUSBFlashToolStripMenuItem";
            this.загрузитьДанныеСUSBFlashToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.загрузитьДанныеСUSBFlashToolStripMenuItem.Text = "Загрузить данные с USB-Flash";
            this.загрузитьДанныеСUSBFlashToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДанныеСUSBFlashToolStripMenuItem_Click);
            // 
            // сохранитьПроектВПКToolStripMenuItem
            // 
            this.сохранитьПроектВПКToolStripMenuItem.Name = "сохранитьПроектВПКToolStripMenuItem";
            this.сохранитьПроектВПКToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.сохранитьПроектВПКToolStripMenuItem.Text = "Сохранить проект в ПК";
            this.сохранитьПроектВПКToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПроектВПКToolStripMenuItem_Click);
            // 
            // загрузитьПроектИзПКToolStripMenuItem
            // 
            this.загрузитьПроектИзПКToolStripMenuItem.Name = "загрузитьПроектИзПКToolStripMenuItem";
            this.загрузитьПроектИзПКToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.загрузитьПроектИзПКToolStripMenuItem.Text = "Загрузить проект из ПК";
            this.загрузитьПроектИзПКToolStripMenuItem.Click += new System.EventHandler(this.загрузитьПроектИзПКToolStripMenuItem_Click);
            // 
            // MenuSettings
            // 
            this.MenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаВесовToolStripMenuItem,
            this.номераТоваровToolStripMenuItem,
            this.категорииТоваровToolStripMenuItem,
            this.библиотекаКартинокToolStripMenuItem});
            this.MenuSettings.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuSettings.Image = ((System.Drawing.Image)(resources.GetObject("MenuSettings.Image")));
            this.MenuSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(124, 45);
            this.MenuSettings.Text = "Настройка";
            // 
            // таблицаВесовToolStripMenuItem
            // 
            this.таблицаВесовToolStripMenuItem.Name = "таблицаВесовToolStripMenuItem";
            this.таблицаВесовToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.таблицаВесовToolStripMenuItem.Text = "Таблица весов";
            this.таблицаВесовToolStripMenuItem.Click += new System.EventHandler(this.BtnWeighingMachins_Click);
            // 
            // номераТоваровToolStripMenuItem
            // 
            this.номераТоваровToolStripMenuItem.Name = "номераТоваровToolStripMenuItem";
            this.номераТоваровToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.номераТоваровToolStripMenuItem.Text = "Номера товаров";
            this.номераТоваровToolStripMenuItem.Click += new System.EventHandler(this.номераТоваровToolStripMenuItem_Click);
            // 
            // категорииТоваровToolStripMenuItem
            // 
            this.категорииТоваровToolStripMenuItem.Name = "категорииТоваровToolStripMenuItem";
            this.категорииТоваровToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.категорииТоваровToolStripMenuItem.Text = "Категории товаров";
            this.категорииТоваровToolStripMenuItem.Click += new System.EventHandler(this.категорииТоваровToolStripMenuItem_Click);
            // 
            // библиотекаКартинокToolStripMenuItem
            // 
            this.библиотекаКартинокToolStripMenuItem.Name = "библиотекаКартинокToolStripMenuItem";
            this.библиотекаКартинокToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.библиотекаКартинокToolStripMenuItem.Text = "Библиотека картинок";
            this.библиотекаКартинокToolStripMenuItem.Click += new System.EventHandler(this.BtnPictureDirectory_Click);
            // 
            // CbxLang
            // 
            this.CbxLang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CbxLang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbxLang.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxLang.Name = "CbxLang";
            this.CbxLang.Size = new System.Drawing.Size(170, 48);
            this.CbxLang.SelectedIndexChanged += new System.EventHandler(this.CbxLang_SelectedIndexChanged);
            // 
            // MenuDescription
            // 
            this.MenuDescription.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuDescription.Image = ((System.Drawing.Image)(resources.GetObject("MenuDescription.Image")));
            this.MenuDescription.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuDescription.Name = "MenuDescription";
            this.MenuDescription.Size = new System.Drawing.Size(110, 45);
            this.MenuDescription.Text = "Описание";
            this.MenuDescription.Click += new System.EventHandler(this.MenuDescription_Click);
            // 
            // CBoxCode
            // 
            this.CBoxCode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CBoxCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBoxCode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBoxCode.Name = "CBoxCode";
            this.CBoxCode.Size = new System.Drawing.Size(380, 48);
            this.CBoxCode.SelectedIndexChanged += new System.EventHandler(this.CBoxCode_SelectedIndexChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(5, 143);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1038, 423);
            this.dataGrid.TabIndex = 5;
            this.dataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentDoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 666);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BtnProducts);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnUnloadToWeighing);
            this.Controls.Add(this.BtnSaveToUsb);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormMain";
            this.Text = "Редактор клавиатуры весов";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProducts;
        private UI.Controls.CustomDataGrid dataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ChkBoxShowProducts;
        private System.Windows.Forms.ComboBox CBoxFields;
        private System.Windows.Forms.TextBox TboxFilter;
        private System.Windows.Forms.Label LbField;
        private System.Windows.Forms.Label LbFindProduct;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbTitleMain;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.Button BtnSaveToUsb;
        private System.Windows.Forms.Button BtnUnloadToWeighing;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton MenuFile;
        private System.Windows.Forms.ToolStripDropDownButton MenuSettings;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеИзВесовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеСUSBFlashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПроектВПКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьПроектИзПКToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox CbxLang;
        private System.Windows.Forms.ToolStripButton MenuDescription;
        private System.Windows.Forms.ToolStripMenuItem таблицаВесовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номераТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem библиотекаКартинокToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox CBoxCode;
    }
}

