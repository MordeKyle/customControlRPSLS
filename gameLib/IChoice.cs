using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    interface IChoice
    {
        // Every class that implements IChoice needs to have playerChoice and computerChoice
        int PlayerChoice { get; set; }
        int ComputerChoice { get; }
    }
}
