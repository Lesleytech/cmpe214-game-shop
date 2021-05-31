using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using GameShop.Games;

namespace GameShop.Storage
{
    class GameStorage
    {
        private static string gamesRootPath = Path.Combine(StorageConfig.root, "games");
        private static string gamesXmlFile = Path.Combine(gamesRootPath, "db.xml");
        private static string gamesJsonFile = Path.Combine(gamesRootPath, "db.json");

        public static void AddGame(Game game)
        {
                if (!Directory.Exists(gamesRootPath))
                    Directory.CreateDirectory(gamesRootPath);

                if (!File.Exists(gamesXmlFile))
                {
                    string xmlContent = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>" + "<games></games>";

                    XmlDocument tempDoc = new XmlDocument();

                    tempDoc.LoadXml(xmlContent);
                    tempDoc.Save(gamesXmlFile);
                }

                var doc = XDocument.Load(gamesXmlFile);

                var newElement = new XElement("game",
                    new XAttribute("id", game.gameId),
                    new XElement("name", game.name),
                    new XElement("price", game.price),
                    new XElement("stock", game.stock),
                    new XElement("imgPath", game.imgPath));

                doc.Element("games").Add(newElement);

                doc.Save(gamesXmlFile);
        }

        public static void UpdateGame(Game game)
        {
            var doc = XDocument.Load(gamesXmlFile);

            var items = from item in doc.Descendants("game") 
                        where item.Attribute("id").Value == game.gameId 
                        select item;

            foreach (XElement el in items)
            {
                el.SetElementValue("name", game.name);
                el.SetElementValue("price", game.price);
                el.SetElementValue("stock", game.stock);
                el.SetElementValue("imgPath", game.imgPath);
            }

            doc.Save(gamesXmlFile);
        }

        public static void RemoveGame(string gameId)
        {

            var doc = XDocument.Load(gamesXmlFile);

            doc.Descendants("game").Where(x => x.Attribute("id").Value == gameId).Remove();

            doc.Save(gamesXmlFile);
        }

        public static void DecrementGameStock(string gameId)
        {
            Game game = FindGameById(gameId);

            if(game.stock == 1)
            {
                RemoveGame(gameId);
                return;
            }

            UpdateGame(new Game { gameId = gameId, price = game.price, name = game.name, imgPath = game.imgPath, stock = --game.stock });
        }

        public static Game FindGameById(string gameId)
        {
            var doc = XDocument.Load(gamesXmlFile);

            var el = doc.Descendants("game").Where(x => x.Attribute("id").Value == gameId).First();

            // Return null if game is not found
            if(el == null) return null;

            string name = el.Element("name").Value;
            int price = int.Parse(el.Element("price").Value);
            int stock = int.Parse(el.Element("stock").Value);
            string imgPath = el.Element("imgPath").Value;

            return new Game { gameId = gameId, name = name, price = price, stock = stock, imgPath = imgPath };
        }

        public static List<Game> GetAllGames()
        {
            if (!File.Exists(gamesXmlFile))
                return null;

            var doc = XDocument.Load(gamesXmlFile);
            List<Game> games = new List<Game>();

            foreach (var game in doc.Descendants("game"))
            {
                games.Add(new Game
                {
                    gameId = game.Attribute("id").Value,
                    name = game.Element("name").Value,
                    price = int.Parse(game.Element("price").Value),
                    stock = int.Parse(game.Element("stock").Value),
                    imgPath = game.Element("imgPath").Value,
                });
            }

            return games;
        }
    }
}
