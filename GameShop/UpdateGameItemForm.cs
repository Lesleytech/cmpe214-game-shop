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
using GameShop.Games;
using GameShop.Storage;

namespace GameShop
{
    public partial class UpdateGameItemForm : Form
    {
        string _gameId;
        ListRetailProductForm _rootParent;
        public UpdateGameItemForm(string gameId, ListRetailProductForm rootParent)
        {
            InitializeComponent();

            this._gameId = gameId;
            this._rootParent = rootParent;
        }

        private void btnUpdateGameImgUpload_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                picBoxUpdateGameImg.ImageLocation = open.FileName;
                picBoxUpdateGameImg.Load();
            }
        }

        private void txtBoxUpdateGamePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.AllowOnlyNumbers(sender, e);
        }

        private void txtBoxUpdateGameStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.AllowOnlyNumbers(sender, e);
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
            bool isValid = FormValidator.ValidateItemForm(txtBoxUpdateGameName, txtBoxUpdateGameStock, txtBoxUpdateGamePrice, picBoxUpdateGameImg, errProviderUpdateGameForm);

            if (!isValid) return;

            string name = txtBoxUpdateGameName.Text;

            // We are certain we have a number as we allowed only numbers in TextBox
            // There's no need using int.TryParse()
            int price = int.Parse(txtBoxUpdateGamePrice.Text);
            int stock = int.Parse(txtBoxUpdateGameStock.Text);

            string imgPath = picBoxUpdateGameImg.ImageLocation;

            Game updatedGame = new Game { gameId = this._gameId, name = name, price = price, stock = stock, imgPath = imgPath };

            try
            {
                GameStorage.UpdateGame(updatedGame);
                
                this.Close();
                this._rootParent.loadGameList();

                MessageBox.Show($"{name} updated successfully.", "Game updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGameItemForm_Load(object sender, EventArgs e)
        {
            Game game = GameStorage.FindGameById(this._gameId);

            txtBoxUpdateGameName.Text = game.name;
            txtBoxUpdateGamePrice.Text = game.price.ToString();
            txtBoxUpdateGameStock.Text = game.stock.ToString();

            picBoxUpdateGameImg.ImageLocation = game.imgPath;
            picBoxUpdateGameImg.Load();
        }
    }
}
