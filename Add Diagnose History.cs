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
        string newUserID;
        public Add_Diagnose_History()
        {
            InitializeComponent();
        }
        private string GenerateUserID()
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

        private void txt_mediccation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {



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


                try
                {

                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Room(s) available
                        txt_medication.Items.Clear(); // Clear previous results

                        while (reader.Read())
                        {
                            string roomNumber = reader["Medicine"].ToString();
                            txt_medication.Items.Add(roomNumber); // Display available room numbers
                            count = count + 1;

                        }
                    }

                    else
                    {
                        MessageBox.Show("No available rooms of this type.");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
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
                        patientID= rows["Patient ID"].ToString();





                    }
                    //disconnect from sql server 
                    con.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                



                SqlCommand cmd = new SqlCommand("Insert Into tbl_diagnostic_data Values('" + newUserID + "','" + txt_date.Text + "','" + txt_description.Text + "','" + txt_medication.Text + "','" + txt_allergies.Text + "','" + patientID + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
             
                MessageBox.Show("added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Add_Diagnose_History_Load(object sender, EventArgs e)
        {
             newUserID = GenerateUserID();
            
        }
    }
}
