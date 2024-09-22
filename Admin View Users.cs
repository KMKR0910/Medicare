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
        string userType = this.combobox_user.Text;
        string sql1;

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
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
            }
        } 
    }
}
