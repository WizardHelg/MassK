
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LbField = new System.Windows.Forms.Label();
            this.LbFindProduct = new System.Windows.Forms.Label();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbTitleMain = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.ButtonUnloadToWeighing = new System.Windows.Forms.Button();
            this.customDataGrid = new MassK.UI.Controls.CustomDataGrid();
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
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnProducts
            // 
            this.BtnProducts.BackColor = System.Drawing.Color.Transparent;
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnProducts.ForeColor = System.Drawing.Color.Black;
            this.BtnProducts.Location = new System.Drawing.Point(14, 83);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(102, 30);
            this.BtnProducts.TabIndex = 6;
            this.BtnProducts.Text = "Товары";
            this.BtnProducts.UseVisualStyleBackColor = false;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.ChkBoxShowProducts);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.LbField);
            this.panel2.Controls.Add(this.LbFindProduct);
            this.panel2.Location = new System.Drawing.Point(2, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 42);
            this.panel2.TabIndex = 11;
            // 
            // ChkBoxShowProducts
            // 
            this.ChkBoxShowProducts.AutoSize = true;
            this.ChkBoxShowProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChkBoxShowProducts.ForeColor = System.Drawing.Color.White;
            this.ChkBoxShowProducts.Location = new System.Drawing.Point(12, 11);
            this.ChkBoxShowProducts.Name = "ChkBoxShowProducts";
            this.ChkBoxShowProducts.Size = new System.Drawing.Size(260, 20);
            this.ChkBoxShowProducts.TabIndex = 4;
            this.ChkBoxShowProducts.Text = "Показать товары без картинок";
            this.ChkBoxShowProducts.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(863, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(610, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LbField
            // 
            this.LbField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LbField.AutoSize = true;
            this.LbField.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbField.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbField.Location = new System.Drawing.Point(801, 13);
            this.LbField.Name = "LbField";
            this.LbField.Size = new System.Drawing.Size(57, 16);
            this.LbField.TabIndex = 1;
            this.LbField.Text = "в поле";
            this.LbField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LbFindProduct
            // 
            this.LbFindProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LbFindProduct.AutoSize = true;
            this.LbFindProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbFindProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbFindProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbFindProduct.Location = new System.Drawing.Point(500, 13);
            this.LbFindProduct.Name = "LbFindProduct";
            this.LbFindProduct.Size = new System.Drawing.Size(102, 16);
            this.LbFindProduct.TabIndex = 1;
            this.LbFindProduct.Text = "Найти товар";
            this.LbFindProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHelp.BackColor = System.Drawing.Color.White;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnHelp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnHelp.Location = new System.Drawing.Point(912, 10);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(93, 23);
            this.BtnHelp.TabIndex = 0;
            this.BtnHelp.Text = "Справка";
            this.BtnHelp.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.LbTitleMain);
            this.panel1.Controls.Add(this.BtnHelp);
            this.panel1.Location = new System.Drawing.Point(2, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 42);
            this.panel1.TabIndex = 10;
            // 
            // LbTitleMain
            // 
            this.LbTitleMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTitleMain.AutoEllipsis = true;
            this.LbTitleMain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbTitleMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbTitleMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbTitleMain.Location = new System.Drawing.Point(26, 9);
            this.LbTitleMain.Name = "LbTitleMain";
            this.LbTitleMain.Size = new System.Drawing.Size(876, 23);
            this.LbTitleMain.TabIndex = 1;
            this.LbTitleMain.Text = "Редактор клавиатуры весов самообслуживания";
            this.LbTitleMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button4.Location = new System.Drawing.Point(818, 580);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 29);
            this.button4.TabIndex = 9;
            this.button4.Text = "Записать на USB";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ButtonUnloadToWeighing
            // 
            this.ButtonUnloadToWeighing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUnloadToWeighing.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUnloadToWeighing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUnloadToWeighing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUnloadToWeighing.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ButtonUnloadToWeighing.Location = new System.Drawing.Point(605, 580);
            this.ButtonUnloadToWeighing.Name = "ButtonUnloadToWeighing";
            this.ButtonUnloadToWeighing.Size = new System.Drawing.Size(201, 29);
            this.ButtonUnloadToWeighing.TabIndex = 9;
            this.ButtonUnloadToWeighing.Text = "Выгрузить в весы";
            this.ButtonUnloadToWeighing.UseVisualStyleBackColor = false;
            // 
            // customDataGrid
            // 
            this.customDataGrid.AllowUserToDeleteRows = false;
            this.customDataGrid.AllowUserToResizeRows = false;
            this.customDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGrid.Location = new System.Drawing.Point(3, 119);
            this.customDataGrid.Name = "customDataGrid";
            this.customDataGrid.Size = new System.Drawing.Size(1024, 414);
            this.customDataGrid.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuSettings,
            this.CbxLang,
            this.MenuDescription});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 35);
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
            this.MenuFile.Image = ((System.Drawing.Image)(resources.GetObject("MenuFile.Image")));
            this.MenuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(62, 32);
            this.MenuFile.Text = "Файл";
            // 
            // загрузитьДанныеИзВесовToolStripMenuItem
            // 
            this.загрузитьДанныеИзВесовToolStripMenuItem.Name = "загрузитьДанныеИзВесовToolStripMenuItem";
            this.загрузитьДанныеИзВесовToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.загрузитьДанныеИзВесовToolStripMenuItem.Text = "Загрузить данные из весов ";
            // 
            // загрузитьДанныеСUSBFlashToolStripMenuItem
            // 
            this.загрузитьДанныеСUSBFlashToolStripMenuItem.Name = "загрузитьДанныеСUSBFlashToolStripMenuItem";
            this.загрузитьДанныеСUSBFlashToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.загрузитьДанныеСUSBFlashToolStripMenuItem.Text = "Загрузить данные с USB-Flash";
            // 
            // сохранитьПроектВПКToolStripMenuItem
            // 
            this.сохранитьПроектВПКToolStripMenuItem.Name = "сохранитьПроектВПКToolStripMenuItem";
            this.сохранитьПроектВПКToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.сохранитьПроектВПКToolStripMenuItem.Text = "Сохранить проект в ПК";
            // 
            // загрузитьПроектИзПКToolStripMenuItem
            // 
            this.загрузитьПроектИзПКToolStripMenuItem.Name = "загрузитьПроектИзПКToolStripMenuItem";
            this.загрузитьПроектИзПКToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.загрузитьПроектИзПКToolStripMenuItem.Text = "Загрузить проект из ПК";
            this.загрузитьПроектИзПКToolStripMenuItem.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // MenuSettings
            // 
            this.MenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаВесовToolStripMenuItem,
            this.номераТоваровToolStripMenuItem,
            this.категорииТоваровToolStripMenuItem,
            this.библиотекаКартинокToolStripMenuItem});
            this.MenuSettings.Image = ((System.Drawing.Image)(resources.GetObject("MenuSettings.Image")));
            this.MenuSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(90, 32);
            this.MenuSettings.Text = "Настройка";
            // 
            // таблицаВесовToolStripMenuItem
            // 
            this.таблицаВесовToolStripMenuItem.Name = "таблицаВесовToolStripMenuItem";
            this.таблицаВесовToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.таблицаВесовToolStripMenuItem.Text = "Таблица весов";
            this.таблицаВесовToolStripMenuItem.Click += new System.EventHandler(this.BtnWeighingMachins_Click);
            // 
            // номераТоваровToolStripMenuItem
            // 
            this.номераТоваровToolStripMenuItem.Name = "номераТоваровToolStripMenuItem";
            this.номераТоваровToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.номераТоваровToolStripMenuItem.Text = "Номера товаров";
            this.номераТоваровToolStripMenuItem.Click += new System.EventHandler(this.номераТоваровToolStripMenuItem_Click);
            // 
            // категорииТоваровToolStripMenuItem
            // 
            this.категорииТоваровToolStripMenuItem.Name = "категорииТоваровToolStripMenuItem";
            this.категорииТоваровToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.категорииТоваровToolStripMenuItem.Text = "Категории товаров";
            this.категорииТоваровToolStripMenuItem.Click += new System.EventHandler(this.категорииТоваровToolStripMenuItem_Click);
            // 
            // библиотекаКартинокToolStripMenuItem
            // 
            this.библиотекаКартинокToolStripMenuItem.Name = "библиотекаКартинокToolStripMenuItem";
            this.библиотекаКартинокToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.библиотекаКартинокToolStripMenuItem.Text = "Библиотека картинок";
            this.библиотекаКартинокToolStripMenuItem.Click += new System.EventHandler(this.BtnPictureDirectory_Click);
            // 
            // CbxLang
            // 
            this.CbxLang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CbxLang.Name = "CbxLang";
            this.CbxLang.Size = new System.Drawing.Size(121, 35);
            this.CbxLang.SelectedIndexChanged += new System.EventHandler(this.CbxLang_SelectedIndexChanged);
            // 
            // MenuDescription
            // 
            this.MenuDescription.Image = ((System.Drawing.Image)(resources.GetObject("MenuDescription.Image")));
            this.MenuDescription.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuDescription.Name = "MenuDescription";
            this.MenuDescription.Size = new System.Drawing.Size(76, 32);
            this.MenuDescription.Text = "Описание";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 612);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BtnProducts);
            this.Controls.Add(this.customDataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonUnloadToWeighing);
            this.Controls.Add(this.button4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(898, 590);
            this.Name = "FormMain";
            this.Text = "Редактор клавиатуры весов";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProducts;
        private UI.Controls.CustomDataGrid customDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ChkBoxShowProducts;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LbField;
        private System.Windows.Forms.Label LbFindProduct;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbTitleMain;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ButtonUnloadToWeighing;
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
    }
}

