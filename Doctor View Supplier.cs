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
    public partial class Doctor_View_Supplier : Form
    {
        public Doctor_View_Supplier()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
            btn_all.BackColor = customC;
        }
        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

        private void Doctor_View_Supplier_Load(object sender, EventArgs e)
        {
            btn_all_Click(null, EventArgs.Empty);
        }

        private void btn_all_Click(object sender, EventArgs e)
        {

            try
            {




                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                                 SELECT [Company_Name],[Supplier_Name],[Company_Address],[Contact_Number],[Email]

                 FROM [tbl_drug_supplier] 
                ";
                SqlCommand com = new SqlCommand(sql, con);




                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_drug_types.DataSource = ds.Tables[0];
                dataGridView_drug_types.Columns[0].HeaderText = "Company Name";
                dataGridView_drug_types.Columns[1].HeaderText = "Supplier Name";
                dataGridView_drug_types.Columns[2].HeaderText = "Company Address";
                dataGridView_drug_types.Columns[3].HeaderText = "Contact Number";


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




                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                 SELECT [Company_Name],[Supplier_Name],[Company_Address],[Contact_Number],[Email]
                 FROM [tbl_drug_supplier]
WHERE [Company_Name] = @name
                ";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@name", this.txt_search.Text);



                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_drug_types.DataSource = ds.Tables[0];
                dataGridView_drug_types.Columns[0].HeaderText = "Company Name";
                dataGridView_drug_types.Columns[1].HeaderText = "Supplier Name";
                dataGridView_drug_types.Columns[2].HeaderText = "Company Address";
                dataGridView_drug_types.Columns[3].HeaderText = "Contact Number";



                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_drug_types_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView_drug_types.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)

              
                string cellValue1 = row.Cells[0].Value.ToString();
                string cellValue2 = row.Cells[1].Value.ToString();
                string cellValue3 = row.Cells[2].Value.ToString();
                string cellValue4 = row.Cells[3].Value.ToString();
                string cellValue5 = row.Cells[4].Value.ToString();


                txt_company.Text = cellValue1;
                txt_name.Text = cellValue2;
                txt_address.Text = cellValue3;
                txt_contact.Text = cellValue4;
                txt_email.Text = cellValue5;


            }
        }
        }
    }

