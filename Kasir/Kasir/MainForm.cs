using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=ATREIDES;Initial Catalog=KasirDB;Integrated Security=True;";

        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            string imagePath = @"C:\Users\laboo\Downloads\Profile.jpg";

            if (System.IO.File.Exists(imagePath))
            {
                pb_profile.Image = Image.FromFile(imagePath);
                pb_profile.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (Login.LoggedInUserRole == "Admin")
            {
                LoadUserLoginHistory(); // Admin melihat history login
            }
            else
            {
                HideLoginHistory(); // Staff/Kasir tidak melihat history login
            }

            lb_email.Text = Login.LoggedInUserEmail;
            lb_role.Text = Login.LoggedInUserRole;  // Menampilkan role pengguna

            dgv_staffLoginHistory.DefaultCellStyle.Font = new Font("Arial", 8);
            dgv_staffLoginHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dgv_kasirLoginHistory.DefaultCellStyle.Font = new Font("Arial", 8);
            dgv_kasirLoginHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);


        }

        private void TampilkanForm(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void LoadUserLoginHistory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string queryStaff = "SELECT Email, Role, LastLogin FROM Users WHERE Role = 'Staff' ORDER BY LastLogin DESC";
                    string queryKasir = "SELECT Email, Role, LastLogin FROM Users WHERE Role = 'Kasir' ORDER BY LastLogin DESC";

                    using (SqlCommand cmdStaff = new SqlCommand(queryStaff, conn))
                    using (SqlCommand cmdKasir = new SqlCommand(queryKasir, conn))
                    {
                        SqlDataAdapter adapterStaff = new SqlDataAdapter(cmdStaff);
                        DataTable dtStaff = new DataTable();
                        adapterStaff.Fill(dtStaff);
                        dgv_staffLoginHistory.DataSource = dtStaff;

                        SqlDataAdapter adapterKasir = new SqlDataAdapter(cmdKasir);
                        DataTable dtKasir = new DataTable();
                        adapterKasir.Fill(dtKasir);
                        dgv_kasirLoginHistory.DataSource = dtKasir;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat mengambil data login history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HideLoginHistory()
        {
            spt_loginHistory.Visible = false;
        }

        private void btn_ProductManagement_Click(object sender, EventArgs e)
        {
            TampilkanForm(new ProductManagement());
        }

        private void btn_newTransaction_Click(object sender, EventArgs e)
        {
            TampilkanForm(new NewTransaction());
        }

        private void btn_transactionHistory_Click(object sender, EventArgs e)
        {
            TampilkanForm(new TransactionHistory());
        }


        private void btn_customerManagement_Click(object sender, EventArgs e)
        {
            TampilkanForm(new CustomerManagement());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda berhasil Logout dari form ini! Silahkan Login jika ingin masuk kembali.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void dgv_staffLoginHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_kasirLoginHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb_profile_Click_1(object sender, EventArgs e)
        {

        }

        private void lb_role_Click(object sender, EventArgs e)
        {

        }

        private void lb_email_Click(object sender, EventArgs e)
        {

        }

        private void lb_labelTime_Click(object sender, EventArgs e)
        {

        }

        private void tmr_realTime_Tick(object sender, EventArgs e)
        {
            lb_labelTime.Text = DateTime.Now.ToString("HH:mm:ss - dd MMMM yyyy");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tmr_realTime.Start();
        }
    }
}
