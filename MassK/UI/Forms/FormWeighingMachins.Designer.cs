
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
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customDataGrid = new MassK.UI.Controls.CustomDataGrid();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ChkBox = new System.Windows.Forms.CheckBox();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnCheckConnection = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 42);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Весы проекта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(503, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Справка";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(2, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 42);
            this.panel2.TabIndex = 16;
            // 
            // customDataGrid
            // 
            this.customDataGrid.AllowUserToDeleteRows = false;
            this.customDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGrid.Location = new System.Drawing.Point(4, 92);
            this.customDataGrid.Name = "customDataGrid";
            this.customDataGrid.Size = new System.Drawing.Size(607, 249);
            this.customDataGrid.TabIndex = 15;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(145, 54);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(90, 30);
            this.BtnAdd.TabIndex = 18;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // ChkBox
            // 
            this.ChkBox.AutoSize = true;
            this.ChkBox.Location = new System.Drawing.Point(13, 71);
            this.ChkBox.Name = "ChkBox";
            this.ChkBox.Size = new System.Drawing.Size(15, 14);
            this.ChkBox.TabIndex = 19;
            this.ChkBox.UseVisualStyleBackColor = true;
            // 
            // BtnFind
            // 
            this.BtnFind.BackColor = System.Drawing.Color.Transparent;
            this.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFind.ForeColor = System.Drawing.Color.Black;
            this.BtnFind.Location = new System.Drawing.Point(49, 54);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(90, 30);
            this.BtnFind.TabIndex = 18;
            this.BtnFind.Text = "Найти";
            this.BtnFind.UseVisualStyleBackColor = false;
            // 
            // BtnCheckConnection
            // 
            this.BtnCheckConnection.BackColor = System.Drawing.Color.Transparent;
            this.BtnCheckConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCheckConnection.ForeColor = System.Drawing.Color.Black;
            this.BtnCheckConnection.Location = new System.Drawing.Point(337, 54);
            this.BtnCheckConnection.Name = "BtnCheckConnection";
            this.BtnCheckConnection.Size = new System.Drawing.Size(145, 30);
            this.BtnCheckConnection.TabIndex = 18;
            this.BtnCheckConnection.Text = "Проверить связь";
            this.BtnCheckConnection.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(241, 54);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(90, 30);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // FormWeighingMachins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 385);
            this.Controls.Add(this.ChkBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.customDataGrid);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCheckConnection);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(630, 420);
            this.Name = "FormWeighingMachins";
            this.Text = "Таблица весов";
            this.Load += new System.EventHandler(this.FormWeighingMachins_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private UI.Controls.CustomDataGrid customDataGrid;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.CheckBox ChkBox;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnCheckConnection;
        private System.Windows.Forms.Button BtnDelete;
    }
}