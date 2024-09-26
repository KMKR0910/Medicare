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
    public partial class Pha_Add_drugs : Form
    {
        public Pha_Add_drugs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                

                string query = "INSERT INTO [tbl_drug_inventory] (Drug_Name, [Pack Size],Drug_Price,Exp_date,Quantity) " +
                               "VALUES (@DrugName, @PackSize, @DrugPrice, @ExpDate, @Quantity)";
                SqlCommand cmd = new SqlCommand(query, con);

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

        private void Pha_Add_drugs_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
