using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Data.SqlClient;



namespace Diploma_Final_Project_1
{
    public partial class Med_Appointments : Form
    {
        string status1 = "Completed";
        string status2 = "Pending";


        public Med_Appointments()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_complete.BackColor = customC;
      


        }

        private void Med_Appointments_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "SELECT COUNT(*)  FROM [tbl_appoinment] WHERE [Date] = @date  ";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@date", DateTime.Today.Date);

                int appointmentCount = (int)com.ExecuteScalar();

                txt_appoinment.Text = appointmentCount.ToString();


                string sql1 = "SELECT COUNT(*)  FROM [tbl_appoinment] WHERE [Date] = @date AND [status]=@status1 ";
                SqlCommand com1 = new SqlCommand(sql1, con);

                com1.Parameters.AddWithValue("@date", DateTime.Today.Date);

                com1.Parameters.AddWithValue("@status1", status1);
                int appointmentStaus1 = (int)com1.ExecuteScalar();
                txt_completed.Text = appointmentStaus1.ToString();



                string sql2 = "SELECT COUNT(*)  FROM [tbl_appoinment] WHERE [Date] = @date AND [status]=@status2 ";
                SqlCommand com2 = new SqlCommand(sql2, con);

                com2.Parameters.AddWithValue("@date", DateTime.Today.Date);

                com2.Parameters.AddWithValue("@status2", status2);
                int appointmentStaus2 = (int)com2.ExecuteScalar();
                txt_pending.Text = appointmentStaus2.ToString();

                loadAppointment();

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
                SELECT a.[time], a.[Appoinment Number], p.Name, a.[status]
            FROM [tbl_appoinment] a
            JOIN tbl_patient_info p ON a.[Patient ID] = p.[Patient ID]
            
            WHERE a.[Date] = @date"
;
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@date", DateTime.Today.Date);



                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_appointment.DataSource = ds.Tables[0];
                dataGridView_appointment.Columns[0].HeaderText = "Time";



                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadData()
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "SELECT COUNT(*)  FROM [tbl_appoinment] WHERE [Date] = @date  ";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@date", this.monthCalendar1.SelectionRange.Start.Date);

                int appointmentCount = (int)com.ExecuteScalar();

                txt_appoinment.Text = appointmentCount.ToString();


                string sql1 = "SELECT COUNT(*)  FROM [tbl_appoinment] WHERE [Date] = @date AND [status]=@status1 ";
                SqlCommand com1 = new SqlCommand(sql1, con);

                com1.Parameters.AddWithValue("@date", this.monthCalendar1.SelectionRange.Start.Date);

                com1.Parameters.AddWithValue("@status1", status1);
                int appointmentStaus1 = (int)com1.ExecuteScalar();
                txt_completed.Text = appointmentStaus1.ToString();



                string sql2 = "SELECT COUNT(*)  FROM [tbl_appoinment] WHERE [Date] = @date AND [status]=@status2 ";
                SqlCommand com2 = new SqlCommand(sql2, con);

                com2.Parameters.AddWithValue("@date", this.monthCalendar1.SelectionRange.Start.Date);

                com2.Parameters.AddWithValue("@status2", status2);
                int appointmentStaus2 = (int)com2.ExecuteScalar();
                txt_pending.Text = appointmentStaus2.ToString();



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
                SELECT a.[time] , a.[Appoinment Number], p.Name, a.[status]
            FROM [tbl_appoinment] a
            JOIN tbl_patient_info p ON a.[Patient ID] = p.[Patient ID]
            
            WHERE a.[Date] = @date"
;
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@date", monthCalendar1.SelectionRange.Start.Date);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_appointment.DataSource = ds.Tables[0];
                dataGridView_appointment.Columns[0].HeaderText = "Time";



                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            loadData();
        }
        private void loadAppointment()
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                SELECT a.[time] , a.[Appoinment Number], p.Name, a.[status]
            FROM [tbl_appoinment] a
            JOIN tbl_patient_info p ON a.[Patient ID] = p.[Patient ID]
            
            WHERE a.[Date] = @date"
;
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@date", monthCalendar1.SelectionRange.Start.Date);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_appointment.DataSource = ds.Tables[0];
                dataGridView_appointment.Columns[0].HeaderText = "Time";


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_appointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView_appointment.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                string cellValue = row.Cells[2].Value.ToString();
                string cellValue2 = row.Cells[1].Value.ToString() ;

                // Set the value to the TextBox
                txt_name.Text = cellValue;
                txt_appointmentNumber.Text = cellValue2;

            }
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            try
            {
               
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();



                string sql = @"
                UPDATE a
                SET a.[status] = @status1
                FROM [tbl_appoinment] a
                JOIN [tbl_patient_info] p ON a.[Patient ID] = p.[Patient ID]
                WHERE p.Name = @name AND a.[Appoinment Number]=@number";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@name", this.txt_name.Text);
                com.Parameters.AddWithValue("@status1", status1);
                com.Parameters.AddWithValue("@number", this.txt_appointmentNumber.Text);





                int ret = com.ExecuteNonQuery();
                if (ret >0)
                {
                    MessageBox.Show("Updated", "Information");
                    loadData();



                }
               
                
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void monthCalendar1_DateChanged(object p, EventArgs empty)
        {
            throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_appointmentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_AP_date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
