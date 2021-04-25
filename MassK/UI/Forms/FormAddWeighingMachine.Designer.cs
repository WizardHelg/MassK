
namespace MassK
{
    partial class FormAddWeighingMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddWeighingMachine));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbTypeConnection = new System.Windows.Forms.Label();
            this.lbIpAddress = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbWeighingMachineName = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(391, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lbTypeConnection
            // 
            this.lbTypeConnection.AutoSize = true;
            this.lbTypeConnection.Location = new System.Drawing.Point(12, 17);
            this.lbTypeConnection.Name = "lbTypeConnection";
            this.lbTypeConnection.Size = new System.Drawing.Size(89, 13);
            this.lbTypeConnection.TabIndex = 2;
            this.lbTypeConnection.Text = "Тип соединения";
            // 
            // lbIpAddress
            // 
            this.lbIpAddress.AutoSize = true;
            this.lbIpAddress.Location = new System.Drawing.Point(188, 17);
            this.lbIpAddress.Name = "lbIpAddress";
            this.lbIpAddress.Size = new System.Drawing.Size(50, 13);
            this.lbIpAddress.TabIndex = 2;
            this.lbIpAddress.Text = "IP-адрес";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(393, 17);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(32, 13);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Порт";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(12, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(535, 20);
            this.textBox3.TabIndex = 1;
            // 
            // lbWeighingMachineName
            // 
            this.lbWeighingMachineName.AutoSize = true;
            this.lbWeighingMachineName.Location = new System.Drawing.Point(9, 80);
            this.lbWeighingMachineName.Name = "lbWeighingMachineName";
            this.lbWeighingMachineName.Size = new System.Drawing.Size(176, 13);
            this.lbWeighingMachineName.TabIndex = 2;
            this.lbWeighingMachineName.Text = "Название весов (необязательно)";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(495, 144);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Отменить";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(410, 144);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnHelp.Location = new System.Drawing.Point(13, 144);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(75, 23);
            this.BtnHelp.TabIndex = 3;
            this.BtnHelp.Text = "Справка";
            this.BtnHelp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lbPort);
            this.panel1.Controls.Add(this.lbTypeConnection);
            this.panel1.Controls.Add(this.lbIpAddress);
            this.panel1.Controls.Add(this.lbWeighingMachineName);
            this.panel1.Location = new System.Drawing.Point(6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 129);
            this.panel1.TabIndex = 4;
            // 
            // FormAddWeighingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 173);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddWeighingMachine";
            this.Text = "Добавить весы";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbTypeConnection;
        private System.Windows.Forms.Label lbIpAddress;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbWeighingMachineName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Panel panel1;
    }
}