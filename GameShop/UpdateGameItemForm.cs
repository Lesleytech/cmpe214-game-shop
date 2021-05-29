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
    public partial class UpdateGameItemForm : Form
    {
        public UpdateGameItemForm(string qs)
        {
            InitializeComponent();
        }

        private void btnUpdateGameImgUpload_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|.jpg; *.jpeg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                picBoxUpdateGameImg.Image = new Bitmap(open.FileName);
                // image file path
                //textBox1.Text = open.FileName;
            }
        }

        private void txtBoxUpdateGamePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.allowOnlyNumbers(sender, e);
        }

        private void txtBoxUpdateGameStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxValidator.allowOnlyNumbers(sender, e);
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
            bool isValid = FormValidator.validateItemForm(txtBoxUpdateGameName, txtBoxUpdateGameStock, txtBoxUpdateGamePrice, picBoxUpdateGameImg, errProviderUpdateGameForm);

            if (!isValid) return;
        }
    }
}
