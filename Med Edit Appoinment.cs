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
    public partial class Med_Edit_Appoinment : Form
    {
        public Med_Edit_Appoinment()
        {
            InitializeComponent();
        }

        private void Med_Edit_Appoinment_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = @"SELECT app.*, pat.[Name] 
               FROM tbl_appoinment app
               JOIN [tbl_patient_info] pat 
               ON app.[Patient ID] = pat.[Patient ID]
               WHERE app.[Appoinment Number] = @appoinmentnumber"; SqlCommand com1 = new SqlCommand(sql, con);
                com1.Parameters.AddWithValue("@appoinmentnumber", this.txt_appoinment.Text);
                SqlDataAdapter dap = new SqlDataAdapter(com1);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow rows = ds.Tables[0].Rows[0];


                    this.txt_patient_name.Text = rows["Name"].ToString();
                    this.dateTimePicker_date.Text = rows["Date"].ToString();
                    this.txt_time.Text = rows["Time"].ToString();


                }
                //disconnect from sql server 
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


                string sql = "DELETE a " +
                             "FROM tbl_appoinment a " +
                             "INNER JOIN tbl_patient_info p ON a.Patient_ID = p.Patient_ID " +
                             "WHERE p.Name = @name AND a.Date = @date AND a.Time = @time AND a.[Appoinment Number] = @number";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@name", this.txt_patient_name.Text);
                com.Parameters.AddWithValue("@date", this.dateTimePicker_date.Value);
                com.Parameters.AddWithValue("@time", this.txt_time.Text);
                com.Parameters.AddWithValue("@number", this.txt_appoinment.Text);


                int ret = com.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Appoinment Deleted", "Information");
                }
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();
                string selectSql = "SELECT [Patient ID] FROM tbl_patient_info WHERE [Name] = @name";
                SqlCommand selectCmd = new SqlCommand(selectSql, con1);
                selectCmd.Parameters.AddWithValue("@name", this.txt_patient_name.Text);

                // Execute the query and retrieve the Patient_ID
                object result = selectCmd.ExecuteScalar();
                if (result != null)
                {
                    int patientId = Convert.ToInt32(result);



                    string sql = "UPDATE  tbl_appoinment SET Date=@date ,time=@time WHERE [Appoinment Number]=@number  ";
                    SqlCommand com = new SqlCommand(sql, con1);


                    com.Parameters.AddWithValue("@date", this.dateTimePicker_date.Value);
                    com.Parameters.AddWithValue("@time", this.txt_time.Text);
                    com.Parameters.AddWithValue("@number", this.txt_appoinment.Text);
                    










                    int ret = com.ExecuteNonQuery();
                    if (ret == 1)
                    {
                        MessageBox.Show("Appoinment Updated", "Information");
                    }
                    con1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
