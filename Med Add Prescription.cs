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
    public partial class Med_Add_Prescription : Form
    {

        private string _userId;
        public Med_Add_Prescription(string userID)
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
            btn_add.BackColor = customC;

            btn_cancel.BackColor = customC;
            btn_delete.BackColor = customC;
            _userId = userID;


        }
        string prescriptionNumber;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {
                if (string.IsNullOrEmpty(this.txt_dosage.Text) || string.IsNullOrEmpty(this.txt_duration.Text) || string.IsNullOrEmpty(this.txt_medicine.Text) || string.IsNullOrEmpty(this.txt_prescripton_number.Text))
                {
                    MessageBox.Show("All required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();


                    SqlCommand cmd = new SqlCommand("Insert Into tbl_prescript Values('" + txt_patient_ID.Text + "','" + txt_medicine.Text + "','" + txt_dosage.Text + "','" + txt_duration.Text + "','" + txt_date.Text + "','" + prescriptionNumber + "','" + _userId + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("added successfully");
                }
            SqlConnection con1 = new SqlConnection(cs);
            con1.Open();

            string query = "SELECT  [patientid],[Medicine],[Dosage],[Duration],[PrescriptionNumber] FROM tbl_prescript WHERE PrescriptionNumber = @number";
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
                dataGridView1.Columns[0].HeaderText = "Patient ID";
                    dataGridView1.Columns[4].HeaderText = "Prescription Number";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Med_Add_Prescription_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog = Diploma Final Project DB1; Integrated Security=True";

            try
            {

                if (string.IsNullOrEmpty(this.txt_search.Text))
                {
                    MessageBox.Show("All required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    DateTime currentDate = DateTime.Now.Date;
                    this.txt_date.Text = currentDate.ToString("yyyy-MM-dd");  // Converts DateTime to string in "YYYY-MM-DD" format


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
                   prescriptionNumber = GeneratePrescriptionNumber(patientId);

                    // Display the generated prescription number
                    string lastThreeDigits = prescriptionNumber.Substring(prescriptionNumber.Length - 3);
                    this.txt_prescripton_number.Text= lastThreeDigits;
                }
                else
                {
                    MessageBox.Show("Please enter a valid Patient ID");
                }
            }

        }
        private string GeneratePrescriptionNumber(string patientId)
        {
            // Get the current date in yyyyMMdd format
            string currentDate = DateTime.Now.ToString("yyyyMMdd");

            // Start with a base sequence of 001
            string sequence = "001";
            string cs = "Data Source=ASUS; Initial Catalog = Diploma Final Project DB1; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            

                // Query to get the last prescription number for the current date and patient
                string query = @"SELECT TOP 1 PrescriptionNumber 
                             FROM tbl_prescript
                             WHERE PrescriptionNumber LIKE @prefix + '%'
                             ORDER BY PrescriptionNumber DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // The prefix would be the current date + patient ID
                    string prefix = currentDate + patientId;

                    cmd.Parameters.AddWithValue("@prefix", prefix);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Extract the last 3 digits of the last prescription number
                        string lastPrescriptionNumber = result.ToString();
                        int lastSequence = int.Parse(lastPrescriptionNumber.Substring(lastPrescriptionNumber.Length - 3));

                        // Increment the sequence
                        sequence = (lastSequence + 1).ToString("D3"); // D3 ensures it's always 3 digits (001, 002, etc.)
                    }
                }
            

            // Combine the current date, patient ID, and sequence to form the prescription number
            return currentDate + patientId + sequence;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                string cellValue = row.Cells[0].Value.ToString();
                string cellValue2 = row.Cells[1].Value.ToString();
                string cellValue3 = row.Cells[2].Value.ToString();
                string cellValue4 = row.Cells[3].Value.ToString();
              

                // Set the value to the TextBox
                txt_patient_ID.Text = cellValue;
                txt_medicine.Text = cellValue2;
                txt_dosage.Text = cellValue3;
                txt_duration.Text = cellValue4;
               


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
                             "FROM [tbl_prescript] " +

                             "WHERE [PrescriptionNumber] = @number ";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@number", prescriptionNumber);
                

                int ret = com.ExecuteNonQuery();
                if (ret >0)
                {
                    MessageBox.Show("Prescription Deleted", "Information");
                    string query = "SELECT  [patientid],[Medicine],[Dosage],[Duration]FROM tbl_prescript WHERE PrescriptionNumber = @number";
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
                        dataGridView1.Columns[0].HeaderText = "Patient ID";
                      


                    }
                }
            
        
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_dosage.Clear();
            txt_duration.Clear();
            txt_medicine.Clear();

        }
    }
}
