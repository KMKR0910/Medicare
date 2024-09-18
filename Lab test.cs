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
    public partial class Lab_test : Form
    {
        public Lab_test()
        {
            InitializeComponent();
        }

        private void Lab_test_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();
            try
            {
                string sql = "SELECT * FROM lab_report ";

                using (SqlCommand cmd = new SqlCommand(sql, con)) // Properly scoped 'using' for SqlCommand
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);  // Adapter to fill the DataTable
                    DataTable dt = new DataTable();  // Create a new DataTable to hold the query results
                    da.Fill(dt);  // Fill the DataTable with data

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["Test_id"].Visible = false;

                    dataGridView1.Columns["Test_type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column1" with the actual column name
                    dataGridView1.Columns["Test_price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Replace "Column2" with the actual column name

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();
            try
            {
                string sql = "SELECT * FROM lab_report WHERE Test_type =@name";

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
                MessageBox.Show("error" + ex.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();
            try
            {
                string sql = "SELECT * FROM lab_report WHERE Test_type =@name";

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
                MessageBox.Show("error" + ex.Message);

            }
        }
    }
}
