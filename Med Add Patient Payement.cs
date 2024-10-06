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
    public partial class Med_Add_Patient_Payement : Form
    {

        string patientID;
        private static Dictionary<string, int> dailyPaymentCount = new Dictionary<string, int>();
        string paymentId;
        string currentDate;
        string PH_payment_Type = "Drug";
        public Med_Add_Patient_Payement()
        {
            InitializeComponent();
        }


        public class PaymentGenerator
        {
            
            private SqlConnection connection;

            public PaymentGenerator(SqlConnection con)
            {
                this.connection = con;
            }

            public string GeneratePaymentID()
            {
                // Get the current date
                string datePart = DateTime.Now.ToString("yyyyMMdd");  // yyyyMMdd format (year, month, day)

                // Get the next payment number for today
                int paymentNumber = GetNextPaymentNumberForToday();  // Automatically calculate paymentNumber

                // Format the payment ID
                string paymentID = $"PAY{datePart}{paymentNumber.ToString("D3")}";  // D3 formats number with 3 digits (001, 002, etc.)

                return paymentID;
            }

            private int GetNextPaymentNumberForToday()
            {
                
                    // Query the database to find the last payment number for today
                    string dateToday = DateTime.Now.ToString("yyyy-MM-dd");  // Format for SQL query

                    string sql = "SELECT COUNT([Patient_pay_ID])FROM [tbl_Patient_Payment] WHERE CAST([Date] AS DATE) = @dateToday";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@dateToday", dateToday);

                        // Execute the query and get the current count of payments
                        int paymentCount = (int)cmd.ExecuteScalar();

                        // Return the next number
                        return paymentCount + 1;  // Increment count for the new payment
                    }
               
            }


        }

            /* Format the payment number with leading zeros
            string formattedPaymentNumber = paymentNumber.ToString("D3"); // 3 digits, e.g., 001

                // Generate the payment ID
                paymentId = "PAY" + currentDate + formattedPaymentNumber;

                // Format the payment number with leading zeros
                string paymentNumber = dailyPaymentCount[key].ToString("D3"); // 3 digits, e.g., 001

                // Generate the payment ID
                paymentId = "PAY" + currentDate + paymentNumber;
                // Output the last 3 digits of the payment ID
                string lastThreeDigits = paymentId.Substring(paymentId.Length - 3);
                this.txt_paymnet_number.Text=lastThreeDigits;

            }*/
            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Med_Add_Patient_Payement_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog=Diploma Final Project DB1; Integrated Security=True";

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // Create an instance of the PaymentGenerator
                PaymentGenerator paymentGenerator = new PaymentGenerator(con);

                // Generate the payment ID
                string paymentID = paymentGenerator.GeneratePaymentID();

                // Display the generated Payment ID (or save it to your database)

                string lastThreeDigits = paymentID.Substring(paymentID.Length - 3);
                this.txt_paymnet_number.Text = lastThreeDigits;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                SqlCommand cmd = new SqlCommand("Insert Into [tbl_Patient_Payment] Values('" + paymentId + "','" + txt_date.Text + "','" + txt_pay_type.Text + "','" + numericUpDownCost.Value + "','" + patientID + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Payment added ");
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
            SELECT p.Name, td.Patient_pay_ID,td.[Payment Type], td.[Total_Cost] ,td.[Date] 
            FROM [tbl_Patient_Payment] td
            INNER JOIN tbl_patient_info p ON td.[patirnt_ID] = p.[Patient ID]
            WHERE p.[Contact Number] = @name ";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@name", this.txt_search.Text);



                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView1.DataSource = ds.Tables[0];



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void btn_search_Click(object sender, EventArgs e)
             {
            string cs = "Data Source=ASUS; Initial Catalog = Diploma Final Project DB1; Integrated Security=True";

            try
            {
                DateTime currentDate = DateTime.Now.Date;
                this.txt_date.Text = currentDate.ToString("yyyy-MM-dd");  // Converts DateTime to string in "YYYY-MM-DD" format


                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "SELECT * FROM tbl_patient_info WHERE [Contact Number] = @name ";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@name", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow rows = ds.Tables[0].Rows[0];


                    this.txt_patient.Text = rows["Name"].ToString();
                    patientID= rows["Patient ID"].ToString();



                }

                con.Close();
                
                this.txt_pay_type.Text = PH_payment_Type;

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
            SELECT p.Name, td.Patient_pay_ID,td.[Payment Type], td.[Total_Cost] ,td.[Date] 
            FROM [tbl_Patient_Payment] td
            INNER JOIN tbl_patient_info p ON td.[patirnt_ID] = p.[Patient ID]
            WHERE p.[Contact Number] = @name ";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@name", this.txt_search.Text);
              


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView1.DataSource = ds.Tables[0];



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_paymnet_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
