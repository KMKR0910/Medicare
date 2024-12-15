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
    public partial class Add_Diagnose_History : Form
    {
        string patientID;
        string cellValue3;
        string docID;
        string medID;
        string docIDValue;
        string medIDValue;

        private string _userId;
        // string newUserID;
        public Add_Diagnose_History(string userID)
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
            btn_delete.BackColor = customC;

            btn_add.BackColor = customC;
            btn_update.BackColor = customC;
            _userId = userID;
        }
        /* private string GenerateUserID()
         {


             string lastUserID = null;
             string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

             SqlConnection con = new SqlConnection(cs);

             try
             {

                 con.Open();
                 string query = "SELECT TOP 1 DiagnosNumber FROM tbl_diagnostic_data ORDER BY DiagnosNumber DESC";

                 SqlCommand cmd = new SqlCommand(query, con);
                 SqlDataReader reader = cmd.ExecuteReader();
                 if (reader.Read())
                 {
                     lastUserID = reader["DiagnosNumber"].ToString();
                 }


                 // If no users exist yet, start with "U001"
                 if (string.IsNullOrEmpty(lastUserID))
                 {
                     return "DG001";
                 }

                 // Extract the numeric part of the UserID and increment it
                 string numericPart = lastUserID.Substring(1);
                 int newNumericPart = int.Parse(numericPart) + 1;

                 // Format the new user ID to have leading zeros
                 return "DG" + newNumericPart.ToString("D3");
             }
             catch (Exception ex)
             {
                 MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return null;
             }


         }
        */
        private void txt_mediccation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            txt_allergies.Clear();
            txt_description.Clear();
           

            int count = 0;
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


            SqlConnection con = new SqlConnection(cs);

            con.Open();
            string sql = @"
                 SELECT td.Medicine 
                 FROM [tbl_prescript] td
                 INNER JOIN tbl_patient_info p ON td.patientid = p.[Patient ID]
                  WHERE p.[Contact Number] = @number";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@number", this.txt_search.Text);


            {




                SqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)
                {

                    txt_medication.Items.Clear(); // Clear previous results

                    while (reader.Read())
                    {
                        string roomNumber = reader["Medicine"].ToString();
                        txt_medication.Items.Add(roomNumber); // Display available room numbers
                        count = count + 1;

                    }
                }


                con.Close();


                try
                {


                    con.Open();


                    string sql1 = "SELECT *  FROM [tbl_patient_info] WHERE [Contact Number] = @number ";
                    SqlCommand com1 = new SqlCommand(sql1, con);
                    com1.Parameters.AddWithValue("@number", this.txt_search.Text);
                    SqlDataAdapter dap = new SqlDataAdapter(com1);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);


                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        DataRow rows = ds.Tables[0].Rows[0];


                        this.txt_patient_name.Text = rows["Name"].ToString();
                        patientID = rows["Patient ID"].ToString();





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



                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();




                    string sql1 = @"
                 SELECT td.* 
                 FROM tbl_diagnostic_data td
                 INNER JOIN tbl_patient_info p ON td.patient_id = p.[Patient ID]
                  WHERE p.[Contact Number] = @number";

                
                    SqlCommand com1 = new SqlCommand(sql1, con1);
                    com1.Parameters.AddWithValue("@number", this.txt_search.Text);



                    SqlDataAdapter dap = new SqlDataAdapter(com1);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    this.dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "Diagnose Number";
                    dataGridView1.Columns[5].HeaderText = "Patient ID";



                    con1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (_userId.StartsWith("DOC", StringComparison.OrdinalIgnoreCase))
            {
                docID = "DOC1";
                
                

            }
            if (_userId.StartsWith("MED", StringComparison.OrdinalIgnoreCase))
            {
                medID = "MED1";
               
            }
            else
            {
                docIDValue = "NULL";
                medIDValue = "NULL";
            }


            if (string.IsNullOrEmpty(this.txt_allergies.Text) || string.IsNullOrEmpty(this.txt_patient_name.Text))
            {
                MessageBox.Show("All required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                try
                {

                    string medicationValues = string.Join(",", txt_medication.Items.Cast<object>().Select(item => item.ToString()));




                    SqlConnection con = new SqlConnection(cs);
                    con.Open();




                    SqlCommand cmd = new SqlCommand("Insert Into tbl_diagnostic_data Values('" + txt_date.Text + "','" + txt_description.Text + "','" + medicationValues + "','" + txt_allergies.Text + "','" + patientID + "','" + docID + "',)", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {



                    SqlConnection con = new SqlConnection(cs);
                    con.Open();





                    string sql1 = @"
                 SELECT td.* 
                 FROM tbl_diagnostic_data td
                 INNER JOIN tbl_patient_info p ON td.patient_id = p.[Patient ID]
                  WHERE p.[Contact Number] = @number";
                    SqlCommand com = new SqlCommand(sql1, con);

                    com.Parameters.AddWithValue("@number", this.txt_search.Text);


                    SqlDataAdapter dap = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    this.dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "Diagnose Number";
                    dataGridView1.Columns[5].HeaderText = "Patient ID";


                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 



        private void Add_Diagnose_History_Load(object sender, EventArgs e)
        {
            // newUserID = GenerateUserID();
            txt_date.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                string cellValue = row.Cells[4].Value.ToString();
                string cellValue2 = row.Cells[2].Value.ToString();
                 cellValue3= row.Cells[0].Value.ToString();

                // Set the value to the TextBox

                txt_allergies.Text = cellValue;
                txt_description.Text = cellValue2;

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {

                

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();




                    SqlCommand cmd = new SqlCommand("UPDATE tbl_diagnostic_data SET [Description] = @description, Allergies = @allergies WHERE [DiagnosNumber] = @number ", con);


                    cmd.Parameters.AddWithValue("@description", txt_description.Text);

                    cmd.Parameters.AddWithValue("@number", cellValue3);
                    cmd.Parameters.AddWithValue("@allergies", txt_allergies.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Updated successfully");
                }
            
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql1 = @"
                 SELECT td.* 
                 FROM tbl_diagnostic_data td
                 INNER JOIN tbl_patient_info p ON td.patient_id = p.[Patient ID]
                  WHERE p.[Contact Number] = @number";
                SqlCommand com = new SqlCommand(sql1, con);

                com.Parameters.AddWithValue("@number", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView1.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                             "FROM [tbl_diagnostic_data] " +

                             "WHERE [DiagnosNumber] = @number ";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@number", cellValue3);


                int ret = com.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Dignosetic Data Deleted", "Information");




                    SqlConnection con = new SqlConnection(cs);
                    con.Open();





                    string sql2 = @"
                 SELECT td.* 
                 FROM tbl_diagnostic_data td
                 INNER JOIN tbl_patient_info p ON td.patient_id = p.[Patient ID]
                  WHERE p.[Contact Number] = @number";
                    SqlCommand com2 = new SqlCommand(sql2, con);




                    SqlDataAdapter dap = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    this.dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "Diagnose Number";
                    dataGridView1.Columns[5].HeaderText = "Patient ID";


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
