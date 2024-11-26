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
        private string _pay1;
        private string _pay2;
        private decimal _IncomeLab;
        private decimal _ExpenseDrug;
        private decimal _ExpenseLab;
        private string _categoryLAB;
        private string _categorySalary;
        private string _salarytype1;
        private decimal _SalaryMed;
        private decimal _SalaryPha;
        private string _salarytype2;
        private decimal _SalaryLab;
        private string _salarytype3;
        private decimal _OtherExpenses;


        public Report_Gen_Income(DateTime startDate, DateTime endDate, decimal totalCost, decimal IncomeLab,String pay1,string pay2, decimal ExpenseDrug,decimal ExpenseLab,string categoryLAB,decimal SalaryMed, string categorySalary,string salarytype1,decimal SalaryPha,string salarytype2,decimal SalaryLab, string salarytype3, decimal OtherExpenses)
        {
            InitializeComponent();
            _startDate = startDate;
            _endDate = endDate;
            _totalCost = totalCost;
            _IncomeLab = IncomeLab;
            _pay1 = pay1;
            _pay2 = pay2;
            _ExpenseDrug = ExpenseDrug;
            _ExpenseLab = ExpenseLab;
            _categoryLAB = categoryLAB;
            _categorySalary = categorySalary;
            _salarytype1 = salarytype1;
            _SalaryMed = SalaryMed;
            _SalaryPha = SalaryPha;
            _salarytype2 = salarytype2;
            _SalaryLab = SalaryLab;
            _salarytype3 = salarytype3;
            _OtherExpenses = OtherExpenses;
        }

        private void Report_Gen_Income_Load(object sender, EventArgs e)
        {

            try
            {
               

                CrystalReport_Gen_Income rpt1 = new CrystalReport_Gen_Income();
                // set the data source of the report
                rpt1.Load(@"C:\Users\kasun\source\repos\Diploma Final Project 1\CrystalReport_Gen_Income.rpt");
               
                rpt1.SetParameterValue("StartDate", _startDate);
                rpt1.SetParameterValue("EndDate", _endDate);
                rpt1.SetParameterValue("TotalCost", _totalCost);
                rpt1.SetParameterValue("IncomeLab", _IncomeLab);
                rpt1.SetParameterValue("Pay1", _pay1); 
                rpt1.SetParameterValue("Pay2", _pay2);
                rpt1.SetParameterValue("DrugExpenses", _ExpenseDrug);
                rpt1.SetParameterValue("LabExpenses", _ExpenseLab);
                rpt1.SetParameterValue("categoryLAB", _categoryLAB);
                rpt1.SetParameterValue("categorySalary", _categorySalary);
                rpt1.SetParameterValue("salarytype1", _salarytype1);
                rpt1.SetParameterValue("SalaryMed", _SalaryMed);

                rpt1.SetParameterValue("SalaryPha", _SalaryPha);
                rpt1.SetParameterValue("salarytype2", _salarytype2);
                rpt1.SetParameterValue("SalaryLab", _SalaryLab);
                rpt1.SetParameterValue("salarytype3", _salarytype3);

                rpt1.SetParameterValue("OtherExpenses", _OtherExpenses);
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
