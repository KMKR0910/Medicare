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
    public partial class Med_Add_Appoinment : Form
    {
        string appointmentID;
        string lastThreeDigits;
        string status = "Pending";
        string SessionStatus1 = "Booked";
        string SessionStatus2 = "Avaliable";
             private string _userId;
        public Med_Add_Appoinment(string userID)
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_check.BackColor = customC;
            btn_add.BackColor = customC;

            btn_clear.BackColor = customC;
            _userId = userID;
        }

        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

       

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();
                string selectSql = "SELECT [Patient ID] FROM tbl_patient_info WHERE [Contact Number] = @number";
                SqlCommand selectCmd = new SqlCommand(selectSql, con1);
                selectCmd.Parameters.AddWithValue("@number", this.txt_contact.Text);

                // Execute the query and retrieve the Patient_ID
                object patientId = selectCmd.ExecuteScalar();
                if (patientId != null)
                {
                  


                    string sql = "INSERT INTO tbl_appoinment ([Patient ID],Date,time,[Appoinment Number],[status],[Med_Assistant_ID])" +
                    "VALUES (@id,@date,@time,@number,@status,@medid)";
                    SqlCommand com = new SqlCommand(sql, con1);


                    com.Parameters.AddWithValue("@date", this.dateTimePicker_date.Value.Date);
                    com.Parameters.AddWithValue("@time", this.txt_time.Text);
                    com.Parameters.AddWithValue("@number", this.txt_AppoinmentNumber.Text);
                    com.Parameters.AddWithValue("@id", patientId);
                    com.Parameters.AddWithValue("@status", status);
                    com.Parameters.AddWithValue("@medid", _userId);









                    int ret = com.ExecuteNonQuery();
                    if (ret == 1)
                    {
                        MessageBox.Show("Appoinment Updated", "Information");
                        Med_Add_Appoinment_Load(this, EventArgs.Empty);

                    }



                    string sql1 = "UPDATE [DoctorSessions] SET [AppointmentStatus] = @status WHERE  [AppointmentNumber]=@number AND  [SessionDate]=@date";
                    SqlCommand com1 = new SqlCommand(sql1, con1);

                    com1.Parameters.AddWithValue("@date", this.dateTimePicker_date.Value.Date);
                    com1.Parameters.AddWithValue("@status", SessionStatus1);
                    com1.Parameters.AddWithValue("@number", this.txt_AppoinmentNumber.Text);
                    int ret1 = com1.ExecuteNonQuery();

                    con1.Close();


                    this.txt_time.Clear();
                    this.txt_AppoinmentNumber.Clear();
                   
                    
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brn_delete_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();


                string sql = "DELETE a " +
                             "FROM tbl_appoinment a " +
                             "INNER JOIN tbl_patient_info p ON a.Patient_ID = p.Patient_ID " +
                             "WHERE p.Name = @name AND a.Date = @date AND a.Time = @time AND a.[Appoinment Number] = @number";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@name", this.txt_patient_name.Text);
                com.Parameters.AddWithValue("@date", this.dateTimePicker_date.Value);
                com.Parameters.AddWithValue("@time", this.txt_time.Text);
                com.Parameters.AddWithValue("@number", this.txt_AppoinmentNumber.Text);


                string sql1 = "UPDATE [DoctorSessions] SET [AppointmentStatus] = @status WHERE  [AppointmentNumber]=@number AND  [SessionDate]=@date";
                SqlCommand com1 = new SqlCommand(sql1, con1);

                com1.Parameters.AddWithValue("@date", this.dateTimePicker_date.Value.Date);
                com1.Parameters.AddWithValue("@status", SessionStatus2);
                com1.Parameters.AddWithValue("@number", this.txt_AppoinmentNumber.Text);
               


                int ret = com.ExecuteNonQuery();
                if (ret >0 )
                {
                    MessageBox.Show("Appoinment Deleted and Session Updated", "Information");
                }
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Med_Add_Appoinment_Load(object sender, EventArgs e)
        {




            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                SELECT a.[Appoinment Number], a.[time] AS Time ,  p.Name AS PatientName , a.[status] AS AppoinmentStatus
            FROM [tbl_appoinment] a
            JOIN tbl_patient_info p ON a.[Patient ID] = p.[Patient ID]
            
            WHERE a.[Date] >= @date"
;
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@date", DateTime.Now.Date);



                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_appointment.DataSource = ds.Tables[0];
                dataGridView_appointment.Columns[2].HeaderText = "Name";
                dataGridView_appointment.Columns[3].HeaderText = "Status";
          


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            // Create an instance of the AppointmentGenerator
            AppointmentGenerator appointmentGenerator = new AppointmentGenerator(con);

            // Generate the appointment ID
            appointmentID = appointmentGenerator.GenerateAppointmentID();

            // Display the appointment ID (or save it to your database)
            lastThreeDigits = appointmentID.Substring(appointmentID.Length - 3);

            txt_time.Text = lastThreeDigits;
            */
        }
        /*public class AppointmentGenerator
        {
            private SqlConnection connection;

            public AppointmentGenerator(SqlConnection con)
            {
                this.connection = con;
            }
            public string GenerateAppointmentID()
            {

                // Get the current date
                string datePart = DateTime.Now.ToString("yyyyMMdd");  // yyyyMMdd format (year, month, day)

                // Get the next appointment number for today
                int appointmentNumber = GetNextAppointmentNumberForToday();  // Automatically calculate appointmentNumber

                // Format the appointment ID
                string appointmentID = $"AP{datePart}{appointmentNumber.ToString("D3")}";  // D3 formats number with 3 digits (001, 002, etc.)

                return appointmentID;
            }
            private int GetNextAppointmentNumberForToday()
            {


                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


                SqlConnection con = new SqlConnection(cs);
                con.Open();

                // Query the database to find the last appointment number for today
                string dateToday = DateTime.Now.ToString("yyyy-MM-dd");  // Format for SQL query

                string sql = "SELECT COUNT(*) FROM tbl_appoinment WHERE CAST([Date] AS DATE) = @dateToday";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@dateToday", dateToday);

                // Execute the query
                int appointmentCount = (int)cmd.ExecuteScalar();

                // Return the next number
                return appointmentCount + 1;  // Increment count for the new appointment
            }
        }*/



        private void txt_contact_TextChanged(object sender, EventArgs e)
        {

            string sql = "SELECT [Name] FROM tbl_patient_info WHERE [Contact Number]=@number";


            if (string.IsNullOrWhiteSpace(this.txt_contact.Text))
            {
                MessageBox.Show("Please enter a Contact Number");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {

                        com.Parameters.AddWithValue("@number", this.txt_contact.Text);

                        using (SqlDataReader dr = com.ExecuteReader())
                        {
                            // Check  any rows are returned
                            if (dr.HasRows)
                            {
                                dr.Read();
                                this.txt_patient_name.Text = dr.GetString(0);
                            }
                            else
                            {
                                if (txt_contact.TextLength == 2)
                                {
                                    MessageBox.Show("No patient found with the provided number");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred : " + ex.Message);
                }
            }
        }



        private void btn_check_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();

                string sql = "SELECT [AppointmentNumber],[StartTime],[EndTime] ,[AppointmentStatus]FROM [DoctorSessions] WHERE [SessionDate]= @date AND [AppointmentStatus] = @status";

                SqlCommand cmd = new SqlCommand(sql, con1);
                cmd.Parameters.AddWithValue("@date", dateTimePicker_date.Value.Date);
                cmd.Parameters.AddWithValue("@status", SessionStatus2);


                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dap.Fill(ds);



                this.dataGridView_appointment.DataSource = ds.Tables[0];
               

                if (ds.Tables[0].Rows.Count > 0)
                {


                    this.dataGridView_appointment.DataSource = ds.Tables[0];
                    dataGridView_appointment.Columns[0].HeaderText = "Appoinment Number";
                    dataGridView_appointment.Columns[1].HeaderText = "Start Time";
                    dataGridView_appointment.Columns[2].HeaderText = "End Time";
                    dataGridView_appointment.Columns[3].HeaderText = "Status";

                }
                else
                {
                    MessageBox.Show("No Appoinments avaliable for this day");
                }
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message);
            }
        }

        private void dataGridView_appointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView_appointment.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                string cellValue = row.Cells[0].Value.ToString();
                string cellValue2 = row.Cells[1].Value.ToString();

                // Set the value to the TextBox
                txt_AppoinmentNumber.Text = cellValue;
                txt_time.Text = cellValue2;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_contact.Clear();
            txt_patient_name.Clear();
            txt_AppoinmentNumber.Clear();
            txt_time.Clear();

        }
    }
}