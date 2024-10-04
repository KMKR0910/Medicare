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
            
        }
        string userType;
        


        private void btn_search_Click(object sender, EventArgs e)
        {
            
            try
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
                    sql = @"[Pharamacists_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB]
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
                          "[Last Name] = @Lname, [Address] = @address, DOB = @DOB, [Email Address] = @email, Salary = @salary, " +
                          "Qualifications = @qualification, ContactNumber = @number WHERE [Med_Assistant_ID] = @userid";
                }
                if (userType == "Pharmacists")
                {
                    sql = "UPDATE [tbl_Pharamacists] SET  [First Name] = @Fname, " +
                          "[Last Name] = @Lname, [Address] = @address, DOB = @DOB, [Email Address] = @email, Salary = @salary, " +
                          "Qualifications = @qualification, ContactNumber = @number WHERE [Pharamacists_ID] = @userid";
                }
                if (userType == "Laboratory Assistant")
                {
                    sql = "UPDATE [tbl_Lab_Assistant] SET [First Name] = @Fname, " +
                          "[Last Name] = @Lname, [Address] = @address, DOB = @DOB, [Email Address] = @email, Salary = @salary, " +
                          "Qualifications = @qualification, ContactNumber = @number WHERE [Lab-Assistant_ID] = @userid";
                }
                if (userType == "Admin")
                {
                    sql = "UPDATE [tbl_Admin] SET [First Name] = @Fname, [Last Name] = @Lname, " +
                          "[Address] = @address, DOB = @DOB, [Email Address] = @email, Salary = @salary, ContactNumber = @number " +
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

                    // Assuming you want the data from the first column (index 0)
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
                        userType = "Pharmacists";
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
                        sql = "SELECT [Address] FROM  [tbl_Medical_Centre_Assistant] WHERE [Med_Assistant_ID] = @userid";
                    }

                    if (userType == "Pharmacists")
                    {
                        sql = "SELECT [Address] FROM [tbl_Pharamacists] WHERE [Pharamacists_ID] = @userid";
                    }

                    if (userType == "Laboratory Assistant")
                    {
                        sql = "SELECT [Address] FROM  [tbl_Lab_Assistant] WHERE [Lab-Assistant_ID] = @userid";
                    }

                    if (userType == "Admin")
                    {
                        sql = "SELECT [Address] FROM [tbl_Admin] WHERE [Admin_ID] = @userid";
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

                    dateTimePicker_DOB.Text = cellValue5;

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
                string sql = "";
                userType = this.combobox_user.SelectedItem.ToString();

                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                // save user details
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
                // save user details
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                if (userType == "Doctor")
                {
                    sql = @"DELETE FROM [tbl_doctor] WHERE [Doctor ID] =@ID";


                }

                if (userType == "Medical Centre Assistant")
                {

                    sql = @"DELETE FROM [tbl_Medical_Centre_Assistant]  WHERE[Med_Assistant_ID] =@ID";




                }

                if (userType == "Pharamacists")
                {
                    sql = @"DELETE FROM [tbl_Pharamacists] WHERE[Pharamacists_ID]=@ID";



                }

                if (userType == "Laboratary Assistant")
                {
                    sql = @"DELETE FROM [tbl_Lab_Assistant] WHERE [Lab-Assistant_ID] =@ID";



                }
                if (userType == "Admin")
                {
                    sql = @"DELETE FROM [tbl_Admin] WHERE [Admin_ID] =@ID";




                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
