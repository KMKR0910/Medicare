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

namespace inventoryManagement
{
    public partial class Drug_Adding : Form
    {
        public Drug_Adding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();
            try
            {
                
                string sql = "INSERT INTO DrugAddSupplierss (supplier_name, company_name, drug_name, drug_type, pack_size, drug_price, expire_date, quantity, discount, final_price) " +
                             "VALUES(@Sname, @Cname, @drug_name, @drug_type, @pack_size, @drug_price, @expire_date, @quantity, @discount, @final_price)";

                using (SqlCommand cmd = new SqlCommand(sql, con)) // Properly scoped 'using' for SqlCommand
                {
                    // Null/empty checks before adding parameters
                    if (string.IsNullOrEmpty(this.txtSname.Text))
                    {
                        MessageBox.Show("Please enter the supplier name");
                        return;
                    }
                    if (string.IsNullOrEmpty(this.txtCname.Text))
                    {
                        MessageBox.Show("Please enter the company name");
                        return;
                    }
                    if (string.IsNullOrEmpty(this.txtDname.Text))
                    {
                        MessageBox.Show("Please enter the drug name");
                        return;
                    }
                    if (string.IsNullOrEmpty(this.txtDtype.Text))
                    {
                        MessageBox.Show("Please enter the drug type");
                        return;
                    }
                    if (string.IsNullOrEmpty(this.textBox1.Text))
                    {
                        MessageBox.Show("Please enter the pack size");
                        return;
                    }
                    if (string.IsNullOrEmpty(this.txtPrice.Text) || !decimal.TryParse(this.txtPrice.Text, out decimal price))
                    {
                        MessageBox.Show("Please enter a valid drug price");
                        return;
                    }
                    if (this.dateTimePicker1.Value.Date < DateTime.Today)
                    {
                        MessageBox.Show("Please select a future date.");
                        return;
                    }
                    if (this.quantity.Value <= 0)
                    {
                        MessageBox.Show("Please enter a valid quantity.");
                        return;
                    }
                    if (string.IsNullOrEmpty(this.txtDisc.Text) || !decimal.TryParse(this.txtDisc.Text, out decimal discount))
                    {
                        MessageBox.Show("Please enter a valid discount.");
                        return;
                    }

                    // Add parameters after validation
                    cmd.Parameters.AddWithValue("@Sname", this.txtSname.Text);
                    cmd.Parameters.AddWithValue("@Cname", this.txtCname.Text);
                    cmd.Parameters.AddWithValue("@drug_name", this.txtDname.Text);
                    cmd.Parameters.AddWithValue("@drug_type", this.txtDtype.Text);
                    cmd.Parameters.AddWithValue("@pack_size", this.textBox1.Text);  // Assuming this is pack size
                    cmd.Parameters.AddWithValue("@drug_price", price);  // Use the validated 'price' variable
                    cmd.Parameters.AddWithValue("@expire_date", this.dateTimePicker1.Value);  // DateTime from DateTimePicker
                    cmd.Parameters.AddWithValue("@quantity", this.quantity.Value);  // Value from NumericUpDown
                    cmd.Parameters.AddWithValue("@discount", discount);  // Use the validated 'discount' variable
                    cmd.Parameters.AddWithValue("@final_price", price * (1 - (discount / 100)));  // Example for calculating final price

                    try
                    {
                        int ret = cmd.ExecuteNonQuery();  // Executes the INSERT command.
                        if (ret == 1)  // If one row was successfully inserted,
                        {
                            MessageBox.Show("Data added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Data not added. Please check back!");
                        }
                    }
                    catch (Exception ex)  // Exception occurs, it is caught, and an error message is displayed.
                    {
                        MessageBox.Show("Error: Failed to add data. " + ex.Message);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            {    
            try
            {
                string sql = "SELECT * FROM DrugAddSupplierss ";

                using (SqlCommand cmd = new SqlCommand(sql, con)) // Properly scoped 'using' for SqlCommand
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);  // Adapter to fill the DataTable
                    DataTable dt = new DataTable();  // Create a new DataTable to hold the query results
                    da.Fill(dt);  // Fill the DataTable with data

                    dataGridView1.DataSource = dt;

                    /*dataGridView1.Columns["Drug_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                    dataGridView1.Columns["Pack_Size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name
                    dataGridView1.Columns["Drug_Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                    dataGridView1.Columns["Drug_Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name
                    dataGridView1.Columns["Expire_date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                    dataGridView1.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name
*/
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);

            }
        }

    }

