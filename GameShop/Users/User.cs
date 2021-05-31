using System;

namespace GameShop.Users
{
    class User
    {
        public string uid { get; set; } = Guid.NewGuid().ToString();
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool isAdmin { 
            get 
            {
                if (this.username == "admin" && this.password == "admin")
                    return true;

                return false;
            } 
        } 
    }
}
