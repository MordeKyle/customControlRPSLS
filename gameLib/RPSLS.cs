using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class RPSLS
    {

        public enum Choice {Rock = 0, Paper = 1, Scissors = 2, Lizard = 3, Spock = 4, Exit = 5} //enums for user inputs.
        public enum Outcome {Win = 10, Lose = 11, Draw = 12} //enums for game outcomes.
        public enum Confirm {Yes = 20, No = 21} //enums for confirmation messages.

        private int computerChoice; //declare class level holder for computerChoice to outputted.

        /// <summary>
        /// gets computer's choice and exports it
        /// </summary>
        public int ComputerChoice
        {
            get { return computerChoice; }
        }

        // create a constructor
        // TODO: revised the constructor
        public RPSLS()
        {

        }

        /// <summary>
        /// Generates the computer's choice
        /// </summary>
        /// <returns>Computer's choice as a game value</returns>
        private static int generateComputerChoice()
        {
            Random num = new Random();
            int computerChoice = num.Next(5);
            return computerChoice;
        }
        
        /// <summary>
        /// Takes game value and returns real world value of selections
        /// </summary>
        /// <param name="choice">Game value of user or computer's choice</param>
        /// <returns>User or computer's choice as real world value</returns>
        public string DisplayChoice(int choice)
        {
            string show = "";
            switch (choice)
            {
                case (int)Choice.Rock:
                    show = "ROCK";
                    break;
                case (int)Choice.Paper:
                    show = "PAPER";
                    break;
                case (int)Choice.Scissors:
                    show = "SCISSORS";
                    break;
                case (int)Choice.Lizard:
                    show = "LIZARD";
                    break;
                case (int)Choice.Spock:
                    show = "SPOCK";
                    break;
            }
            return show;
        }

        /// <summary>
        /// Takes result of game as game value and resturns real world value
        /// </summary>
        /// <param name="outcome">game value result of game</param>
        /// <returns>real world value of result of game</returns>
        public string DisplayOutcome(int outcome)
        {
            string result = "";
            switch (outcome)
            {
                case (int)Outcome.Win:
                    result = "You Win!";
                    break;
                case (int)Outcome.Lose:
                    result = "You Lose!";
                    break;
                case (int)Outcome.Draw:
                    result = "It's a Draw!";
                    break;
            }
            return result;
        }

        /// <summary>
        /// Compares the user's and computer's inputs.
        /// </summary>
        /// <param name="userInput">User's input</param>
        /// <param name="computerInput">Computer's input</param>
        /// <returns>Returns the result of the game</returns>
        public int DetermineOutcome(int userInput, int computerInput)
        {
            int result;
            int[,] selection = new int[5, 5] {  {(int)Outcome.Draw, (int)Outcome.Lose, (int)Outcome.Win,  (int)Outcome.Win, (int)Outcome.Lose},
                                                {(int)Outcome.Win,  (int)Outcome.Draw, (int)Outcome.Lose, (int)Outcome.Lose,(int)Outcome.Win }, 
                                                {(int)Outcome.Lose, (int)Outcome.Win,  (int)Outcome.Draw, (int)Outcome.Win, (int)Outcome.Lose},
                                                {(int)Outcome.Lose, (int)Outcome.Win,  (int)Outcome.Lose, (int)Outcome.Draw,(int)Outcome.Win },
                                                {(int)Outcome.Win,  (int)Outcome.Lose, (int)Outcome.Win,  (int)Outcome.Lose,(int)Outcome.Draw}};
            result = selection[userInput, computerInput];
            return result;
        }

        /// <summary>
        /// PLays the game
        /// </summary>
        /// <param name="userInput">game value of user's input</param>
        /// <returns>result of game as game value</returns>
        public int playGame(int userInput)
        {
            int result;
            computerChoice = generateComputerChoice(); //generate computer choice and assign to int
            result = DetermineOutcome(userInput, computerChoice);
            return result;
        }
    }
}
