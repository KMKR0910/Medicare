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
    public partial class Med_View_Doctor_Visits : Form
    {
        public Med_View_Doctor_Visits()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_cancel.BackColor = customC;
            btn_delete.BackColor = customC;
            btn_save.BackColor = customC;
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Format = DateTimePickerFormat.Time;

        }
        string date;
        string cellValue3;
        private void Med_View_Doctor_Visits_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
           SELECT 
        [SessionID],
          [StartTime] ,
        [EndTime]  
         FROM [DoctorSessions]
         WHERE [SessionDate] = @date";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_visits.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();




                string sql = @"
           SELECT 
        [SessionID],
          [StartTime] ,
        [EndTime]  
         FROM [DoctorSessions]
         WHERE [SessionDate] = @date";
                ;
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_visits.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_visits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView_visits.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                cellValue3 = row.Cells[0].Value.ToString();
                string cellValue = row.Cells[1].Value.ToString();
                string cellValue2 = row.Cells[2].Value.ToString();

                // Set the value to the TextBox
                dateTimePicker2.Text = cellValue;
                dateTimePicker3.Text = cellValue2;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {
                
                    SqlConnection con = new SqlConnection(cs);
                con.Open();


                string query = "UPDATE [DoctorSessions] SET [StartTime]=@starttime,[EndTime] =@endtime WHERE [SessionID]=@id";
                           
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@starttime", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@endtime", dateTimePicker3.Text);
                cmd.Parameters.AddWithValue("@id", cellValue3);



                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Saved successfully");
                    dateTimePicker1_ValueChanged(null, EventArgs.Empty);



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

            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string query = "DELETE FROM DoctorSessions WHERE SessionID = @sessionId";
                SqlCommand cmd = new SqlCommand(query, con);

               
                cmd.Parameters.AddWithValue("@sessionId", cellValue3);



                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Deleted successfully");
                    dateTimePicker1_ValueChanged(null, EventArgs.Empty);



                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today.Date.AddHours(0).AddMinutes(0);

            dateTimePicker3.Value = DateTime.Today.Date.AddHours(0).AddMinutes(0);

        }
    }
    }

