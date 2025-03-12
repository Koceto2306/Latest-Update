using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace VolleyballRecruitmentApp
{
    public partial class PlayerDetails : Form
    {
        private string mysqlcon;
        private string username;
        private string userType;

        public PlayerDetails(string mysqlConnection, string loggedInUsername)
        {
            InitializeComponent();
            mysqlcon = mysqlConnection;
            username = loggedInUsername;
            userType = "Player"; // Default to "Player"

            cmbPosition.Items.AddRange(new string[]
            {
                "Libero",
                "Middle Blocker",
                "Outside Hitter",
                "Opposite Hitter",
                "Setter"
            });

            ShowPlayerFields();
        }

        private void radioButtonPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPlayer.Checked)
            {
                userType = "Player";
                ShowPlayerFields();
            }
        }

        private void radioButtonCoachScout_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCoachScout.Checked)
            {
                userType = "Coach";
                ShowCoachScoutFields();
            }
        }

        private void ShowPlayerFields()
        {
            lblPlayerDetails.Text = "Enter Player Details";

            // Show player-specific fields
            lblFirstName.Visible = true;
            txtFirstName.Visible = true;
            lblMiddleName.Visible = true;
            txtMiddleName.Visible = true;
            lblLastName.Visible = true;
            txtLastName.Visible = true;
            lblBirthDate.Visible = true;
            dtpBirthDate.Visible = true;
            lblPosition.Visible = true;
            cmbPosition.Visible = true;
            lblHeight.Visible = true;
            txtHeight.Visible = true;
            lblWeight.Visible = true;
            txtWeight.Visible = true;

            btnSavePlayerDetails.Visible = true;
            btnSaveCoachScoutDetails.Visible = false;

            ClearFields();
        }

        private void ShowCoachScoutFields()
        {
            lblPlayerDetails.Text = "Enter Coach/Scout Details";

            // Hide player-specific fields
            lblFirstName.Visible = true;
            txtFirstName.Visible = true;
            lblMiddleName.Visible = true;
            txtMiddleName.Visible = true;
            lblLastName.Visible = true;
            txtLastName.Visible = true;
            lblBirthDate.Visible = false;
            dtpBirthDate.Visible = false;
            lblPosition.Visible = false;
            cmbPosition.Visible = false;
            lblHeight.Visible = false;
            txtHeight.Visible = false;
            lblWeight.Visible = false;
            txtWeight.Visible = false;

            btnSaveCoachScoutDetails.Visible = true;
            btnSavePlayerDetails.Visible = false;

            ClearFields();
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            dtpBirthDate.Value = DateTime.Now;
            cmbPosition.SelectedIndex = -1;
        }

        private void btnSavePlayerDetails_Click(object sender, EventArgs e)
        {
            if (!radioButtonPlayer.Checked)
            {
                MessageBox.Show("Please select the 'Player' role before saving player details.");
                return;
            }

            if (!ValidatePlayerFields(out string firstName, out string middleName, out string lastName,
                out string heightText, out string weightText, out string position, out int height, out int weight))
                return;

            SaveUserType(); // Update UserType in the database
            SavePlayerDetails(firstName, middleName, lastName, dtpBirthDate.Value, position, height, weight);

            RedirectToLogReg();
        }

        private void btnSaveCoachScoutDetails_Click(object sender, EventArgs e)
        {
            if (!radioButtonCoachScout.Checked)
            {
                MessageBox.Show("Please select the 'Coach/Scout' role before saving coach/scout details.");
                return;
            }

            if (!ValidateCoachScoutFields(out string firstName, out string middleName, out string lastName))
                return;

            SaveUserType(); // Update UserType in the database
            SaveCoachScoutDetails(firstName, middleName, lastName);

            RedirectToLogReg();
        }

        private bool ValidatePlayerFields(out string firstName, out string middleName, out string lastName,
            out string heightText, out string weightText, out string position, out int height, out int weight)
        {
            firstName = txtFirstName.Text.Trim();
            middleName = txtMiddleName.Text.Trim();
            lastName = txtLastName.Text.Trim();
            heightText = txtHeight.Text.Trim();
            weightText = txtWeight.Text.Trim();
            position = cmbPosition.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(middleName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(heightText) || string.IsNullOrEmpty(weightText) || string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Please fill in all the fields.");
                height = weight = 0;
                return false;
            }

            if (!IsNameValid(firstName) || !IsNameValid(middleName) || !IsNameValid(lastName))
            {
                MessageBox.Show("First Name, Middle Name, and Last Name must start with a capital letter.");
                height = weight = 0;
                return false;
            }

            if (!int.TryParse(heightText, out height) || height < 130)
            {
                MessageBox.Show("Height must be a valid integer and not less than 130 cm.");
                weight = 0;
                return false;
            }

            if (!int.TryParse(weightText, out weight) || weight <= 30)
            {
                MessageBox.Show("Weight must be a valid integer and greater than 30 kg.");
                return false;
            }

            return true;
        }

        private bool ValidateCoachScoutFields(out string firstName, out string middleName, out string lastName)
        {
            firstName = txtFirstName.Text.Trim();
            middleName = txtMiddleName.Text.Trim();
            lastName = txtLastName.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(middleName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please fill in all the fields.");
                return false;
            }

            if (!IsNameValid(firstName) || !IsNameValid(middleName) || !IsNameValid(lastName))
            {
                MessageBox.Show("First Name, Middle Name, and Last Name must start with a capital letter.");
                return false;
            }

            return true;
        }

        private bool IsNameValid(string name)
        {
            return !string.IsNullOrEmpty(name) && char.IsUpper(name[0]);
        }

        private void SaveUserType()
        {
            string query = "UPDATE Users SET UserType = @UserType WHERE Username = @Username";

            using (MySqlConnection conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserType", userType);
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating user type: {ex.Message}");
                }
            }
        }

        private void SavePlayerDetails(string firstName, string middleName, string lastName, DateTime birthDate, string position, int height, int weight)
        {
            string query = @"
                UPDATE Users
                SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, 
                    BirthDate = @BirthDate, Position = @Position, Height = @Height, Weight = @Weight
                WHERE Username = @Username";

            using (MySqlConnection conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@MiddleName", middleName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                cmd.Parameters.AddWithValue("@Position", position);
                cmd.Parameters.AddWithValue("@Height", height);
                cmd.Parameters.AddWithValue("@Weight", weight);
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Player details saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving player details: {ex.Message}");
                }
            }
        }

        private void SaveCoachScoutDetails(string firstName, string middleName, string lastName)
        {
            string query = @"
                UPDATE Users
                SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName
                WHERE Username = @Username";

            using (MySqlConnection conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@MiddleName", middleName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Coach/Scout details saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving coach/scout details: {ex.Message}");
                }
            }
        }

        private void RedirectToLogReg()
        {
            this.Close();
            LogReg logRegForm = new LogReg();
            logRegForm.Show();
        }
    }
}
