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
       // string userType = this.combobox_user.Text;
       // string sql1;

        private void btn_search_Click(object sender, EventArgs e)
        {
           /* try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);

                con.Open();
                if (userType == "Doctor")
                {
                    sql1 = "SELECT *  FROM [tbl_doctor] WHERE [Doctor ID] = @userID ";

                }

                string sql1 = "SELECT *  FROM [tbl_patient_info] WHERE [Contact Number] = @number ";
                SqlCommand com1 = new SqlCommand(sql1, con);
                com1.Parameters.AddWithValue("@number", this.txt_search.Text);
                SqlDataAdapter dap = new SqlDataAdapter(com1);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow rows = ds.Tables[0].Rows[0];


                    this.txt_patient_name.Text = rows["Name"].ToString();
                    patientID = rows["Patient ID"].ToString();





                }
                //disconnect from sql server 
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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

        }

        private void dataGridView_view_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

                // Set the value to the TextBox
                txt_userID.Text = cellValue;
                txt_F_name.Text = cellValue1;
                txt_L_Name.Text = cellValue2;
                txt_email.Text = cellValue3;
                txt_contact.Text = cellValue4;

                dateTimePicker_DOB.Text = cellValue5;

            }



        }
    }
}
