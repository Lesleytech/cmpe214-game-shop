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
    public partial class GameItem : UserControl
    {
        public GameItem()
        {
            InitializeComponent();
        }

        private string _gameName;
        private string _gameStock;
        private string _gamePrice;
        private Image _gameImage;
        private Button _gameBuy;
        private string _gameId = Guid.NewGuid().ToString();

        [Category("Custom Prop")]
        public string GameId
        {
            get { return _gameId; }
            //set { _gameId = value; }
        }


        [Category("Custom Prop")]
        public string GameName
        {
            get { return _gameName; }
            set { _gameName = value; lblGameName.Text = value; }
        }


        [Category("Custom Prop")]
        public string GamePrice
        {
            get { return _gamePrice; }
            set { _gamePrice = value; lblGamePrice.Text = value; }
        }


        [Category("Custom Prop")]
        public string GameStock
        {
            get { return _gameStock; }
            set { _gameStock = value; lblGameStock.Text = value;  }
        }


        [Category("Custom Prop")]
        public Image GameImage
        {
            get { return _gameImage; }
            set { _gameImage = value; picBoxGameImg.Image = value; }
        }


        [Category("Custom Prop")]
        public Button GameBuy
        {
            get { return _gameBuy; }
            set { _gameBuy = value; }
        }

        private void btnGameBuy_Click(object sender, EventArgs e)
        {
            PurchaseForm frmPurchase = new PurchaseForm(GameId);
            frmPurchase.Show();
        }
    }

}
