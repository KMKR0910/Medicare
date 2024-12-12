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
    public partial class Doctor_View_Diagnose_Histroy : Form
    {
        public Doctor_View_Diagnose_Histroy()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
       
            btn_clear.BackColor = customC;
            btn_save.BackColor = customC;
            btn_all.BackColor = customC;

            btn_search.BackColor = customC;
        }
        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
        string cellValue;
        private void GetPatientName()
        {

            try
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "SELECT *  FROM [tbl_patient_info] WHERE [Contact Number] = @number ";
                SqlCommand com1 = new SqlCommand(sql, con);
                com1.Parameters.AddWithValue("@number", this.txt_search.Text);
                SqlDataAdapter dap = new SqlDataAdapter(com1);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow rows = ds.Tables[0].Rows[0];


                    this.txt_name.Text = rows["Name"].ToString();
                    
                   

                }
                //disconnect from sql server 
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(this.txt_search.Text))
                {
                    MessageBox.Show("All required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {





                    SqlConnection con = new SqlConnection(cs);
                    con.Open();





                    string sql = @"
                 SELECT td.[DiagnosNumber],td.[Allergies],td.[Description],p.[Name] 
                 FROM tbl_diagnostic_data td
                 INNER JOIN tbl_patient_info p ON td.patient_id = p.[Patient ID]
                  WHERE p.[Contact Number] = @number";
                    SqlCommand com = new SqlCommand(sql, con);

                    com.Parameters.AddWithValue("@number", this.txt_search.Text);


                    SqlDataAdapter dap = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    this.dataGridView_diagnose.DataSource = ds.Tables[0];


                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView_diagnose_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                // Get the current row
                DataGridViewRow row = dataGridView_diagnose.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
                 cellValue = row.Cells[0].Value.ToString();
                

                string cellValue1 = row.Cells[1].Value.ToString();
                string cellValue2 = row.Cells[2].Value.ToString();
                string cellValue3 = row.Cells[3].Value.ToString();


                // Set the value to the TextBox

                txt_allergies.Text = cellValue1;
                txt_description.Text = cellValue2;
                txt_name.Text = cellValue3;


            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(this.txt_description.Text) || string.IsNullOrEmpty(this.txt_allergies.Text))
                {
                    MessageBox.Show("All required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {




                    // save user details
                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();


                    string sql = @"UPDATE  [tbl_diagnostic_data] SET [Description] =@description , [Allergies] =@allergies WHERE  [DiagnosNumber]=@id";







                    SqlCommand com = new SqlCommand(sql, con1);

                    com.Parameters.AddWithValue("@description", this.txt_description.Text);
                    com.Parameters.AddWithValue("@allergies", this.txt_allergies.Text);
                    com.Parameters.AddWithValue("@id", cellValue);










                    int ret = com.ExecuteNonQuery();
                    if (ret == 1)
                    {
                        MessageBox.Show("Updated", "Information");
                        btn_search_Click(null, EventArgs.Empty);


                    }
                    con1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Doctor_View_Diagnose_Histroy_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_allergies.Clear();
            txt_description.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               





                    SqlConnection con = new SqlConnection(cs);
                    con.Open();

              



                string sql = @"
                 SELECT td.[DiagnosNumber],td.[Allergies],td.[Description],p.[Name] 
                 FROM tbl_diagnostic_data td
                 INNER JOIN tbl_patient_info p ON td.patient_id = p.[Patient ID]
                  ";
                    SqlCommand com = new SqlCommand(sql, con);

               


                    SqlDataAdapter dap = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    this.dataGridView_diagnose.DataSource = ds.Tables[0];


                    con.Close();
                }
            
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
