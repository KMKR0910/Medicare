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
        public Doctor_Employee_User_Profile()
        {
            InitializeComponent();
            DisableFields();
        }

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

        private void btn_save_Click(object sender, EventArgs e)
        {
            try { 
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


            // save user details
            SqlConnection con1 = new SqlConnection(cs);
            con1.Open();



            string sql = "UPDATE  tbl_Internal_User SET Salary =@salary WHERE  [First Name]=@Fname";

            SqlCommand com = new SqlCommand(sql, con1);

            com.Parameters.AddWithValue("@salary", this.txt_salary.Text);

            com.Parameters.AddWithValue("@Fname", this.txt_name.Text);
         








            int ret = com.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("User Updated", "Information");
                    Doctor_Employee_User_Profile_Load();

            }
            con1.Close();
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
                 SELECT * 
                 FROM tbl_Internal_User";
                SqlCommand com = new SqlCommand(sql, con);




                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_Employees.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void btn_cancel_Click(object sender, EventArgs e)
        {

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
                string cellValue = row.Cells[4].Value.ToString();
                string cellValue2 = row.Cells[2].Value.ToString();

                // Set the value to the TextBox
                txt_Postion.Text = cellValue;
                txt_name.Text = cellValue2;

            }
        }
    }
}
