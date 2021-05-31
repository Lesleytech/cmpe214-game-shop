using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using GameShop.Users;

namespace GameShop.Storage
{
    class UserStorage
    {
        private static string usersRootPath = Path.Combine(StorageConfig.root, "users");
        private static string usersXmlFile = Path.Combine(usersRootPath, "db.xml");
        private static string authUserXmlFile = Path.Combine(usersRootPath, "auth_user.xml");
        private static string usersJsonFile = Path.Combine(usersRootPath, "db.json");

        public static void AddUser(User user)
        {

            checkDirectory();

            if (!File.Exists(usersXmlFile))
            {
                string xmlContent = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>" + "<users></users>";

                XmlDocument tempDoc = new XmlDocument();

                tempDoc.LoadXml(xmlContent);
                tempDoc.Save(usersXmlFile);
            }

            var doc = XDocument.Load(usersXmlFile);

            var newElement = new XElement("user",
                    new XAttribute("uid", user.uid),
                    new XElement("username", user.username),
                    new XElement("email", user.email),
                    new XElement("password", user.password));

            doc.Element("users").Add(newElement);

            doc.Save(usersXmlFile);
        }


        public static User FindUserByEmail(string email)
        {
            checkDirectory();

            XElement el;

            try
            {
                var doc = XDocument.Load(usersXmlFile);
                el = doc.Descendants("user").Where(x => x.Element("email").Value.ToLower() == email.ToLower()).First();
            }
            catch (System.Exception)
            {
                // Return null if user is not found
                return null;
            }


            string uid = el.Attribute("uid").Value;
            string username = el.Element("username").Value;
            string _email = el.Element("email").Value;
            string password = el.Element("password").Value;

            return new User { uid = uid, username = username, email = _email, password = password };
        }

        public static User FindUserByName(string username)
        {
            checkDirectory();

            XElement el;

            try
            {
                var doc = XDocument.Load(usersXmlFile);
                el = doc.Descendants("user").Where(x => x.Element("username").Value.ToLower() == username.ToLower()).First();
            }
            catch (System.Exception)
            {
                // Return null if user is not found
                return null;
            }

            string uid = el.Attribute("uid").Value;
            string _username = el.Element("username").Value;
            string email = el.Element("email").Value;
            string password = el.Element("password").Value;

            return new User { uid = uid, username = _username, email = email, password = password };
        }

        public static void SetAuthUser(User user)
        {
            checkDirectory();
                
            string xmlContent = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>" +
                                        $"<authUser>" +
                                            $"<username>{user.username}</username>" +
                                            $"<email>{user.email}</email>" +
                                        "</authUser>";

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(xmlContent);
            doc.Save(authUserXmlFile);
        }

        public static void RemoveAuthUser()
        {
            checkDirectory();
            File.Delete(authUserXmlFile);
        }

        public static string GetAuthUserName()
        {
            checkDirectory();

            if (!File.Exists(authUserXmlFile))
                return null;

            var doc = XDocument.Load(authUserXmlFile);

            string val = doc.Descendants("authUser")
                            .Select(x => x.Element("username").Value).FirstOrDefault();

            return val;
        }

        private static void checkDirectory()
        {
            if (!Directory.Exists(usersRootPath))
                Directory.CreateDirectory(usersRootPath);
        }
    }
}
