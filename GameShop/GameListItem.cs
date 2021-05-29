using System;
using System.ComponentModel;
using System.Windows.Forms;
using GameShop.Storage;

namespace GameShop
{
    public partial class GameListItem : UserControl
    {
        ListRetailProductForm _parent;
        public GameListItem(ListRetailProductForm parent)
        {
            InitializeComponent();
            this._parent = parent;
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
            set { _gameName = value; lblGameListName.Text = value; }
        }


        [Category("Custom Prop")]
        public int GamePrice
        {
            get { return _gamePrice; }
            set { _gamePrice = value; lblGameListPrice.Text = "$" + value; }
        }


        [Category("Custom Prop")]
        public int GameStock
        {
            get { return _gameStock; }
            set { _gameStock = value; lblGameListStock.Text = value + " in stock"; }
        }


        [Category("Custom Prop")]
        public string GameImgLocation
        {
            get { return _gameImgLocation; }
            set { _gameImgLocation = value; picBoxGameListImg.ImageLocation = value; picBoxGameListImg.Load(); }
        }


        private void btnEditGame_Click(object sender, EventArgs e)
        {
            UpdateGameItemForm frm = new UpdateGameItemForm(GameId, _parent);
            frm.Show();
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {GameName}?", "Delete game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                GameStorage.RemoveGame(GameId);

                this._parent.loadGameList();
            }
        }
    }
}
