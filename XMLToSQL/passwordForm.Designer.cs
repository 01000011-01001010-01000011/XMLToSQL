namespace XMLToSQL
{
    partial class passwordForm
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.Blue;
            this.lblLogin.Location = new System.Drawing.Point(12, 20);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(200, 32);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "MySQL Login:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Blue;
            this.lblUsername.Location = new System.Drawing.Point(18, 79);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 20);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblPassword.Location = new System.Drawing.Point(20, 128);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 20);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password:";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUsername.Location = new System.Drawing.Point(113, 76);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(244, 26);
            this.txtBoxUsername.TabIndex = 16;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPassword.Location = new System.Drawing.Point(113, 125);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(244, 26);
            this.txtBoxPassword.TabIndex = 17;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(113, 177);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 33);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(236, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 33);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // passwordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 254);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLogin);
            this.Name = "passwordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "passwordFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}