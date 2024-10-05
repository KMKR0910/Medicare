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
    public partial class Med_View_expenses : Form
    {
        public Med_View_expenses()
        {
            InitializeComponent();
             Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
            btn_clear.BackColor = customC;

            btn_delete.BackColor = customC;
            btn_save.BackColor = customC;
        }


        

    private void Med_View_expenses_Load(object sender, EventArgs e)
    {
    }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dateTimePicker_start.Value;
                DateTime toDate = dateTimePicker_end.Value;
                string selectedCategory = comboBox_category.SelectedItem?.ToString();
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                // save user details
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = @"
                    SELECT 
                        
                        [Date],
                        [Category],
                        [Amount],
                        [Description],
                        [payment method]
                    FROM [tbl_finance] 
                    
                   WHERE ([Date] BETWEEN @fromDate AND @toDate)
        AND (@category IS NULL OR [Category] = @category)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);
                cmd.Parameters.AddWithValue("@category", selectedCategory);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind the result to the DataGridView
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                string cellValue = row.Cells[0].Value.ToString();
                string cellValue2 = row.Cells[1].Value.ToString();
                string cellValue3 = row.Cells[2].Value.ToString();
                string cellValue4 = row.Cells[3].Value.ToString();
                string cellValue5 = row.Cells[4].Value.ToString();

                // Set the value to the TextBox
                dateTimePicker1.Text = cellValue;
                comboBox_category.Text = cellValue2;
                txt_amount.Text = cellValue3;
                txt_description.Text = cellValue4;
                comboBox_payment_method.Text = cellValue5;

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                // save user details
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();





                string sql = @"
                    UPDATE [tbl_finance]
                    SET [Date] = @Date,
                        [Category] = @category,
                        [Amount] = @amount,
                        [Description] = @description,
                        [payment method] = @paymentMethod
                    WHERE [Date] = @Date AND [Category]=@category AND [Amount]=@amount ";
                SqlCommand com = new SqlCommand(sql, con1);

                
                com.Parameters.AddWithValue("@date", this.dateTimePicker1.Value.Date);
                com.Parameters.AddWithValue("@category", this.comboBox_category.Text);
                com.Parameters.AddWithValue("@amount", this.txt_amount.Text);
                com.Parameters.AddWithValue("@description", this.txt_description.Text);
                com.Parameters.AddWithValue("@paymentMethod", this.comboBox_payment_method.Text);









                int ret = com.ExecuteNonQuery();
                if (ret ==1)
                {
                    MessageBox.Show("Updated", "Information");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
