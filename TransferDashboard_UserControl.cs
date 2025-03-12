using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VolleyballRecruitmentApp
{
    public partial class TransferDashboard_UserControl : UserControl
    {
        private static TransferDashboard_UserControl? instance;
        public static TransferDashboard_UserControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TransferDashboard_UserControl();
                }
                return instance;
            }
        }

        // MySQL connection string
        private string mysqlcon = "server=localhost;database=volleyballrecruitmentagency;user=root;password=;port=3307";


        public TransferDashboard_UserControl()
        {
            InitializeComponent();
            this.Load += TransferDashboard_UserControl_Load;
        }

        private void TransferDashboard_UserControl_Load(object sender, EventArgs e)
        {
            lblWelcomeTransfer.Text = "Welcome to the Recruitment Dashboard!";
            lblInfo.Text = "Filter and view teams based on country and team name.";

            LoadCountries();  // Load unique countries into the ComboBox
            LoadTeams();      // Load all teams initially
        }

        // Method to load unique countries into the ComboBox
        private void LoadCountries()
        {
            using (var connection = new MySqlConnection(mysqlcon))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT DISTINCT Country FROM teams", connection);
                using (var reader = command.ExecuteReader())
                {
                    cmbCountry.Items.Add("All"); // Default option for no filter
                    while (reader.Read())
                    {
                        cmbCountry.Items.Add(reader["Country"].ToString());
                    }
                }
            }
            cmbCountry.SelectedIndex = 0; // Select "All" by default
        }

        // Method to load teams based on optional filters
        private void LoadTeams(string country = "All", string teamName = "")
        {
            using (var connection = new MySqlConnection(mysqlcon))
            {
                connection.Open();
                var query = "SELECT TeamName, Category, Country FROM teams WHERE 1=1";

                if (country != "All")
                {
                    query += " AND Country = @Country";
                }

                if (!string.IsNullOrEmpty(teamName))
                {
                    query += " AND TeamName LIKE @TeamName";
                }

                using (var command = new MySqlCommand(query, connection))
                {
                    if (country != "All")
                    {
                        command.Parameters.AddWithValue("@Country", country);
                    }

                    if (!string.IsNullOrEmpty(teamName))
                    {
                        command.Parameters.AddWithValue("@TeamName", "%" + teamName + "%");
                    }

                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Remove the TeamID column if it exists (it should not be part of the query)
                        if (dataTable.Columns.Contains("TeamID"))
                        {
                            dataTable.Columns.Remove("TeamID");
                        }

                        dataGridTransfers.DataSource = dataTable;
                    }
                }
            }
        }

        // Event handler for filter button click
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedCountry = cmbCountry.SelectedItem?.ToString() ?? "All";
            string teamName = txtTeamName.Text.Trim();
            LoadTeams(selectedCountry, teamName);
        }

        // Event handler for "I am interested" button click (empty for now)
        private void btnInterested_Click(object sender, EventArgs e)
        {
            // Placeholder for future functionality
        }
    }
}
