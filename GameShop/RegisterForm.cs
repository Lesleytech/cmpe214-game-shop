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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnGotoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm frmLogin = new LoginForm();

            this.Close();
            frmLogin.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool isValid = FormValidator.validateRegForm(txtBoxRegUsername, txtBoxRegEmail, txtBoxRegPassword, errorProviderRegisterForm);

            if(!isValid) return;

            // Continue with registration
        }
    }
}