        private void Drug_Adding_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();
            try
            {
                string sql = "SELECT * FROM DrugAddSupplierss ";

                using (SqlCommand cmd = new SqlCommand(sql, con)) // Properly scoped 'using' for SqlCommand
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);  // Adapter to fill the DataTable
                    DataTable dt = new DataTable();  // Create a new DataTable to hold the query results
                    da.Fill(dt);  // Fill the DataTable with data

                    dataGridView1.DataSource = dt;

                    /*dataGridView1.Columns["Drug_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                    dataGridView1.Columns["Pack_Size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name
                    dataGridView1.Columns["Drug_Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                    dataGridView1.Columns["Drug_Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name
                    dataGridView1.Columns["Expire_date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                    dataGridView1.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name
*/
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();
            try
            {

                string sql = "UPDATE DrugAddSupplierss (supplier_name, company_name, drug_name, drug_type, pack_size, drug_price, expire_date, quantity, discount, final_price) " +
                             "VALUES(@Sname, @Cname, @drug_name, @drug_type, @pack_size, @drug_price, @expire_date, @quantity, @discount, @final_price)";

                using (SqlCommand cmd = new SqlCommand(sql, con)) // Properly scoped 'using' for SqlCommand
                {
                    

                    // Add parameters after validation
                    cmd.Parameters.AddWithValue("@Sname", this.txtSname.Text);
                    cmd.Parameters.AddWithValue("@Cname", this.txtCname.Text);
                    cmd.Parameters.AddWithValue("@drug_name", this.txtDname.Text);
                    cmd.Parameters.AddWithValue("@drug_type", this.txtDtype.Text);
                    cmd.Parameters.AddWithValue("@pack_size", this.textBox1.Text);  // Assuming this is pack size
                    cmd.Parameters.AddWithValue("@drug_price", price);  // Use the validated 'price' variable
                    cmd.Parameters.AddWithValue("@expire_date", this.dateTimePicker1.Value);  // DateTime from DateTimePicker
                    cmd.Parameters.AddWithValue("@quantity", this.quantity.Value);  // Value from NumericUpDown
                    cmd.Parameters.AddWithValue("@discount", discount);  // Use the validated 'discount' variable
                    cmd.Parameters.AddWithValue("@final_price", price * (1 - (discount / 100)));  // Example for calculating final price

                    try
                    {
                        int ret = cmd.ExecuteNonQuery();  // Executes the INSERT command.
                        if (ret == 1)  // If one row was successfully inserted,
                        {
                            MessageBox.Show("Data added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Data not added. Please check back!");
                        }
                    }
                    catch (Exception ex)  // Exception occurs, it is caught, and an error message is displayed.
                    {
                        MessageBox.Show("Error: Failed to add data. " + ex.Message);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            {
                try
                {
                    string sql = "SELECT * FROM DrugAddSupplierss ";

                    using (SqlCommand cmd = new SqlCommand(sql, con)) // Properly scoped 'using' for SqlCommand
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);  // Adapter to fill the DataTable
                        DataTable dt = new DataTable();  // Create a new DataTable to hold the query results
                        da.Fill(dt);  // Fill the DataTable with data

                        dataGridView1.DataSource = dt;

                        /*dataGridView1.Columns["Drug_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                        dataGridView1.Columns["Pack_Size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name
                        dataGridView1.Columns["Drug_Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                        dataGridView1.Columns["Drug_Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name
                        dataGridView1.Columns["Expire_date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                        dataGridView1.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name
    */
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);

                }
            }


        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row and retrieve the primary key (CID)
                string id = dataGridView1.SelectedRows[0].Cells[ "id"].Value.ToString();

                // Confirm the deletion
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Database connection string
                    string cs4 = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(cs4))
                    {
                        string sql = "DELETE FROM DrugAddSupplierss WHERE id = @id";
                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            try
                            {
                                con.Open();
                                command.ExecuteNonQuery();
                                MessageBox.Show("Record deleted successfully!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }
    }
}
    


