namespace XMLToSQL
{
    partial class loginForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxServer = new System.Windows.Forms.TextBox();
            this.txtBoxPort = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblTestResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(169, 281);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 33);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(292, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.Blue;
            this.lblLogin.Location = new System.Drawing.Point(12, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(200, 32);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = "MySQL Login:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServer.ForeColor = System.Drawing.Color.Blue;
            this.lblServer.Location = new System.Drawing.Point(12, 85);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(136, 20);
            this.lblServer.TabIndex = 12;
            this.lblServer.Text = "Server/Server Name:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPort.ForeColor = System.Drawing.Color.Blue;
            this.lblPort.Location = new System.Drawing.Point(111, 134);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 20);
            this.lblPort.TabIndex = 15;
            this.lblPort.Text = "Port:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Blue;
            this.lblUsername.Location = new System.Drawing.Point(74, 183);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 20);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblPassword.Location = new System.Drawing.Point(76, 232);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 20);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password:";
            // 
            // txtBoxServer
            // 
            this.txtBoxServer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxServer.Location = new System.Drawing.Point(169, 82);
            this.txtBoxServer.Name = "txtBoxServer";
            this.txtBoxServer.Size = new System.Drawing.Size(244, 26);
            this.txtBoxServer.TabIndex = 0;
            this.txtBoxServer.TextChanged += new System.EventHandler(this.txtBoxServer_TextChanged);
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPort.Location = new System.Drawing.Point(169, 131);
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.Size = new System.Drawing.Size(100, 26);
            this.txtBoxPort.TabIndex = 1;
            this.txtBoxPort.TextChanged += new System.EventHandler(this.txtBoxPort_TextChanged);
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUsername.Location = new System.Drawing.Point(169, 180);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(244, 26);
            this.txtBoxUsername.TabIndex = 2;
            this.txtBoxUsername.TextChanged += new System.EventHandler(this.txtBoxUsername_TextChanged);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPassword.Location = new System.Drawing.Point(169, 229);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(244, 26);
            this.txtBoxPassword.TabIndex = 3;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // lblTestResponse
            // 
            this.lblTestResponse.AutoSize = true;
            this.lblTestResponse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTestResponse.Location = new System.Drawing.Point(28, 354);
            this.lblTestResponse.Name = "lblTestResponse";
            this.lblTestResponse.Size = new System.Drawing.Size(0, 18);
            this.lblTestResponse.TabIndex = 16;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 387);
            this.Controls.Add(this.lblTestResponse);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxServer);
            this.Controls.Add(this.txtBoxPort);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblServer;        
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;

        private System.Windows.Forms.TextBox txtBoxServer;
        private System.Windows.Forms.TextBox txtBoxPort;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblTestResponse;
    }
}