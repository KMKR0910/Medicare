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
    public partial class Med_Finance : Form
    {

        public Med_Finance()
        {
            InitializeComponent();
        }

        private void Med_Finance_Load(object sender, EventArgs e)
        {

        }

        private void LoadFinance3()
        {
            //Create an instance of Form2
            Med_Add_expenses form2 = new Med_Add_expenses();

            // Remove borders and make the form a child control






            // Show the form inside the GroupBox
            form2.Show();
            this.Hide();
        }



        private void btn_add_expenses_Click(object sender, EventArgs e)
        {
            LoadFinance3();

        }

        private void btn_viewExpenses_Click(object sender, EventArgs e)
        {
            LoadFinance3();
        }

        private void btn_income_report_Click(object sender, EventArgs e)
        {

            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();



                DateTime startDate = dateTimePicker_start.Value;
                DateTime endDate = dateTimePicker_end.Value;

                string sql = @"SELECT SUM([Total_Cost]) AS TotalCost 
                             FROM [tbl_Patient_Payment]
                             WHERE [Date] BETWEEN @StartDate AND @EndDate";

                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);


                object result = command.ExecuteScalar();

                decimal totalCost = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                // Pass data to Crystal Report
                Report_Gen_Income reportForm = new Report_Gen_Income(startDate, endDate, totalCost);
                reportForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      



    
    }
}