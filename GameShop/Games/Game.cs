using System;

namespace GameShop.Games
{
    class Game
    {
        public string gameId { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public int price { get; set; }
        public int stock { get; set; }
        public string imgPath { get; set; }
    }
}
