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
                Console.WriteLine($"{currentPlayer.Name} its your turn! Enter the column that you wish to place your checker into(0 to 6):");
                int column = int.Parse(Console.ReadLine());
                TakeTurn(column);
                if (WinnerAlert())
                {
                    Console.WriteLine($"{currentPlayer.Name} wins!");
                    break;
                }
                SwitchPlayer();
            }    
        }
        private void TakeTurn(int column)
        {
            //The TakeTurn method facilitates the player as they take a turn during game play
            for (int i = 5; i >= 0; i--)
            {
                if (board[i, column] == '\0')
                {
                    board[i, column] = currentPlayer.Checker;
                    break;
                }
            }
        }
        private bool WinnerAlert()
        {    
            //To win the Connect Four Game, a player needs to form a row of four of their color of Checker (the gamepiece)
            //Check for a winner after every single turn so no one misses out on their hard earned victory
            //Wins must be checked for horizontally, vertically, and diagonally in both directions, as a line of four checkers can be formed in multiple ways
            //If a player wins, announce their win but if no one has won yet, then it will be the time for the next player to take a turn and place their game piece
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    //Diagonal Check (Starting from the left hand side of the board at top, down to the right hand side of the board at bottom)
                    if(i < 3 && j < 4 && board[i, j] == 
                    currentPlayer.Checker && board [i + 1, j + 1] == 
                    currentPlayer.Checker && board [i + 2, j + 2] == 
                    currentPlayer.Checker && board [i + 3, j + 3] ==
                    currentPlayer.Checker)
                    {
                        return true;
                    }    
                    //Diagonal Check (Starting from the top right hand side of the board, down to the left hand side of the board at bottom)
                    if(i < 3 && j < 2 && board[i, j] == 
                    currentPlayer.Checker && board [i + 1, j + 1] == 
                    currentPlayer.Checker && board [i + 2, j + 2] == 
                    currentPlayer.Checker && board [i + 3, j + 3] ==
                    currentPlayer.Checker)
                    {
                        return true;
                    }                  
                    //Horizontal Check
                    if(j < 4 && board[i, j] == 
                    currentPlayer.Checker && board[i, j + 1] == 
                    currentPlayer.Checker && board[i, j + 2] == 
                    currentPlayer.Checker && board[i, j + 3] == 
                    currentPlayer.Checker)
                    {
                        return true;
                    }    
                    //Vertical Check
                    if(i < 3 && board[i, j] == 
                    currentPlayer.Checker && board[i + 1, j] == 
                    currentPlayer.Checker && board[i + 2, j] == 
                    currentPlayer.Checker && board[i + 3, j] ==
                    currentPlayer.Checker)
                    {
                        return true;
                    }    
                }
            }
            //If winning conditions are not met, the current player did not win after their turn
            return false;
        }
        //Gameplay involves the players taking turns alternating between player 1 and player 2
        private void SwitchPlayer()
        {
            currentPlayer = currentPlayer == player1 ? player2 : player1;
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
            game.Start();
        }
    }
}
