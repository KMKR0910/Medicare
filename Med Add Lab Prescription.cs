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
        }
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


                string query = "INSERT INTO [tbl_Lab_Test_Report] ([Test_Type], [Rep_status],[Test_Price],[Patient_ID],[Lab_test_number]) " +
                               "VALUES (@type, @status, @Price, @patientID,@number)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@type", comboBox_type.Text);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@Price", txt_price.Text);
                cmd.Parameters.AddWithValue("@patientID", txt_patient_ID.Text);
                cmd.Parameters.AddWithValue("@number", txt_lab_test_number.Text);


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

                string query = "SELECT * FROM [tbl_Lab_Test_Report] WHERE [Lab_test_number] = @number";
                using (SqlCommand cmd1 = new SqlCommand(query, con))
                {
                    // Add parameter to the command
                    cmd1.Parameters.AddWithValue("@number", txt_lab_test_number.Text);

                    // Create SqlDataAdapter and SqlCommandBuilder
                    SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                    // Fill the DataSet
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    // Set the DataSource of the DataGridView
                    dataGridView1.DataSource = ds.Tables[0];
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
                    string prescriptionNumber = GenerateLabTestNumber(patientId);

                    // Display the generated prescription number
                    this.txt_lab_test_number.Text = prescriptionNumber;
                }
                else
                {
                    MessageBox.Show("Please enter a valid Patient ID");
                }
            }
        }
    }
}
