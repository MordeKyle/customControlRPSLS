using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    /// <summary>
    /// RPSConsole inherits from RPS base class.
    /// </summary>
    public class RPSConsole : RPS
    {
        /// <summary>
        /// Helper method to show welcome message when the game is played.
        /// "virtual" keyword is used so that derived classes can do an override.
        /// </summary>
        public void ShowWelcomeMessage()   // Good candidate for game class, should be set to abstract when done so.
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*               Welcome to  Rock,  Paper, Scissors,  Game!               *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
        }
        /// <summary>
        /// Helper method to show game menu to play the game.
        ///  "virtual" keyword is used so that derived classes can do an override.
        /// </summary>
        public void ShowGameMenu() 
        {
            Console.WriteLine();
            Console.WriteLine("^^^^^^^^TO PLAY: Press R=Rock, P=Paper, S=Scissors, E=Exit Game^^^^^^^^^^^");
            Console.WriteLine("..........................................................................");
        }

        public void DisplayResults() //TODO: Check if this is required in WPF and WinForms If so, move it to RPS
        {
            Console.Clear();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("                Your Choice       :" + DisplayChoice(PlayerChoice));
            Console.WriteLine("                Computer's Choice :" + DisplayChoice(ComputerChoice));
            Console.WriteLine("                OUTCOME           :" + DisplayOutcome(DetermineOutcome()));
            Console.WriteLine("**************************************************************************");
            Console.WriteLine();
        }
    }
}
