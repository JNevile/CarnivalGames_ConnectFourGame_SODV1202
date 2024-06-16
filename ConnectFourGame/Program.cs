using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourGame
{
    //This class represents a player in the Connect Four Game
    //The checker represents a game piece that will be placed into a column on the board during each player's turn
    public class Player
    {
        public string Name { get; set; }
        public char Checker { get; set; }
        
        public Player(string name, char checker)
        {
            Name = name;
            Checker = checker;
        }
    }
    //This class reperesents the Connect Four Game and it has two player Objects in this class
    public class Game
    {
        private Player currentPlayer;
        //This represents the game board for the Connect Four Game
        private char[,] board;
        //The game has 6 columns that are 7 rows long and gameplay will alternate between two players taking turns, starting with player 1
        public Game(Player player1, Player player2)
        {
            currentPlayer = player1;
            board = new char[6, 7];
        }
        //This is the Start Method that contains the game logics
        public void Start()
        {
            while (true)
            {
                Console.WriteLine($"{currentPlayer.Name}" its your turn! Enter the column where you wish to place your checker(0 to 6):");
                int column = int.Parse(Console.ReadLine());
                TakeTurn(column);
                if (CheckWin())
                {
                    Console.WriteLine($"{currentPlayer.Name} wins!");
                    break;
                }
                SwitchPlayer();
            }    
        }
        private void TakeTurn(int column, int player)
        {
            //The TakeTurn method facilitates the player as they take a turn during game play
            for (int a = 5; a >= 0; a--)
            {
                if (board[a, column] == "\0")
                {
                    board[a, column] = currentPlayer.Checker;
                    break;
                }
            }
        }
        private bool WinnerAlert()
        {    
            //Add logic to check for a winner after every single turn so no one misses out on their hard earned victory
            //To win the Connect Four Game, a player needs to form a row of four of their color of Checker (the gamepiece)
            //Wins much be checked for horizontally, vertically, and diagonally as a line can be formed in multiple directions
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

            Player player1 = new Player(player1Name, "Red");
            Player player2 = new Player(player2Name, "Blue");
            
            Game game = new Game(player1, player2);
            //TO DO
            while (true)
            {
                //TO DO: Game logic
            }
            //TO DO
            //Add ability for game to respond to the players, displaying the name they inputted 
            //and explain to player 1 they are red and to player 2 blue game pieces
            //i.e. let them know player 1 is x and that represents red and player 2 is o and that represents blue - tbd
        }
    }
}
