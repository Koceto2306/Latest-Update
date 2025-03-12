using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VolleyballRecruitmentApp
{
    public partial class Dashboard_UserControl : UserControl
    {
        // Singleton instance for Dashboard_UserControl
        private static Dashboard_UserControl? instance;

        public static Dashboard_UserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Dashboard_UserControl();
                }
                return instance;
            }
        }

        // MySQL connection string for the database
        private string mysqlcon = "server=localhost;database=volleyballrecruitmentagency;user=root;password=;port=3307";


        // Constructor
        public Dashboard_UserControl()
        {
            InitializeComponent();
        }

        // Event handler for when the control loads
        private void Dashboard_UserControl_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to the Player Dashboard!";

            // Automatically load player details based on logged-in user
            if (string.IsNullOrEmpty(UserSession.LoggedInUsername))
            {
                MessageBox.Show("No logged-in user found.");
                return;
            }

            LoadPlayerDetails(UserSession.LoggedInUsername);
        }

        // Method to load player details based on username
        public void LoadPlayerDetails(string username)
        {
            string query = @"
                SELECT p.FirstName, p.MiddleName, p.LastName, p.BirthDate, p.Position, p.Height, p.Weight, u.Email 
                FROM users p
                JOIN users u ON p.UserID = u.UserID
                WHERE u.Username = @Username";

            using (MySqlConnection connection = new MySqlConnection(mysqlcon))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Extract player details
                            string firstName = reader["FirstName"]?.ToString() ?? "N/A";
                            string middleName = reader["MiddleName"]?.ToString() ?? "N/A";
                            string lastName = reader["LastName"]?.ToString() ?? "N/A";
                            DateTime BirthDate = reader["BirthDate"] as DateTime? ?? DateTime.MinValue;
                            string position = reader["Position"]?.ToString() ?? "N/A";
                            string height = reader["Height"]?.ToString() ?? "N/A";
                            string weight = reader["Weight"]?.ToString() ?? "N/A";
                            string email = reader["Email"]?.ToString() ?? "N/A";

                            // Display in labels
                            lblPlayerName.Text = $"Player Name: {firstName} {middleName} {lastName}";
                            lblTeam.Text = $"Email: {email}";
                            lblPosition.Text = $"Position: {position}";
                            lblAge.Text = $"Date of Birth: {BirthDate.ToShortDateString()}";
                            lblHeight.Text = $"Height: {height} cm | Weight: {weight} kg";
                        }
                        else
                        {
                            MessageBox.Show("Player not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving data: {ex.Message}");
                }
            }
        }

        private void lblPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
