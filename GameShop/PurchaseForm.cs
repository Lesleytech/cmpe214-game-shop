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
using GameShop.Storage;

namespace GameShop
{
    public partial class PurchaseForm : Form
    {
        string _gameId;
        ProductForm _rootParent;
        public PurchaseForm(string gameId, ProductForm rootParent)
        {
            InitializeComponent();
            this._gameId = gameId;
            this._rootParent = rootParent;
        }

        private void txtBoxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.AllowOnlyNumbers(sender, e);
        }

        private void txtBoxCardVerCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.AllowOnlyNumbers(sender, e);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            bool isValid = FormValidator.ValidatePurchaseForm(txtBoxCardNumber, txtBoxCardExpDate, txtBoxCardVerCode, errProviderPurchaseForm);

            if (!isValid) return;

            try
            {
                GameStorage.DecrementGameStock(this._gameId);
                this.Close();

                this._rootParent.loadGameList();

                MessageBox.Show("Game purchased successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error processing payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
