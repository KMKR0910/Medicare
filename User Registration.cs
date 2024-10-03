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
        string userType;
        string UserID1;


        private string GenerateUserID()
        {


            string lastUserID = null;
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
            string query = "";
            userType = this.comboBox_postion.Text;

            SqlConnection con = new SqlConnection(cs);

            try
            {

                con.Open();
                if (userType == "Doctor")
                {


                    query = "SELECT TOP 1 [Doctor ID] FROM [tbl_doctor] ORDER BY [Doctor ID] DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lastUserID = reader["Doctor ID"].ToString();
                    }

                    // If no users exist yet, start with "U001"
                    if (string.IsNullOrEmpty(lastUserID))
                    {
                        UserID1 = "DOC1";
                    }
                    else
                    {
                        // Extract the numeric part of the UserID and increment it
                        string numericPart = lastUserID.Substring(1);
                        int newNumericPart = int.Parse(numericPart) + 1;

                        // Format the new user ID to have leading zeros
                        UserID1 = "DOC" + newNumericPart.ToString("D1");
                    }
                }
                else if (userType == "Medical Centre Assistant")
                {


                    query = "SELECT TOP 1 [Med_Assistant_ID] FROM [tbl_Medical_Centre_Assistant] ORDER BY[Med_Assistant_ID] DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lastUserID = reader["Med_Assistant_ID"].ToString();
                    }

                    // If no users exist yet, start with "U001"
                    if (string.IsNullOrEmpty(lastUserID))
                    {
                        UserID1 = "MED1";
                    }
                    else
                    {
                        // Extract the numeric part of the UserID and increment it
                        string numericPart = lastUserID.Substring(1);
                        int newNumericPart = int.Parse(numericPart) + 1;

                        // Format the new user ID to have leading zeros
                        UserID1 = "MED" + newNumericPart.ToString("D1");
                    }


                }
                else if (userType == "Pharamacists")
                {


                    query = "SELECT TOP 1 [Pharamacists_ID] FROM [tbl_Pharamacists] ORDER BY[Pharamacists_ID] DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lastUserID = reader["Pharamacists_ID"].ToString();
                    }

                    // If no users exist yet, start with "U001"
                    if (string.IsNullOrEmpty(lastUserID))
                    {
                        UserID1 = "PHA1";
                    }
                    else
                    {
                        // Extract the numeric part of the UserID and increment it
                        string numericPart = lastUserID.Substring(1);
                        int newNumericPart = int.Parse(numericPart) + 1;

                        // Format the new user ID to have leading zeros
                        UserID1 = "PHA" + newNumericPart.ToString("D1");
                    }

                  




                }
                else if (userType == "Laboratary Assistant")
                {


                    query = "SELECT TOP 1 [Lab-Assistant_ID] FROM [tbl_Lab_Assistant] ORDER BY[Lab-Assistant_ID] DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lastUserID = reader["Lab-Assistant_ID"].ToString();
                    }

                    // If no users exist yet, start with "U001"
                    if (string.IsNullOrEmpty(lastUserID))
                    {
                        UserID1 = "LAB1";
                    }
                    else
                    {
                        // Extract the numeric part of the UserID and increment it
                        string numericPart = lastUserID.Substring(1);
                        int newNumericPart = int.Parse(numericPart) + 1;

                        // Format the new user ID to have leading zeros
                        UserID1 = "LAB" + newNumericPart.ToString("D1");
                    }






                }
                else if (userType == "Admin")
                {


                    query = "SELECT TOP 1  [Admin_ID]FROM [tbl_Admin] ORDER BY[Admin_ID] DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lastUserID = reader["Admin_ID"].ToString();
                    }

                    // If no users exist yet, start with "U001"
                    if (string.IsNullOrEmpty(lastUserID))
                    {
                        UserID1 = "ADM1";
                    }
                    else
                    {
                        // Extract the numeric part of the UserID and increment it
                        string numericPart = lastUserID.Substring(1);
                        int newNumericPart = int.Parse(numericPart) + 1;

                        // Format the new user ID to have leading zeros
                        UserID1 = "ADM" + newNumericPart.ToString("D1");
                    }






                }




                return UserID1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }
        private string GeneratePassword(int length) {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                password.Append(validChars[random.Next(validChars.Length)]);
            }

            return password.ToString();

        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                string v1 = txt_address_HNO.Text;
                string v2 = txt_address_StreetName.Text;
                string v3 = txt_address_city.Text;

                string address = v1 + " , " + v2 + " ,"  + v3;
                string sql = "";
                userType = this.comboBox_postion.Text;
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

                if (userType == "Doctor")
                {
                    sql = "INSERT INTO [tbl_doctor] ([Doctor ID],[User Password],[First Name],[Last Name],Address,DOB,[Email Address],Qualifications,ContactNumber)" +
                        "VALUES (@userid,@userpwd,@Fname,@Lname,@address,@DOB,@email,@qualification,@number)"; 

                }

                if (userType == "Medical Centre Assistant")
                {
                    sql = "INSERT INTO [tbl_Medical_Centre_Assistant] ([Med_Assistant_ID] ,[User Password],[First Name],[Last Name],[Address],DOB,[Email Address],Salary,Qualifications,ContactNumber)" +
                        "VALUES (@userid,@userpwd,@Fname,@Lname,@address,@DOB,@email,@salary,@qualification,@number)";

                }

                if (userType == "Pharamacists")
                {
                    sql = "INSERT INTO tbl_Pharamacists (Pharamacists_ID,[User Password],[First Name],[Last Name],[Address],DOB,[Email Address],Salary,Qualifications,ContactNumber)" +
                        "VALUES (@userid,@userpwd,@Fname,@Lname,@address,@DOB,@email,@salary,@qualification,@number)";

                }

                if (userType == "Laboratary Assistant")
                {
                    sql = "INSERT INTO [tbl_Lab_Assistant] ([Lab-Assistant_ID],[User Password],[First Name],[Last Name],[Address],DOB,[Email Address],Salary,Qualifications,ContactNumber)" +
                        "VALUES (@userid,@userpwd,@Fname,@Lname,@address,@DOB,@email,@salary,@qualification,@number)";

                }
                if (userType == "Admin")
                {
                    sql = "INSERT INTO [tbl_Admin] ([Admin_ID],[User Password],[First Name],[Last Name],[Address],DOB,[Email Address],Salary,ContactNumber)" +
                        "VALUES (@userid,@userpwd,@Fname,@Lname,@address,@DOB,@email,@salary,@qualification,@number)";

                }



                SqlCommand com = new SqlCommand(sql, con1);

                    com.Parameters.AddWithValue("@userid", this.txt_userID.Text);
                    com.Parameters.AddWithValue("@userpwd", this.txt_userpwd.Text);
                    com.Parameters.AddWithValue("@Fname", this.txt_F_name.Text);
                    com.Parameters.AddWithValue("@Lname", this.txt_L_Name.Text);
                   
                   
                    com.Parameters.AddWithValue("@address", address);
                    com.Parameters.AddWithValue("@DOB", this.dateTimePicker_DOB.Value);
                    com.Parameters.AddWithValue("@email", this.txt_email.Text);
                    com.Parameters.AddWithValue("@salary", this.numericUpDown_salary.Text);
                com.Parameters.AddWithValue("@qualification", this.txt_qulifications.Text);
                com.Parameters.AddWithValue("@number", this.txt_contact.Text);








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
            

           
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_F_name.Clear();
            this.txt_L_Name.Clear();
            this.txt_address_HNO.Clear();
            this.txt_address_StreetName.Clear();
            this.txt_address_city.Clear();
            this.txt_contact.Clear();
            this.txt_contact2.Clear();
            this.txt_email.Clear();
            this.comboBox_postion.SelectedIndex = -1;
            this.numericUpDown_salary.Value = 0;
            this.txt_qulifications.Clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            Users_Login m1 = new Users_Login();
            m1.Show();
            this.Hide();
        }

        private void dateTimePicker_DOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_postion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newUserID = GenerateUserID();
            int plengh = 4;
            string newuserpassword = GeneratePassword(plengh);
            txt_userpwd.Text = newuserpassword;

            if (!string.IsNullOrEmpty(newUserID))
            {
                txt_userID.Text = newUserID;

            }
        }

        private void txt_contact2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address_HNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address_StreetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qulifications_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_F_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_L_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_salary_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
