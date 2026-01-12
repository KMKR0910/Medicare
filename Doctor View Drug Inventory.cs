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
    public partial class Doctor_View_Drug_Inventory : Form
    {
        public Doctor_View_Drug_Inventory()
        {
            InitializeComponent();
            
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
            btn_All.BackColor = customC;
            btn_genarate.BackColor = customC;


        }
        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                 SELECT [Drug_Name], [Drug_Price],[Pack Size],[Quantity],[Exp_date] 
                 FROM [tbl_drug_inventory] 
               
                  WHERE [Drug_Name] = @drugname";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@drugname", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "Drug Name";

                dataGridView1.Columns[1].HeaderText = "Price";
                dataGridView1.Columns[4].HeaderText = "Expire Date";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Doctor_View_Drug_Inventory_Load(object sender, EventArgs e)
        {

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                 SELECT [Drug_Name], [Drug_Price],[Pack Size],[Quantity],[Exp_date]
                 FROM [tbl_drug_inventory]";
                SqlCommand com = new SqlCommand(sql, con);



                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "Drug Name";

                dataGridView1.Columns[1].HeaderText = "Price";
                dataGridView1.Columns[4].HeaderText = "Expire Date";


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_genarate_Click(object sender, EventArgs e)
        {
            Report_Gen_Drug_Inventory r1 = new Report_Gen_Drug_Inventory();
            r1.Show();
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            Doctor_View_Drug_Inventory_Load(null, EventArgs.Empty);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
