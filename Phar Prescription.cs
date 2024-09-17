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
    public partial class Phar_Prescription : Form
    {
        public Phar_Prescription()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phar_Prescription_Load(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {

        }
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

                }
                //disconnect from sql server 
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {

              


                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                 SELECT td.* 
                 FROM [tbl_prescription] td
                 INNER JOIN tbl_patient_info p ON td.[Patient ID] = p.[Patient ID]
                  WHERE p.[Contact Number] = @number";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@number", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_Prescription.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Prescription_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView_Prescription.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                string cellValue = row.Cells[0].Value.ToString();
                string cellValue2 = row.Cells[1].Value.ToString();
                string cellValue3 = row.Cells[2].Value.ToString();

                // Set the value to the TextBox
                txt_prescription.Text = cellValue;
                txt_drugs.Text = cellValue2;
                txt_description.Text = cellValue2;

            }
        }
    }
}
