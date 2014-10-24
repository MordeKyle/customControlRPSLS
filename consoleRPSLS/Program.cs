using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;


namespace consoleRPSLS
{
    class Program
    {

        static void Main(string[] args)
        {
            // Show Welcome Message
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*          Welcome to Rock, Paper, Scissors, Lizard, Spock Game!         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine();
            Console.WriteLine("TO PLAY: Press R=Rock, P=Paper, S=Scissors, L=Lizard, K=Spock");

            // Declare a variable for player input
            string playerInput = GetInput();

            do
            {
                // create a new game instance
                RPSLS play = new RPSLS();
                int player = GetPlayerChoice(playerInput);
                play.PlayerChoice = player; // invokes set accessor
                // get player choice
                int playerChoice = play.PlayerChoice;
                // validate player choice
                if (!(Enum.IsDefined(typeof(RPSLS.Choice), playerChoice)))
                {
                    Console.WriteLine("Please enter a valid input!");
                }
                else
                {
                    // get computer choice (Invokes the get accessor)
                    int computerChoice = play.ComputerChoice;
                    
                    // display player's choice 
                    string showPlayerChoice = play.DisplayChoice(playerChoice);
                    Console.WriteLine("Your Choice       : " + showPlayerChoice);
                    // display computer choice
                    string showComputerChoice = play.DisplayChoice(computerChoice);
                    Console.WriteLine("Computer's Choice : " + showComputerChoice);
                    // determine outcome
                    int outcome = play.DetermineOutcome();
                    // display outcome
                    Console.WriteLine("Game Result       : " + play.DisplayOutcome(outcome));
                }
                // prompt if player wants to play again
                Console.WriteLine();
                Console.WriteLine("Play again? Press 'R'=rock, 'P'=paper, 'S'=Scissors, 'L'=Lizard, 'K'=Spock or 'N' to exit game.");
                playerInput = GetInput();
                // confirm exit
                if (playerInput == "n" || playerInput == "N")
                {
                    Console.WriteLine("Press 'Y' to confirm exit or press 'R', 'P', 'S', 'L', 'K' to play again.");
                    playerInput = GetInput();
                }

             } while ((playerInput != "y") && (playerInput != "Y"));
        }
        // method to get player input (set to uppercase)
        private static string GetInput()
        {
            Console.WriteLine();
            Console.Write("Enter Choice: ");
            string input = "";
            input = (Console.ReadLine().ToUpper());
            return input;
        }
        // Method to get player choice
        public static int GetPlayerChoice(string choice)
        {
            int playerChoice = -1;

            switch (choice)
            {
                case "R":
                    playerChoice = (int)RPSLS.Choice.Rock;
                    break;
                case "P":
                    playerChoice = (int)RPSLS.Choice.Paper;
                    break;
                case "S":
                    playerChoice = (int)RPSLS.Choice.Scissors;
                    break;
                case "L":
                    playerChoice = (int)RPSLS.Choice.Lizard;
                    break;
                case "K":
                    playerChoice = (int)RPSLS.Choice.Spock;
                    break;
            }
            return playerChoice;
        }
        //}
    }
}
