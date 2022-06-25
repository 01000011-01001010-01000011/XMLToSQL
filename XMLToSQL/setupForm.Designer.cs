namespace XMLToSQL
{
    partial class setupForm
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
            this.lblSetup = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxServer = new System.Windows.Forms.TextBox();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSetup
            // 
            this.lblSetup.AutoSize = true;
            this.lblSetup.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSetup.ForeColor = System.Drawing.Color.Blue;
            this.lblSetup.Location = new System.Drawing.Point(22, 23);
            this.lblSetup.Name = "lblSetup";
            this.lblSetup.Size = new System.Drawing.Size(293, 32);
            this.lblSetup.TabIndex = 22;
            this.lblSetup.Text = "MySQL Server Setup:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServer.ForeColor = System.Drawing.Color.Blue;
            this.lblServer.Location = new System.Drawing.Point(22, 99);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(136, 20);
            this.lblServer.TabIndex = 23;
            this.lblServer.Text = "Server/Server Name:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPort.ForeColor = System.Drawing.Color.Blue;
            this.lblPort.Location = new System.Drawing.Point(121, 148);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 20);
            this.lblPort.TabIndex = 24;
            this.lblPort.Text = "Port:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Blue;
            this.lblUsername.Location = new System.Drawing.Point(84, 197);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 20);
            this.lblUsername.TabIndex = 25;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblPassword.Location = new System.Drawing.Point(86, 246);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 20);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Password:";
            // 
            // txtBoxServer
            // 
            this.txtBoxServer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxServer.Location = new System.Drawing.Point(179, 96);
            this.txtBoxServer.Name = "txtBoxServer";
            this.txtBoxServer.Size = new System.Drawing.Size(244, 26);
            this.txtBoxServer.TabIndex = 16;
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPort.Location = new System.Drawing.Point(179, 145);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(100, 26);
            this.txtBoxPort.TabIndex = 17;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUsername.Location = new System.Drawing.Point(179, 194);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(244, 26);
            this.txtBoxUsername.TabIndex = 18;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPassword.Location = new System.Drawing.Point(179, 243);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(244, 26);
            this.txtBoxPassword.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(179, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 33);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(302, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 33);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // setupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 354);
            this.Controls.Add(this.lblSetup);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxServer);
            this.Controls.Add(this.txtBoxPort);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "setupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL Server Setup";
            this.Load += new System.EventHandler(this.setupFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetup;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxServer;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}