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
    public partial class Report_Gen_Bil_Invoice : Form
    {

        string patientID;
        public Report_Gen_Bil_Invoice(string patientID)
        {
            InitializeComponent();
            this.patientID = patientID;

        }
        string cs = "Data Source=ASUS; Initial Catalog = Diploma Final Project DB1; Integrated Security=True";

        private void Report_Gen_Bil_Invoice_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = @"
                 SELECT td.*,p.[Patient ID],[Name], [Address],[Contact Number]
                 FROM [tbl_Patient_Payment] td
                 INNER JOIN tbl_patient_info p ON td.[patirnt_ID] = p.[Patient ID]
                  WHERE CAST(td.[Date] AS DATE) = @date AND td.[patirnt_ID] = @pID
";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@date", DateTime.Today.Date);
                com.Parameters.AddWithValue("@pID", patientID.Trim());

                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                MessageBox.Show($"Rows retrieved: {ds.Tables[0].Rows.Count}");


                CrystalReport_Gen_Patient_B_Invoice rpt1 = new CrystalReport_Gen_Patient_B_Invoice();
                // set the data source of the report
                rpt1.Load(@"C:\Users\kasun\source\repos\Diploma Final Project 1\CrystalReport_Gen_Patient_B_Invoice.rpt");

                //rpt1.SetParameterValue("StartDate", _startDate);
                rpt1.SetDataSource(ds.Tables[0]);

                // set the report source of the created “crystalReportViewer”
                this.crystalReportViewer1.ReportSource = rpt1;
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
