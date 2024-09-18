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
    public partial class Drug_Order : Form
    {
        public Drug_Order()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Drug_Order_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();
            try
            {
                string sql = "SELECT * FROM Drug_Inventory WHERE Supplier_name = @Sname ";

                using (SqlCommand cmd = new SqlCommand(sql, con)) // Properly scoped 'using' for SqlCommand
                {
                    cmd.Parameters.AddWithValue("@Sname", this.textBox2.Text);
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
    }
}
