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
    public partial class Generate_Medical_Certificate : Form
    {
        public Generate_Medical_Certificate()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog = Diploma Final Project DB1; Integrated Security=True";

            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "SELECT ID FROM tbl_patient_info WHERE Name = @name ";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@name", this.txt_search.Text);


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

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try { 
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            // save user details
            SqlConnection con1 = new SqlConnection(cs);
            con1.Open();



            string sql = "INSERT INTO tbl_M_certificate (MC_ID,Description,[Issued Date],[Start Date],[End Date])" +
                "VALUES (@MCID,@description,@issue,@start,@end From tbl_patient_info WHERE Name=@name)";
            SqlCommand com = new SqlCommand(sql, con1);

            com.Parameters.AddWithValue("@name", this.txt_Name.Text);
            com.Parameters.AddWithValue("@description", this.txt_description.Text);
            com.Parameters.AddWithValue("@issue", this.dateTimePicker_Issue.Text);
            com.Parameters.AddWithValue("@start", this.dateTimePicker_start.Text);
            com.Parameters.AddWithValue("@end", this.dateTimePicker_end.Text);
          







            int ret = com.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("Medical Certificate Updated", "Information");
            }
            con1.Close();
        }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
}

        private void Generate_Medical_Certificate_Load(object sender, EventArgs e)
        {

        }

        private void btn_genarate_Click(object sender, EventArgs e)
        {

        }
    }
}
