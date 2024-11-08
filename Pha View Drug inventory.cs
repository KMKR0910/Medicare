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
    public partial class Pha_View_Drug_inventory : Form
    {
        public Pha_View_Drug_inventory()
        {
            InitializeComponent();

            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_genarate.BackColor = customC;
            btn_search.BackColor = customC;
            button2.BackColor = customC;
            btn_update.BackColor = customC;
            button1.BackColor = customC;

        }
        string drugID;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Get the current row
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Assuming you want the data from the first column (index 0)
                    drugID = row.Cells[0].Value.ToString();
                    string cellValue = row.Cells[1].Value.ToString();
                    string cellValue1 = row.Cells[2].Value.ToString();
                    string cellValue2 = row.Cells[3].Value.ToString();
                    string cellValue3 = row.Cells[4].Value.ToString();
                    string cellValue4 = row.Cells[5].Value.ToString();

                    // Set the value to the TextBox
                    txt_d_name.Text = cellValue;
                    txt_pack_size.Text = cellValue1;
                    numericUpDown_price.Value = Convert.ToDecimal(cellValue2);
                    dateTimePicker_exp.Text = cellValue3;
                    numericUpDown_quantity.Value = Convert.ToDecimal(cellValue4);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "UPDATE [tbl_drug_inventory] " +
                     "SET Drug_Name = @DrugName, [Pack Size] = @PackSize, Drug_Price = @DrugPrice, Exp_date = @ExpDate, Quantity = @Quantity " +
                     "WHERE Drug_ID = @DrugID";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@DrugID", drugID);
                cmd.Parameters.AddWithValue("@DrugName", txt_d_name.Text);
                cmd.Parameters.AddWithValue("@PackSize", txt_pack_size.Text);
                cmd.Parameters.AddWithValue("@DrugPrice", numericUpDown_price.Value);
                cmd.Parameters.AddWithValue("@ExpDate", dateTimePicker_exp.Value.Date);
                cmd.Parameters.AddWithValue("@Quantity", numericUpDown_quantity.Value);

                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Added successfully");
                    txt_d_name.Clear();
                    txt_pack_size.Clear();
                    numericUpDown_price.Value = 0;
                    dateTimePicker_exp.Value = DateTime.Now;
                    numericUpDown_quantity.Value = 0;

                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                 SELECT * 
                 FROM [tbl_drug_inventory] 
               
                  WHERE [Drug_Name] = @drugname";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@drugname", this.txt_search.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView1.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pha_View_Drug_inventory_Load(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                 SELECT * 
                 FROM [tbl_drug_inventory]";
                SqlCommand com = new SqlCommand(sql, con);



                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView1.DataSource = ds.Tables[0];


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
    }
}
