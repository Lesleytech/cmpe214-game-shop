using System.Windows.Forms;

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

        public static bool validateLoginForm(TextBox txtBoxIdentifier, TextBox txtBoxPassword, ErrorProvider errProvider)
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

            return true;
        }

        public static bool validateRegForm(TextBox txtBoxUsername, TextBox txtBoxEmail, TextBox txtBoxPassword, ErrorProvider errProvider)
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

            return true;
        }
    }
}