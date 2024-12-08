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
    public partial class Doctor_Genarate_Medical_Certificate : Form
    {
        public Doctor_Genarate_Medical_Certificate()
        {
            InitializeComponent();
          
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
            btn_genarate.BackColor = customC;

            btn_cancel.BackColor = customC;
            

        }

        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

        private void btn_search_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "SELECT * FROM tbl_patient_info WHERE [Contact Number] = @number ";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@number", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow rows = ds.Tables[0].Rows[0];


                    this.txt_Name.Text = rows["Name"].ToString();
                    this.txt_address.Text = rows["Address"].ToString();
                    this.dateTimePicker_DOB.Text = rows["DOB"].ToString();

                    this.txt_contact.Text = rows["Contact Number"].ToString();


                }
                DateTime dob = this.dateTimePicker_DOB.Value;
                int age = DateTime.Now.Year - dob.Year;

                // If the birthday hasn't occurred this year, subtract one from the age
                if (DateTime.Now.DayOfYear < dob.DayOfYear)
                {
                    age--;
                }

                this.txt_age.Text = age.ToString();


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


                string sql = "SELECT MAX ([MC_ID]) FROM [tbl_M_certificate]";
                SqlCommand com = new SqlCommand(sql, con); //This creates a SQL command object (com) with the query (sql) and an established connection (con)

                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {

                    // when you have a blank value of the first coloumn in current row you should tyep this code
                    if (dr.GetValue(0).ToString() == "")
                    {
                        this.txt_MCID.Text = "1"; //if have a blank sapace in item code must 1
                    }
                    else
                    {
                        this.txt_MCID.Text = (Convert.ToInt32(dr.GetValue(0).ToString()) + 1).ToString();// if there is a value in item code
                    }
                }
                else
                {
                    this.txt_MCID.Text = "1"; // if there is no any filled rows in table
                }



                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       /* private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();
                string selectSql = "SELECT [Patient ID] FROM tbl_patient_info WHERE [Contact Number] = @number";
                SqlCommand selectCmd = new SqlCommand(selectSql, con1);
                selectCmd.Parameters.AddWithValue("@number", this.txt_search.Text);

                // Execute the query and retrieve the Patient_ID
                object result = selectCmd.ExecuteScalar();
                if (result != null)
                {
                    int patientId = Convert.ToInt32(result);

                    // Now, insert into tbl_M_certificate using the retrieved Patient_ID
                    string insertSql = @"
        INSERT INTO tbl_M_certificate (Description, [Issued Date], [Start Date], [End Date], [Patient ID])
        VALUES (@description, @issue, @start, @end, @id)";

                    SqlCommand insertCmd = new SqlCommand(insertSql, con1);
                    insertCmd.Parameters.AddWithValue("@description", this.txt_description.Text);
                    insertCmd.Parameters.AddWithValue("@issue", this.dateTimePicker_Issue.Value);  // Use .Value for DateTimePickers
                    insertCmd.Parameters.AddWithValue("@start", this.dateTimePicker_start.Value);
                    insertCmd.Parameters.AddWithValue("@end", this.dateTimePicker_end.Value);
                    insertCmd.Parameters.AddWithValue("@id", patientId);  // Set the Patient_ID from the previous query

                    // Execute the insert command
                    insertCmd.ExecuteNonQuery();
                }
                else
                {
                    // Handle case where no Patient_ID is found for the given Contact Number
                    MessageBox.Show("No patient found with the given contact number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       */
        private void Doctor_Genarate_Medical_Certificate_Load(object sender, EventArgs e)
        {
           
            string newID = GenerateID();

            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            // save user details
            SqlConnection con1 = new SqlConnection(cs);
            con1.Open();
            string sql = "INSERT INTO tbl_M_certificate ([MC_ID])" +
                    "VALUES (@id)";
            SqlCommand com = new SqlCommand(sql, con1);
            com.Parameters.AddWithValue("@id", newID);





        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private string GenerateID()
        {


            string lastID = null;
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);

            try
            {

                con.Open();
                string query = "SELECT TOP 1 [MC_ID] FROM tbl_M_certificate ORDER BY [MC_ID] DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lastID = reader["MC_ID"].ToString();
                }


                // If no users exist yet, start with "U001"
                if (string.IsNullOrEmpty(lastID))
                {
                    return "MC001";
                }

                // Extract the numeric part of the UserID and increment it
                string numericPart = lastID.Substring(1);
                int newNumericPart = int.Parse(numericPart) + 1;

                // Format the new user ID to have leading zeros
                return "MC" + newNumericPart.ToString("D3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }

        private void btn_genarate_Click(object sender, EventArgs e)
        {

            
            string MC_ID = txt_MCID.Text;

            Report_Gen_M_Certificate f1 = new Report_Gen_M_Certificate(MC_ID);
            f1.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_description.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                // save  details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();
                string selectSql = "SELECT [Patient ID] FROM [tbl_patient_info] WHERE [Contact Number] = @number";
                SqlCommand selectCmd = new SqlCommand(selectSql, con1);
                selectCmd.Parameters.AddWithValue("@number", this.txt_search.Text);

                // Execute the query and retrieve the Patient_ID
                object result = selectCmd.ExecuteScalar();
                if (result != null)
                {
                    int patientId = Convert.ToInt32(result);

                    // Now, insert into tbl_M_certificate using the retrieved Patient_ID
                    string insertSql = @"
        INSERT INTO tbl_M_certificate (Description, [Issued Date], [Start Date], [End Date], [Patient ID])
        VALUES (@description, @issue, @start, @end, @id)";

                    SqlCommand insertCmd = new SqlCommand(insertSql, con1);
                    insertCmd.Parameters.AddWithValue("@description", this.txt_description.Text);
                    insertCmd.Parameters.AddWithValue("@issue", this.dateTimePicker_Issue.Value);  // Use .Value for DateTimePickers
                    insertCmd.Parameters.AddWithValue("@start", this.dateTimePicker_start.Value);
                    insertCmd.Parameters.AddWithValue("@end", this.dateTimePicker_end.Value);
                    insertCmd.Parameters.AddWithValue("@id", patientId);  // Set the Patient_ID from the previous query

                    // Execute the insert command
                    insertCmd.ExecuteNonQuery();
                }
                else
                {
                    // Handle case where no Patient_ID is found for the given Contact Number
                    MessageBox.Show("No patient found with the given contact number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
