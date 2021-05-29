using System;
using System.Windows.Forms;
using GameShop.Validation;
using GameShop.Authentication;
using GameShop.Users;

namespace GameShop
{
    public partial class RegisterForm : Form
    {
        ProductForm _parent;
        public RegisterForm(ProductForm parent)
        {
            InitializeComponent();
            this._parent = parent;
        }

        private void btnGotoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm frmLogin = new LoginForm(this._parent); 

            this.Close();
            frmLogin.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // ValidateRegForm checks for empty fields, already-existing accounts, and restricted usernames (admin)
            bool isValid = FormValidator.ValidateRegForm(txtBoxRegUsername, txtBoxRegEmail, txtBoxRegPassword, errorProviderRegisterForm);

            if(!isValid) return;

            // Continue with registration
            try
            {
                User user = new User
                {
                    username = txtBoxRegUsername.Text,
                    email = txtBoxRegEmail.Text,
                    password = txtBoxRegPassword.Text,
                };

                Auth.Register(user);

                MessageBox.Show("Registration completed successfully.", "User registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGotoLogin_LinkClicked(null, null);
            }
            catch (Exception)
            {

            }
        }
    }
}
