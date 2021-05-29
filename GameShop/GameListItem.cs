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
    public partial class GameListItem : UserControl
    {
        public GameListItem()
        {
            InitializeComponent();
        }

        private string _gameName;
        private string _gameStock;
        private string _gamePrice;
        private Image _gameImage;
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
            set { _gameName = value; lblGameListName.Text = value; }
        }


        [Category("Custom Prop")]
        public string GamePrice
        {
            get { return _gamePrice; }
            set { _gamePrice = value; lblGameListPrice.Text = value; }
        }


        [Category("Custom Prop")]
        public string GameStock
        {
            get { return _gameStock; }
            set { _gameStock = value; lblGameListStock.Text = value; }
        }


        [Category("Custom Prop")]
        public Image GameImage
        {
            get { return _gameImage; }
            set { _gameImage = value; picBoxGameListImg.Image = value; }
        }


        private void btnEditGame_Click(object sender, EventArgs e)
        {
            UpdateGameItemForm frm = new UpdateGameItemForm(GameId);
            frm.Show();
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {

        }
    }
}
