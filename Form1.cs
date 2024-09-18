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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();
            try
            {
                string sql = "SELECT * FROM Drug_Inventory WHERE name =@Drug_Name";

                using (SqlCommand cmd = new SqlCommand(sql, con)) // Properly scoped 'using' for SqlCommand
                {
                    // Add parameter to the command to prevent SQL injection
                    cmd.Parameters.AddWithValue("@name", this.textBox1.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);  // Adapter to fill the DataTable
                    DataTable dt = new DataTable();  // Create a new DataTable to hold the query results
                    da.Fill(dt);  // Fill the DataTable with data

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error"+ex.Message);
            
            }

        }

        private void btnLda_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();
            try
            {
                string sql = "SELECT * FROM Drug_Inventory ";

                using (SqlCommand cmd = new SqlCommand(sql, con)) // Properly scoped 'using' for SqlCommand
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);  // Adapter to fill the DataTable
                    DataTable dt = new DataTable();  // Create a new DataTable to hold the query results
                    da.Fill(dt);  // Fill the DataTable with data

                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["Drug_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                    dataGridView1.Columns["Pack_Size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name
                    dataGridView1.Columns["Drug_Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                    dataGridView1.Columns["Drug_Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name
                    dataGridView1.Columns["Expire_date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                    dataGridView1.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
