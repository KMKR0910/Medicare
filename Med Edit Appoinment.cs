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
    public partial class Med_Edit_Appoinment : Form
    {
        public Med_Edit_Appoinment()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
            btn_cancel.BackColor = customC;

            btn_save.BackColor = customC;
            btn_search_date.BackColor = customC;
            btn_delete.BackColor = customC;
        }
        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
        string SessionStatus2 = "Avaliable";

        private void Med_Edit_Appoinment_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = @"SELECT app.[Appoinment Number],app.[Date],app.[time], pat.[Name] 
               FROM tbl_appoinment app
               JOIN [tbl_patient_info] pat 
               ON app.[Patient ID] = pat.[Patient ID]
               WHERE app.[Appoinment Number] = @appoinmentnumber AND [Date] >= @date"; 
                SqlCommand com1 = new SqlCommand(sql, con);
                com1.Parameters.AddWithValue("@appoinmentnumber", this.txt_appoinment.Text);
                com1.Parameters.AddWithValue("@date", DateTime.Today);
                SqlDataAdapter dap = new SqlDataAdapter(com1);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow rows = ds.Tables[0].Rows[0];


                    this.txt_patient_name.Text = rows["Name"].ToString();
                    this.dateTimePicker_date.Text = rows["Date"].ToString();
                    this.txt_time.Text = rows["Time"].ToString();


                }
                //disconnect from sql server 
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


                string sql = "DELETE a " +
                             "FROM tbl_appoinment a " +
                             "INNER JOIN tbl_patient_info p ON a.[Patient ID] = p.[Patient ID] " +
                             "WHERE p.Name = @name AND a.Date = @date AND a.Time = @time AND a.[Appoinment Number] = @number";

                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@name", this.txt_patient_name.Text);
                com.Parameters.AddWithValue("@date", this.dateTimePicker_date.Value);
                com.Parameters.AddWithValue("@time", this.txt_time.Text);
                com.Parameters.AddWithValue("@number", this.txt_appoinment.Text);


                int ret = com.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Appoinment Deleted", "Information");
                    btn_search_date_Click(null, EventArgs.Empty);



                }

                string SessionStatus2 = "Avaliable";
                string sql1 = "UPDATE [DoctorSessions] SET [AppointmentStatus] = @status WHERE  [AppointmentNumber]=@number AND  [SessionDate]=@date";
                SqlCommand com1 = new SqlCommand(sql1, con1);

                com1.Parameters.AddWithValue("@date", this.dateTimePicker_date.Value.Date);
                com1.Parameters.AddWithValue("@status", SessionStatus2);
                com1.Parameters.AddWithValue("@number", this.txt_appoinment.Text);
                int ret1 = com1.ExecuteNonQuery();

                

                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(this.txt_appoinment.Text) || string.IsNullOrEmpty(this.txt_patient_name.Text) || string.IsNullOrEmpty(this.txt_time.Text) )
                {
                    MessageBox.Show("All Field must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                    // save user details
                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();
                    string selectSql = "SELECT [Patient ID] FROM tbl_patient_info WHERE [Name] = @name";
                    SqlCommand selectCmd = new SqlCommand(selectSql, con1);
                    selectCmd.Parameters.AddWithValue("@name", this.txt_patient_name.Text);

                    // Execute the query and retrieve the Patient_ID
                    object result = selectCmd.ExecuteScalar();
                    if (result != null)
                    {
                        int patientId = Convert.ToInt32(result);



                        string sql = "UPDATE  tbl_appoinment SET Date=@date ,time=@time WHERE [Appoinment Number]=@number  ";
                        SqlCommand com = new SqlCommand(sql, con1);


                        com.Parameters.AddWithValue("@date", this.dateTimePicker_date.Value);
                        com.Parameters.AddWithValue("@time", this.txt_time.Text);
                        com.Parameters.AddWithValue("@number", this.txt_appoinment.Text);











                        int ret = com.ExecuteNonQuery();
                        if (ret == 1)
                        {
                            MessageBox.Show("Appoinment Updated", "Information");
                            btn_search_date_Click(null, EventArgs.Empty);
                        }
                        con1.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_appoinment_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_date_ValueChanged(object sender, EventArgs e)
        {

           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_appoinment.Clear();
            txt_patient_name.Clear();
            txt_time.Clear();
            


        }

        private void dataGridView_appointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView_appointment.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                string cellValue = row.Cells[0].Value.ToString();
                string cellValue2 = row.Cells[3].Value.ToString();
                string cellValue3 = row.Cells[2].Value.ToString();
                string cellValue4= row.Cells[1].Value.ToString();

                // Set the value to the TextBox
                txt_appoinment.Text = cellValue;
                txt_patient_name.Text = cellValue2;
                txt_time.Text = cellValue3;
                dateTimePicker_date.Value = DateTime.Parse(cellValue4.ToString());

            }
        }

        private void dateTimePicker_searchDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_search_date_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = @"SELECT app.[Appoinment Number],app.[Date],app.[time], pat.[Name]
               FROM tbl_appoinment app
               JOIN [tbl_patient_info] pat 
               ON app.[Patient ID] = pat.[Patient ID]
               WHERE [Date] = @date";
                SqlCommand com1 = new SqlCommand(sql, con);

                com1.Parameters.AddWithValue("@date", dateTimePicker_searchDate.Value.Date);
                SqlDataAdapter dap = new SqlDataAdapter(com1);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                this.dataGridView_appointment.DataSource = ds.Tables[0];

                if (ds.Tables[0].Rows.Count > 0)
                {


                    this.dataGridView_appointment.DataSource = ds.Tables[0];
                    dataGridView_appointment.Columns[2].HeaderText = "Time";


                }
                else
                    //disconnect from sql server 
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker_check_Doctor_ValueChanged(object sender, EventArgs e)
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
    }
}
