using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameShop.Games;
using GameShop.Storage;
using GameShop.Authentication;

namespace GameShop
{
    public partial class ListRetailProductForm : Form
    {
        public ListRetailProductForm()
        {
            InitializeComponent();
        }

        private void linkLabelAddGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddGameItemForm frm = new AddGameItemForm(this);
            frm.Show();
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

            if (games == null)
                return;

            if (flowLayoutGameList.Controls.Count > 0)
            {
                flowLayoutGameList.Controls.Clear();
            }

            foreach (Game game in games)
            {
                GameListItem gameItem = new GameListItem(this)
                {
                    GameId = game.gameId,
                    GameName = game.name,
                    GameStock = game.stock,
                    GamePrice = game.price,
                    GameImgLocation = game.imgPath
                };
               
                flowLayoutGameList.Controls.Add(gameItem);
            }
        }

        private void ListRetailProductForm_Load(object sender, EventArgs e)
        {
            loadGameList();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Auth.Logout();

            ProductForm frm = new ProductForm();

            frm.Show();
            this.Close();
        }

        private void ListRetailProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}
