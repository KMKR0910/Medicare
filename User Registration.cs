using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Diploma_Final_Project_1
{
    public partial class User_Registration : Form
    {
        private string _userIdreg;
        public User_Registration(string userID)
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            _userIdreg = userID;
            btn_clear.BackColor = customC;
            btn_save.BackColor = customC;
        }
        string userType;
        string UserID1;

        private bool ValidateInputs()
        {
            // 1. Check for empty fields
            if (string.IsNullOrEmpty(txt_F_name.Text.Trim()))
            {
                MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_F_name.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txt_L_Name.Text.Trim()))
            {
                MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_L_Name.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txt_email.Text.Trim()))
            {
                MessageBox.Show("Email address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txt_address_HNO.Text.Trim()))
            {
                MessageBox.Show("House number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_address_HNO.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txt_address_StreetName.Text.Trim()))
            {
                MessageBox.Show("Street name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_address_StreetName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txt_address_city.Text.Trim()))
            {
                MessageBox.Show("City is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_address_city.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txt_contact.Text.Trim()))
            {
                MessageBox.Show("Contact number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_contact.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txt_qulifications.Text.Trim()))
            {
                MessageBox.Show("Qualifications are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_qulifications.Focus();
                return false;
            }

            if (comboBox_postion.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a position.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_postion.Focus();
                return false;
            }

            // 2. Name validations
            if (!Regex.IsMatch(txt_F_name.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("First name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_F_name.Focus();
                return false;
            }

            if (!Regex.IsMatch(txt_L_Name.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Last name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_L_Name.Focus();
                return false;
            }

            // 3. Email validation
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txt_email.Text.Trim(), emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
                return false;
            }

            // 4. Contact number validation
            if (!Regex.IsMatch(txt_contact.Text.Trim(), @"^[0-9]{10}$"))
            {
                MessageBox.Show("Contact number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_contact.Focus();
                return false;
            }

            // 5. Date of Birth validation
            DateTime dob = dateTimePicker_DOB.Value;
            DateTime minDate = DateTime.Now.AddYears(-100);
            DateTime maxDate = DateTime.Now.AddYears(-18); // Minimum 18 years old

            if (dob < minDate)
            {
                MessageBox.Show("Date of birth cannot be older than 100 years.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker_DOB.Focus();
                return false;
            }

            if (dob > maxDate)
            {
                MessageBox.Show("User must be at least 18 years old.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker_DOB.Focus();
                return false;
            }

            // 6. Address validations
            if (!Regex.IsMatch(txt_address_HNO.Text.Trim(), @"^[a-zA-Z0-9\-\/\\#\s]+$"))
            {
                MessageBox.Show("House number contains invalid characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_address_HNO.Focus();
                return false;
            }

            if (!Regex.IsMatch(txt_address_StreetName.Text.Trim(), @"^[a-zA-Z0-9\s\.\-]+$"))
            {
                MessageBox.Show("Street name contains invalid characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_address_StreetName.Focus();
                return false;
            }

            if (!Regex.IsMatch(txt_address_city.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("City can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_address_city.Focus();
                return false;
            }

            // 7. Qualifications validation (minimum length)
            if (txt_qulifications.Text.Trim().Length < 2)
            {
                MessageBox.Show("Qualifications must be at least 2 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_qulifications.Focus();
                return false;
            }

            // 8. Check for duplicate email in database
            if (IsEmailAlreadyExists(txt_email.Text.Trim()))
            {
                MessageBox.Show("This email address is already registered. Please use a different email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
                return false;
            }

            // 9. Check for duplicate contact number in database
            if (IsContactNumberExists(txt_contact.Text.Trim()))
            {
                MessageBox.Show("This contact number is already registered. Please use a different number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_contact.Focus();
                return false;
            }

            return true;
        }

        private bool IsEmailAlreadyExists(string email)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    // Check across all user tables
                    string query = @"
                        SELECT COUNT(*) FROM [tbl_doctor] WHERE [Email Address] = @email
                        UNION ALL
                        SELECT COUNT(*) FROM [tbl_Medical_Centre_Assistant] WHERE [Email Address] = @email
                        UNION ALL
                        SELECT COUNT(*) FROM [tbl_Pharamacists] WHERE [Email Address] = @email
                        UNION ALL
                        SELECT COUNT(*) FROM [tbl_Lab_Assistant] WHERE [Email Address] = @email
                        UNION ALL
                        SELECT COUNT(*) FROM [tbl_Admin] WHERE [Email Address] = @email";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        int totalCount = 0;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalCount += reader.GetInt32(0);
                            }
                        }

                        return totalCount > 0;
                    }
                }
            }
            catch (Exception)
            {
                // If we can't check, assume it doesn't exist (fail-safe)
                return false;
            }
        }

        private bool IsContactNumberExists(string contactNumber)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    // Check across all user tables
                    string query = @"
                        SELECT COUNT(*) FROM [tbl_doctor] WHERE ContactNumber = @contact
                        UNION ALL
                        SELECT COUNT(*) FROM [tbl_Medical_Centre_Assistant] WHERE ContactNumber = @contact
                        UNION ALL
                        SELECT COUNT(*) FROM [tbl_Pharamacists] WHERE ContactNumber = @contact
                        UNION ALL
                        SELECT COUNT(*) FROM [tbl_Lab_Assistant] WHERE ContactNumber = @contact
                        UNION ALL
                        SELECT COUNT(*) FROM [tbl_Admin] WHERE ContactNumber = @contact";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@contact", contactNumber);

                        int totalCount = 0;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalCount += reader.GetInt32(0);
                            }
                        }

                        return totalCount > 0;
                    }
                }
            }
            catch (Exception)
            {
                // If we can't check, assume it doesn't exist (fail-safe)
                return false;
            }
        }

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

                    if (string.IsNullOrEmpty(lastUserID))
                    {
                        UserID1 = "DOC1";
                    }
                    else
                    {
                        string numericPart = lastUserID.Substring(3);
                        int newNumericPart = int.Parse(numericPart) + 1;
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

                    if (string.IsNullOrEmpty(lastUserID))
                    {
                        UserID1 = "MED1";
                    }
                    else
                    {
                        string numericPart = lastUserID.Substring(3);
                        int newNumericPart = int.Parse(numericPart) + 1;
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

                    if (string.IsNullOrEmpty(lastUserID))
                    {
                        UserID1 = "PHA1";
                    }
                    else
                    {
                        string numericPart = lastUserID.Substring(3);
                        int newNumericPart = int.Parse(numericPart) + 1;
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

                    if (string.IsNullOrEmpty(lastUserID))
                    {
                        UserID1 = "LAB1";
                    }
                    else
                    {
                        string numericPart = lastUserID.Substring(3);
                        int newNumericPart = int.Parse(numericPart) + 1;
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

                    if (string.IsNullOrEmpty(lastUserID))
                    {
                        UserID1 = "ADM1";
                    }
                    else
                    {
                        string numericPart = lastUserID.Substring(3);
                        int newNumericPart = int.Parse(numericPart) + 1;
                        UserID1 = "ADM" + newNumericPart.ToString("D1");
                    }
                }

                return UserID1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating User ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Run all validations before proceeding
                if (!ValidateInputs())
                {
                    return;
                }

                string v1 = txt_address_HNO.Text.Trim();
                string v2 = txt_address_StreetName.Text.Trim();
                string v3 = txt_address_city.Text.Trim();

                string address = v1 + " , " + v2 + " , " + v3;
                string sql = "";
                userType = this.comboBox_postion.Text;

                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                // Save user details
                using (SqlConnection con1 = new SqlConnection(cs))
                {
                    con1.Open();

                    if (userType == "Doctor")
                    {
                        sql = "INSERT INTO [tbl_doctor] ([Doctor ID],[User Password],[First Name],[Last Name],Address,DOB,[Email Address],Qualifications,ContactNumber)" +
                            "VALUES (@userid,@userpwd,@Fname,@Lname,@address,@DOB,@email,@qualification,@number)";
                    }
                    else if (userType == "Medical Centre Assistant")
                    {
                        sql = "INSERT INTO [tbl_Medical_Centre_Assistant] ([Med_Assistant_ID],[User Password],[First Name],[Last Name],[Address],DOB,[Email Address],Qualifications,ContactNumber,[Admin_ID])" +
                            "VALUES (@userid,@userpwd,@Fname,@Lname,@address,@DOB,@email,@qualification,@number,@adminID)";
                    }
                    else if (userType == "Pharamacists")
                    {
                        sql = "INSERT INTO tbl_Pharamacists (Pharamacists_ID,[User Password],[First Name],[Last Name],[Address],DOB,[Email Address],Qualifications,ContactNumber,[Admin_ID])" +
                            "VALUES (@userid,@userpwd,@Fname,@Lname,@address,@DOB,@email,@qualification,@number,@adminID)";
                    }
                    else if (userType == "Laboratary Assistant")
                    {
                        sql = "INSERT INTO [tbl_Lab_Assistant] ([Lab-Assistant_ID],[User Password],[First Name],[Last Name],[Address],DOB,[Email Address],Qualifications,ContactNumber,[Admin_ID])" +
                            "VALUES (@userid,@userpwd,@Fname,@Lname,@address,@DOB,@email,@qualification,@number,@adminID)";
                    }
                    else if (userType == "Admin")
                    {
                        sql = "INSERT INTO [tbl_Admin] ([Admin_ID],[User Password],[First Name],[Last Name],[Address],DOB,[Email Address],Qualifications,ContactNumber)" +
                            "VALUES (@userid,@userpwd,@Fname,@Lname,@address,@DOB,@email,@qualification,@number)";
                    }

                    using (SqlCommand com = new SqlCommand(sql, con1))
                    {
                        com.Parameters.AddWithValue("@userid", this.txt_userID.Text);
                        com.Parameters.AddWithValue("@userpwd", this.txt_userpwd.Text);
                        com.Parameters.AddWithValue("@Fname", this.txt_F_name.Text.Trim());
                        com.Parameters.AddWithValue("@Lname", this.txt_L_Name.Text.Trim());
                        com.Parameters.AddWithValue("@address", address);
                        com.Parameters.AddWithValue("@DOB", this.dateTimePicker_DOB.Value.Date);
                        com.Parameters.AddWithValue("@email", this.txt_email.Text.Trim());
                        com.Parameters.AddWithValue("@qualification", this.txt_qulifications.Text.Trim());
                        com.Parameters.AddWithValue("@number", this.txt_contact.Text.Trim());

                        // Add adminID parameter only if needed
                        if (userType != "Doctor" && userType != "Admin")
                        {
                            com.Parameters.AddWithValue("@adminID", _userIdreg);
                        }
                        else if (userType == "Admin")
                        {
                            // For Admin registration, remove the trailing comma in SQL
                            sql = sql.Replace("@number,)", "@number)");
                        }

                        int ret = com.ExecuteNonQuery();
                        if (ret == 1)
                        {
                            MessageBox.Show("User Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_clear_Click(sender, e); // Clear form after successful registration
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601) // Primary key or unique constraint violation
                {
                    MessageBox.Show("User ID already exists. Please try again.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void User_Registration_Load(object sender, EventArgs e)
        {
            // Set minimum and maximum dates for DOB
            dateTimePicker_DOB.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker_DOB.MinDate = DateTime.Now.AddYears(-100);
            dateTimePicker_DOB.Value = DateTime.Now.AddYears(-25); // Default to 25 years old

            // Set maximum length for contact field
            txt_contact.MaxLength = 10;

            // Set maximum lengths for other fields
            txt_F_name.MaxLength = 50;
            txt_L_Name.MaxLength = 50;
            txt_email.MaxLength = 100;
            txt_address_HNO.MaxLength = 20;
            txt_address_StreetName.MaxLength = 100;
            txt_address_city.MaxLength = 50;
            txt_qulifications.MaxLength = 500;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_F_name.Clear();
            this.txt_L_Name.Clear();
            this.txt_address_HNO.Clear();
            this.txt_address_StreetName.Clear();
            this.txt_address_city.Clear();
            this.txt_contact.Clear();
            this.txt_email.Clear();
            this.comboBox_postion.SelectedIndex = -1;
            this.txt_qulifications.Clear();
            this.txt_userID.Clear();
            this.txt_userpwd.Clear();

            // Reset DOB to default
            dateTimePicker_DOB.Value = DateTime.Now.AddYears(-25);

            // Set focus to first field
            txt_F_name.Focus();
        }

        // Add real-time validation for contact number
        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limit to 10 digits
            if (txt_contact.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Add real-time validation for names
        private void txt_F_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, spaces, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txt_L_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, spaces, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txt_address_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, spaces, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        // Real-time email validation feedback
        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_email.Text))
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txt_email.Text, emailPattern))
                {
                    errorProvider1.SetError(txt_email, "Invalid email format");
                }
                else
                {
                    errorProvider1.SetError(txt_email, "");
                }
            }
        }

        // Real-time contact validation feedback
        private void txt_contact_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_contact.Text))
            {
                if (!Regex.IsMatch(txt_contact.Text, @"^[0-9]{10}$"))
                {
                    errorProvider1.SetError(txt_contact, "Must be exactly 10 digits");
                }
                else
                {
                    errorProvider1.SetError(txt_contact, "");
                }
            }
        }

        // Other event handlers remain the same...
        private void btn_cancel_Click(object sender, EventArgs e) { }

        private void dateTimePicker_DOB_ValueChanged(object sender, EventArgs e) { }

        private void comboBox_postion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string newUserID = GenerateUserID();
                int plengh = 8; // Increased password length for better security
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
        private void txt_L_Name_TextChanged(object sender, EventArgs e)
        {

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

     

        private void numericUpDown_salary_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        // Other event handlers...
    }
}