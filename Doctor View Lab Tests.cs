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
    public partial class Doctor_View_Lab_Tests : Form
    {
        public Doctor_View_Lab_Tests()
        {
            InitializeComponent();
          
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
            btn_All.BackColor = customC;
           
        }
        
        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                 SELECT [Test_Name],[Test_Price],[Description]
                 FROM [tbl_lab_tests] 
               
                  WHERE Test_Name = @name";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@name", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_lab_tests.DataSource = ds.Tables[0];
                dataGridView_lab_tests.Columns[0].HeaderText = "Test Name";

                dataGridView_lab_tests.Columns[1].HeaderText = "Price";


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Doctor_View_Lab_Tests_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                  SELECT [Test_Name],[Test_Price],[Description]
                 FROM [tbl_lab_tests] ";
                SqlCommand com = new SqlCommand(sql, con);




                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_lab_tests.DataSource = ds.Tables[0];
                dataGridView_lab_tests.Columns[0].HeaderText = "Test Name"; 

                dataGridView_lab_tests.Columns[1].HeaderText = "Price"; 



                con.Close();
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
                    
                    string cellValue = row.Cells[0].Value.ToString();
                    string cellValue1 = row.Cells[1].Value.ToString();
                    string cellValue2 = row.Cells[2].Value.ToString();


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

        private void btn_All_Click(object sender, EventArgs e)
        {
            Doctor_View_Lab_Tests_Load(null, EventArgs.Empty) ;
        }
    }
}
