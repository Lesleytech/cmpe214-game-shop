using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameShop.Validation;

namespace GameShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGotoRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm frmRegister = new RegisterForm();

            this.Close();
            frmRegister.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = FormValidator.validateLoginForm(txtBoxLoginIdentifier, txtBoxLoginPassword, errProviderLoginForm);

            if (!isValid) return;

            // Continue with login
        }
    }
}
