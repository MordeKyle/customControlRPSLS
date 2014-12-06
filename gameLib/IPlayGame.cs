using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    interface IPlayGame
    {
        /// <summary>
        /// Sets a contract to implement DetermineOutcome to classes that implements IPlayGame to 
        /// hace DetermineOutcome method.
        /// </summary>
        /// <returns>The game outcome: WIN, LOSE, DRAW</returns>
        int DetermineOutcome();
    }
}
