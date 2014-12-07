using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GameLibrary;
using System.Data;
using System.Data.SqlClient;

namespace WPF_RPSLS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int playerChoice = -1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, RoutedEventArgs e)
        {
            playerChoice = (int)RPSLS.Choice.Rock;
            PlayGame(playerChoice);
        }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            playerChoice = (int)RPSLS.Choice.Paper;
            PlayGame(playerChoice);
        }

        private void btnScissors_Click(object sender, RoutedEventArgs e)
        {
           playerChoice = (int)RPSLS.Choice.Scissors;
           PlayGame(playerChoice);
        }

        private void btnLizard_Click(object sender, RoutedEventArgs e)
        {
            playerChoice = (int)RPSLS.Choice.Lizard;
            PlayGame(playerChoice);
        }

        private void btnSpock_Click(object sender, RoutedEventArgs e)
        {
            playerChoice = (int)RPSLS.Choice.Spock;
            PlayGame(playerChoice);
        }

        private void PlayGame(int player)
        {
            RPSLS play = new RPSLS();
            // Get and set player choice
            play.PlayerChoice = player;


            tbPlayerChoice.Text = play.DisplayChoice(play.PlayerChoice);
            tbComputerChoice.Text = play.DisplayChoice(play.ComputerChoice);
            tbResult.Text = play.DisplayOutcome(play.DetermineOutcome());

            string pChoice = play.DisplayChoice(play.PlayerChoice);
            string cChoice = play.DisplayChoice(play.ComputerChoice);
            string gOutcome = play.DisplayOutcome(play.DetermineOutcome());

            // Record results to text file
            play.recordResults(play.DisplayOutcome(play.DetermineOutcome())); 

            // Display stats
            string win = "You Win!";
            string lose = "You Lose!";
            string draw = "It's a Draw!";
            tbWinCount.Text = play.readResults(win).ToString();
            tbLoseCount.Text = play.readResults(lose).ToString();
            tbDrawCount.Text = play.readResults(draw).ToString();

            string playerChoiceString = playerChoice.ToString();
            
            // Record result to database
            // TODO: This is totally unsafe, connection must be saved in app.config file.
            SqlConnection db = new SqlConnection();
            db.ConnectionString = "Data Source=198.###.###.###;" +
                                    "Initial Catalog=########;" +
                                    "User id=#########;" +
                                    "Password=#############;";
            db.Open();

            try
            {
                string sql = "INSERT INTO RPSLS(PlayerChoice, ComputerChoice, Outcome) VALUES(@player, @computer, @outcome)";
                SqlCommand exec = new SqlCommand(sql, db);
                //exec.Parameters.Add("@player", pChoice);
                exec.Parameters.AddWithValue("@player", pChoice);
                //exec.Parameters.Add("@computer", cChoice);
                exec.Parameters.AddWithValue("@computer", cChoice);
                //exec.Parameters.Add("@outcome", gOutcome);
                exec.Parameters.AddWithValue("@outcome", gOutcome);
                //db.Open();
                exec.ExecuteNonQuery();

                MessageBox.Show("Added Record", "Message", MessageBoxButton.OK);

                // Retrieve data to MessageBox
                SqlCommand cmd = new SqlCommand("Select Count(Outcome) from RPSLS where Outcome='You Win!'", db);
                Int32 count = (Int32)cmd.ExecuteScalar();

                MessageBox.Show(count.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
            finally
            {
                db.Close();
            }
            
        }
    }
}
