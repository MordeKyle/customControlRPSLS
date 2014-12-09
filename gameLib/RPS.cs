using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLibrary
{
    public class RPS : IChoice, IPlayGame
    {
        /// <summary>
        /// Declare an enum whose members are of type int. Enumeration members will, however, be explicitly 
        /// converted to type "int" by using a cast.
        /// </summary>
        public enum Choice: int { Rock = 0, Paper = 1, Scissors = 2, Exit = 5 }
        public enum Outcome: int { Win = 10, Lose = 11, Draw = 12 }
        public enum Confirm { Yes = 20, No = 21 } //enums for confirmation messages.

        /// <summary>
        /// Implement IChoice: playerChoice interface.
        /// </summary>
        private int playerChoice;       // Backing field for player choice
        public int PlayerChoice         // Set the property for player choice

        {
            get
            {
                return playerChoice;
            }
            set
            {
                playerChoice = value;
            }
        }

        /// <summary>
        /// Implement IChoice: computerChoice interface.
        /// </summary>
        protected int computerChoice;     // Backing field for computer choice // Use protected keyword so that it will be inherited when overrided
        public virtual int ComputerChoice       // Set the property for computer choice
        {
            get
            {
                Random num = new Random();
                computerChoice = num.Next(3);
                return computerChoice;
            }
        }

        /// <summary>
        /// Takes game value and returns real world value of selections
        /// </summary>
        /// <param name="choice">Game value of user or computer's choice</param>
        /// <returns>User or computer's choice as real world value</returns>
        public virtual string DisplayChoice(int choice)
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
            }
            return show;
        }

        /// <summary>
        /// Implement IPlayGame: DetermineOutcome interface. 
        /// Should be declared virtual so that derived class can override the 2D array.
        /// </summary>
        public virtual int DetermineOutcome()
        {
            int result;
            int[,] selection = new int[3, 3] {  {(int)Outcome.Draw, (int)Outcome.Lose, (int)Outcome.Win  },
                                                {(int)Outcome.Win,  (int)Outcome.Draw, (int)Outcome.Lose }, 
                                                {(int)Outcome.Lose, (int)Outcome.Win,  (int)Outcome.Draw }};                          
            //result = selection[userInput, computerInput];
            result = selection[PlayerChoice, ComputerChoice];
            return result;
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

    }
}
