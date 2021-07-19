using System;
namespace RishabhBattleship
{
    public class Battleship
    {
        public string name { get; set; }
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int health { get; set; }
        public int ammunition {get; set;}
        public bool isDestroyed { get; set; }
    }
}
