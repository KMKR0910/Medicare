using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoryManagement
{
    public partial class SupplerReg : Form
    {
        public SupplerReg()
        {
            InitializeComponent();
        }

        private void SupplerReg_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=FinalProject; Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);  //connection string
                con.Open();

                string sql = "INSERT INTO Supplier_Registration (First_name, Last_name, Address, contact, email, password) VALUES (@Fname, @Lname, @Address, @contact, @email, @pass)";


                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Fname", this.txtFname.Text);
                    cmd.Parameters.AddWithValue("@Lname", this.txtLname.Text);
                    cmd.Parameters.AddWithValue("@Address", this.txtAdd.Text);
                    cmd.Parameters.AddWithValue("@contact", this.txtCnum.Text);
                    cmd.Parameters.AddWithValue("@email", this.txtEmail.Text);
                    cmd.Parameters.AddWithValue("@pass", this.txtPass.Text);



                       if (this.txtFname.Text == "")
                       {
                        MessageBox.Show("Please enter your first name");
                        return;
                        }
                       if (this.txtLname.Text == "")
                       {
                        MessageBox.Show("Please enter the last name");
                        return;
                       }
                      if (this.txtAdd.Text == "")
                      {
                        MessageBox.Show("Please enter the address");
                        return;
                      }
                      if (this.txtCnum.Text == "")
                      {
                        MessageBox.Show("Please enter your contact number");
                        return;
                       
                      }
                     if (this.txtCnum.Text.Length != 10)
                     {
                        MessageBox.Show("invalid phone number, type again");
                        return;
                     }
                     if (this.txtEmail.Text == "")
                     {
                        MessageBox.Show("Please enter your Email Address");
                        return;

                     }
                     if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                      {
                        MessageBox.Show("Please enter a valid Email address");
                        return;
                      }
                     if (this.txtPass.Text == "")
                      {
                        MessageBox.Show("Please enter your Email Address");
                        return;

                      }
                     if (this.txtRpass.Text == "")
                      {
                        MessageBox.Show("Please enter password to re enter");
                        return;
                       
                      }
                    if (this.txtPass.Text != this.txtRpass.Text)
                     {
                        MessageBox.Show("Passwords do not match");
                        return;
                     }
                  
                       
                     int ret = cmd.ExecuteNonQuery();  // Executes the INSERT command. 
                        if (ret == 1)  // If one row was successfully inserted,
                        {

                            MessageBox.Show("Supplier details saved");

                        }
                        else
                        {
                            MessageBox.Show("Data not added. Please check back!");
                        }

                    try
                    {


                        String sql2 = "INSERT INTO Company_Data ( Company_Reg_Num, Name, Company_Contact, Company_Address ) VALUES ( @Cnum, @name, @contact, @Add)";
                        using (SqlCommand cmd1 = new SqlCommand(sql2, con))
                        {

                            cmd1.Parameters.AddWithValue("@Cnum", this.txtCreg.Text);
                            cmd1.Parameters.AddWithValue("@name", this.txtCName.Text);
                            cmd1.Parameters.AddWithValue("@contact", this.txtCno.Text);
                            cmd1.Parameters.AddWithValue("@Add", this.txtCaddr.Text);

                            if (this.txtCreg.Text == "")
                            {
                                MessageBox.Show("Please enter your company registration Number");
                                return;
                            }

                            if (this.txtCName.Text == "")
                            {
                                MessageBox.Show("Please enter your company name");
                                return;
                            }

                            if (this.txtCno.Text == "")
                            {
                                MessageBox.Show("Please enter your company detaisl");
                                return;
                            }
                            if (this.txtCno.Text.Length != 10)
                            {
                                MessageBox.Show("Please enter your company contavct number !");
                                return;

                            }
                            if (this.txtCaddr.Text == "")
                            {
                                MessageBox.Show("please enter your company address");
                                return;
                            }
                            int ret1 = cmd1.ExecuteNonQuery();
                            if (ret1 == 1)
                            {
                                MessageBox.Show("company datails saved");
                            }
                            else
                            {
                                MessageBox.Show("Data not added, please check again");
                            }




                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
         
                    
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);

            }

           




        }
    }
}
