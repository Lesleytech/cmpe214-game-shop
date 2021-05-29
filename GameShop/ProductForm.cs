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

            ListRetailProductForm regForm = new ListRetailProductForm();

            regForm.Show();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //PurchaseForm purchaseFrm = new PurchaseForm();
        //    //purchaseFrm.Show();
        //}

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private string _selectedGameId;
        public string SelectedGameId
        {
            get { return _selectedGameId; }
            set { _selectedGameId = value; }
        }



        private void populateItems()
        {
            GameItem[] gameItems = new GameItem[20];

            for(int i = 0; i < gameItems.Length; i++)
            {
                gameItems[i] = new GameItem();
                gameItems[i].GameName = "Game name";
                gameItems[i].GameStock = "10 in stock";
                gameItems[i].GamePrice = "$400";
                //gameItems[i].GameId = ;

                if (flowLayoutAllGames.Controls.Count < 0)
                {
                    flowLayoutAllGames.Controls.Clear();
                }
                else
                {
                    flowLayoutAllGames.Controls.Add(gameItems[i]);
                }
            }
        }
    }
}
