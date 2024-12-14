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
    public partial class Doctor_Employee_User_Profile : Form


    {
        private string _userId;
        public Doctor_Employee_User_Profile(string userID)
        {
            InitializeComponent();
            DisableFields();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_cancel.BackColor = customC;
            btn_edit.BackColor = customC;
            btn_save.BackColor = customC;
            _userId = userID;

        }
        string cellValue;
        string userType;

        private void DisableFields()
        {
            txt_Postion.Enabled = false;
            txt_name.Enabled = false;


            txt_salary.Enabled = false;
           

        }
        private void EnableFields()
        {
            txt_Postion.Enabled = true;
            txt_salary.Enabled = true;
            txt_name.Enabled = true;
          

        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            EnableFields();
        }
        public void GetUserType()
        {
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
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(this.txt_name.Text) || string.IsNullOrEmpty(this.txt_Postion.Text) || string.IsNullOrEmpty(this.txt_salary.Text))
                {
                    MessageBox.Show("All required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sql = "";
                    string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                    // save user details
                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();
                    GetUserType();



                    if (userType == "Medical Centre Assistant")
                    {

                        sql = @"UPDATE [tbl_Medical_Centre_Assistant] SET Salary =@salary,[Doctor ID]=@doctorID WHERE  [First Name]=@Fname";



                    }

                    if (userType == "Pharamacists")
                    {
                        sql = @"UPDATE  [tbl_Pharamacists] SET Salary =@salary,[Doctor ID]=@doctorID WHERE  [First Name]=@Fname";


                    }

                    if (userType == "Laboratary Assistant")
                    {
                        sql = @"UPDATE  [tbl_Lab_Assistant] SET Salary =@salary , [Doctor ID]=@doctorID WHERE  [First Name]=@Fname";


                    }
                    if (userType == "Admin")
                    {
                        sql = @"UPDATE  [tbl_Admin] SET Salary =@salary , [Doctor ID]=@doctorID WHERE  [First Name]=@Fname";



                    }


                    SqlCommand com = new SqlCommand(sql, con1);

                    com.Parameters.AddWithValue("@salary", this.txt_salary.Text);
                    com.Parameters.AddWithValue("@doctorID", _userId);
                    com.Parameters.AddWithValue("@Fname", this.txt_name.Text);









                    int ret = com.ExecuteNonQuery();
                    if (ret == 1)
                    {
                        MessageBox.Show("User Updated", "Information");
                        Doctor_Employee_User_Profile_Load();

                    }
                    con1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void Doctor_Employee_User_Profile_Load()
        {
          
            try
            {

                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                SqlConnection con = new SqlConnection(cs);
                con.Open();




                string sql = @"
               
               
                 SELECT [Lab-Assistant_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB],[Address],Salary
                 FROM [tbl_Lab_Assistant]
                UNION
                 
                  SELECT  [Med_Assistant_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB],[Address],Salary
                 FROM [tbl_Medical_Centre_Assistant]
                    UNION
                  SELECT  [Pharamacists_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB],[Address],Salary
                 FROM [tbl_Pharamacists]
                    UNION
                  SELECT  [Admin_ID] AS UserID , [First Name],[Last Name],[Email Address],[ContactNumber],[DOB],[Address],Salary
                 FROM [tbl_Admin]"
               ;
                SqlCommand com = new SqlCommand(sql, con);




                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_Employees.DataSource = ds.Tables[0];
                dataGridView_Employees.Columns[4].HeaderText = "Contact Number";
                dataGridView_Employees.Columns[4].HeaderText = "Date Of Birth";


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_Postion.Clear();
            txt_salary.Clear();
        }

        private void Doctor_Employee_User_Profile_Load(object sender, EventArgs e)
        {

            Doctor_Employee_User_Profile_Load();
            

        }

        private void dataGridView_Employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView_Employees.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                 cellValue = row.Cells[0].Value.ToString();
                GetUserType();

                string cellValue2 = row.Cells[1].Value.ToString();

                // Set the value to the TextBox
                txt_Postion.Text = userType;
                txt_name.Text = cellValue2;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Postion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
