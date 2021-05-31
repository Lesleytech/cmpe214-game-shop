using System;
using System.Windows.Forms;
using GameShop.Validation;
using GameShop.Authentication;
using GameShop.Users;


namespace GameShop
{
    public partial class LoginForm : Form
    {
        ProductForm _parent;
        public LoginForm(ProductForm parent)
        {
            InitializeComponent();
            this._parent = parent;
        }

        private void btnGotoRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm frmRegister = new RegisterForm(this._parent);

            this.Close();
            frmRegister.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // ValidateLoginForm checks for empty fields, non-existing accounts, and wrong passwords
            bool isValid = FormValidator.ValidateLoginForm(txtBoxLoginIdentifier, txtBoxLoginPassword, errProviderLoginForm);

            if (!isValid) return;

            try
            {
                User authUser = Auth.Login(txtBoxLoginIdentifier.Text, txtBoxLoginPassword.Text);

                if(authUser.isAdmin)
                {
                    ListRetailProductForm frm = new ListRetailProductForm();

                    frm.Show();
                    
                    this.Close();
                    this._parent.Close();

                    return;
                }

                this._parent.Text = $"Games - {authUser.username}";
                this._parent.LinkLabelAccount.Text = $"Logout ({authUser.username})";

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem signing you in.", "Authentication error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
