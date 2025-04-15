using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kasir
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=ATREIDES;Initial Catalog=KasirDB;Integrated Security=True;";
        public static string LoggedInUserEmail;
        public static string LoggedInUserRole;

        public Login()
        {
            InitializeComponent();
            EnsureDefaultUsersExist();
            tb_password.PasswordChar = '•';

            cb_roleUsers.Items.Add("Admin");
            cb_roleUsers.Items.Add("Staff");
            cb_roleUsers.Items.Add("Kasir");
            cb_roleUsers.SelectedIndex = -1;
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateLastLogin(string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Users SET LastLogin = GETDATE() WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when system try to update last login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            string password = tb_password.Text;

            if (cb_roleUsers.SelectedItem == null)
            {
                MessageBox.Show("Please select a role before logging in!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string role = cb_roleUsers.SelectedItem.ToString();

            if (AuthenticateUser(email, password, role))
            {
                Login.LoggedInUserEmail = email;
                Login.LoggedInUserRole = role;

                UpdateLastLogin(email);

                MessageBox.Show($"Login Successfully as {role}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The email, password, and role you entered are incorrect or do not have access!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string email, string password, string role)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Email=@Email AND Password=@Password AND Role=@Role";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void EnsureDefaultUsersExist()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'firas@example.com')
                    BEGIN
                        INSERT INTO Users (Email, Password, Role) VALUES ('firas@example.com', '123', 'Admin');
                    END;

                    IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'fathir@example.com')
                    BEGIN
                        INSERT INTO Users (Email, Password, Role) VALUES ('fathir@example.com', '123', 'Kasir');
                    END;

                    IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'fathan@example.com')
                    BEGIN
                        INSERT INTO Users (Email, Password, Role) VALUES ('fathan@example.com', '123', 'Staff');
                    END;

                    IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'admin@example.com')
                    BEGIN
                        INSERT INTO Users (Email, Password, Role) VALUES ('admin@example.com', '123', 'Admin');
                    END;

                    IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'staff@example.com')
                    BEGIN
                        INSERT INTO Users (Email, Password, Role) VALUES ('staff@example.com', '123', 'Staff');
                    END;

                    IF NOT EXISTS (SELECT 1 FROM Users WHERE Email = 'admin@example.com')
                    BEGIN
                        INSERT INTO Users (Email, Password, Role) VALUES ('admin@example.com', '123', 'Kasir');
                    END;
                    ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat memastikan akun admin dan kasir1: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cb_roleUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
