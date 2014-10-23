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
            // sample output from main
            Console.WriteLine("Hello, world! from Main.");
            // sample call from game library
            RPSLS classCall = new RPSLS();
            classCall.SampleClassCall();

            Console.ReadLine();
        }
    }
}
