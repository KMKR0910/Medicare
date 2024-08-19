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
    public partial class User_Registration : Form
    {
        public User_Registration()
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
                string query = "SELECT TOP 1 [User ID] FROM tbl_Internal_User ORDER BY [User ID] DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lastUserID = reader["User ID"].ToString();
                }


                // If no users exist yet, start with "U001"
                if (string.IsNullOrEmpty(lastUserID))
                {
                    return "U001";
                }

                // Extract the numeric part of the UserID and increment it
                string numericPart = lastUserID.Substring(1);
                int newNumericPart = int.Parse(numericPart) + 1;

                // Format the new user ID to have leading zeros
                return "U" + newNumericPart.ToString("D3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }
    

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                /*

                string email = this.txt_email.Text;
                string phoneNumber = this.txt_contact.Text;

                if (string.IsNullOrEmpty(this.txt_F_name.Text) || string.IsNullOrEmpty(this.txt_L_Name.Text) || string.IsNullOrEmpty(this.comboBox_postion.Text) || string.IsNullOrEmpty(this.txt_address_HNO.Text) || string.IsNullOrEmpty(this.txt_address_StreetName.Text) || string.IsNullOrEmpty(this.txt_address_city.Text) || string.IsNullOrEmpty(this.dateTimePicker_DOB.Text) || string.IsNullOrEmpty(this.txt_email.Text))
                {
                    MessageBox.Show("All Field must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
                {
                    MessageBox.Show("Invalid Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {*/
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";















                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();



                string sql = "INSERT INTO tbl_Internal_User ([User ID],[First Name],[Last Name],Postion)" +
                    "VALUES (@userid,@Fname,@Lname,@postion)";
                /*
                string sql = "INSERT INTO tbl_Internal_User ([User ID],[First Name],[Last Name],Postion,[House No],[Street Name],City,DOB,[Email Address],Salary,Qualifications)" +
                        "VALUES (@userid,@Fname,@Lname,@postion,@houseNO,@streetName,@city,@DOB,@email,@salary,@qualification)";*/
                    SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@userid", this.txt_userID.Text);
                com.Parameters.AddWithValue("@Fname", this.txt_F_name.Text);
                    com.Parameters.AddWithValue("@Lname", this.txt_L_Name.Text);
                    com.Parameters.AddWithValue("@postion", this.comboBox_postion.Text);
                    /*com.Parameters.AddWithValue("@houseNO", this.txt_address_HNO.Text);
                    com.Parameters.AddWithValue("@streetName", this.txt_address_StreetName.Text);
                    com.Parameters.AddWithValue("@city", this.txt_address_city.Text);
                    com.Parameters.AddWithValue("@DOB", this.dateTimePicker_DOB.Text);
                    com.Parameters.AddWithValue("@email", this.txt_email.Text);
                    com.Parameters.AddWithValue("@salary", this.numericUpDown_salary.Text);
                    com.Parameters.AddWithValue("@qualification", this.txt_qulifications.Text)/*/








                    int ret = com.ExecuteNonQuery();
                    if (ret == 1)
                    {
                        MessageBox.Show("User Registered", "Information");
                    }
                    con1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           ////

        
        }

        private void User_Registration_Load(object sender, EventArgs e)
        {
            

            string newUserID = GenerateUserID();
            if (!string.IsNullOrEmpty(newUserID))
            {
                txt_userID.Text =newUserID;

            }
        }
    }
}
