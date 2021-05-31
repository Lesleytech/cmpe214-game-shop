using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameShop.Games;
using GameShop.Storage;
using GameShop.Authentication;

namespace GameShop
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            string authUsername = Auth.GetAuthUsername();

            if (authUsername != null)
            {
                linkLblAccount.Text = $"Logout ({authUsername})";
                this.Text = $"Games - {authUsername}";
            }

            loadGameList();
        }

        private string _selectedGameId;
        public string SelectedGameId
        {
            get { return _selectedGameId; }
            set { _selectedGameId = value; }
        }

        public void loadGameList()
        {
            List<Game> games = GameStorage.GetAllGames();

            if (games == null) return;

            if (flowLayoutAllGames.Controls.Count > 0)
            {
                flowLayoutAllGames.Controls.Clear();
            }

            foreach (Game game in games)
            {
                GameItem gameItem = new GameItem(this)
                {
                    GameId = game.gameId,
                    GameName = game.name,
                    GameStock = game.stock,
                    GamePrice = game.price,
                    GameImgLocation = game.imgPath
                };

                flowLayoutAllGames.Controls.Add(gameItem);
            }
        }

        public LinkLabel LinkLabelAccount
        {
            get { return this.linkLblAccount; }
        }

        private void linkLblAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkLblAccount.Text == "Account")
            {
                LoginForm frm = new LoginForm(this);

                frm.Show();
                return;
            }

            Auth.Logout();

            linkLblAccount.Text = "Account";
            this.Text = "Games";
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}
