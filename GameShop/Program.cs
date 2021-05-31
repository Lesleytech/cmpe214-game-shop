using System;
using System.Windows.Forms;
using GameShop.Authentication;

namespace GameShop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string authUsername = Auth.GetAuthUsername();
            
            // Show form according to user role
            // 1. User is an admin
            if(authUsername == "admin")
            { 
                ListRetailProductForm listRetailProdForm = new ListRetailProductForm();
                listRetailProdForm.Show();
            }
            // 2. User is not an admin or user is not logged in
            else
            {
                ProductForm productForm = new ProductForm();
                productForm.Show();
            }

            Application.Run();
        }
    }
}
