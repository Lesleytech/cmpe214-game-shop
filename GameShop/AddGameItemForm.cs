using System;
using System.Windows.Forms;
using GameShop.Validation;
using GameShop.Games;
using GameShop.Storage;

namespace GameShop
{
    public partial class AddGameItemForm : Form
    {
        ListRetailProductForm _parent;
        public AddGameItemForm(ListRetailProductForm parent)
        {
            this._parent = parent;
            InitializeComponent();
        }

        private void btnAddGameImgUpload_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                picBoxAddGameImg.ImageLocation = open.FileName;
                picBoxAddGameImg.Load();
            }
        }

        private void txtBoxAddGamePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.AllowOnlyNumbers(sender, e);
        }

        private void txtBoxAddGameStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.AllowOnlyNumbers(sender, e);
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            bool isValid = FormValidator.ValidateItemForm(txtBoxAddGameName, txtBoxAddGameStock, txtBoxAddGamePrice, picBoxAddGameImg, errProviderAddGameForm);

            if (!isValid) return;

            string name = txtBoxAddGameName.Text;

            // We are certain we have a number as we allowed only numbers in TextBox
            // There's no need using int.TryParse()
            int price = int.Parse(txtBoxAddGamePrice.Text);
            int stock = int.Parse(txtBoxAddGameStock.Text);

            string imgPath = picBoxAddGameImg.ImageLocation;

            Game newGame = new Game { name = name, price = price, stock = stock, imgPath = imgPath };

            try
            {
                GameStorage.AddGame(newGame);
                
                this._parent.loadGameList();
                
                MessageBox.Show($"{name} successfully added.", "Game added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBoxAddGameName.Clear();
                txtBoxAddGamePrice.Clear();
                txtBoxAddGameStock.Clear();
                picBoxAddGameImg.Image = null;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
