using System;
using System.Windows.Forms;

namespace GameShop.Validation
{
    class TextBoxValidator
    {
        public static void allowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
