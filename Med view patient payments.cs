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
    public partial class Med_view_patient_payments : Form
    {
        public Med_view_patient_payments()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_delete.BackColor = customC;
            btn_update.BackColor = customC;
            btn_clear.BackColor = customC;


        }
        string PID;//pstientID
        string cellValue;//paymentid

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                cellValue = row.Cells[4].Value.ToString();
                string cellValue2 = row.Cells[1].Value.ToString();
                string cellValue3 = row.Cells[2].Value.ToString();
                string cellValue4 = row.Cells[3].Value.ToString();
                string cellValue5 = row.Cells[0].Value.ToString();
                // Set the value to the TextBox
                txt_patient.Text = cellValue5;
               
                dateTimePicker_date.Text = cellValue4;
                numericUpDownCost.Value = Convert.ToDecimal(cellValue3);


            }
        }

        private void Med_view_patient_payments_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_end_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
            SELECT p.Name,td.[Payment Type], td.[Total_Cost] ,td.[Date] ,td.Patient_pay_ID
            FROM [tbl_Patient_Payment] td
            INNER JOIN tbl_patient_info p ON td.[patirnt_ID] = p.[Patient ID]
            WHERE td.Date BETWEEN @startDate AND @endDate ";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@name", this.txt_patient.Text);
                com.Parameters.AddWithValue("@startDate", this.dateTimePicker_start.Value.Date);
                com.Parameters.AddWithValue("@endDate", this.dateTimePicker_end.Value.Date);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[2].HeaderText = "Amount";
                dataGridView1.Columns[4].HeaderText = "Payment Number";
          



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            txt_patient_TextChanged(null, EventArgs.Empty);




            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();


                MessageBox.Show(PID);
                string sql = "UPDATE  [tbl_Patient_Payment] SET [Date] =@date, [Payment Type] =@paymentType,[Total_Cost] =@cost,[patirnt_ID] =@id WHERE  Patient_pay_ID=@pay_ID";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@id", PID);
                com.Parameters.AddWithValue("@date", this.dateTimePicker_date.Value.Date);
                com.Parameters.AddWithValue("@paymentType", this.comboBox_pay_type.Text);

                com.Parameters.AddWithValue("@cost", this.numericUpDownCost.Value);
                com.Parameters.AddWithValue("@pay_ID", this.cellValue);









                int ret = com.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Updated", "Information");

                }
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_patient_TextChanged(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "SELECT [Patient ID]  FROM [tbl_patient_info] WHERE Name = @name ";
                SqlCommand com1 = new SqlCommand(sql, con);
                com1.Parameters.AddWithValue("@name", cellValue);
                SqlDataAdapter dap = new SqlDataAdapter(com1);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow rows = ds.Tables[0].Rows[0];


                    PID = rows["Patient ID"].ToString();

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();


                string sql = "DELETE  " +
                             "FROM [tbl_Patient_Payment] " +

                             "WHERE [Patient_pay_ID] = @number ";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@number", cellValue);


                int ret = com.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Deleted", "Information");
                   
                }


                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_patient.Clear();
            txt_pay_type.Clear();
            numericUpDownCost.Value = 0;
        }
    }
}
