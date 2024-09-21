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
    public partial class addDrug : Form
    {
        public addDrug()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();
            try
            {
                string sql = "SELECT * FROM Drug_Inventory WHERE Drug_Name =@name";

                using (SqlCommand cmd = new SqlCommand(sql, con)) // Properly scoped 'using' for SqlCommand
                {
                    // Add parameter to the command to prevent SQL injection
                    cmd.Parameters.AddWithValue("@name", this.txtSearch.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);  // Adapter to fill the DataTable
                    DataTable dt = new DataTable();  // Create a new DataTable to hold the query results
                    da.Fill(dt);  // Fill the DataTable with data

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();
            try
            {
                string sql = "INSERT INTO Drug_Inventory (Drug_Name, Drug_Price, Expire_Date, Quantity, Pack_Size) VALUES(@name, @price, @date, @quantity, @size)";

                using (SqlCommand cmd = new SqlCommand(sql, con)) // Properly scoped 'using' for SqlCommand
                {
                    // Add parameter to the command to prevent SQL injection
                    cmd.Parameters.AddWithValue("@name", this.txtName.Text);
                    cmd.Parameters.AddWithValue("@price", this.txtPrice.Text);
                    cmd.Parameters.AddWithValue("@date", this.dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@quantity", this.txtqty.Text);
                    cmd.Parameters.AddWithValue("@size", this.txtSize.Text);
                    
                    if(this.txtName.Text=="")
                    {
                        MessageBox.Show("Please enter the item name");
                        return;
                    }
                    if (this.txtPrice.Text == "")
                    {
                        MessageBox.Show("Please enter the item price");
                        return;
                    }
                    if (this.txtqty.Text == "")
                    {
                        MessageBox.Show("Please enter the item quantity");
                        return;
                    }
                    if (this.txtSize.Text == "")
                    {
                        MessageBox.Show("Please enter the item pack size");
                        return;
                    }
                    if (this.dateTimePicker1.Value.Date < DateTime.Today)
                    {
                        MessageBox.Show("Please select a future date.");
                        return;
                    }

                    try
                    {
                        int ret = cmd.ExecuteNonQuery();  // Executes the INSERT command. 
                        if (ret == 1)  // If one row was successfully inserted,
                        {

                            MessageBox.Show("Do you want to proceed with the purchase?", "Confirm Purchase");

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
                MessageBox.Show("error" + ex.Message);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";

            using (SqlConnection con1 = new SqlConnection(cs))
            {
                try
                {
                    con1.Open();

                    string sql = "UPDATE Drug_Inventory SET Drug_Price = @name, @price, Expire_Date = @date, Quantity = @quantity, Pack_Size = @size WHERE Drug_Name = @name";

                    using (SqlCommand cmd1 = new SqlCommand(sql, con1))
                    {
                        // Ensure required fields are filled
                        if (string.IsNullOrWhiteSpace(txtName.Text) ||
                            string.IsNullOrWhiteSpace(txtPrice.Text) ||
                            string.IsNullOrWhiteSpace(txtqty.Text) ||
                            string.IsNullOrWhiteSpace(txtSize.Text))
                        {
                            MessageBox.Show("Please fill all fields.");
                            return;
                        }

                        if (dateTimePicker1.Value.Date < DateTime.Today)
                        {
                            MessageBox.Show("Please select a future date.");
                            return;
                        }

                        // Add parameters to the command
                        cmd1.Parameters.AddWithValue("@name", txtName.Text);
                        cmd1.Parameters.AddWithValue("@price", txtPrice.Text);
                        cmd1.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                        cmd1.Parameters.AddWithValue("@quantity", txtqty.Text);
                        cmd1.Parameters.AddWithValue("@size", txtSize.Text);

                        int ret = cmd1.ExecuteNonQuery();  // Executes the UPDATE command
                        MessageBox.Show(ret > 0 ? "The record has been successfully updated." : "No record was updated. Please check the Drug Name.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Failed to update data. " + ex.Message);
                }
            }
        }

            private void btnDel_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row and retrieve the primary key (CID)
                string id = dataGridView1.SelectedRows[0].Cells["Drug_Id"].Value.ToString();

                // Confirm the deletion
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Database connection string
                    string cs4 = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(cs4))
                    {
                        string sql = "DELETE FROM Drug_Inventory WHERE Drug_Id = @id";
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
