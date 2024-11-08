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
    public partial class Pha_Add_Drug_Payment : Form
    {
        public Pha_Add_Drug_Payment()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_add.BackColor = customC;
            btn_clear.BackColor = customC;
            btn_genarate.BackColor = customC;
        }
        String supplierID;

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string query = "INSERT INTO tbl_drug_payments (Pay_Date, Payment_Method, Total_Cost, Suppler_ID)VALUES(@Pay_Date, @Payment_Method, @Total_Cost, @Suppler_ID)";
                
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Pay_Date", txt_date.Text);
                cmd.Parameters.AddWithValue("@Payment_Method", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@Total_Cost", numericUpDownCost.Value);
                cmd.Parameters.AddWithValue("@Suppler_ID", supplierID);


                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Added successfully");
                    txt_date.Clear();
                    comboBox1.SelectedIndex=-1;
                    
                 
                    numericUpDownCost.Value = 0;

                }

                con.Close();
                MessageBox.Show("Payment added ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
            SELECT p.Name, td.Patient_pay_ID,td.[Payment Type], td.[Total_Cost] ,td.[Date] 
            FROM [tbl_Patient_Payment] td
            INNER JOIN tbl_patient_info p ON td.[patirnt_ID] = p.[Patient ID]
            WHERE p.[Contact Number] = @name ";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@name", this.txt_search.Text);



                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView1.DataSource = ds.Tables[0];



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date;
            this.txt_date.Text = currentDate.ToString("yyyy-MM-dd");
        }

        private void Pha_Add_Drug_Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
