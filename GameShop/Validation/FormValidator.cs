using System.Windows.Forms;
using GameShop.Users;
using GameShop.Storage;

namespace GameShop.Validation
{
    class FormValidator
    {
        private static bool isTextBoxEmpty(TextBox txtBox)
        {
            if (txtBox.Text.Length == 0)
                return true;

            return false;
        }

        public static bool ValidateLoginForm(TextBox txtBoxIdentifier, TextBox txtBoxPassword, ErrorProvider errProvider)
        {
            errProvider.Clear();

            if(isTextBoxEmpty(txtBoxIdentifier))
            {
                errProvider.SetError(txtBoxIdentifier, "Username or email is required");
                return false;
            }

            if (isTextBoxEmpty(txtBoxPassword))
            {
                errProvider.SetError(txtBoxPassword, "Password is required");
                return false;
            }

            if (txtBoxIdentifier.Text == "admin" && txtBoxPassword.Text == "admin")
                return true;

            User user = UserStorage.FindUserByEmail(txtBoxIdentifier.Text);

            if (user == null)
                user = UserStorage.FindUserByName(txtBoxIdentifier.Text);

            if ( user == null)
            {
                errProvider.SetError(txtBoxIdentifier, "Account does not exist");
                return false;
            }

            if(user.password != txtBoxPassword.Text)
            {
                errProvider.SetError(txtBoxPassword, "Password is incorrect");
                return false;
            }

            return true;
        }

        public static bool ValidateRegForm(TextBox txtBoxUsername, TextBox txtBoxEmail, TextBox txtBoxPassword, ErrorProvider errProvider)
        {
            errProvider.Clear();

            if (isTextBoxEmpty(txtBoxUsername))
            {
                errProvider.SetError(txtBoxUsername, "Username is required");
                return false;
            }

            if (isTextBoxEmpty(txtBoxEmail))
            {
                errProvider.SetError(txtBoxEmail, "Email is required");
                return false;
            }

            if (isTextBoxEmpty(txtBoxPassword))
            {
                errProvider.SetError(txtBoxPassword, "Password is required");
                return false;
            }

            if (txtBoxUsername.Text.Trim().ToLower() == "admin")
            {
                errProvider.SetError(txtBoxUsername, "Username is restricted");
                return false;
            }

            User user = UserStorage.FindUserByEmail(txtBoxEmail.Text);

            if (user != null)
            {
                errProvider.SetError(txtBoxEmail, "User with this email already exist");
                return false;
            }

            user = UserStorage.FindUserByName(txtBoxUsername.Text);

            if (user != null)
            {
                errProvider.SetError(txtBoxUsername, "User with this username already exist");
                return false;
            }

            return true;
        }

        public static bool ValidatePurchaseForm(TextBox txtBoxCardNumber, TextBox txtBoxCardExpDate, TextBox txtBoxCardVerCode, ErrorProvider errProvider)
        {
            errProvider.Clear();

            if (isTextBoxEmpty(txtBoxCardNumber))
            {
                errProvider.SetError(txtBoxCardNumber, "Card number is required");
                return false;
            }

            if (isTextBoxEmpty(txtBoxCardExpDate))
            {
                errProvider.SetError(txtBoxCardExpDate, "Card expiry date is required");
                return false;
            }

            if (isTextBoxEmpty(txtBoxCardVerCode))
            {
                errProvider.SetError(txtBoxCardVerCode, "Card verification code is required");
                return false;
            }

            return true;
        }

        public static bool ValidateItemForm(TextBox txtBoxName, TextBox txtBoxStock ,TextBox txtBoxPrice, PictureBox picBoxGameImg, ErrorProvider errProvider)
        {
            errProvider.Clear();

            if (isTextBoxEmpty(txtBoxName))
            {
                errProvider.SetError(txtBoxName, "Game name is required");
                return false;
            }

            if (isTextBoxEmpty(txtBoxPrice))
            {
                errProvider.SetError(txtBoxPrice, "Game price is required");
                return false;
            }

            if (isTextBoxEmpty(txtBoxStock))
            {
                errProvider.SetError(txtBoxStock, "Game stock is required");
                return false;
            }

            if (picBoxGameImg.Image == null)
            {
                errProvider.SetError(picBoxGameImg, "Game image is required");
                return false;
            }

            return true;
        }
    }
}