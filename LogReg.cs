using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VolleyballRecruitmentApp
{
    public partial class LogReg : Form
    {
        private string mysqlcon;

        public LogReg()
        {
            InitializeComponent();
            // MySQL Connection String
            mysqlcon = "server=localhost;database=volleyballrecruitmentagency;user=root;password=;port=3307";
        }

        private void LogReg_Load(object sender, EventArgs e)
        {
            // Set up the form's appearance and dynamic controls positioning
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(750, 530);

            // Initially, show login view
            ShowLoginView();
        }

        private void ShowLoginView()
        {
            // Hide registration-specific fields and show login
            lblEmail.Visible = false;
            txtEmail.Visible = false;
            btnRegister.Visible = false;
            btnLogin.Visible = true;
            linkSignUp.Visible = true;
            linkSignIn.Visible = false;
        }

        private void ShowRegistrationView()
        {
            // Show registration-specific fields and hide login
            lblEmail.Visible = true;
            txtEmail.Visible = true;
            btnRegister.Visible = true;
            btnLogin.Visible = false;
            linkSignUp.Visible = false;
            linkSignIn.Visible = true;
        }

        // Event handler for linkSignUp LinkClicked
        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkSignUp.LinkVisited = true; // Mark the link as visited
            ShowRegistrationView(); // Switch to registration view
        }

        // Event handler for linkSignIn LinkClicked
        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkSignIn.LinkVisited = true; // Mark the link as visited
            ShowLoginView(); // Switch to login view
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both username and password.");
                return;
            }

            string userType = AuthenticateUser(username, password);

            if (!string.IsNullOrEmpty(userType))
            {
                // Store the username in session or global variable (like UserSession)
                UserSession.LoggedInUsername = username;
                MessageBox.Show("Login successful!");

                // Redirect based on user type
                if (userType == "Player")
                {
                    RedirectToUserLogin(username);
                }
                else if (userType == "Coach" || userType == "Scout")
                {
                    RedirectToCoachScout();
                }
                else
                {
                    MessageBox.Show("Unrecognized user type.");
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private string AuthenticateUser(string username, string password)
        {
            string query = "SELECT UserType FROM Users WHERE Username=@Username AND PasswordHash=SHA2(@Password, 256)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();
                        return result?.ToString(); // Return the UserType
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during authentication: {ex.Message}");
                return null;
            }
        }

        private void RedirectToUserLogin(string username)
        {
            UserLogin userLoginForm = new UserLogin(username);
            userLoginForm.Show();
            userLoginForm.WindowState = FormWindowState.Maximized;
        }

        private void RedirectToCoachScout()
        {
            CoachScout coachScoutForm = new CoachScout();
            coachScoutForm.Show();
            coachScoutForm.WindowState = FormWindowState.Maximized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (username.Length < 5)
            {
                MessageBox.Show("Username must be at least 5 characters long.");
                return;
            }

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must be at least 8 characters long, include at least one uppercase letter, and at least one symbol.");
                return;
            }

            if (IsUsernameTaken(username))
            {
                MessageBox.Show("Username already taken. Please choose a different username.");
                return;
            }

            if (RegisterUser(username, password, email))
            {
                MessageBox.Show("Registration successful! Redirecting to Player Details...");
                PlayerDetails playerDetailsForm = new PlayerDetails(mysqlcon, username);
                playerDetailsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }

        private bool IsPasswordValid(string password)
        {
            string passwordPattern = @"^(?=.*[A-Z])(?=.*\W).{8,}$";
            return new Regex(passwordPattern).IsMatch(password);
        }

        private bool IsUsernameTaken(string username)
        {
            string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking username availability: {ex.Message}");
                return false;
            }
        }

        private bool RegisterUser(string username, string password, string email)
        {
            string query = "INSERT INTO Users (Username, PasswordHash, Email, UserType) VALUES (@Username, SHA2(@Password, 256), @Email, 'Player')";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlcon))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}");
                return false;
            }
        }

        // Event handler for txtUsername TextChanged
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for any action when the username is typed
        }

        // Event handler for txtPassword TextChanged
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for any action when the password is typed
        }

        // Event handler for txtEmail TextChanged
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for any action when the email is typed
        }

        // Event handler for lblUsername Click
        private void lblUsername_Click(object sender, EventArgs e)
        {
            // Placeholder for any action when the username label is clicked
        }

        // Event handler for lblPassword Click
        private void lblPassword_Click(object sender, EventArgs e)
        {
            // Placeholder for any action when the password label is clicked
        }

        // Event handler for lblEmail Click
        private void lblEmail_Click(object sender, EventArgs e)
        {
            // Placeholder for any action when the email label is clicked
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
