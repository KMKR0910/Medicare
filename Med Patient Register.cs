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
    public partial class Med_Patient_Register : Form
    {
        private string _userId;
        public Med_Patient_Register(string userID)
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_clear.BackColor = customC;
            btn_save.BackColor = customC;
            _userId = userID;


        }
        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

        string UserID1;


        private string GenerateUserID()
        {


            string lastUserID = null;
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
            string query = "";

            SqlConnection con = new SqlConnection(cs);

            try
            {

                con.Open();



                query = "SELECT TOP 1 [Patient ID] FROM [tbl_patient_info] ORDER BY [Patient ID] DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lastUserID = reader["Patient ID"].ToString();
                }

                // If no users exist yet, start with "DOC1"
                if (string.IsNullOrEmpty(lastUserID))
                {
                    UserID1 = "P00001";
                }
                else
                {
                    // Extract the numeric part of the UserID and increment it
                    string numericPart = lastUserID.Substring(1);
                    int newNumericPart = int.Parse(numericPart) + 1;

                    // Format the new user ID to have leading zeros
                    UserID1 = "P" + newNumericPart.ToString("D5");
                }


                return UserID1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private string GeneratePassword(int length)
        {
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

               
                   string sql = "INSERT INTO [tbl_patient_info] ([Patient ID],[Name],[Address],[DOB],[Contact Number],[Email],[Gender],[Password],[Med_Assistant_ID])" +
                        "VALUES (@userid,@name,@address,@DOB,@number,@email,@gender,@userpwd,@medID)";

              

               



                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@userid", this.txt_userID.Text);
                com.Parameters.AddWithValue("@userpwd", this.txt_userpwd.Text);
                com.Parameters.AddWithValue("@name", this.txt_name.Text);
               


                com.Parameters.AddWithValue("@address", this.txt_address.Text);
                com.Parameters.AddWithValue("@DOB", this.dateTimePicker_DOB.Value);
                com.Parameters.AddWithValue("@email", this.txt_email.Text);
                com.Parameters.AddWithValue("@gender", this.comboBoxGender.SelectedItem);
             
                com.Parameters.AddWithValue("@number", this.txt_contact.Text);
                com.Parameters.AddWithValue("@medID", _userId);








                int ret = com.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Patient Registered", "Information");
                    Med_Patient_Register_Load(null, EventArgs.Empty);
                }


                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Med_Patient_Register_Load(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_address.Clear();
            txt_contact.Clear();
            txt_email.Clear();
            txt_name.Clear();
            comboBoxGender.SelectedIndex = -1;
          
            
        }
    }
}
