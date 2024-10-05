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
    public partial class Report_Gen_Drug_Inventory : Form
    {
        public Report_Gen_Drug_Inventory()
        {
            InitializeComponent();
        }
        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

        private void Report_Gen_Drug_Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = @"
                 SELECT * 
                 FROM [tbl_drug_inventory] 
                
                  ";
                SqlCommand com = new SqlCommand(sql, con);

                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                CrystalReport_Drug_inventory rpt1 = new CrystalReport_Drug_inventory();
                // set the data source of the report
                rpt1.Load(@"C:\Users\kasun\source\repos\Diploma Final Project 1\CrystalReport_Drug_inventory.rpt");
                rpt1.SetDataSource(ds.Tables[0]);

                // set the report source of the created “crystalReportViewer”
                this.crystalReportViewer1.ReportSource = rpt1;

                //Disconnect
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
