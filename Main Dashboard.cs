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
    public partial class Main_Dashboard : Form
    {
        public Main_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            {

                this.txt_password.PasswordChar = '*';
                //validation part
                string password = txt_password.Text;
                if (string.IsNullOrEmpty(this.txt_username.Text) || string.IsNullOrEmpty(this.txt_password.Text))
                {
                    MessageBox.Show("All Field must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Length < 4)
                {
                    MessageBox.Show("Password must be 4 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string cs = "Data Source=ASUS; Initial Catalog = Diploma Final Project DB1; Integrated Security=True";

                try
                {

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string UserID = this.txt_username.Text;
                    string userType = "";
                    string sql = "";
                    if (UserID.StartsWith("DOC", StringComparison.OrdinalIgnoreCase))
                    {
                        userType = "Doctor";
                    }
                    if (UserID.StartsWith("MED", StringComparison.OrdinalIgnoreCase))
                    {
                        userType = "Medical Centre Assistant";
                    }
                    if (UserID.StartsWith("PHA", StringComparison.OrdinalIgnoreCase))
                    {
                        userType = "Pharmacists";
                    }
                    if (UserID.StartsWith("LAB", StringComparison.OrdinalIgnoreCase))
                    {
                        userType = "Laboratory Assistant";
                    }
                    if (UserID.StartsWith("ADM", StringComparison.OrdinalIgnoreCase))
                    {
                        userType = "Admin";
                    }



                    if (userType == "Doctor")
                    {
                        sql = "SELECT  [Doctor ID],[User Password] FROM [tbl_doctor] WHERE [Doctor ID] = @userid AND [User Password]=@password";
                    }

                    if (userType == "Medical Centre Assistant")
                    {
                        sql = "SELECT  [Med_Assistant_ID],[User Password] FROM  [tbl_Medical_Centre_Assistant] WHERE [Med_Assistant_ID] = @userid AND [User Password]=@password";
                    }

                    if (userType == "Pharmacists")
                    {
                        sql = "SELECT  [Pharamacists_ID],[User Password] FROM [tbl_Pharamacists] WHERE [Pharamacists_ID] = @userid AND [User Password]=@password";
                    }

                    if (userType == "Laboratory Assistant")
                    {
                        sql = "SELECT  [Lab-Assistant_ID] ,[User Password] FROM  [tbl_Lab_Assistant] WHERE [Lab-Assistant_ID] = @userid AND [User Password]=@password";
                    }

                    if (userType == "Admin")
                    {
                        sql = "SELECT  [Admin_ID],[User Password] FROM [tbl_Admin] WHERE [Admin_ID] = @userid AND [User Password]=@password ";
                    }
                    //define sql command

                    SqlCommand com = new SqlCommand(sql, con);


                    com.Parameters.AddWithValue("@userid", this.txt_username.Text);
                    com.Parameters.AddWithValue("@password", this.txt_password.Text);


                    SqlDataReader dr = com.ExecuteReader();



                    if (dr.Read() == true)
                    {
                        if (userType == "Doctor")
                        {
                            Doctor_Home m1 = new Doctor_Home(UserID);
                            m1.Show();
                            this.Hide();
                        }
                        else if (userType == "Admin")
                        {
                            Admin_Home m1 = new Admin_Home(UserID);
                            m1.Show();
                            this.Hide();
                        }
                        else if (userType == "Medical Centre Assistant")
                        {
                            Med_Home1 m1 = new Med_Home1(UserID);
                            m1.Show();
                            this.Hide();
                        }
                        else if (userType == "Pharmacists")
                        {
                            Pha_Home m1 = new Pha_Home(UserID);
                            m1.Show();
                            this.Hide();
                        }
                        else if (userType == "Laboratory Assistant")
                        {
                            Lab_Home m1 = new Lab_Home(UserID);
                            m1.Show();
                            this.Hide();
                        }

                    }

                    else
                    {

                        MessageBox.Show("Invalid User Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.txt_password.Clear();


                    }       //disconnect from sql server 
                    con.Close();





                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void Main_Dashboard_Load(object sender, EventArgs e)
        {
            this.txt_password.PasswordChar = '*';
        }

        private void checkBox_password_check1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_password_check1.Checked)
            {
                this.txt_password.PasswordChar = '\0'; // Show password
            }
            else
            {
                this.txt_password.PasswordChar = '*'; // Mask password
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
