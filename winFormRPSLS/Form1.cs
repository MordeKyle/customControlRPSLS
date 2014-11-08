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
    public partial class RPSLS_Form : Form
    {
        int userChoice = -1;

        //TODO: Reference the display outcome in the library to get the outcome status below
        static string win = "You Win!";
        static string lose = "You Lose!";
        static string draw = "It's a Draw!";

        public RPSLS_Form()
        {
            InitializeComponent();
            userChoiceLbl.Text = String.Empty; //empties label
            computerChoiceLbl.Text = String.Empty; //empties label
            resultLbl.Text = String.Empty; //empties label
            //label2.Text = String.Empty; //empties label
            RPSLS results = new RPSLS();
            winsLbl.Text = results.readResults(win).ToString(); //prints past wins
            losesLbl.Text = results.readResults(lose).ToString(); //prints past loses
            drawsLbl.Text = results.readResults(draw).ToString(); //prints past draws
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
            //MessageBox.Show(userInput.ToString());
            string resultOut; //declare string result holder for display
            string computerChoiceOut; //declare string computerChoice holder for display
            result = play.playGame(userInput); //play the game, return win lose or draw
            computerChoice = play.ComputerChoice; //return the computer's choice
            resultOut = play.DisplayOutcome(result); //return real world value
            computerChoiceOut = play.DisplayChoice(computerChoice); //return real world value
            displayResults(computerChoiceOut, resultOut); //pass user choice, computer choice, and result of game to be displayed
            play.recordResults(resultOut); //record result of game to result file

            winsLbl.Text  = play.readResults(win).ToString(); //print wins
            losesLbl.Text = play.readResults(lose).ToString(); //print loses
            drawsLbl.Text = play.readResults(draw).ToString(); //print draws

            // Display user input
            // TODO: Create a method to display user, computer choice, and results
            userChoiceLbl.Text = play.DisplayChoice(userInput);
        }
        private void displayResults(string computerChoice, string result)
        {
            computerChoiceLbl.Text = computerChoice;
            userChoiceLbl.Text = userChoice.ToString();
            resultLbl.Text = result;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //shows message box with yes and no buttons to confirm exit.
            var confirm = MessageBox.Show("Are you sure you want to erase your result history?", "Erase History Confirmation", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                RPSLS clear = new RPSLS();
                clear.clearHistory();
                winsLbl.Text = "0"; //update labels
                losesLbl.Text = "0";
                drawsLbl.Text = "0";
            }
            else
            {

            }
        }



    }
}
