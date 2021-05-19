
namespace MassK
{
    partial class FormWeighingMachins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWeighingMachins));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ChkBox = new System.Windows.Forms.CheckBox();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnCheckConnection = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.dataGrid = new MassK.UI.Controls.CustomDataGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnHelp);
            this.panel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 58);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Весы проекта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHelp.BackColor = System.Drawing.Color.White;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHelp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnHelp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnHelp.Location = new System.Drawing.Point(609, 12);
            this.BtnHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(118, 32);
            this.BtnHelp.TabIndex = 0;
            this.BtnHelp.Text = "Справка";
            this.BtnHelp.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(3, 574);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 58);
            this.panel2.TabIndex = 16;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Location = new System.Drawing.Point(597, 11);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(137, 37);
            this.BtnSave.TabIndex = 20;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(169, 71);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(134, 37);
            this.BtnAdd.TabIndex = 18;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ChkBox
            // 
            this.ChkBox.AutoSize = true;
            this.ChkBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChkBox.Location = new System.Drawing.Point(22, 91);
            this.ChkBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ChkBox.Name = "ChkBox";
            this.ChkBox.Size = new System.Drawing.Size(15, 14);
            this.ChkBox.TabIndex = 19;
            this.ChkBox.UseVisualStyleBackColor = true;
            this.ChkBox.CheckedChanged += new System.EventHandler(this.ChkBox_CheckedChanged);
            // 
            // BtnFind
            // 
            this.BtnFind.BackColor = System.Drawing.Color.Transparent;
            this.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFind.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFind.ForeColor = System.Drawing.Color.Black;
            this.BtnFind.Location = new System.Drawing.Point(56, 71);
            this.BtnFind.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(103, 37);
            this.BtnFind.TabIndex = 18;
            this.BtnFind.Text = "Найти";
            this.BtnFind.UseVisualStyleBackColor = false;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnCheckConnection
            // 
            this.BtnCheckConnection.BackColor = System.Drawing.Color.Transparent;
            this.BtnCheckConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckConnection.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCheckConnection.ForeColor = System.Drawing.Color.Black;
            this.BtnCheckConnection.Location = new System.Drawing.Point(441, 71);
            this.BtnCheckConnection.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnCheckConnection.Name = "BtnCheckConnection";
            this.BtnCheckConnection.Size = new System.Drawing.Size(194, 37);
            this.BtnCheckConnection.TabIndex = 18;
            this.BtnCheckConnection.Text = "Проверить связь";
            this.BtnCheckConnection.UseVisualStyleBackColor = false;
         
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(313, 71);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(118, 37);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(3, 116);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(750, 456);
            this.dataGrid.TabIndex = 15;
            // 
            // FormWeighingMachins
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 632);
            this.Controls.Add(this.ChkBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCheckConnection);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnAdd);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormWeighingMachins";
            this.Text = "Таблица весов";
            this.Load += new System.EventHandler(this.FormWeighingMachins_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Panel panel2;
        private UI.Controls.CustomDataGrid dataGrid;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.CheckBox ChkBox;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnCheckConnection;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
    }
}