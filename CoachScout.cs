using MySql.Data.MySqlClient;
using System.Data;

namespace VolleyballRecruitmentApp
{
    public partial class CoachScout : Form
    {
        private readonly string username;

        // Constructor to initialize the form and database connection
        public CoachScout(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;

            // Bind button click events
            DashboardBt.Click += DashboardBt_Click;
            PlayersBt.Click += PlayersBt_Click_1; // Bind PlayersBt to the new method

            // Show the dashboard by default
            ShowDashboard();
        }

        // Default constructor for designer use (if necessary)
        public CoachScout() => InitializeComponent();

        // Show the Dashboard when the Dashboard button is clicked
        private void DashboardBt_Click(object sender, EventArgs e)
        {
            // Show panel1 and hide panel2
            panel1.Visible = true;
            panel2.Visible = false;

            ShowDashboard();
            menuChange(DashboardBt);
        }

        // Show the Players section when the Players button is clicked
        private void PlayersBt_Click_1(object sender, EventArgs e)
        {
            // Hide panel1 and show panel2 (Players Panel)
            panel1.Visible = false;
            panel2.Visible = true;

            // Clear any existing controls in panel2
            panel2.Controls.Clear();

            try
            {
                string query = @"SELECT FirstName, LastName, Height, Weight, Email, Position, BirthDate 
                                 FROM users WHERE UserType = 'Player'";

                using (MySqlCommand command = new MySqlCommand(query, DataBase.Instance.Connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable usersTable = new DataTable();
                    adapter.Fill(usersTable);

                    List<Player> playersList = usersTable.AsEnumerable().Select(row => new Player
                    {
                        Name = row.Field<string>("FirstName") + " " + row.Field<string>("LastName"),
                        Position = row.Field<string>("Position"),
                        Height = row.Field<string>("Height"),
                        Weight = row.Field<string>("Weight"),
                        Email = row.Field<string>("Email"),
                        BirthDate = row.Field<DateTime>("BirthDate")
                    }).ToList();

                    // Populate the Players ComboBox
                    PlayersComboBox.Items.Clear();
                    foreach (var player in playersList)
                    {
                        PlayersComboBox.Items.Add(player);
                    }

                    // Handle the event when a player is selected
                    PlayersComboBox.SelectedIndexChanged += (s, e) =>
                    {
                        var selectedPlayer = PlayersComboBox.SelectedItem as Player;
                        if (selectedPlayer != null)
                        {
                            lblPlayerHeight.Text = $"Height: {selectedPlayer.Height}";
                            lblPlayerWeight.Text = $"Weight: {selectedPlayer.Weight}";
                            lblPlayerEmail.Text = $"Email: {selectedPlayer.Email}";
                            lblPlayerPosition.Text = $"Position: {selectedPlayer.Position}";
                            lblPlayerBirthDate.Text = $"Birth Date: {selectedPlayer.BirthDate.ToShortDateString()}";
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading players: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Optional: Update button appearance for navigation
            menuChange(PlayersBt);
        }

        // Method to show the dashboard content (just a placeholder for now)
        private void ShowDashboard()
        {
            panel1.Controls.Clear();
            Label dashboardLabel = new Label
            {
                Text = "Dashboard Coming Soon...",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 20, FontStyle.Bold)
            };
            panel1.Controls.Add(dashboardLabel);
        }

        // Method to update the menu button colors when clicked
        private void menuChange(Button btn)
        {
            foreach (Button menuButton in panelTop.Controls.OfType<Button>())
            {
                menuButton.BackColor = (menuButton == btn) ? Color.RoyalBlue : Color.MidnightBlue;
            }
            GC.Collect();
        }
    }

    // Player class to store player details
    public class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
