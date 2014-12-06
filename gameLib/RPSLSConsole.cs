using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    /// <summary>
    /// RPSLSConsole inherits from RPSLS base class.
    /// </summary>
    public class RPSLSConsole : RPSLS

    {
        /// <summary>
        /// This is a derive class from RPSConsole. The "new" keyword hides the old method that's inherited from
        /// the base class. The new method includes Lizard and Spock.
        /// </summary>
        public new void ShowWelcomeMessage()  
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*        Welcome to  Rock,  Paper, Scissors, Lizard, Spock  Game!          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
        }

        /// <summary>
        /// This is a derive class from RPSConsole. The "new" keyword hides the old method that'a inherited from
        /// the base class. The new method includes Lizard and Spock.
        /// </summary>
        public new void ShowGameMenu() 
        {
            Console.WriteLine();
            Console.WriteLine("^TO PLAY: Press R=Rock, P=Paper, S=Scissors, Lizard=L, K=Spock, E=Exit Game^");
            Console.WriteLine("...........................................................................");
        }
    }
}
