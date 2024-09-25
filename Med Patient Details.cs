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
    public partial class Med_Patient_Details : Form
    {
        public Med_Patient_Details()
        {
            InitializeComponent();
            DisableFields();
        }

        private void Med_Patient_Details_Load(object sender, EventArgs e)
        {

        }
        private void DisableFields()
        {
            txt_Name.Enabled = false;
            txt_address.Enabled = false;
           
         
            dateTimePicker_DOB.Enabled = false;
            txt_email.Enabled = false;
            txt_contact.Enabled = false;
            txt_age.Enabled = false;

        }
        private void EnableFields()
        {
            txt_Name.Enabled = true;
            txt_address.Enabled = true;
            dateTimePicker_DOB.Enabled = true;
            txt_email.Enabled = true;
            txt_contact.Enabled = true;
            txt_age.Enabled = true;

        }
        public int CalculateAge(DateTime dob)
        {
            // Get today's date
            DateTime today = DateTime.Today;

            // Calculate the age
            int age = today.Year - dob.Year;

            // Adjust the age if the birthday has not occurred yet this year
            if (dob > today.AddYears(-age))
            {
                age--;
            }

            txt_age.Text = age.ToString();
            return age;
        }
        public void patientsDetail()
        {

        }
        

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "SELECT *  FROM [tbl_patient_info] WHERE [Contact Number] = @number ";
                SqlCommand com1 = new SqlCommand(sql, con);
                com1.Parameters.AddWithValue("@number", this.txt_search.Text);
                SqlDataAdapter dap = new SqlDataAdapter(com1);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow rows = ds.Tables[0].Rows[0];


                    this.txt_Name.Text = rows["Name"].ToString();
                    this.txt_address.Text = rows["Address"].ToString();
                    this.dateTimePicker_DOB.Text = rows["DOB"].ToString();
                    this.txt_contact.Text = rows["Contact Number"].ToString();
                    this.txt_email.Text = rows["email"].ToString();
                    this.comboBox_gender.Text = rows["Gender"].ToString();

                    // Parse the DOB field to a DateTime object
                    DateTime dob = DateTime.Parse(rows["DOB"].ToString());

                    // Call the method to calculate the patient's age and display it
                    CalculateAge(dob);

                }
                //disconnect from sql server 
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





                string sql = @"
                 SELECT td.* 
                 FROM tbl_diagnostic_data td
                 INNER JOIN tbl_patient_info p ON td.patient_id = p.[Patient ID]
                  WHERE p.[Contact Number] = @number";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@number", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_Diagnose.DataSource = ds.Tables[0];


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





                string sql = @"
                 SELECT td.* 
                 FROM [tbl_prescription] td
                 INNER JOIN tbl_patient_info p ON td.[Patient ID] = p.[Patient ID]
                  WHERE p.[Contact Number] = @number";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@number", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_Prescription.DataSource = ds.Tables[0];


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





                string sql = @"
                 SELECT td.* 
                 FROM [tbl_M_certificate] td
                 INNER JOIN tbl_patient_info p ON td.[Patient ID] = p.[Patient ID]
                  WHERE p.[Contact Number] = @number";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@number", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_M_Certificate.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            EnableFields();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();



                string sql = "UPDATE [tbl_patient_info] SET [Name]=@name, [Address]=@address, [DOB]=@dob,  [Contact Number]=@number1 ,[Email]=@email ,[Gender]=@gender WHERE [Contact Number]=@number,";

                SqlCommand com = new SqlCommand(sql, con1);
                com.Parameters.AddWithValue("@number", this.txt_search.Text);

                com.Parameters.AddWithValue("@name", this.txt_Name.Text);

                com.Parameters.AddWithValue("@address", this.txt_address.Text);
                com.Parameters.AddWithValue("@dob", this.dateTimePicker_DOB.Value);
                
                com.Parameters.AddWithValue("@number1", this.txt_contact.Text);

                com.Parameters.AddWithValue("@email", this.txt_email.Text);
                com.Parameters.AddWithValue("@gender", this.comboBox_gender.Text);

                int ret = com.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("User Updated", "Information");
                }
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


}

        private void dataGridView_Diagnose_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
