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

namespace GameShop
{
    public partial class AddGameItemForm : Form
    {
        public AddGameItemForm()
        {
            InitializeComponent();
        }

        private void btnAddGameImgUpload_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|.jpg; *.jpeg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                picBoxAddGameImg.Image = new Bitmap(open.FileName);
                // image file path
                //textBox1.Text = open.FileName;
            }
        }

        private void txtBoxAddGamePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.allowOnlyNumbers(sender, e);
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            bool isValid = FormValidator.validateItemForm(txtBoxAddGameName, txtBoxAddGameStock, txtBoxAddGamePrice, picBoxAddGameImg, errProviderAddGameForm);

            if (!isValid) return;
           
        }

        private void txtBoxAddGameStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.allowOnlyNumbers(sender, e);
        }
    }
}
