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
        int userChoice = -1;

        public Form1()
        {
            InitializeComponent();
            userChoiceLbl.Text = String.Empty;
            computerChoiceLbl.Text = String.Empty;
            resultLbl.Text = String.Empty;
            label2.Text = String.Empty;
            //TODO: With results file available, add initial display of past results here.
        }

        private void rockBtn_Click(object sender, EventArgs e)
        {
            userChoice = (int)RPSLS.Choice.Rock;
            playGame(userChoice);
        }

        private void paperBtn_Click(object sender, EventArgs e)
        {
            userChoice = (int)RPSLS.Choice.Paper;
            playGame(userChoice);
        }

        private void scissorsBtn_Click(object sender, EventArgs e)
        {
            userChoice = (int)RPSLS.Choice.Scissors;
            playGame(userChoice);
        }

        private void lizardBtn_Click(object sender, EventArgs e)
        {
            userChoice = (int)RPSLS.Choice.Lizard;
            playGame(userChoice);
        }

        private void spockBtn_Click(object sender, EventArgs e)
        {
            userChoice = (int)RPSLS.Choice.Spock;
            playGame(userChoice);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //shows message box with yes and no buttons to confirm exit.
            var confirm = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {

            }
        }

        private void playGame(int userInput)
        {
            RPSLS play = new RPSLS();
            int result; //delcare result holder
            int computerChoice; //declare computer choice holder
            string resultOut; //declare string result holder for display
            string computerChoiceOut; //declare string computerChoice holder for display
            result = play.playGame(userInput); //play the game, return win lose or draw
            computerChoice = play.ComputerChoice; //return the computer's choice
            resultOut = play.DisplayOutcome(result); //return real world value
            computerChoiceOut = play.DisplayChoice(computerChoice); //return real world value
            displayResults(computerChoiceOut, resultOut); //pass user choice, computer choice, and result of game to be displayed
            play.recordResults(resultOut);
        }
        private void displayResults(string computerChoice, string result)
        {
            computerChoiceLbl.Text = computerChoice;
            resultLbl.Text = result;
        }
    }
}
