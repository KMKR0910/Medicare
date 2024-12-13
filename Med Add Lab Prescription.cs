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
    public partial class Med_Add_Lab_Prescription : Form
    {
        public Med_Add_Lab_Prescription()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
            btn_add.BackColor = customC;

            btn_cancel.BackColor = customC;
            btn_delete.BackColor = customC;
        }
        string prescriptionNumber;
        string status = "Not Collected";
        private string GenerateLabTestNumber(string patientId)
        {
            // Get the current date in yyyyMMdd format
            string currentDate = DateTime.Now.ToString("yyyyMMdd");

            // Start with a base sequence of 001
            string sequence = "001";
            string cs = "Data Source=ASUS; Initial Catalog = Diploma Final Project DB1; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();




            // Query to get the last prescription number for the current date and patient
            string query = @"SELECT TOP 1 Lab_test_number 
                             FROM [tbl_Lab_Test_Report]
                             WHERE Lab_test_number LIKE @prefix + '%'
                             ORDER BY Lab_test_number DESC";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // The prefix would be the current date + patient ID
                string prefix = currentDate + patientId;

                cmd.Parameters.AddWithValue("@prefix", prefix);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // Extract the last 3 digits of the last prescription number
                    string lastlabtestNumber = result.ToString();
                    int lastSequence = int.Parse(lastlabtestNumber.Substring(lastlabtestNumber.Length - 3));

                    // Increment the sequence
                    sequence = (lastSequence + 1).ToString("D3"); // D3 ensures it's always 3 digits (001, 002, etc.)
                }
            }


            // Combine the current date, patient ID, and sequence to form the prescription number
            return currentDate + patientId + sequence;
        }

        private void Med_Add_Lab_Prescription_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string query = "INSERT INTO [tbl_Lab_Test_Report] ([Test_Type], [Rep_status],[Test_Price],[Patient_ID],[Lab_test_number],[Description]) " +
                               "VALUES (@type, @status, @Price, @patientID,@number,@description)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@type", comboBox_type.Text);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@Price", txt_price.Text);
                cmd.Parameters.AddWithValue("@patientID", txt_patient_ID.Text);
                cmd.Parameters.AddWithValue("@number", prescriptionNumber);
                cmd.Parameters.AddWithValue("@description", this.txt_description.Text);


                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Added successfully");
                    comboBox_type.SelectedIndex = 0;
                    txt_price.Clear();


                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try


            {
                SqlConnection con = new SqlConnection(cs);

                con.Open();

                string query = "SELECT [Test_Type],[Rep_status],[Test_Price],[Patient_ID] ,[Description] FROM [tbl_Lab_Test_Report] WHERE [Lab_test_number] = @number";
                using (SqlCommand cmd1 = new SqlCommand(query, con))
                {
                    // Add parameter to the command
                    cmd1.Parameters.AddWithValue("@number", prescriptionNumber);

                    // Create SqlDataAdapter and SqlCommandBuilder
                    SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                    // Fill the DataSet
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    // Set the DataSource of the DataGridView
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "Test Name";
                    dataGridView1.Columns[1].HeaderText = "Status";
                    dataGridView1.Columns[2].HeaderText = "Price";
                    dataGridView1.Columns[3].HeaderText = "Patient ID";

                    dataGridView1.Columns[4].HeaderText = "Description";


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog = Diploma Final Project DB1; Integrated Security=True";

            try
            {
                DateTime currentDate = DateTime.Now.Date;
                this.txt_date.Text = currentDate.ToString("yyyy-MM-dd");

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "SELECT [Patient ID] FROM tbl_patient_info WHERE [Contact Number] = @name ";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@name", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow rows = ds.Tables[0].Rows[0];


                    this.txt_patient_ID.Text = rows["Patient ID"].ToString();



                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {
                // Assuming txtPatientId is a TextBox where the user inputs the patient ID
                string patientId = txt_patient_ID.Text;

                if (!string.IsNullOrEmpty(patientId))
                {
                    // Generate the prescription number
                    prescriptionNumber = GenerateLabTestNumber(patientId);

                    // Display the generated prescription number
                    string lastThreeDigits = prescriptionNumber.Substring(prescriptionNumber.Length - 3);
                    this.txt_lab_test_number.Text = lastThreeDigits;
                }
                else
                {
                    MessageBox.Show("Please enter a valid Patient ID");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                string cellValue = row.Cells[0].Value.ToString();
                string cellValue2 = row.Cells[2].Value.ToString();
                string cellValue3 = row.Cells[4].Value.ToString();
             


                // Set the value to the TextBox
                comboBox_type.Text = cellValue;
                txt_price.Text = cellValue2;
                txt_description.Text = cellValue3;
                



            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();


                string sql = "DELETE  " +
                             "FROM [tbl_Lab_Test_Report] " +

                             "WHERE [Lab_test_number]= @number ";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@number", prescriptionNumber);


                int ret = com.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Prescription Deleted", "Information");
                    btn_cancel_Click(null, EventArgs.Empty);
                    string query = "SELECT [Test_Type],[Rep_status],[Test_Price],[Patient_ID] ,[Description] FROM [tbl_Lab_Test_Report] WHERE [Lab_test_number] = @number";
                    using (SqlCommand cmd1 = new SqlCommand(query, con1))
                    {
                        // Add parameter to the command
                        cmd1.Parameters.AddWithValue("@number", prescriptionNumber);

                        // Create SqlDataAdapter and SqlCommandBuilder
                        SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                        SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                        // Fill the DataSet
                        DataSet ds = new DataSet();
                        sda.Fill(ds);

                        // Set the DataSource of the DataGridView
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns[0].HeaderText = "Test Name";
                        dataGridView1.Columns[1].HeaderText = "Status";
                        dataGridView1.Columns[2].HeaderText = "Price";
                        dataGridView1.Columns[3].HeaderText = "Patient ID";

                        dataGridView1.Columns[4].HeaderText = "Description";
                    }

                }


                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string selectedType = comboBox_type.SelectedItem.ToString();

            string sql = "SELECT [Test_Price] FROM [tbl_lab_tests] WHERE [Test_Name] = @type";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@type", selectedType);
            object result = com.ExecuteScalar();

            decimal price = Convert.ToDecimal(result);
            txt_price.Text = price.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_description.Clear();
        
            txt_price.Clear();
            comboBox_type.SelectedIndex = -1;
        }
    }
}
