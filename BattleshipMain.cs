using System;
using System.Collections.Generic;
using System.Linq;

namespace RishabhBattleship
{
    class Program
    {

        /*This program achieves the follwing objectives: 
        1. Create a board
        2. Add a battleship to the board
        3. Take an “attack” at a given position, and report back whether the attack resulted in a
           hit or a miss
        4. Return whether the player has lost the game yet (i.e. all battleships are sunk)*/

        /*In this game, there is only one player at the moment. In order to win the game, take a shot at 0,0.
        Keep taking shots at other random coordinates to run out of Ammo and lose*/

        
        private static Board board;//Creating a 10 x 10 Size board wrt origin
        private static Battleship battleship;
        private static Player player;

        private static bool isWonLose;

        public static void Main(string[] args)
        {
            isWonLose = false;
            board = new Board{xCoordinate = 10 , yCoordinate = 10, battleship = null};
            InitBattleship();
            InitPlayer();
            PlaceShip(battleship);
            
            Console.WriteLine("Get ready!");

            //While the player has not lost the game, let them hit. In this case the player can't hit anything
            //because there's only one battleship on the board and only one player really.
            while (!isWonLose)
            {
                if(battleship.ammunition == 0) {
                    Console.WriteLine(player.name + "'s battleships ran out of ammunition. Game over, you lost!");
                    string writeAnythingDoesnotMatter = Console.ReadLine();
                    isWonLose = true;
                    return;
                    
                }
                    Console.WriteLine(player.name + ", please enter a coordinate to attack.");

                    //Player can take a shot outside the board, doesn't affect anyone except the player itself.
                    //You run out of Ammo you lose!
                    Console.Write("X-Coordinate: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Y-Coordinate: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    battleship.ammunition--;

                    if(battleship.xCoordinate == x && battleship.yCoordinate == y) {
                        Console.WriteLine("You've hit a battleship! Unfortunately that happens to be your own.");
                        Console.WriteLine("Technically you lose! But for the sake of this demonstration, you win!");
                        Console.WriteLine("##############");
                        Console.WriteLine("##############");
                        Console.WriteLine("##############");
                        Console.WriteLine("##############");
                        Console.WriteLine("##############");
                        Console.WriteLine("Game Ends!");
                        isWonLose = true;

                    } else {
                        Console.WriteLine("Missed it!");
                    }

                    

            }
            string blank = Console.ReadLine();
            return;

        }

        //This places a battleship on the board. only one battleship is supported at the moment
        private static void PlaceShip(Battleship battleship)
        {
            board.battleship = battleship;
            Console.WriteLine("Battleship: " + battleship + " has been placed on the board.");
        }

        //Intialises a battleship with certain features. Can use a list to add more ships.
        //Some problem solving would be required to calculate area occupied by each ship around it's coordinates.
        //That would help in deciding if it was hit when attacked.
        private static void InitBattleship()
        {
            battleship = new Battleship
            {
                name = "DeathWish",
                xCoordinate = 0,
                yCoordinate = 0,
                width = 1,
                height = 1,
                ammunition = 5,
                isDestroyed = false
            };

        }

        private static void InitPlayer()
        {
            player = new Player();
            player.battleships = battleship;
            Console.WriteLine("Please enter the Player's name: ");
            player.name = Console.ReadLine();;
        }

    }
}
