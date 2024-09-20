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
        }

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
          MIN([StartTime]) AS StartTime,
        MAX([EndTime]) AS EndTime   
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
    }
}
