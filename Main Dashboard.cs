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


                    //define sql command

                    string sql = "select [User ID],[User Password] from tbl_Internal_User WHERE [User ID]=@username AND [User Password]=@password";
                    SqlCommand com = new SqlCommand(sql, con);


                    com.Parameters.AddWithValue("@username", this.txt_username.Text);
                    com.Parameters.AddWithValue("@password", this.txt_password.Text);


                    SqlDataReader dr = com.ExecuteReader();

                   

                    if (dr.Read() == true)
                    {
                        dr.Close();

                        string sql2 = "select [Postion] from tbl_Internal_User WHERE [User ID]=@username ";
                        SqlCommand com2 = new SqlCommand(sql2, con);

                        com2.Parameters.AddWithValue("@username", this.txt_username.Text);

                        SqlDataReader dr2 = com2.ExecuteReader();
                        


                        if (dr2.Read()==true)
                        {
                            string postion = dr2["Postion"] != DBNull.Value ? dr2["Postion"].ToString() : string.Empty;


                            if (postion == "Doctor")
                            {
                                Doctor_Home m1 = new Doctor_Home();
                                m1.Show();
                                this.Hide();
                            }
                            else if (postion == "Admin")
                            {
                                Admin_Home m1 = new Admin_Home();
                                m1.Show();
                                this.Hide();
                            }
                            else if(postion == "Medical Centre Assistant")
                            {
                                Med_home m1 = new Med_home();
                                m1.Show();
                                this.Hide();
                            }
                            else if(postion == "Pharamacists")
                            {
                                Pha_Home m1 = new Pha_Home();
                                m1.Show();
                                this.Hide();
                            }
                            else if(postion == "Laboratary Assistant")
                            {
                                Lab_Home m1 = new Lab_Home();
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
    }
}
