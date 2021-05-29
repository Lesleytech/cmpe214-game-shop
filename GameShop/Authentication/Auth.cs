using GameShop.Users;
using GameShop.Storage;

namespace GameShop.Authentication
{
    class Auth
    {
        public static void Register(User user)
        {
            UserStorage.AddUser(user);
        }

        public static User Login(string identifier, string password)
        {
            User user;

            if (identifier.ToLower() == "admin" && password.ToLower() == "admin")
            {
                user = new User { email = "admin@gameshop.com", username = "admin", password = "admin" };
                UserStorage.SetAuthUser(user);

                return user;
            }
            
            user = UserStorage.FindUserByEmail(identifier);

            if (user == null)
                user = UserStorage.FindUserByName(identifier);

            UserStorage.SetAuthUser(user);

            return user;
        }

        public static void Logout()
        {
            UserStorage.RemoveAuthUser();
        }

        public static string GetAuthUsername()
        {
            return UserStorage.GetAuthUserName();
        }
    }
}
