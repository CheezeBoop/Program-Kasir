using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class ProductManagement : Form
    {
        private string connectionString = "Data Source=ATREIDES;Initial Catalog=KasirDB;Integrated Security=True;";

        public ProductManagement()
        {
            InitializeComponent();
            TampilkanData();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            this.FormBorderStyle = FormBorderStyle.None;

            cb_category.Items.Add("Food");
            cb_category.Items.Add("Drink");
            cb_category.Items.Add("Building Tool");
            cb_category.Items.Add("Electronic Tool");
            cb_category.Items.Add("Clothes");
            cb_category.Items.Add("Other");
            cb_category.SelectedIndex = -1;

            cb_unit.Items.Add("Pcs");
            cb_unit.Items.Add("Pack");
            cb_unit.Items.Add("Dozen");
            cb_unit.Items.Add("Liter");
            cb_unit.Items.Add("Kg");
            cb_unit.Items.Add("Box");
            cb_unit.Items.Add("Gr");
            cb_unit.Items.Add("Other");
            cb_category.SelectedIndex = -1;

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                tb_kode.Text = row.Cells["ProductCode"].Value?.ToString() ?? "";
                tb_productName.Text = row.Cells["ProductName"].Value?.ToString() ?? "";
                tb_price.Text = row.Cells["Price"].Value?.ToString() ?? "";
                tb_stock.Text = row.Cells["Stock"].Value?.ToString() ?? "";
                cb_category.Text = row.Cells["Category"].Value?.ToString() ?? "";
                cb_unit.Text = row.Cells["Unit"].Value?.ToString() ?? "";
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Price" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal price))
                {
                    e.Value = price.ToString("C", new CultureInfo("id-ID"));
                    e.FormattingApplied = true;
                }
            }
        }

        private void TampilkanData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void tb_searchProduct_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products WHERE ProductName LIKE @search", conn);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + tb_searchProduct.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            tb_searchProduct.Clear();
            TampilkanData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tb_kode.Text = row.Cells["ProductCode"].Value.ToString();
                tb_productName.Text = row.Cells["ProductName"].Value.ToString();
                tb_price.Text = row.Cells["Price"].Value.ToString();
                tb_stock.Text = row.Cells["Stock"].Value.ToString();
                cb_category.Text = row.Cells["Category"].Value.ToString();
                cb_unit.Text = row.Cells["Unit"].Value.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_kode.Text))
            {
                MessageBox.Show("Product Code cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Products WHERE ProductCode = @code", conn);
                checkCmd.Parameters.AddWithValue("@code", tb_kode.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Product Code is already in use!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (!decimal.TryParse(tb_price.Text, out decimal price))
                {
                    MessageBox.Show("Invalid price format! Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(tb_stock.Text, out int stock))
                {
                    MessageBox.Show("Invalid stock format! Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductCode, ProductName, Price, Stock, Category, Unit) VALUES (@code, @name, @price, @stock, @category, @unit)", conn);
                cmd.Parameters.AddWithValue("@code", tb_kode.Text);
                cmd.Parameters.AddWithValue("@name", tb_productName.Text);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@category", cb_category.Text);
                cmd.Parameters.AddWithValue("@unit", cb_unit.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilkanData();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Products SET ProductName = @name, Price = @price, Stock = @stock, Category = @category, Unit = @unit WHERE ProductCode = @code", conn);
                    decimal.TryParse(tb_price.Text, out decimal price);
                    int.TryParse(tb_stock.Text, out int stock);
                    cmd.Parameters.AddWithValue("@code", tb_kode.Text);
                    cmd.Parameters.AddWithValue("@name", tb_productName.Text);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@category", cb_category.Text);
                    cmd.Parameters.AddWithValue("@unit", cb_unit.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TampilkanData(); 
                    }
                    else
                    {
                        MessageBox.Show("No product updated. Add Product Code First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the product you want to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedCode = dataGridView1.SelectedRows[0].Cells["ProductCode"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM Products WHERE ProductCode = @code", conn);
                    deleteCmd.Parameters.AddWithValue("@code", selectedCode);
                    deleteCmd.ExecuteNonQuery();

                    SqlCommand resetCmd = new SqlCommand(@"
                SELECT ROW_NUMBER() OVER (ORDER BY ProductID) AS NewID, 
                       ProductCode, ProductName, Price, Stock, Category, Unit
                INTO #TempTable
                FROM Products;

                DELETE FROM Products;

                SET IDENTITY_INSERT Products ON;
                INSERT INTO Products (ProductID, ProductCode, ProductName, Price, Stock, Category, Unit)
                SELECT NewID, ProductCode, ProductName, Price, Stock, Category, Unit FROM #TempTable;
                SET IDENTITY_INSERT Products OFF;

                DROP TABLE #TempTable;

                DECLARE @maxID INT;
                SELECT @maxID = MAX(ProductID) FROM Products;
                IF @maxID IS NULL 
                    SET @maxID = 0;
                DBCC CHECKIDENT ('Products', RESEED, @maxID);
            ", conn);
                    resetCmd.ExecuteNonQuery();

                    MessageBox.Show("Product successfully removed and ProductID has been updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilkanData();
                }
            }
            else
            {
                MessageBox.Show("Select the product you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb_kode_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_productName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_unit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_kode.Text = "";
            tb_productName.Text = "";
            tb_price.Text = "";
            tb_stock.Text = "";
            cb_category.SelectedIndex = -1;
            cb_unit.SelectedIndex = -1;
        }
    }
}
