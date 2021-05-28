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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void txtBoxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.allowOnlyNumbers(sender, e);
        }

        private void txtBoxCardVerCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.allowOnlyNumbers(sender, e);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            bool isValid = FormValidator.validatePurchaseForm(txtBoxCardNumber, txtBoxCardExpDate, txtBoxCardVerCode, errProviderPurchaseForm);

            if (!isValid) return;
        }
    }
}
