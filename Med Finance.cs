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
using System.Windows.Forms.DataVisualization.Charting;

namespace Diploma_Final_Project_1
{
    public partial class Med_Finance : Form

    {
        private Chart progressChart; // Chart control
        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


        public Med_Finance()
        {
            // Assuming you have a GroupBox named groupBox1 on your form
            InitializeComponent();

            // Initialize the chart control
            progressChart = new Chart();

            // Set the chart's parent to the GroupBox
            progressChart.Parent = groupBox1;

            // Dock the chart to fill the GroupBox
            progressChart.Dock = DockStyle.Fill;

            // Optional: Configure other chart properties
            progressChart.BackColor = Color.White; // Example: Set background color

            // Add the chart to the GroupBox (already done by setting Parent)
            groupBox1.Controls.Add(progressChart);

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
        private void LoadDataChart()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    // Prepare the chart
                    progressChart.Series.Clear();
                    progressChart.ChartAreas.Clear();

                    // Create a new chart area and series
                    ChartArea chartArea = new ChartArea();
                    progressChart.ChartAreas.Add(chartArea);
                    // Series for Drug
                    Series drugSeries = new Series("Drug");
                    drugSeries.ChartType = SeriesChartType.Column;
                    progressChart.Series.Add(drugSeries);



                    // Series for Lab
                    Series labSeries = new Series("Lab");
                    labSeries.ChartType = SeriesChartType.Column;
                    progressChart.Series.Add(labSeries);

                    int selectedMonth = dateTimePicker_report.Value.Month;
                    int selectedYear = dateTimePicker_report.Value.Year;


                    chartArea.AxisX.Interval = 1; // Show all dates on the X-axis
                    drugSeries["PixelPointWidth"] = "50"; // Adjust column width if needed
                    labSeries["PixelPointWidth"] = "50";

                    drugSeries.Color = Color.Blue;
                    labSeries.Color = Color.Green;

                    drugSeries.IsValueShownAsLabel = true;
                    labSeries.IsValueShownAsLabel = true;

                    labSeries.IsVisibleInLegend = true;



                    // Payment type filter
                    string pay1 = "Drug";

                    // SQL query
                    string sql = @"
               SELECT 
    ISNULL(SUM(CASE WHEN [Payment Type] = 'Drug' THEN [Total_Cost] END), 0) AS DrugIncome,
    ISNULL(SUM(CASE WHEN [Payment Type] = 'Lab Tets' THEN [Total_Cost] END), 0) AS LabIncome,
    CAST([Date] AS DATE) AS PaymentDate
FROM [dbo].[tbl_Patient_Payment]
WHERE MONTH([Date]) = @Month AND YEAR([Date]) = @Year
GROUP BY CAST([Date] AS DATE)
ORDER BY PaymentDate;
";

                    SqlCommand command = new SqlCommand(sql, con);
                    command.Parameters.AddWithValue("@Month", selectedMonth);
                    command.Parameters.AddWithValue("@Year", selectedYear);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime date = reader.IsDBNull(reader.GetOrdinal("PaymentDate"))
                                            ? DateTime.MinValue
                                            : reader.GetDateTime(reader.GetOrdinal("PaymentDate"));

                            double drugIncome = reader.IsDBNull(reader.GetOrdinal("DrugIncome"))
                                                ? 0
                                                : Convert.ToDouble(reader["DrugIncome"]);

                            double labIncome = reader.IsDBNull(reader.GetOrdinal("LabIncome"))
                                               ? 0
                                               : Convert.ToDouble(reader["LabIncome"]);

                            // Add data points to the chart series
                            if (date != DateTime.MinValue)
                            {
                                drugSeries.Points.AddXY(date, drugIncome);
                                labSeries.Points.AddXY(date, labIncome);
                            }
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No data found for the selected period.");
                            }

                        }
                    }
                }
            }





            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadDataChart(); // Load data when the form is loaded
        }
        private void btn_income_report_Click(object sender, EventArgs e)
        {


            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();



                DateTime startDate = dateTimePicker_start.Value;
                DateTime endDate = dateTimePicker_end.Value;
                String pay1 = "Drug";

                string sql = @"SELECT SUM([Total_Cost]) AS TotalCost 
                             FROM [tbl_Patient_Payment]
                             WHERE [Date] BETWEEN @StartDate AND @EndDate AND [Payment Type]=@payment_type";

                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                command.Parameters.AddWithValue("@payment_type", pay1);


                object result = command.ExecuteScalar();

                decimal totalCost = result != DBNull.Value ? Convert.ToDecimal(result) : 0;



                //
                //
                // For Calculate Laboratory Income

                String pay2 = "Lab Tets";

                string sql2 = @"SELECT SUM([Total_Cost]) AS IncomeLab 
                             FROM [tbl_Patient_Payment]
                             WHERE [Date] BETWEEN @StartDate AND @EndDate AND [Payment Type]=@payment_type";

                SqlCommand com2 = new SqlCommand(sql2, con);
                com2.Parameters.AddWithValue("@StartDate", startDate);
                com2.Parameters.AddWithValue("@EndDate", endDate);
                com2.Parameters.AddWithValue("@payment_type", pay2);


                object result2 = com2.ExecuteScalar();

                decimal IncomeLab = result2 != DBNull.Value ? Convert.ToDecimal(result2) : 0;


                //
                // For Calculate Drug Expenses 

               

                string sql3 = @"SELECT SUM([Total_Cost]) AS ExpenseDrug 
                             FROM [tbl_drug_payments]
                             WHERE [Pay_Date] BETWEEN @StartDate AND @EndDate";

                SqlCommand com3 = new SqlCommand(sql3, con);
                com3.Parameters.AddWithValue("@StartDate", startDate);
                com3.Parameters.AddWithValue("@EndDate", endDate);
             


                object result3 = com3.ExecuteScalar();

                decimal ExpenseDrug = result3 != DBNull.Value ? Convert.ToDecimal(result3) : 0;

                //
                //
                // For Calculate Lab Expenses 


                string categoryLAB = "Lab";

                string sql4 = @"SELECT SUM([Amount]) AS ExpenseLab 
                             FROM [tbl_finance]
                             WHERE [Date] BETWEEN @StartDate AND @EndDate AND [Category]= @category";

                SqlCommand com4 = new SqlCommand(sql4, con);
                com4.Parameters.AddWithValue("@StartDate", startDate);
                com4.Parameters.AddWithValue("@EndDate", endDate);
                com4.Parameters.AddWithValue("@category", categoryLAB);



                object result4 = com4.ExecuteScalar();

                decimal ExpenseLab = result4 != DBNull.Value ? Convert.ToDecimal(result4) : 0;


                //
                //
                // For Calculate Employee Salary Expenses - Medical Centre Assistant


                string categorySalary = "Salary";
                string salarytype1 = "Med";

                string sql5 = @"SELECT SUM([Amount]) AS SalaryMed
                              FROM [tbl_finance]
                             WHERE [Date] BETWEEN @StartDate AND @EndDate AND [Category]= @category AND [Description] =@description";

                SqlCommand com5 = new SqlCommand(sql5, con);
                com5.Parameters.AddWithValue("@StartDate", startDate);
                com5.Parameters.AddWithValue("@EndDate", endDate);
                com5.Parameters.AddWithValue("@category", categorySalary);
                com5.Parameters.AddWithValue("@description", salarytype1);




                object result5 = com5.ExecuteScalar();

                decimal SalaryMed = result5 != DBNull.Value ? Convert.ToDecimal(result5) : 0;


                // For Calculate Employee Salary Expenses -Pharamacists


                
                string salarytype2 = "Pha";

                string sql6 = @"SELECT SUM([Amount]) AS SalaryPha
                              FROM [tbl_finance]
                             WHERE [Date] BETWEEN @StartDate AND @EndDate AND [Category]= @category AND [Description] =@description";

                SqlCommand com6 = new SqlCommand(sql6, con);
                com6.Parameters.AddWithValue("@StartDate", startDate);
                com6.Parameters.AddWithValue("@EndDate", endDate);
                com6.Parameters.AddWithValue("@category", categorySalary);
                com6.Parameters.AddWithValue("@description", salarytype2);




                object result6= com6.ExecuteScalar();

                decimal SalaryPha = result6 != DBNull.Value ? Convert.ToDecimal(result6) : 0;

                // For Calculate Employee Salary Expenses -Laboaratory Assistant



                string salarytype3 = "Lab";

                string sql7 = @"SELECT SUM([Amount]) AS SalaryPha
                              FROM [tbl_finance]
                             WHERE [Date] BETWEEN @StartDate AND @EndDate AND [Category]= @category AND [Description] =@description";

                SqlCommand com7 = new SqlCommand(sql7, con);
                com7.Parameters.AddWithValue("@StartDate", startDate);
                com7.Parameters.AddWithValue("@EndDate", endDate);
                com7.Parameters.AddWithValue("@category", categorySalary);
                com7.Parameters.AddWithValue("@description", salarytype3);




                object result7 = com7.ExecuteScalar();

                decimal SalaryLab = result7 != DBNull.Value ? Convert.ToDecimal(result7) : 0;

                //
                // For Calculate Other Expenses 
                //

       
              

                string sql8 = @"SELECT SUM([Amount]) AS Others
                              FROM [tbl_finance]
                             WHERE [Date] BETWEEN @StartDate AND @EndDate AND [Category]!= @Other1  AND [Category]!= @Other2    ";

                SqlCommand com8 = new SqlCommand(sql8, con);
                com8.Parameters.AddWithValue("@StartDate", startDate);
                com8.Parameters.AddWithValue("@EndDate", endDate);
                com8.Parameters.AddWithValue("@Other1", categoryLAB);
                com8.Parameters.AddWithValue("@Other2", categorySalary);
 



                object result8 = com8.ExecuteScalar();

                decimal OtherExpenses = result8 != DBNull.Value ? Convert.ToDecimal(result8) : 0;






                // Pass data to Crystal Report
                Report_Gen_Income reportForm = new Report_Gen_Income(startDate, endDate, totalCost,IncomeLab,pay1,pay2, ExpenseDrug,  ExpenseLab, categoryLAB, SalaryMed, categorySalary, salarytype1, SalaryPha, salarytype2, SalaryLab, salarytype3, OtherExpenses);
                reportForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadDataChart();
        }
    }
}