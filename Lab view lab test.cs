using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Diploma_Final_Project_1
{
    public partial class Lab_view_lab_test : Form
    {
        public Lab_view_lab_test()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_add.BackColor = customC;
            btn_update.BackColor = customC;
            btn_search.BackColor = customC;
            btn_delete.BackColor = customC;
            btn_all.BackColor = customC;
            btn_clear.BackColor = customC;
        }
        string TestID;
        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {

                if (string.IsNullOrEmpty(this.txt_search.Text))
                {
                    MessageBox.Show("All required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();





                    string sql = @"
                 SELECT *
                 FROM [tbl_lab_tests] 
               
                  WHERE Test_Name LIKE @name";
                    SqlCommand com = new SqlCommand(sql, con);

                    com.Parameters.AddWithValue("@name", "%" + this.txt_search.Text + "%");


                    SqlDataAdapter dap = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    this.dataGridView_lab_tests.DataSource = ds.Tables[0];


                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Lab_view_lab_test_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                 SELECT *
                 FROM [tbl_lab_tests] ";
                SqlCommand com = new SqlCommand(sql, con);

               


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_lab_tests.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try


            {
                if (string.IsNullOrEmpty(this.txt_description.Text) || string.IsNullOrEmpty(this.txt_test_name.Text) )
                {
                    MessageBox.Show("All required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();


                    string query = "INSERT INTO [tbl_lab_tests] (Test_Name, Test_Price,[Description]) " +
                                   "VALUES (@Name, @Price, @description)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Name", txt_test_name.Text);
                    cmd.Parameters.AddWithValue("@description", txt_description.Text);
                    cmd.Parameters.AddWithValue("@Price", numericUpDown_price.Value);


                    int ret = cmd.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Added successfully");
                        txt_test_name.Clear();
                        txt_description.Clear();
                        numericUpDown_price.Value = 0;
                        Lab_view_lab_test_Load(this, EventArgs.Empty);

                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {

                if (string.IsNullOrEmpty(this.txt_description.Text) || string.IsNullOrEmpty(this.txt_test_name.Text))
                {
                    MessageBox.Show("All required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();


                    string query = "UPDATE [tbl_lab_tests] " +
                                   "SET Test_Name = @Name, Test_Price = @Price, [Description] = @description " +
                                   "WHERE Lab_Test_ID = @TestID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@TestID", TestID);

                    cmd.Parameters.AddWithValue("@Name", txt_test_name.Text);
                    cmd.Parameters.AddWithValue("@description", txt_description.Text);
                    cmd.Parameters.AddWithValue("@Price", numericUpDown_price.Value);


                    int ret = cmd.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Updated successfully");
                        txt_test_name.Clear();
                        txt_description.Clear();
                        numericUpDown_price.Value = 0;
                        Lab_view_lab_test_Load(this, EventArgs.Empty);



                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_lab_tests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Get the current row
                    DataGridViewRow row = dataGridView_lab_tests.Rows[e.RowIndex];

                    // Assuming you want the data from the first column (index 0)
                    TestID = row.Cells[0].Value.ToString();
                    string cellValue = row.Cells[1].Value.ToString();
                    string cellValue1 = row.Cells[2].Value.ToString();
                    string cellValue2 = row.Cells[3].Value.ToString();
               

                    // Set the value to the TextBox
                  
                    txt_test_name.Text = cellValue;
                    numericUpDown_price.Value = Convert.ToDecimal(cellValue1);
                    txt_description.Text = cellValue2;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            Lab_view_lab_test_Load(this, EventArgs.Empty);
        }
        


        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_description.Clear();
            txt_test_name.Clear();
            numericUpDown_price.Value = 0;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();


                string sql = "DELETE  " +
                             "FROM [tbl_lab_tests] " +

                             "WHERE [Lab_Test_ID] = @id ";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@id", TestID);


                int ret = com.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Deleted", "Information");
                    Lab_view_lab_test_Load(this, EventArgs.Empty);
                    
                }


                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
