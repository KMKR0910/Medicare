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
    public partial class Report_Gen_Income : Form
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private decimal _totalCost;
        public Report_Gen_Income(DateTime startDate, DateTime endDate, decimal totalCost)
        {
            InitializeComponent();
            _startDate = startDate;
            _endDate = endDate;
            _totalCost = totalCost;

        }

        private void Report_Gen_Income_Load(object sender, EventArgs e)
        {

            try
            {
               

                CrystalReport_Gen_Income rpt1 = new CrystalReport_Gen_Income();
                // set the data source of the report
                rpt1.Load(@"C:\Users\kasun\source\repos\Diploma Final Project 1\CrystalReport_Gen_Income.rpt");
                Console.WriteLine("Setting StartDate: " + _startDate);
                Console.WriteLine("Setting EndDate: " + _endDate);
                Console.WriteLine("Setting TotalCost: " + _totalCost);
                rpt1.SetParameterValue("StartDate", _startDate);
                rpt1.SetParameterValue("EndDate", _endDate);
                rpt1.SetParameterValue("TotalCost", _totalCost);



                // set the report source of the created “crystalReportViewer”
                this.crystalReportViewer1.ReportSource = rpt1;
                this.crystalReportViewer1.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
