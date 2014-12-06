using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    interface IChoice
    {
        /// <summary>
        /// Sets a contract to classes that implement IChoice to have playerChoice and computerChoice.
        /// This will be implemented in RPS and will be inherited in RPSLS.
        /// </summary>
        int PlayerChoice { get; set; }
        int ComputerChoice { get; }
    }
}
