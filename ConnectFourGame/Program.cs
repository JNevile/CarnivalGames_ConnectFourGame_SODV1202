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
        //This Array in 2D is the game board for the Connect Four Game
        private int[,] board; 
        
        public Game(string player1Name, string player2Name)
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

            //Start up the game by making the game board and it will be 6 rows in height and 7 columns in width
            //All rows will start out as filled with zeros which symbolize empty slots in the game board ready to accept game pieces
            board = new int[6,7];
            for (int a = 0; a < 6; a++)
            {
                for (int b = 0; b < 7; b++)
                {
                    board[a, b] = 0;
                }
            }
            //Start with player 1 (red)
            //TO DO Get a player to start playing
            //Player = player1;
        }
        public bool TakeTurn(int column, int player)
        {
            //The TakeTurn method facilitates the player as they take a turn

        }
        public void WinnerAlert()
        {    
            //Add logic to check for a winner after every single turn so no one misses out on their hard earned victory, could also be called Win Audit or soething similar
            //Next steps: If a player has won, announce their win and if no one has won then it will be the time for the next player to take a turn and place their game piece
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
