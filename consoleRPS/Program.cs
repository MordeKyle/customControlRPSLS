using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace consoleRPS
{
    class Program
    {
  
        static void Main(string[] args)
        {
            // Create a new RPS instance to play Rock, Paper, Scissors Game
            RPSConsole play = new RPSConsole();
            play.ShowWelcomeMessage();

            while (true)
            {
                play.ShowGameMenu();
                // Get and set playerChoice
                play.PlayerChoice = GetUserInput();    
                // Validate if user wants to exit
                if (play.PlayerChoice == (int)RPS.Choice.Exit)
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
                // Validate if user input is valid
                else if (!(Enum.IsDefined(typeof(RPS.Choice), play.PlayerChoice))) // Check if input is valid
                {
                    Console.WriteLine("Please enter a valid input!");
                }
                // If input is valid: show choices, determine winner, and record results???
                else
                {
                    play.DisplayResults();
                }
                
            }
        }

        /// <summary>
        /// Confirms a user's selection
        /// </summary>
        /// <param name="type">message to add. IE exit, clear results, etc.</param>
        /// <returns>True or False</returns>
        private static Boolean confirm(string type)
        {
            bool result;
            Console.Clear();
            Console.WriteLine("Are you sure you want to " + type + "?");
            Console.Write("Please type Y or N and hit enter.");   // Added this to give the user what keys to hit, to confirm exit.
            //int userInput = play.GetUserInput();
            int userInput = GetUserInput();
 
            while (!(Enum.IsDefined(typeof(RPSLS.Confirm), userInput)))
            {
                Console.Clear();
                Console.WriteLine();
                Console.Write("Invalid Input. Please type Y or N, and hit enter.");  // Prompt the user to enter valid input.
                //userInput = inputHandeler();
            }
           
            if (userInput == (int)RPSConsole.Confirm.No)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
             
        }


        public static int GetUserInput()  
        {
            Console.WriteLine();
            Console.Write("ENTER CHOICE: ");
            string input = "";
            input = (Console.ReadLine().ToUpper()); 

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
    }
}
