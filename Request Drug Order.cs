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
    public partial class Request_Drug_Order : Form
    {
        public Request_Drug_Order()
        {
            InitializeComponent();
        }

        private void txtOid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Request_Drug_Order_Load(object sender, EventArgs e)
        {
            string cs = "Data Source =LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con1 = new SqlConnection(cs);

            try
            {
                con1.Open();

                string sql1 = "Select Drug_Name, Drug_price FROM Drug_Order ";

                using (SqlCommand cmd1 = new SqlCommand(sql1, con1))
                {
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da1.Fill(dt);

                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["Drug_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Drug_price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                string sql2 = "Select Drug_Name, Drug_type, Quantity FROM Drug_Order ";

                using (SqlCommand cmd2 = new SqlCommand(sql2, con1))
                {
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);

                    dataGridView2.DataSource = dt2;

                    dataGridView2.Columns["Drug_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView2.Columns["Drug_type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView2.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con1.State == ConnectionState.Open)
                {
                    con1.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cs1 = "Data Source =LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con1 = new SqlConnection(cs1);

            string sql1 = "INSERT INTO ";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
