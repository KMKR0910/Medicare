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
        }
        string date;
        private void Med_View_Doctor_Visits_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                SELECT TOP 1 [SessionDate],[StartTime]
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();




                string sql = @"
           SELECT 
        [SessionDate],
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
                date = row.Cells[0].Value.ToString();
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


                string query = "UPDATE [DoctorSessions] SET [StartTime]=@starttime,[EndTime] =@endtime WHERE [SessionDate]=@date ([Test_Type], [Rep_status],[Test_Price],[Patient_ID],[Lab_test_number]) " +
                               "VALUES (@type, @status, @Price, @patientID,@number)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@starttime", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@endtime", dateTimePicker3.Text);
                cmd.Parameters.AddWithValue("@date", date);
             


                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Added successfully");
                   

                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
