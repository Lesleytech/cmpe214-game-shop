using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShop
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            LoginForm loginFrm = new LoginForm();
            //loginFrm.Show();

            RegisterForm regForm = new RegisterForm();

            regForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseFrm = new PurchaseForm();
            purchaseFrm.Show();
        }
    }
}
