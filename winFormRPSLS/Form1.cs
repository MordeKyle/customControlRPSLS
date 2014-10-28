using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;

namespace winFormRPSLS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //TODO: With results available, add initial display of past results here.
        }

        private int userChoice = -1;

        private void rockBtn_Click(object sender, EventArgs e)
        {
            userChoice = (int)RPSLS.Choice.Rock;
        }

        private void paperBtn_Click(object sender, EventArgs e)
        {
            userChoice = (int)RPSLS.Choice.Paper;
        }

        private void scissorsBtn_Click(object sender, EventArgs e)
        {
            userChoice = (int)RPSLS.Choice.Scissors;
        }

        private void lizardBtn_Click(object sender, EventArgs e)
        {
            userChoice = (int)RPSLS.Choice.Lizard;
        }

        private void spockBtn_Click(object sender, EventArgs e)
        {
            userChoice = (int)RPSLS.Choice.Spock;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }

        private static void playGame(int userInput)
        {
            RPSLS play = new RPSLS();
            int result; //delcare result holder
            int computerChoice; //declare computer choice holder
            result = play.playGame(userInput); //play the game, return win lose or draw
            computerChoice = play.ComputerChoice; //return the computer's choice
            displayResults(userInput, computerChoice, result); //pass user choice, computer choice, and result of game to be displayed

        }
        private static void displayResults(int userInput, int computerChoice, int result)
        {

        }
    }
}
