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
    public partial class Admin_View_Users : Form
    {

        public Admin_View_Users()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_clear.BackColor = customC;
            btn_Clear1.BackColor = customC;
            btn_Delete.BackColor = customC;
            btn_reset.BackColor = customC;
            btn_search.BackColor = customC;
            btn_Update.BackColor = customC;
            btn_all.BackColor = customC;

        



        }
        string userType;
        


        private void btn_search_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(this.combobox_user.Text))
                {
                    MessageBox.Show("Select User Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sql = "";

                    userType = this.combobox_user.SelectedItem.ToString();
                    string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
                    SqlConnection con = new SqlConnection(cs);

                    con.Open();
                    if (userType == "Doctor")
                    {
                        sql = @"
                SELECT  [Doctor ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB]
                 FROM [tbl_doctor]";

                    }

                    if (userType == "Medical Centre Assistant")
                    {
                        sql = @"SELECT  [Med_Assistant_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB]
                 FROM [tbl_Medical_Centre_Assistant]";

                    }

                    if (userType == "Pharamacists")
                    {
                        sql = @"SELECT[Pharamacists_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB]
                 FROM [tbl_Pharamacists]";

                    }

                    if (userType == "Laboratary Assistant")
                    {
                        sql = @" SELECT [Lab-Assistant_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB]
                 FROM [tbl_Lab_Assistant]";
                    }
                    if (userType == "Admin")
                    {
                        sql = @" SELECT  [Admin_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB]
                 FROM [tbl_Admin]";

                    }
                    SqlCommand com = new SqlCommand(sql, con);


                    SqlDataAdapter dap = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    this.dataGridView_view_users.DataSource = ds.Tables[0];
                    //disconnect from sql server 
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Admin_View_Users_Load(object sender, EventArgs e)
        {
            try
            {

                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                SELECT  [Doctor ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB]
                 FROM [tbl_doctor]
                UNION
                 SELECT [Lab-Assistant_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB]
                 FROM [tbl_Lab_Assistant]
                UNION
                 
                  SELECT  [Med_Assistant_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB]
                 FROM [tbl_Medical_Centre_Assistant]
                    UNION
                  SELECT  [Pharamacists_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB]
                 FROM [tbl_Pharamacists]
                    UNION
                  SELECT  [Admin_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB]
                 FROM [tbl_Admin]"
;
                SqlCommand com = new SqlCommand(sql, con);




                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_view_users.DataSource = ds.Tables[0];
                dataGridView_view_users.Columns[0].HeaderText = "ID";
                dataGridView_view_users.Columns[3].HeaderText = "Email";
                dataGridView_view_users.Columns[4].HeaderText = "Contact Number";
                dataGridView_view_users.Columns[5].HeaderText = "Date Of Birth";
               

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try


            {

                //validation part
                

                if (string.IsNullOrEmpty(this.txt_F_name.Text) || string.IsNullOrEmpty(this.txt_L_Name.Text) || string.IsNullOrEmpty(this.txt_email.Text) || string.IsNullOrEmpty(this.txt_address_HNO.Text) || string.IsNullOrEmpty(this.txt_address_StreetName.Text) || string.IsNullOrEmpty(this.txt_address_city.Text) || string.IsNullOrEmpty(this.dateTimePicker_DOB.Text) || string.IsNullOrEmpty(this.txt_contact.Text) || string.IsNullOrEmpty(this.txt_qulifications.Text))
                {
                    MessageBox.Show("All Field must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string v1 = txt_address_HNO.Text;
                    string v2 = txt_address_StreetName.Text;
                    string v3 = txt_address_city.Text;

                    string address = v1 + " , " + v2 + " ," + v3;
                    string sql = "";

                    string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                    SqlConnection con = new SqlConnection(cs);
                    con.Open();

                    if (userType == "Doctor")
                    {
                        sql = "UPDATE [tbl_doctor] SET  [First Name] = @Fname, [Last Name] = @Lname, " +
                              "Address = @address, DOB = @DOB, [Email Address] = @email, Qualifications = @qualification, " +
                              "ContactNumber = @number WHERE [Doctor ID] = @userid";
                    }
                    if (userType == "Medical Centre Assistant")
                    {
                        sql = "UPDATE [tbl_Medical_Centre_Assistant] SET  [First Name] = @Fname, " +
                              "[Last Name] = @Lname, [Address] = @address, DOB = @DOB, [Email Address] = @email, " +
                              "Qualifications = @qualification, ContactNumber = @number WHERE [Med_Assistant_ID] = @userid";
                    }
                    if (userType == "Pharamacists")
                    {
                        sql = "UPDATE [tbl_Pharamacists] SET  [First Name] = @Fname, " +
                              "[Last Name] = @Lname, [Address] = @address, DOB = @DOB, [Email Address] = @email, " +
                              "Qualifications = @qualification, ContactNumber = @number WHERE [Pharamacists_ID] = @userid";
                    }
                    if (userType == "Laboratory Assistant")
                    {
                        sql = "UPDATE [tbl_Lab_Assistant] SET [First Name] = @Fname, " +
                              "[Last Name] = @Lname, [Address] = @address, DOB = @DOB, [Email Address] = @email,  " +
                              "Qualifications = @qualification, ContactNumber = @number WHERE [Lab-Assistant_ID] = @userid";
                    }
                    if (userType == "Admin")
                    {
                        sql = "UPDATE [tbl_Admin] SET [First Name] = @Fname, [Last Name] = @Lname, " +
                              "[Address] = @address, DOB = @DOB, [Email Address] = @email, ContactNumber = @number " +
                              "WHERE [Admin_ID] = @userid";
                    }

                    SqlCommand com = new SqlCommand(sql, con);

                    com.Parameters.AddWithValue("@userid", this.txt_userID.Text);

                    com.Parameters.AddWithValue("@Fname", this.txt_F_name.Text);
                    com.Parameters.AddWithValue("@Lname", this.txt_L_Name.Text);


                    com.Parameters.AddWithValue("@address", address);
                    com.Parameters.AddWithValue("@DOB", this.dateTimePicker_DOB.Value);
                    com.Parameters.AddWithValue("@email", this.txt_email.Text);

                    com.Parameters.AddWithValue("@qualification", this.txt_qulifications.Text);
                    com.Parameters.AddWithValue("@number", this.txt_contact.Text);








                    int ret = com.ExecuteNonQuery();
                    if (ret == 1)
                    {
                        MessageBox.Show("User Updated", "Information");
                        Admin_View_Users_Load(null, EventArgs.Empty);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


}

        private void dataGridView_view_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sql = "";
                string address = "";
                if (e.RowIndex >= 0)
                {
                    // Get the current row
                    DataGridViewRow row = dataGridView_view_users.Rows[e.RowIndex];
                   
                    string cellValue = row.Cells[0].Value.ToString();
                    string cellValue1 = row.Cells[1].Value.ToString();
                    string cellValue2 = row.Cells[2].Value.ToString();
                    string cellValue3 = row.Cells[3].Value.ToString();
                    string cellValue4 = row.Cells[4].Value.ToString();
                    string cellValue5 = row.Cells[5].Value.ToString();

                    string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                    
                    SqlConnection con = new SqlConnection(cs);

                    con.Open();

                    if (cellValue.StartsWith("DOC", StringComparison.OrdinalIgnoreCase))
                    {
                        userType = "Doctor"; 
                    }
                    if (cellValue.StartsWith("MED", StringComparison.OrdinalIgnoreCase))
                    {
                        userType = "Medical Centre Assistant";
                    }
                    if (cellValue.StartsWith("PHA", StringComparison.OrdinalIgnoreCase))
                    {
                        userType = "Pharamacists";
                    }
                    if (cellValue.StartsWith("LAB", StringComparison.OrdinalIgnoreCase))
                    {
                        userType = "Laboratory Assistant";
                    }
                    if (cellValue.StartsWith("ADM", StringComparison.OrdinalIgnoreCase))
                    {
                        userType = "Admin";
                    }



                    if (userType == "Doctor")
                    {
                        sql = "SELECT [Address],[Qualifications] FROM [tbl_doctor] WHERE [Doctor ID] = @userid";
                    }

                    if (userType == "Medical Centre Assistant")
                    {
                        sql = "SELECT [Address],[Qualifications]  FROM  [tbl_Medical_Centre_Assistant] WHERE [Med_Assistant_ID] = @userid";
                    }

                    if (userType == "Pharamacists")
                    {
                        sql = "SELECT [Address] ,[Qualifications] FROM [tbl_Pharamacists] WHERE [Pharamacists_ID] = @userid";
                    }

                    if (userType == "Laboratory Assistant")
                    {
                        sql = "SELECT [Address] ,[Qualifications] FROM  [tbl_Lab_Assistant] WHERE [Lab-Assistant_ID] = @userid";
                    }

                    if (userType == "Admin")
                    {
                        sql = "SELECT [Address] ,[Qualifications] FROM [tbl_Admin] WHERE [Admin_ID] = @userid";
                    }
                    SqlCommand com = new SqlCommand(sql, con);

                        com.Parameters.AddWithValue("@userid", txt_userID.Text);
                    
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.Read())
                    {
                        address = reader["Address"].ToString();
                        this.txt_qulifications.Text = reader["Qualifications"].ToString();
                    }


                    // Assuming the address is stored as "HouseNo , StreetName , City"
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
                  
                    // Set the value to the TextBox
                    txt_userID.Text = cellValue;
                    txt_F_name.Text = cellValue1;
                    txt_L_Name.Text = cellValue2;
                    txt_email.Text = cellValue3;
                    txt_contact.Text = cellValue4;

                    dateTimePicker_DOB.Value = DateTime.Parse(cellValue5);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txt_pwd1.Text;
                if (string.IsNullOrEmpty(this.txt_pwd1.Text) || string.IsNullOrEmpty(this.txt_pwd2.Text))
                {
                    MessageBox.Show("All Field must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Length < 4)
                {
                    MessageBox.Show("Password must be 4 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string sql = "";
                    userType = this.combobox_user.SelectedItem.ToString();

                    string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";



                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();



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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                string sql = "";

                SqlConnection con = new SqlConnection(cs);
                con.Open();

                if (userType == "Doctor")
                {
                    sql = @"DELETE FROM [tbl_doctor] WHERE [Doctor ID] =@userid";


                }

                if (userType == "Medical Centre Assistant")
                {

                    sql = @"DELETE FROM [tbl_Medical_Centre_Assistant]  WHERE[Med_Assistant_ID] =@userid";




                }

                if (userType == "Pharamacists")
                {
                    sql = @"DELETE FROM [tbl_Pharamacists] WHERE[Pharamacists_ID]=@userid";



                }

                if (userType == "Laboratary Assistant")
                {
                    sql = @"DELETE FROM [tbl_Lab_Assistant] WHERE [Lab-Assistant_ID] =@userid";



                }
                if (userType == "Admin")
                {
                    sql = @"DELETE FROM [tbl_Admin] WHERE [Admin_ID] =@userid";




                }
                SqlCommand com = new SqlCommand(sql, con);


                com.Parameters.AddWithValue("@userid", this.txt_userID.Text);


                int ret = com.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("User Deleted", "Information");
                    btn_Clear1_Click(null, EventArgs.Empty);

                    Admin_View_Users_Load(null, EventArgs.Empty);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear1_Click(object sender, EventArgs e)
        {
            this.txt_F_name.Clear();
            this.txt_L_Name.Clear();
            this.txt_address_HNO.Clear();
            this.txt_address_city.Clear();
            this.txt_address_StreetName.Clear();
            this.dateTimePicker_DOB.CustomFormat = " ";
            this.dateTimePicker_DOB.Format = DateTimePickerFormat.Custom;
            this.txt_email.Clear();
            this.txt_contact.Clear();
          
            this.txt_qulifications.Clear();
       
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_pwd1.Clear();
            this.txt_pwd2.Clear();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            Admin_View_Users_Load(null, EventArgs.Empty);
        }
        /* private void LoadUserRegister()
{
    //Create an instance of Form2
    User_Registration form2 = new User_Registration();

    // Remove borders and make the form a child control
    form2.TopLevel = false;
    form2.FormBorderStyle = FormBorderStyle.None;
    form2.Dock = DockStyle.Fill;

    // Add the form to the GroupBox
    groupBox_Main.Controls.Clear();  // Optionally clear previous controls
    groupBox_Main.Controls.Add(form2);

    // Show the form inside the GroupBox
    form2.Show();
}*/
    }
}
