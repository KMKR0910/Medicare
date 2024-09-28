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
    public partial class View_Drug_Supplier : Form
    {
        public View_Drug_Supplier()
        {
            InitializeComponent();
        }
        string Sup_ID;
        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
        public void loadGridViewer()
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {




                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                 SELECT * 
                 FROM [tbl_drug_supplier] 
                ";
                SqlCommand com = new SqlCommand(sql, con);

               


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_drug_supplier.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                password.Append(validChars[random.Next(validChars.Length)]);
            }

            return password.ToString();

        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {

                int plengh = 4;
                string newpassword = GeneratePassword(plengh);
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string query = "INSERT INTO [tbl_drug_supplier] (Company_Name, Supplier_Name ,Company_Address,Contact_Number,Email,[Password]) " +
                               "VALUES (@company_name, @supplier_name, @address, @number,@email,@password)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@company_name", txt_company_name.Text);
                cmd.Parameters.AddWithValue("@supplier_name", txt_suppler_name.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@number", txt_contact_number.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@password", newpassword);


                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Added successfully");
                    txt_company_name.Clear();
                    txt_suppler_name.Clear();
                    txt_address.Clear();
                    txt_contact_number.Clear();
                    txt_email.Clear();
                    loadGridViewer();


                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void View_Drug_Supplier_Load(object sender, EventArgs e)
        {
            loadGridViewer();
        }

        private void dataGridView_drug_supplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView_drug_supplier.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)

                Sup_ID = row.Cells[0].Value.ToString();
                string cellValue1 = row.Cells[1].Value.ToString();
                string cellValue2 = row.Cells[2].Value.ToString();
                string cellValue3 = row.Cells[3].Value.ToString();
                string cellValue4 = row.Cells[4].Value.ToString();
                string cellValue5 = row.Cells[5].Value.ToString();


                txt_company_name.Text = cellValue1;
                txt_suppler_name.Text = cellValue2;
                txt_address.Text = cellValue3;
                txt_contact_number.Text = cellValue4;
                txt_email.Text = cellValue5;



            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {

                int plengh = 4;
                string newpassword = GeneratePassword(plengh);
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string query = "UPDATE [tbl_drug_supplier] " +
                "SET Company_Name = @company_name, " +
                "Supplier_Name = @supplier_name, " +
                "Company_Address = @address, " +
                "Contact_Number = @number, " +
                "Email = @email " +
                "WHERE Supplier_ID = @supplier_id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@supplier_id", Sup_ID);

                cmd.Parameters.AddWithValue("@company_name", txt_company_name.Text);
                cmd.Parameters.AddWithValue("@supplier_name", txt_suppler_name.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@number", txt_contact_number.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                

                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Updated successfully");
                    txt_company_name.Clear();
                    txt_suppler_name.Clear();
                    txt_address.Clear();
                    txt_contact_number.Clear();
                    txt_email.Clear();
                    loadGridViewer();


                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
