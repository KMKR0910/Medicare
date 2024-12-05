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
    public partial class Report_Gen_M_Certificate : Form
    {
        string MC_ID;
        public Report_Gen_M_Certificate(string MC_ID)
        {
            InitializeComponent();
            this.MC_ID = MC_ID;
        }
        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

        private void Report_Gen_M_Certificate_Load(object sender, EventArgs e)
        {
            try { 
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string sql = @"
                 SELECT td.*,p.* 
                 FROM [tbl_M_certificate] td
                 INNER JOIN tbl_patient_info p ON td.[Patient ID] = p.[Patient ID]
                  WHERE td.[MC_ID]  = @MCID";
            SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@MCID", MC_ID);

                SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            CrystalReports_Gen_M_Certificate rpt1 = new CrystalReports_Gen_M_Certificate();
            // set the data source of the report
            rpt1.Load(@"C:\Users\kasun\source\repos\Diploma Final Project 1\CrystalReports_Gen_M_Certificate.rpt");
            rpt1.SetDataSource(ds.Tables[0]);

            // set the report source of the created “crystalReportViewer”
            this.crystalReportViewer2.ReportSource = rpt1;

            //Disconnect
            con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
