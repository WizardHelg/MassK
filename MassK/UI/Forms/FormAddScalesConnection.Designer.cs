
namespace MassK.UI.Forms
{
    partial class FormAddScalesConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddScalesConnection));
            this.CBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.TBoxPort = new System.Windows.Forms.TextBox();
            this.TypeConnection = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.Label();
            this.PortNumber = new System.Windows.Forms.Label();
            this.TBoxName = new System.Windows.Forms.TextBox();
            this.ScalesName = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonHelp = new System.Windows.Forms.Button();
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
            // TypeConnection
            // 
            this.TypeConnection.AutoSize = true;
            this.TypeConnection.Font = new System.Drawing.Font("Verdana", 12F);
            this.TypeConnection.Location = new System.Drawing.Point(20, 14);
            this.TypeConnection.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TypeConnection.Name = "TypeConnection";
            this.TypeConnection.Size = new System.Drawing.Size(143, 18);
            this.TypeConnection.TabIndex = 2;
            this.TypeConnection.Text = "Тип соединения";
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Font = new System.Drawing.Font("Verdana", 12F);
            this.IP.Location = new System.Drawing.Point(193, 13);
            this.IP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(81, 18);
            this.IP.TabIndex = 2;
            this.IP.Text = "IP-адрес";
            // 
            // PortNumber
            // 
            this.PortNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PortNumber.AutoSize = true;
            this.PortNumber.Font = new System.Drawing.Font("Verdana", 12F);
            this.PortNumber.Location = new System.Drawing.Point(490, 13);
            this.PortNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(47, 18);
            this.PortNumber.TabIndex = 2;
            this.PortNumber.Text = "Порт";
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
            // ScalesName
            // 
            this.ScalesName.AutoSize = true;
            this.ScalesName.Font = new System.Drawing.Font("Verdana", 12F);
            this.ScalesName.Location = new System.Drawing.Point(20, 90);
            this.ScalesName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ScalesName.Name = "ScalesName";
            this.ScalesName.Size = new System.Drawing.Size(289, 18);
            this.ScalesName.TabIndex = 2;
            this.ScalesName.Text = "Название весов (необязательно)";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonCancel.Location = new System.Drawing.Point(503, 184);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(140, 34);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Отменить";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonSave.Location = new System.Drawing.Point(339, 184);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(154, 34);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonHelp.Font = new System.Drawing.Font("Verdana", 12F);
            this.ButtonHelp.Location = new System.Drawing.Point(10, 184);
            this.ButtonHelp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(124, 34);
            this.ButtonHelp.TabIndex = 6;
            this.ButtonHelp.Text = "Справка";
            this.ButtonHelp.UseVisualStyleBackColor = true;
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
            this.panel1.Controls.Add(this.PortNumber);
            this.panel1.Controls.Add(this.TypeConnection);
            this.panel1.Controls.Add(this.IP);
            this.panel1.Controls.Add(this.ScalesName);
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
            // FormAddScalesConnection
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(653, 226);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormAddScalesConnection";
            this.Text = "Добавить весы";
            this.Load += new System.EventHandler(this.FormAddWeighingMachine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxConnectionType;
        private System.Windows.Forms.TextBox TBoxPort;
        private System.Windows.Forms.Label TypeConnection;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label PortNumber;
        private System.Windows.Forms.TextBox TBoxName;
        private System.Windows.Forms.Label ScalesName;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox TBoxIp;
    }
}