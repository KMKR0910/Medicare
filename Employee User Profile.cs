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
    public partial class Employee_User_Profile : Form
    {

        private string _userId;
        string userType;
        public Employee_User_Profile(string userID)
        {
            InitializeComponent();
            DisableFields();
            _userId = userID;
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_edit.BackColor = customC;
            btn_clear.BackColor = customC;
            btn_save.BackColor = customC;
            btn_reset.BackColor = customC;

            btn_clear2.BackColor = customC;


        }
        string sql = "";
        private void DisableFields()
        {
            txt_F_name.Enabled = false;
            txt_L_Name.Enabled = false;
            txt_address_HNO.Enabled = false;
            txt_address_StreetName.Enabled = false;
            txt_address_city.Enabled = false;
            dateTimePicker_DOB.Enabled = false;
            txt_email.Enabled = false;
            txt_contact.Enabled = false;
            txt_contact2.Enabled = false;
            txt_qulifications.Enabled = false;
            txt_pwd1.Enabled = false;
            txt_pwd2.Enabled = false;

        }
        private void EnableFields()
        {
            txt_F_name.Enabled = true;
            txt_L_Name.Enabled = true;
            txt_address_HNO.Enabled = true;
            txt_address_StreetName.Enabled = true;
            txt_address_city.Enabled = true;
            dateTimePicker_DOB.Enabled = true;
            txt_email.Enabled = true;
            txt_contact.Enabled = true;
            txt_contact2.Enabled = true;
            txt_qulifications.Enabled = true;
            txt_pwd1.Enabled = true;
            txt_pwd2.Enabled = true;

        }
        public void GetUserType()
        {
            if (_userId.StartsWith("DOC", StringComparison.OrdinalIgnoreCase))
            {
                userType = "Doctor";
            }
            if (_userId.StartsWith("MED", StringComparison.OrdinalIgnoreCase))
            {
                userType = "Medical Centre Assistant";
            }
            if (_userId.StartsWith("PHA", StringComparison.OrdinalIgnoreCase))
            {
                userType = "Pharmacists";
            }
            if (_userId.StartsWith("LAB", StringComparison.OrdinalIgnoreCase))
            {
                userType = "Laboratory Assistant";
            }
            if (_userId.StartsWith("ADM", StringComparison.OrdinalIgnoreCase))
            {
                userType = "Admin";
            }
        }
        private void ResetPassword()
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();



                string sql = "UPDATE  tbl_Internal_User SET [User Password]=@userpwd WHERE  [User ID]=@userid";
                SqlCommand com = new SqlCommand(sql, con1);


                com.Parameters.AddWithValue("@userid", this.txt_userID.Text);
                com.Parameters.AddWithValue("@userpwd", this.txt_pwd1.Text);
                com.Parameters.AddWithValue("@userpwd2", this.txt_pwd2.Text);

                if (this.txt_pwd1.Text == this.txt_pwd2.Text)
                {

                    int ret1 = com.ExecuteNonQuery();
                    if (ret1 == 1)
                    {
                        MessageBox.Show("Retrive Password successfully.", "Information");



                    }



                }
                else
                {
                    MessageBox.Show("Passwords does not match.", "Information");

                    this.txt_pwd1.Clear();
                    this.txt_pwd2.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Employee_User_Profile_Load(object sender, EventArgs e)
        {
            txt_pwd1.TextChanged += new EventHandler(txt_pwd1_TextChanged);
            txt_userID.Text = _userId;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EnableFields();
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



                string sql = "UPDATE  tbl_Internal_User SET [First Name]=@Fname,[Last Name]=@Lname WHERE  [User ID]=@userid";

                /*
                string sql = "UPDATE  tbl_Internal_User SET ([User ID],[User Password],[First Name],[Last Name],Postion,[House No],[Street Name],City,DOB,[Email Address],Salary,Qualifications)" +
                        "VALUES (@userid,@userpwd,@Fname,@Lname,@postion,@houseNO,@streetName,@city,@DOB,@email,@salary,@qualification)";*/
                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@userid", this.txt_userID.Text);

                com.Parameters.AddWithValue("@Fname", this.txt_F_name.Text);
                com.Parameters.AddWithValue("@Lname", this.txt_L_Name.Text);

                /*com.Parameters.AddWithValue("@houseNO", this.txt_address_HNO.Text);
                com.Parameters.AddWithValue("@streetName", this.txt_address_StreetName.Text);
                com.Parameters.AddWithValue("@city", this.txt_address_city.Text);
                com.Parameters.AddWithValue("@DOB", this.dateTimePicker_DOB.Text);
                com.Parameters.AddWithValue("@email", this.txt_email.Text);
                com.Parameters.AddWithValue("@salary", this.numericUpDown_salary.Text);
                com.Parameters.AddWithValue("@qualification", this.txt_qulifications.Text)
                com.Parameters.AddWithValue("@userpwd", this.txt_userpwd.Text);/*/

                if(txt_pwd2.Text == "desired_value")
                {
                    ResetPassword();
                }
                else
                {
                    MessageBox.Show("Use22Updated", "Information");

                }

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

        private void txt_pwd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_userID_TextChanged(object sender, EventArgs e)
        {
            string address; 
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
            // save user details
            SqlConnection con1 = new SqlConnection(cs);


            con1.Open();
            GetUserType();

            if (userType == "Doctor")
            {
                sql = @"SELECT *
                 FROM [tbl_doctor] WHERE [Doctor ID] =@userid";

            }

            if (userType == "Medical Centre Assistant")
            {
                sql = @"SELECT *
                 FROM [tbl_Medical_Centre_Assistant] WHERE [Med_Assistant_ID] =@userid";

            }

            if (userType == "Pharamacists")
            {
                sql = @"SELECT *
                 FROM [tbl_Pharamacists] WHERE [Pharamacists_ID] =@userid";

            }

            if (userType == "Laboratary Assistant")
            {
                sql = @"SELECT *
                 FROM [tbl_Lab_Assistant] WHERE [Lab-Assistant_ID] =@userid";
            }
            if (userType == "Admin")
            {
                sql = @"SELECT *
                 FROM [tbl_Admin] WHERE [Admin_ID] =@userid";

            }

         

            SqlCommand com = new SqlCommand(sql, con1);


            com.Parameters.AddWithValue("@userid", this.txt_userID.Text);
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);


            if (ds.Tables[0].Rows.Count > 0)
            {

                DataRow rows = ds.Tables[0].Rows[0];


                this.txt_F_name.Text = rows["First Name"].ToString();
                this.txt_L_Name.Text = rows["Last Name"].ToString();
                address = rows["Address"].ToString();
             
                this.dateTimePicker_DOB.Text = rows["DOB"].ToString();
                this.txt_email.Text = rows["Email Address"].ToString();
                this.txt_contact.Text = rows["ContactNumber"].ToString();
                this.txt_qulifications.Text = rows["Qualifications"].ToString();

                string[] addressParts = address.Split(',');
                if (addressParts.Length == 3)
                {
                    // Trim and ensure no empty parts
                    string houseNo = addressParts[0].Trim();
                    string streetName = addressParts[1].Trim();
                    string city = addressParts[2].Trim();

                    if (!string.IsNullOrEmpty(houseNo) && !string.IsNullOrEmpty(streetName) && !string.IsNullOrEmpty(city))
                    {
                        txt_address_HNO.Text = houseNo;          // House Number
                        txt_address_StreetName.Text = streetName; // Street Name
                        txt_address_city.Text = city;            // City
                    }
                    else
                    {
                        MessageBox.Show("Address contains empty parts. Please check the address entry in the database.");
                    }
                }




            }
            con1.Close();



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                

                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();

                GetUserType();

                if (userType == "Doctor")
                {
                    sql = @"UPDATE [tbl_doctor]  SET [User Password]=@newPWD WHERE [Doctor ID] =@ID";


                }

                if (userType == "Medical Centre Assistant")
                {

                    sql = @"UPDATE [tbl_Medical_Centre_Assistant] SET [User Password]=@newPWD WHERE[Med_Assistant_ID] =@ID";



                }

                if (userType == "Pharamacists")
                {
                    sql = @"UPDATE  [tbl_Pharamacists] SET [User Password]=@newPWD WHERE[Pharamacists_ID]=@ID";


                }

                if (userType == "Laboratary Assistant")
                {
                    sql = @"UPDATE  [tbl_Lab_Assistant] SET [User Password]=@newPWD WHERE [Lab-Assistant_ID] =@ID";


                }
                if (userType == "Admin")
                {
                    sql = @"UPDATE  [tbl_Admin] SET [User Password]=@newPWD WHERE [Admin_ID] =@ID";



                }


                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@ID", this.txt_userID.Text);
                com.Parameters.AddWithValue("@newPWD", this.txt_pwd1.Text);

                if (this.txt_pwd1.Text == this.txt_pwd2.Text)
                {

                    int ret = com.ExecuteNonQuery();
                    if (ret == 1)
                    {
                        MessageBox.Show("Reset Password successfully", "Information");


                    }

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