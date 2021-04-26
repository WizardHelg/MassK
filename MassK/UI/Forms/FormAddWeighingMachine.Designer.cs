
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
            this.CBoxConnectionType.FormattingEnabled = true;
            this.CBoxConnectionType.Location = new System.Drawing.Point(9, 35);
            this.CBoxConnectionType.Name = "CBoxConnectionType";
            this.CBoxConnectionType.Size = new System.Drawing.Size(159, 21);
            this.CBoxConnectionType.TabIndex = 0;
            // 
            // TBoxPort
            // 
            this.TBoxPort.Location = new System.Drawing.Point(391, 36);
            this.TBoxPort.Name = "TBoxPort";
            this.TBoxPort.Size = new System.Drawing.Size(143, 20);
            this.TBoxPort.TabIndex = 2;
            // 
            // lbTypeConnection
            // 
            this.lbTypeConnection.AutoSize = true;
            this.lbTypeConnection.Location = new System.Drawing.Point(12, 15);
            this.lbTypeConnection.Name = "lbTypeConnection";
            this.lbTypeConnection.Size = new System.Drawing.Size(89, 13);
            this.lbTypeConnection.TabIndex = 2;
            this.lbTypeConnection.Text = "Тип соединения";
            // 
            // lbIpAddress
            // 
            this.lbIpAddress.AutoSize = true;
            this.lbIpAddress.Location = new System.Drawing.Point(188, 15);
            this.lbIpAddress.Name = "lbIpAddress";
            this.lbIpAddress.Size = new System.Drawing.Size(50, 13);
            this.lbIpAddress.TabIndex = 2;
            this.lbIpAddress.Text = "IP-адрес";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(393, 15);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(32, 13);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Порт";
            // 
            // TBoxName
            // 
            this.TBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBoxName.Location = new System.Drawing.Point(9, 86);
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(525, 20);
            this.TBoxName.TabIndex = 3;
            // 
            // lbWeighingMachineName
            // 
            this.lbWeighingMachineName.AutoSize = true;
            this.lbWeighingMachineName.Location = new System.Drawing.Point(12, 67);
            this.lbWeighingMachineName.Name = "lbWeighingMachineName";
            this.lbWeighingMachineName.Size = new System.Drawing.Size(176, 13);
            this.lbWeighingMachineName.TabIndex = 2;
            this.lbWeighingMachineName.Text = "Название весов (необязательно)";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(483, 136);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Отменить";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(398, 136);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnHelp.Location = new System.Drawing.Point(13, 136);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(75, 23);
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
            this.panel1.Location = new System.Drawing.Point(6, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 121);
            this.panel1.TabIndex = 4;
            // 
            // TBoxIp
            // 
            this.TBoxIp.Location = new System.Drawing.Point(188, 36);
            this.TBoxIp.Name = "TBoxIp";
            this.TBoxIp.Size = new System.Drawing.Size(180, 20);
            this.TBoxIp.TabIndex = 4;
            // 
            // FormAddWeighingMachine
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(564, 165);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 200);
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