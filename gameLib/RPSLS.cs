using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLibrary
{
    public class RPSLS : RPSConsole
    {
        /// <summary>
        /// Enums declared in RPS cannot be inherited. The "new" keyword is used to hide inherited member and define a new enum.
        /// </summary>
        public new enum Choice {Rock = 0, Paper = 1, Scissors = 2, Lizard = 3, Spock = 4, Exit = 5} //enums for user inputs.
        //public new enum Outcome {Win = 10, Lose = 11, Draw = 12} //enums for game outcomes.
        //public enum Confirm {Yes = 20, No = 21} //enums for confirmation messages.

        // create a constructor
        // TODO: revised the constructor
        public RPSLS() { }

        /// <summary>
        /// Implement the computer choice interface. The override keyword is used to change the number of
        /// random numbers from 3 to 5 to play RPSLS.
        /// </summary>
        private int computerChoice;     // Backing field for computer choice
        public override int ComputerChoice       // Set the property for computer choice
        {
            get 
            {
                Random num = new Random();
                computerChoice = num.Next(5);
                return computerChoice; 
            }
        }

        /// <summary>
        /// Takes game value and returns real world value of selections
        /// </summary>
        /// <param name="choice">Game value of user or computer's choice</param>
        /// <returns>User or computer's choice as real world value</returns>
        public override string DisplayChoice(int choice)
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
        /*public string DisplayOutcome(int outcome)
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
        }*/

        /// <summary>
        /// Compares the user's and computer's inputs.
        /// </summary>
        /// <param name="userInput">User's input</param>
        /// <param name="computerInput">Computer's input</param>
        /// <returns>Returns the result of the game</returns>
        public override int DetermineOutcome()
        {
            int result;
            int[,] selection = new int[5, 5] {  {(int)Outcome.Draw, (int)Outcome.Lose, (int)Outcome.Win,  (int)Outcome.Win, (int)Outcome.Lose},
                                                {(int)Outcome.Win,  (int)Outcome.Draw, (int)Outcome.Lose, (int)Outcome.Lose,(int)Outcome.Win }, 
                                                {(int)Outcome.Lose, (int)Outcome.Win,  (int)Outcome.Draw, (int)Outcome.Win, (int)Outcome.Lose},
                                                {(int)Outcome.Lose, (int)Outcome.Win,  (int)Outcome.Lose, (int)Outcome.Draw,(int)Outcome.Win },
                                                {(int)Outcome.Win,  (int)Outcome.Lose, (int)Outcome.Win,  (int)Outcome.Lose,(int)Outcome.Draw}};
            result = selection[PlayerChoice, ComputerChoice];
            return result;
        }

        /// <summary>
        /// PLays the game
        /// </summary>
        /// <param name="userInput">game value of user's input</param>
        /// <returns>result of game as game value</returns>
        /*
        public int playGame(int userInput)
        {
            int result;
            //computerChoice = generateComputerChoice(); //generate computer choice and assign to int
            result = DetermineOutcome(userInput, ComputerChoice);
            return result;
        }
        */
        public void recordResults(string result)
        {
            const string resultFile = "../../Results.txt";
            StreamWriter outputFile;
            outputFile = File.AppendText(resultFile);
            outputFile.WriteLine(result);
            outputFile.Close();
        }
        public int readResults(string result)
        {
            //declaring output
            int resultTotal = 0;
            //declaring location of resultFile
            const string resultFile = "../../Results.txt";

            //declaring streamreader
            StreamReader inputFile;
            //streamreading the results file
            inputFile = File.OpenText(resultFile);

            string readLine;

            while (inputFile.EndOfStream == false)  //loop to count how many times win, lose, or draw is in the file
            {
                readLine = inputFile.ReadLine();

                if (readLine == result)     //checks to se if each line is equal to win, lose, or draw
                {
                    ++resultTotal;   //if so, add 1 to the counter
                }
            }
            inputFile.Close();

            return resultTotal;     //output the counter, as it is equal to how many wins, loses, or draws
        }

        public void clearHistory()
        {
            const string resultFile = "../../Results.txt";
            File.WriteAllText(resultFile, string.Empty);
        }
    }
}
