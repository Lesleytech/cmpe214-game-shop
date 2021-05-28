
namespace GameShop
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBoxRegPassword = new System.Windows.Forms.TextBox();
            this.txtBoxRegUsername = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRegEmail = new System.Windows.Forms.TextBox();
            this.errorProviderRegisterForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGotoLogin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegisterForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegister.Location = new System.Drawing.Point(33, 417);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(307, 38);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(32, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 41);
            this.label2.TabIndex = 14;
            this.label2.Text = "Register";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(33, 373);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 5);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(33, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 5);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(33, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(33, 91);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(104, 28);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // txtBoxRegPassword
            // 
            this.txtBoxRegPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtBoxRegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxRegPassword.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtBoxRegPassword.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtBoxRegPassword.Location = new System.Drawing.Point(33, 343);
            this.txtBoxRegPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxRegPassword.Name = "txtBoxRegPassword";
            this.txtBoxRegPassword.PasswordChar = '*';
            this.txtBoxRegPassword.Size = new System.Drawing.Size(310, 27);
            this.txtBoxRegPassword.TabIndex = 9;
            // 
            // txtBoxRegUsername
            // 
            this.txtBoxRegUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtBoxRegUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxRegUsername.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtBoxRegUsername.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtBoxRegUsername.Location = new System.Drawing.Point(33, 127);
            this.txtBoxRegUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxRegUsername.Name = "txtBoxRegUsername";
            this.txtBoxRegUsername.Size = new System.Drawing.Size(310, 27);
            this.txtBoxRegUsername.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(33, 264);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 5);
            this.panel3.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(33, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // txtBoxRegEmail
            // 
            this.txtBoxRegEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtBoxRegEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxRegEmail.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtBoxRegEmail.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtBoxRegEmail.Location = new System.Drawing.Point(33, 233);
            this.txtBoxRegEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxRegEmail.Name = "txtBoxRegEmail";
            this.txtBoxRegEmail.Size = new System.Drawing.Size(310, 27);
            this.txtBoxRegEmail.TabIndex = 16;
            // 
            // errorProviderRegisterForm
            // 
            this.errorProviderRegisterForm.ContainerControl = this;
            // 
            // btnGotoLogin
            // 
            this.btnGotoLogin.AutoSize = true;
            this.btnGotoLogin.LinkColor = System.Drawing.Color.White;
            this.btnGotoLogin.Location = new System.Drawing.Point(31, 474);
            this.btnGotoLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnGotoLogin.Name = "btnGotoLogin";
            this.btnGotoLogin.Size = new System.Drawing.Size(145, 13);
            this.btnGotoLogin.TabIndex = 19;
            this.btnGotoLogin.TabStop = true;
            this.btnGotoLogin.Text = "Already registered? login now";
            this.btnGotoLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnGotoLogin_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(401, 550);
            this.Controls.Add(this.btnGotoLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxRegEmail);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtBoxRegPassword);
            this.Controls.Add(this.txtBoxRegUsername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Yourself";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegisterForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtBoxRegPassword;
        private System.Windows.Forms.TextBox txtBoxRegUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxRegEmail;
        private System.Windows.Forms.ErrorProvider errorProviderRegisterForm;
        private System.Windows.Forms.LinkLabel btnGotoLogin;
    }
}