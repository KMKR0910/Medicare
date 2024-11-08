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
    public partial class Med_Add_expenses : Form
    {
        string type = "Expenses";
        public Med_Add_expenses()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_add.BackColor = customC;
           

            btn_clear.BackColor = customC;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();





                string sql = "INSERT INTO tbl_finance ([Finance Type],Date,Category,Amount,Description,[payment method])" +
                "VALUES (@type,@date,@category,@amount,@description,@pay)";
                SqlCommand com = new SqlCommand(sql, con1);

                com.Parameters.AddWithValue("@type", this.type);
                com.Parameters.AddWithValue("@date", this.dateTimePicker1.Value.Date);
                com.Parameters.AddWithValue("@category", this.comboBox_category.Text);
                com.Parameters.AddWithValue("@amount", this.txt_amount.Text);
                com.Parameters.AddWithValue("@description", this.txt_description.Text);
                com.Parameters.AddWithValue("@pay", this.comboBox_payment_method.Text);









                int ret = com.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Added", "Information");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Med_Add_expenses_Load(object sender, EventArgs e)
        {

        }
    }
}
