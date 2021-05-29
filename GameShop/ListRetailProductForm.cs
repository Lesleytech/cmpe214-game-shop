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
    public partial class ListRetailProductForm : Form
    {
        public ListRetailProductForm()
        {
            InitializeComponent();
        }

        private void linkLabelAddGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddGameItemForm frm = new AddGameItemForm();
            frm.Show();
        }

   

        private string _selectedGameId;
        public string SelectedGameId
        {
            get { return _selectedGameId; }
            set { _selectedGameId = value; }
        }



        private void populateItems()
        {
            GameListItem[] gameItems = new GameListItem[20];

            for (int i = 0; i < gameItems.Length; i++)
            {
                gameItems[i] = new GameListItem();
                gameItems[i].GameName = "Game name";
                gameItems[i].GameStock = "10 in stock";
                gameItems[i].GamePrice = "$400";
                //gameItems[i].GameId = ;

                if (flowLayoutGameList.Controls.Count < 0)
                {
                    flowLayoutGameList.Controls.Clear();
                }
                else
                {
                    flowLayoutGameList.Controls.Add(gameItems[i]);
                }
            }
        }

        private void ListRetailProductForm_Load(object sender, EventArgs e)
        {
            populateItems();

        }
    }
}
