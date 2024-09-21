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
    public partial class Users_Login : Form

    {


        public Users_Login()
        {
            InitializeComponent(); // You need this to properly initialize the form controls

            
        }




        private void User_Login_Load(object sender, EventArgs e)
        {
            this.txt_password.Password = true;
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            {

                this.txt_password.Password = true;
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


                    //define sql command

                    string sql = "select [User ID],[User Password] from tbl_Internal_User WHERE [User ID]=@username AND [User Password]=@password";
                    SqlCommand com = new SqlCommand(sql, con);


                    com.Parameters.AddWithValue("@username", this.txt_username.Text);
                    com.Parameters.AddWithValue("@password", this.txt_password.Text);


                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.Read() == true)
                    {


                        Doctor_Home m1 = new Doctor_Home();
                        m1.Show();
                        this.Hide();
                    }
                    /*
                    if (dr.Read() == true)
                    {

                        string sql2 = "select [Postion] fromtbl_Internal_User WHERE [User Name]=@username ";
                        SqlCommand com2 = new SqlCommand(sql2, con);


                        SqlDataReader dr2 = com.ExecuteReader();
                        if (dr2.Read())
                        {


                            string postion = dr2["Position"].ToString();
                            if (postion == "Doctor")
                            {
                                DoctorInterface m1 = new DoctorInterface();
                                m1.Show();
                                this.Hide();
                            }
                            if (postion == "Admin")
                            {
                                AdminInterface m1 = new AdminInterface();
                                m1.Show();
                                this.Hide();
                            }
                            if (postion == "Medical Centre Assistant")
                            {
                                MedicalCentreAssistantInterface m1 = new MedicalCentreAssistantInterface();
                                m1.Show();
                                this.Hide();
                            }
                            if (postion == "Pharamacists")
                            {
                                PharamacistsInterface m1 = new PharamacistsInterface();
                                m1.Show();
                                this.Hide();
                            }
                            if (postion == "Laboratary Assistant")
                            {
                                LaborataryAssistantInterface m1 = new LaborataryAssistantInterface();
                                m1.Show();
                                this.Hide();
                            }

                }*/
                    else
                    {

                        MessageBox.Show("Invalid User Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.txt_password.Clear();


                    }
                    //disconnect from sql server 
                    con.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }




        private void checkBox_password_check1_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_password.Password = checkBox_password_check1.Checked;
        }

        private void linkLabel_forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
