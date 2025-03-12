using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace VolleyballRecruitmentApp
{
    public class DataBase : IDisposable
    {
        private static DataBase? instance = null;
        private readonly string connectionString;
        public MySqlConnection Connection { get; private set; }

        public static DataBase Instance
        {
            get
            {
                instance ??= new DataBase();
                return instance;
            }
        }

        private DataBase()
        {
            connectionString = "server=localhost;database=volleyballrecruitmentagency;user=root;port=3307";
            try
            {
                Connection = new MySqlConnection(connectionString);
                Connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Optionally rethrow to handle this in the application
            }
        }

        public void Dispose()
        {
            Connection?.Dispose();
            instance = null;
        }
    }
}
