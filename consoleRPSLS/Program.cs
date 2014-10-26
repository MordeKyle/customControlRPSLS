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
            welcomeMessage(); //displays welcome message on initialize.

            while (true)
            {
                int playerChoice = -1; //declare int to hold user's input as game value
                splash(); //display the user's options
                RPSLS play = new RPSLS(); //delcare GameLibrary ----> Create a new RPSLS instance
                playerChoice = inputHandeler();

                if (playerChoice == (int)RPSLS.Choice.Exit) //TODO: if (RPSLS.Choice.Exit.Equals(playerChoice)) doesnt work. Seems to skip it.
                {
                    string exit = "exit";
                    if (confirm(exit))
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                else if (!(Enum.IsDefined(typeof(RPSLS.Choice), playerChoice))) //checks for valid input
                {
                    Console.WriteLine("Please enter a valid input!");
                }
                else
                {
                    int result; //delcare result holder
                    int computerChoice; //declare computer choice holder
                    result = play.playGame(playerChoice); //play the game, return win lose or draw
                    computerChoice = play.ComputerChoice; //return the computer's choice
                    displayResults(playerChoice, computerChoice, result); //pass user choice, computer choice, and result of game to be displayed
                }
            }
        }

        /// <summary>
        /// Displays welcome message.
        /// </summary>
        static void welcomeMessage()
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*          Welcome to Rock, Paper, Scissors, Lizard, Spock Game!         *");
            Console.WriteLine("**************************************************************************");
        }

        /// <summary>
        /// Displays the welcome message to the user, and offers the user their options.
        /// </summary>
        static void splash()
        {
            Console.WriteLine();
            Console.WriteLine("TO PLAY: Press R=Rock, P=Paper, S=Scissors, L=Lizard, K=Spock, E=Exit Game");
        }

        /// <summary>
        /// Takes the user's input and applies it to a game value.
        /// </summary>
        /// <returns>User's input as a game value.</returns>
        public static int inputHandeler()
        {
            Console.WriteLine();
            Console.Write("Enter Choice: ");
            string input = "";
            input = (Console.ReadLine().ToUpper()); //take users input, apply to uppercase method.

            int playerChoice = -1;

            switch (input)
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
                case "E":
                    playerChoice = (int)RPSLS.Choice.Exit;
                    break;
                case "Y":
                    playerChoice = (int)RPSLS.Confirm.Yes;
                    break;
                case "N":
                    playerChoice = (int)RPSLS.Confirm.No;
                    break;
            }
            return playerChoice;
        }

        /// <summary>
        /// Displays the results of the game, user's choice, and computer's choice as real world values
        /// </summary>
        /// <param name="userInput">User's input</param>
        /// <param name="computerChoice">Computer's input</param>
        /// <param name="result">Results of RPSLS.playGame</param>
        static void displayResults(int userInput, int computerChoice, int result)
        {
            Console.Clear();
            RPSLS results = new RPSLS();
            string computerOutput = results.DisplayChoice(computerChoice); //assign computer's game value to real world value
            string userOutput = results.DisplayChoice(userInput); //assign player's game value to real world value
            string resultOutput = results.DisplayOutcome(result); //assign result's game value to real world value
            Console.WriteLine("You chose: " + userOutput); //displays user's choice
            Console.WriteLine("The computer chose: " + computerOutput); //displays computer's choice
            Console.WriteLine(resultOutput); //displays result of game
            Console.WriteLine();
        }

        /// <summary>
        /// Confirms a user's selection
        /// </summary>
        /// <param name="type">message to add. IE exit, clear results, etc.</param>
        /// <returns>True or False</returns>
        static Boolean confirm(string type)
        {
            bool result;
            Console.Clear();
            Console.WriteLine("Are you sure you want to " + type + "?");
            Console.Write("Please type Y or N and hit enter.");   // Added this to give the user what keys to hit, to confirm exit.
            int userInput = inputHandeler();

            while (!(Enum.IsDefined(typeof(RPSLS.Confirm), userInput)))
            {
                Console.Clear();
                Console.WriteLine();
                Console.Write("Invalid Input. Please type Y or N, and hit enter.");  // Prompt the user to enter valid input.
                userInput = inputHandeler();
            }

            if (userInput == (int)RPSLS.Confirm.No)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}
