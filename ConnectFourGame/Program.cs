using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    //This class represents a player in the Connect Four Game
    public class Player
    {
        public string Name { get; set; }
        public Player(string name)
        {
            Name = name;
        }
    }
    //This class reperesents the Connect Four Game and it has two player Objects in this class
    public class Game
    {
        private Player player1;
        private Player player2;

        public Game{string player1Name; string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);
        }
        //This is the Start Method that contains the game logics
        public void Start()
        {
            //To do insert game logic to allow placement of game pieces in game board 
            //and have the game check for a winner (four in a row) after each turn
            //Game logic checks for four matching color pieces (red or blue) in a row horizontally, vertically, or diagonlly.  
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome greeting
            Console.WriteLine("Welcome to the Connect Four Game! ");
            //Ask each of the two players to enter their names to get started, starting with Player 1
            Console.WriteLine("Player 1, please enter your name. ");
            //Allow game player to answer by inputting text
            string player1Name = Console.ReadLine();
            Console.WriteLine("Player 2, please enter your name. ");
            string player2Name = Console.ReadLine();
            //TO DO
            //Add ability for game to respond to the players, displaying the name they inputted 
            //and explain to player 1 they are red and to player 2 blue game pieces
            //i.e. let them know player 1 is x and that represents red and player 2 is o and that represents blue - tbd
        }
    }
}
