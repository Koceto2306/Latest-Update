using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VolleyballRecruitmentApp
{
    public partial class UserLogin : Form
    {
        private string mysqlcon;
        private string username;

        public UserLogin(string loggedInUsername)
        {
            InitializeComponent();
            mysqlcon = "server=localhost;database=volleyballrecruitmentagency;user=root;password=;port=3307";
            username = loggedInUsername;

            // Add button click event handlers
            btDashboard.Click += btDashboard_Click;
            btNotifications.Click += btNotifications_Click;
            btTransfer.Click += btTransfer_Click;
            btSupport.Click += btSupport_Click;

            ShowDashboard();
        }

        public UserLogin() => InitializeComponent();

        private void btDashboard_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            ShowDashboard();
            menuChange(btDashboard);
        }

        private void btNotifications_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Controls.Clear();
            LoadNotifications();
            menuChange(btNotifications);
        }

        private void btTransfer_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.Controls.Clear();

            if (!panel2.Controls.Contains(TransferDashboard_UserControl.Instance))
            {
                TransferDashboard_UserControl.Instance.Dock = DockStyle.Fill;
                panel2.Controls.Add(TransferDashboard_UserControl.Instance);
            }

            TransferDashboard_UserControl.Instance.BringToFront();
            TransferDashboard_UserControl.Instance.Focus();
            menuChange(btTransfer);
        }

        private void btSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Support section is under construction.");
            menuChange(btSupport);
        }

        private void ShowDashboard()
        {
            panel1.Controls.Clear();

            if (!panel1.Controls.Contains(Dashboard_UserControl.Instance))
            {
                Dashboard_UserControl.Instance.Dock = DockStyle.Fill;
                panel1.Controls.Add(Dashboard_UserControl.Instance);
            }

            Dashboard_UserControl.Instance.BringToFront();
            Dashboard_UserControl.Instance.Focus();
        }

        private void LoadNotifications()
        {
            string query = "SELECT Message, Timestamp FROM Notifications WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username) ORDER BY Timestamp DESC";
            MySqlConnection conn = new MySqlConnection(mysqlcon);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                MySqlDataReader reader = cmd.ExecuteReader();
                ListBox notificationList = new ListBox
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 12),
                    ForeColor = Color.Black
                };

                if (!reader.HasRows)
                {
                    notificationList.Items.Add("No notifications found.");
                }

                while (reader.Read())
                {
                    string message = reader.GetString("Message");
                    string timestamp = reader.GetDateTime("Timestamp").ToString("g");
                    notificationList.Items.Add($"{timestamp}: {message}");
                }

                panel2.Controls.Add(notificationList);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notifications: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void menuChange(Button btn)
        {
            foreach (Button menuButton in panel3.Controls.OfType<Button>())
            {
                menuButton.BackColor = (menuButton == btn) ? Color.LightSteelBlue : Color.SteelBlue;
            }
            GC.Collect();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Add your logic for picture box click here
        }

        private void btNotifications_Click_1(object sender, EventArgs e)
        {

        }

        private void btDashboard_Click_1(object sender, EventArgs e)
        {

        }

        private void btTransfer_Click_1(object sender, EventArgs e)
        {

        }
    }
}
