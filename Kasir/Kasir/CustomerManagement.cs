using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Kasir
{
    public partial class CustomerManagement : Form
    {
        private string connectionString = "Data Source=ATREIDES;Initial Catalog=KasirDB;Integrated Security=True";

        public CustomerManagement()
        {
            InitializeComponent();
            TampilkanData();
            LayoutPhoto();
            this.FormBorderStyle = FormBorderStyle.None;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private byte[] GetImageBytes()
        {
            if (pb_facePhoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pb_facePhoto.Image.Save(ms, pb_facePhoto.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                tb_customerId.Text = row.Cells["CustomerID"].Value?.ToString() ?? "";
                tb_customerName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                tb_phone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                tb_email.Text = row.Cells["Email"].Value?.ToString() ?? "";
                tb_address.Text = row.Cells["Address"].Value?.ToString() ?? "";
                cb_vip.Checked = row.Cells["VIP"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["VIP"].Value);

                if (row.Cells["Photo"].Value != DBNull.Value && row.Cells["Photo"].Value != null)
                {
                    byte[] imageBytes = (byte[])row.Cells["Photo"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pb_facePhoto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pb_facePhoto.Image = null;
                }
            }
        }


        private void TampilkanData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, CustomerID, Name, Phone, Email, Address, VIP, Photo From Customers", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void LayoutPhoto()
        {
            if (dataGridView1.Columns["Photo"] is DataGridViewImageColumn imgColumn)
            {
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

            dataGridView1.RowTemplate.Height = 100;
        }

        private void tb_searchCustomer_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers WHERE Name LIKE @Search OR Phone LIKE @Search", conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + tb_searchCustomer.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_customerId.Text) || string.IsNullOrWhiteSpace(tb_customerName.Text))
            {
                MessageBox.Show("CustomerID cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE CustomerID=@CustomerID", conn);
                checkCmd.Parameters.AddWithValue("@CustomerID", tb_customerId.Text);
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("CustomerID is already in use!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] imageBytes = GetImageBytes();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customers (CustomerID, Name, Phone, Email, Address, VIP, Photo) VALUES (@CustomerID, @Name, @Phone, @Email, @Address, @VIP, @Photo)", conn);
                cmd.Parameters.AddWithValue("@CustomerID", tb_customerId.Text);
                cmd.Parameters.AddWithValue("@Name", tb_customerName.Text);
                cmd.Parameters.AddWithValue("@Phone", tb_phone.Text);
                cmd.Parameters.AddWithValue("@Email", tb_email.Text);
                cmd.Parameters.AddWithValue("@Address", tb_address.Text);
                cmd.Parameters.AddWithValue("@VIP", cb_vip.Checked ? 1 : 0);
                cmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = (object)imageBytes ?? DBNull.Value;
                cmd.ExecuteNonQuery();

            }
            MessageBox.Show("New Customer successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TampilkanData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tb_customerId.Text = row.Cells["CustomerID"].Value.ToString();
                tb_customerName.Text = row.Cells["Name"].Value.ToString(); 
                tb_phone.Text = row.Cells["Phone"].Value.ToString();
                tb_email.Text = row.Cells["Email"].Value.ToString();
                tb_address.Text = row.Cells["Address"].Value.ToString();
                if (row.Cells["VIP"].Value != DBNull.Value)
                {
                    cb_vip.Checked = Convert.ToBoolean(row.Cells["VIP"].Value);
                }
                else
                {
                    cb_vip.Checked = false;
                }

                if (row.Cells["Photo"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["Photo"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pb_facePhoto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pb_facePhoto.Image = null;
                }

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_customerId.Text))
            {
                MessageBox.Show("Select the customer to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_customerName.Text) || string.IsNullOrWhiteSpace(tb_phone.Text))
            {
                MessageBox.Show("Name and Phone cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] imageBytes = GetImageBytes();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Customers SET Name=@Name, Phone=@Phone, Email=@Email, Address=@Address, VIP=@VIP, Photo=@Photo WHERE CustomerID=@CustomerID", conn);
                    cmd.Parameters.AddWithValue("@CustomerID", tb_customerId.Text);
                    cmd.Parameters.AddWithValue("@Name", tb_customerName.Text);
                    cmd.Parameters.AddWithValue("@Phone", tb_phone.Text);
                    cmd.Parameters.AddWithValue("@Email", tb_email.Text);
                    cmd.Parameters.AddWithValue("@Address", tb_address.Text);
                    cmd.Parameters.AddWithValue("@VIP", cb_vip.Checked ? 1 : 0);
                    cmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = (object)imageBytes ?? DBNull.Value;

                    Console.WriteLine("SQL Command: " + cmd.CommandText);
                    Console.WriteLine("Parameters: ");
                    foreach (SqlParameter param in cmd.Parameters)
                    {
                        Console.WriteLine($"{param.ParameterName}: {param.Value}");
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer data successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No changes were made to the data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            TampilkanData();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells["CustomerID"].Value != null && selectedRow.Cells["CustomerID"].Value != DBNull.Value)
                {
                    string selectCustomer = selectedRow.Cells["CustomerID"].Value.ToString();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM Customers WHERE CustomerID=@CustomerID", conn);
                        cmd.Parameters.AddWithValue("@CustomerID", selectCustomer);
                        cmd.ExecuteNonQuery();

                        SqlCommand resetCmd = new SqlCommand("DBCC CHECKIDENT ('Customers', RESEED, 0);", conn);
                        resetCmd.ExecuteNonQuery();

                        TampilkanData();

                        MessageBox.Show("Customer successfully removed and ID sequence reset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("CustomerID is empty or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select the customer you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_customerId.Clear();
            tb_customerName.Clear();
            tb_phone.Clear();
            tb_email.Clear();
            tb_address.Clear();
            cb_vip.Checked = false;
            pb_facePhoto.Image = null;
        }

        private void btn_addPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_facePhoto.Image = Image.FromFile(open.FileName); 
            }
        }

        private void pb_facePhoto_Click(object sender, EventArgs e)
        {

        }

        private void cb_vip_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tb_customerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_customerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
