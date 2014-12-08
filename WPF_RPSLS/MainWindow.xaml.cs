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
            
            // Record result to database
            // TODO: This is totally unsafe, connection string must be saved in app.config file.
            SqlConnection db = new SqlConnection();
            db.ConnectionString = "Data Source=###.###.###.###;" +
                                    "Initial Catalog=#######;" +
                                    "User id=########;" +
                                    "Password=#############;";
            db.Open();

            try
            {
                // Insert data into the database
                string sql = "INSERT INTO RPSLS(PlayerChoice, ComputerChoice, Outcome) VALUES(@player, @computer, @outcome)";
                SqlCommand exec = new SqlCommand(sql, db);
                exec.Parameters.AddWithValue("@player", pChoice);
                exec.Parameters.AddWithValue("@computer", cChoice);
                exec.Parameters.AddWithValue("@outcome", gOutcome);
                exec.ExecuteNonQuery();

                //MessageBox.Show("Added Record", "Message", MessageBoxButton.OK);

                // Retrieve win count from database
                SqlCommand cmdWin = new SqlCommand("Select Count(Outcome) from RPSLS where Outcome='You Win!'", db);
                Int32 winCount = (Int32)cmdWin.ExecuteScalar();
                tbWinCount.Text = winCount.ToString();
                // Retrieve lose count from database
                SqlCommand cmdLose = new SqlCommand("Select Count(Outcome) from RPSLS where Outcome='You Lose!'", db);
                Int32 loseCount = (Int32)cmdLose.ExecuteScalar();
                tbLoseCount.Text = loseCount.ToString();
                // Retrieve raw count from database
                SqlCommand cmdDraw = new SqlCommand("Select Count(Outcome) from RPSLS where Outcome='It''s a Draw!'", db);
                Int32 drawCount = (Int32)cmdDraw.ExecuteScalar();
                tbDrawCount.Text = drawCount.ToString();

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
