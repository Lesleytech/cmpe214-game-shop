
namespace GameShop
{
    partial class LoginForm
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
            this.txtBoxLoginIdentifier = new System.Windows.Forms.TextBox();
            this.txtBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errProviderLoginForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGotoRegister = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderLoginForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxLoginIdentifier
            // 
            this.txtBoxLoginIdentifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtBoxLoginIdentifier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxLoginIdentifier.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtBoxLoginIdentifier.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtBoxLoginIdentifier.Location = new System.Drawing.Point(62, 349);
            this.txtBoxLoginIdentifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxLoginIdentifier.MaxLength = 128;
            this.txtBoxLoginIdentifier.Name = "txtBoxLoginIdentifier";
            this.txtBoxLoginIdentifier.Size = new System.Drawing.Size(568, 27);
            this.txtBoxLoginIdentifier.TabIndex = 0;
            // 
            // txtBoxLoginPassword
            // 
            this.txtBoxLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtBoxLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxLoginPassword.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtBoxLoginPassword.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtBoxLoginPassword.Location = new System.Drawing.Point(62, 545);
            this.txtBoxLoginPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxLoginPassword.MaxLength = 32;
            this.txtBoxLoginPassword.Name = "txtBoxLoginPassword";
            this.txtBoxLoginPassword.PasswordChar = '*';
            this.txtBoxLoginPassword.Size = new System.Drawing.Size(568, 27);
            this.txtBoxLoginPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(62, 282);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(135, 23);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username/Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(62, 484);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(62, 406);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 9);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(62, 600);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 9);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(59, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(68, 698);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(563, 70);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errProviderLoginForm
            // 
            this.errProviderLoginForm.ContainerControl = this;
            // 
            // btnGotoRegister
            // 
            this.btnGotoRegister.AutoSize = true;
            this.btnGotoRegister.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnGotoRegister.LinkColor = System.Drawing.Color.White;
            this.btnGotoRegister.Location = new System.Drawing.Point(62, 794);
            this.btnGotoRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnGotoRegister.Name = "btnGotoRegister";
            this.btnGotoRegister.Size = new System.Drawing.Size(294, 23);
            this.btnGotoRegister.TabIndex = 8;
            this.btnGotoRegister.TabStop = true;
            this.btnGotoRegister.Text = "Don\'t have an account? Register now";
            this.btnGotoRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnGotoRegister_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(735, 1015);
            this.Controls.Add(this.btnGotoRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtBoxLoginPassword);
            this.Controls.Add(this.txtBoxLoginIdentifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errProviderLoginForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLoginIdentifier;
        private System.Windows.Forms.TextBox txtBoxLoginPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider errProviderLoginForm;
        private System.Windows.Forms.LinkLabel btnGotoRegister;
    }
}