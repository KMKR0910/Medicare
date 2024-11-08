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
    public partial class Lab_Prescription : Form
    {
        public Lab_Prescription()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_collected.BackColor = customC;
            btn_print.BackColor = customC;
            btn_search.BackColor = customC;
            btn_view_report.BackColor = customC;
            btn_report_relesed.BackColor = customC;


        }
        string status = "Collected";
        string status2 = "Report Relesed";

        string report_ID;
        DateTime DateTime = DateTime.Now;

        public int CalculateAge(DateTime dob)
        {
            // Get today's date
            DateTime today = DateTime.Today;

            // Calculate the age
            int age = today.Year - dob.Year;

            // Adjust the age if the birthday has not occurred yet this year
            if (dob > today.AddYears(-age))
            {
                age--;
            }

            txt_age.Text = age.ToString();
            return age;
        }
        public void loadDatagrid()
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {




                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                 SELECT td.* 
                 FROM [tbl_Lab_Test_Report] td
                 INNER JOIN tbl_patient_info p ON td.Patient_ID = p.[Patient ID]
                  WHERE p.[Contact Number] = @number";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@number", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_lab.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "SELECT *  FROM [tbl_patient_info] WHERE [Contact Number] = @number ";
                SqlCommand com1 = new SqlCommand(sql, con);
                com1.Parameters.AddWithValue("@number", this.txt_search.Text);
                SqlDataAdapter dap = new SqlDataAdapter(com1);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow rows = ds.Tables[0].Rows[0];


                    this.txt_Name.Text = rows["Name"].ToString();
                    this.txt_address.Text = rows["Address"].ToString();
                    this.dateTimePicker_DOB.Text = rows["DOB"].ToString();
                    this.txt_contact.Text = rows["Contact Number"].ToString();


                    // Parse the DOB field to a DateTime object
                    DateTime dob = DateTime.Parse(rows["DOB"].ToString());

                    // Call the method to calculate the patient's age and display it
                    CalculateAge(dob);
                    loadDatagrid();

                }
                //disconnect from sql server 
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        

        private void dataGridView_lab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView_lab.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)

                string cellValue = row.Cells[7].Value.ToString();
                string cellValue2 = row.Cells[1].Value.ToString();
                string cellValue3 = row.Cells[3].Value.ToString();
                string cellValue4 = row.Cells[0].Value.ToString();

                report_ID = cellValue4;
                txt_prescripton_number.Text = cellValue;
                txt_test_name.Text = cellValue2;
                txt_price.Text = cellValue3;
               
                

            }
        }

        private void btn_collected_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();



                string sql = "UPDATE  [tbl_Lab_Test_Report] SET [Rep_status] =@status , [Blood_Collected_Time]=@time WHERE  [Lab_Report_ID]=@id";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@status", status);
                com.Parameters.AddWithValue("@time", DateTime);
                com.Parameters.AddWithValue("@id", report_ID);









                int ret = com.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Updated", "Information");
                    loadDatagrid();
                   

                }
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_test_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lab_Prescription_Load(object sender, EventArgs e)
        {

        }

        private void btn_report_relesed_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();



                string sql = "UPDATE  [tbl_Lab_Test_Report] SET [Rep_status] =@status ,[Report_Relesed_Time]=@time WHERE  [Lab_Report_ID]=@id";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@status", status2);
                com.Parameters.AddWithValue("@time", DateTime);
                com.Parameters.AddWithValue("@id", report_ID);









                int ret = com.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Updated", "Information");
                    loadDatagrid();


                }
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
