
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
            this.CBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.TBoxPort = new System.Windows.Forms.TextBox();
            this.lbTypeConnection = new System.Windows.Forms.Label();
            this.lbIpAddress = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.TBoxName = new System.Windows.Forms.TextBox();
            this.lbWeighingMachineName = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBoxIp = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBoxConnectionType
            // 
            this.CBoxConnectionType.Font = new System.Drawing.Font("Verdana", 12F);
            this.CBoxConnectionType.FormattingEnabled = true;
            this.CBoxConnectionType.Location = new System.Drawing.Point(15, 38);
            this.CBoxConnectionType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CBoxConnectionType.Name = "CBoxConnectionType";
            this.CBoxConnectionType.Size = new System.Drawing.Size(160, 26);
            this.CBoxConnectionType.TabIndex = 0;
            // 
            // TBoxPort
            // 
            this.TBoxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxPort.Font = new System.Drawing.Font("Verdana", 12F);
            this.TBoxPort.Location = new System.Drawing.Point(482, 37);
            this.TBoxPort.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBoxPort.Name = "TBoxPort";
            this.TBoxPort.Size = new System.Drawing.Size(133, 27);
            this.TBoxPort.TabIndex = 2;
            // 
            // lbTypeConnection
            // 
            this.lbTypeConnection.AutoSize = true;
            this.lbTypeConnection.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbTypeConnection.Location = new System.Drawing.Point(20, 14);
            this.lbTypeConnection.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTypeConnection.Name = "lbTypeConnection";
            this.lbTypeConnection.Size = new System.Drawing.Size(143, 18);
            this.lbTypeConnection.TabIndex = 2;
            this.lbTypeConnection.Text = "Тип соединения";
            // 
            // lbIpAddress
            // 
            this.lbIpAddress.AutoSize = true;
            this.lbIpAddress.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbIpAddress.Location = new System.Drawing.Point(193, 13);
            this.lbIpAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbIpAddress.Name = "lbIpAddress";
            this.lbIpAddress.Size = new System.Drawing.Size(81, 18);
            this.lbIpAddress.TabIndex = 2;
            this.lbIpAddress.Text = "IP-адрес";
            // 
            // lbPort
            // 
            this.lbPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbPort.Location = new System.Drawing.Point(490, 13);
            this.lbPort.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(47, 18);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Порт";
            // 
            // TBoxName
            // 
            this.TBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxName.Font = new System.Drawing.Font("Verdana", 12F);
            this.TBoxName.Location = new System.Drawing.Point(15, 117);
            this.TBoxName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(601, 27);
            this.TBoxName.TabIndex = 3;
            // 
            // lbWeighingMachineName
            // 
            this.lbWeighingMachineName.AutoSize = true;
            this.lbWeighingMachineName.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbWeighingMachineName.Location = new System.Drawing.Point(20, 90);
            this.lbWeighingMachineName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbWeighingMachineName.Name = "lbWeighingMachineName";
            this.lbWeighingMachineName.Size = new System.Drawing.Size(289, 18);
            this.lbWeighingMachineName.TabIndex = 2;
            this.lbWeighingMachineName.Text = "Название весов (необязательно)";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnCancel.Location = new System.Drawing.Point(503, 184);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(140, 34);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Отменить";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnSave.Location = new System.Drawing.Point(339, 184);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(154, 34);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnHelp.Font = new System.Drawing.Font("Verdana", 12F);
            this.BtnHelp.Location = new System.Drawing.Point(10, 184);
            this.BtnHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(124, 34);
            this.BtnHelp.TabIndex = 6;
            this.BtnHelp.Text = "Справка";
            this.BtnHelp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.TBoxIp);
            this.panel1.Controls.Add(this.TBoxName);
            this.panel1.Controls.Add(this.CBoxConnectionType);
            this.panel1.Controls.Add(this.TBoxPort);
            this.panel1.Controls.Add(this.lbPort);
            this.panel1.Controls.Add(this.lbTypeConnection);
            this.panel1.Controls.Add(this.lbIpAddress);
            this.panel1.Controls.Add(this.lbWeighingMachineName);
            this.panel1.Font = new System.Drawing.Font("Verdana", 12F);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 164);
            this.panel1.TabIndex = 4;
            // 
            // TBoxIp
            // 
            this.TBoxIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxIp.Font = new System.Drawing.Font("Verdana", 12F);
            this.TBoxIp.Location = new System.Drawing.Point(185, 37);
            this.TBoxIp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBoxIp.Name = "TBoxIp";
            this.TBoxIp.Size = new System.Drawing.Size(285, 27);
            this.TBoxIp.TabIndex = 4;
            // 
            // FormAddWeighingMachine
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(653, 226);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormAddWeighingMachine";
            this.Text = "Добавить весы";
            this.Load += new System.EventHandler(this.FormAddWeighingMachine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxConnectionType;
        private System.Windows.Forms.TextBox TBoxPort;
        private System.Windows.Forms.Label lbTypeConnection;
        private System.Windows.Forms.Label lbIpAddress;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox TBoxName;
        private System.Windows.Forms.Label lbWeighingMachineName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox TBoxIp;
    }
}