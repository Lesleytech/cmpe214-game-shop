using System;
using System.ComponentModel;
using System.Windows.Forms;
using GameShop.Authentication;

namespace GameShop
{
    public partial class GameItem : UserControl
    {
        ProductForm _rootParent;
        public GameItem(ProductForm parent)
        {
            InitializeComponent();
            this._rootParent = parent;
        }

        private string _gameName;
        private int _gameStock;
        private int _gamePrice;
        private string _gameImgLocation;
        private string _gameId;

        [Category("Custom Prop")]
        public string GameId
        {
            get { return _gameId; }
            set { _gameId = value; }
        }


        [Category("Custom Prop")]
        public string GameName
        {
            get { return _gameName; }
            set { _gameName = value; lblGameName.Text = value; }
        }


        [Category("Custom Prop")]
        public int GamePrice
        {
            get { return _gamePrice; }
            set { _gamePrice = value; lblGamePrice.Text = "$" + value; }
        }


        [Category("Custom Prop")]
        public int GameStock
        {
            get { return _gameStock; }
            set { _gameStock = value; lblGameStock.Text = value + " in stock"; }
        }


        [Category("Custom Prop")]
        public string GameImgLocation
        {
            get { return _gameImgLocation; }
            set { _gameImgLocation = value; picBoxGameImg.ImageLocation = value; picBoxGameImg.Load(); }
        }

        private void btnGameBuy_Click(object sender, EventArgs e)
        {
            string authUsername = Auth.GetAuthUsername();

            if(authUsername == null)
            {
                MessageBox.Show("You must be logged in to proceed to checkout page.", "Login request", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                LoginForm frm = new LoginForm(_rootParent);
                frm.Show();
            }
            else
            {
                PurchaseForm frmPurchase = new PurchaseForm(GameId, _rootParent);
                frmPurchase.Show();
            }
        }
    }

}
