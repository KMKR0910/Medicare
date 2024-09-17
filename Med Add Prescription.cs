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
        public Med_Add_Prescription()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();

                string getPatientIdSql = "SELECT PatientID FROM tbl_patient_info WHERE Name = @name";
                SqlCommand getPatientIdCmd = new SqlCommand(getPatientIdSql, con1);
                getPatientIdCmd.Parameters.AddWithValue("@name", this.txt_search.Text);

                object patientIdObj = getPatientIdCmd.ExecuteScalar();

                if (patientIdObj != null)
                {
                    int patientId = Convert.ToInt32(patientIdObj);


                    string sql = "INSERT INTO tbl_prescription ([Patient ID],Drugs, Date, Description) VALUES (@patientID,@drug, @date, @description)";
                    SqlCommand com = new SqlCommand(sql, con1);

                    com.Parameters.AddWithValue("@description", patientId);
                    com.Parameters.AddWithValue("@description", this.txt_description.Text);
                    com.Parameters.AddWithValue("@date", DateTime.Today);

                    com.Parameters.AddWithValue("@drug", this.txt_drugs.Text);
                    com.Parameters.AddWithValue("@description", this.txt_description.Text);








                    int ret = com.ExecuteNonQuery();
                    if (ret == 1)
                    {
                        MessageBox.Show("Prescription Updated", "Information");
                    }
                }
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();


                string sql = "UPDATE tbl_prescription " +
                 "SET Drugs = @drug, Date = @date, Description = @description " +
                 "FROM tbl_prescription p " +
                 "INNER JOIN tbl_patient_info pi ON p.Patient_ID = pi.Patient_ID " +  // Assuming Patient_ID is the linking column
                 "WHERE pi.Name = @name";

                SqlCommand com = new SqlCommand(sql, con1);
                com.Parameters.AddWithValue("@name", this.txt_search.Text);
                com.Parameters.AddWithValue("@description", this.txt_description.Text);
                com.Parameters.AddWithValue("@date", DateTime.Today);

                com.Parameters.AddWithValue("@drug", this.txt_drugs.Text);
                com.Parameters.AddWithValue("@description", this.txt_description.Text);

                int ret1 = com.ExecuteNonQuery();
                if (ret1 > 0)
                {
                    MessageBox.Show("Prescription updated successfully!");
                }
                else
                {
                    MessageBox.Show("No record updated.");
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
    }
}
