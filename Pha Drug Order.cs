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
    public partial class Pha_Drug_Order : Form
    {

        private string _userId;
        public Pha_Drug_Order(string userID)
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
            btn_add.BackColor = customC;
            _userId = userID;

            btn_clear.BackColor = customC;
            btn_remove.BackColor = customC;
            btn_order.BackColor = customC;
            btn_suppliers.BackColor = customC;

        }
        int SupplierID;
        int ItemID;
        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

            try
            {
                if (string.IsNullOrEmpty(this.txt_search.Text))
                {
                    MessageBox.Show("Search Field must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();


                    string sql = "SELECT *  FROM [tbl_drug_supplier] WHERE [Supplier_ID] = @id ";
                    SqlCommand com1 = new SqlCommand(sql, con);
                    com1.Parameters.AddWithValue("@id", this.txt_search.Text);
                    SqlDataAdapter dap = new SqlDataAdapter(com1);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);


                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        DataRow rows = ds.Tables[0].Rows[0];


                        this.txt_company.Text = rows["Company_Name"].ToString();
                        this.txt_name.Text = rows["Supplier_Name"].ToString();
                        SupplierID = Convert.ToInt32(rows["Supplier_ID"]);
                        Pha_Drug_Order_Load(this, EventArgs.Empty);



                    }
                    //disconnect from sql server 
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string status1 = "Not Ordered";
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string query = "INSERT INTO [tbl_Drug_order]([Order_Status],[Supplier_ID],[Pharamacists_ID]) " +
                               "VALUES (@status,@supplierID,@phaID)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", status1);
                cmd.Parameters.AddWithValue("@supplierID", SupplierID);
                cmd.Parameters.AddWithValue("@phaID", _userId);

                int ret = cmd.ExecuteNonQuery();


                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /*
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


                    this.txt_Name.Text = rows["Name"].ToString();
                    this.txt_address.Text = rows["Address"].ToString();
                    this.dateTimePicker_DOB.Text = rows["DOB"].ToString();
                    this.txt_contact.Text = rows["Contact Number"].ToString();
                    this.txt_email.Text = rows["email"].ToString();
                    this.comboBox_gender.Text = rows["Gender"].ToString();


                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        */
        }
        private void ResetItemId()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string resetQuery = "DBCC CHECKIDENT ('tbl_Order_Item', RESEED, 0);"; // Resets next value to 1
            SqlCommand resetCmd = new SqlCommand(resetQuery, con);

            try
            {
                resetCmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while resetting Item ID: " + ex.Message);
            }
            finally
            {
                con.Close(); // Close the connection after operation
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {/*

            string status1 = "Not Ordered";
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string query = "INSERT INTO [tbl_Drug_order]([Order_Status],[Supplier_ID]) " +
                               "VALUES (@status,@supplierID)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", status1);
                cmd.Parameters.AddWithValue("@supplierID", SupplierID);

                int ret = cmd.ExecuteNonQuery();
               

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string query = "INSERT INTO [tbl_Order_Item]([OrderID],[Drug_Name], [Pack_Size],[Quantity]) " +
                               "VALUES (@OrderId,@DrugName, @PackSize,@Quantity)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@OrderId", int.Parse(txt_order_Id.Text));  // Converts the string to an integer
                cmd.Parameters.AddWithValue("@DrugName", txt_d_name.Text);
                cmd.Parameters.AddWithValue("@PackSize", txt_pack_size.Text);
                cmd.Parameters.AddWithValue("@Quantity", numericUpDown_quantity.Value);

                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Added successfully");
                    txt_d_name.Clear();
                    txt_pack_size.Clear();
                
                    numericUpDown_quantity.Value = 0;

                }

                con.Close();

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
                 SELECT [OrderID],[Drug_Name], [Pack_Size],[Quantity]
                 FROM [tbl_Order_Item] 
                
                  WHERE [OrderID] = @ordeId";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@ordeId", this.txt_order_Id.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_Items.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pha_Drug_Order_Load(object sender, EventArgs e)
        {
            // connect to the sql

            SqlConnection con = new SqlConnection(cs);
            con.Open();





            string sql = "SELECT MAX ([OrderID]) FROM [tbl_Drug_order]";
            SqlCommand com = new SqlCommand(sql, con); //This creates a SQL command object (com) with the query (sql) and an established connection (con)

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {

                // when you have a blank value of the first coloumn in current row you should tyep this code
                if (dr.GetValue(0).ToString() == "")
                {
                    this.txt_order_Id.Text = "1"; //if have a blank sapace in item code must 1
                }
                else
                {
                    this.txt_order_Id.Text = (Convert.ToInt32(dr.GetValue(0).ToString()) + 1).ToString();// if there is a value in item code
                }
            }
            else
            {
                this.txt_order_Id.Text = "1"; // if there is no any filled rows in table
            }


        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            string status1 = "Pending Doctor Confirm";
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                //string query = "INSERT INTO [tbl_Drug_order]([Order_Status],[Supplier_ID]) " +
                             // "VALUES (@status,@supplierID)";

                string query = "UPDATE [tbl_Drug_order] SET[Order_Status]= @status WHERE [OrderID]=@orderID";
                   
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", status1);
               cmd.Parameters.AddWithValue("@orderID", this.txt_order_Id.Text);
                int ret = cmd.ExecuteNonQuery();


                if (ret > 0)
                {
                    MessageBox.Show("Ordered.");
                 


                }
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResetItemId();
        }

        private void dataGridView_Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Get the current row
                    DataGridViewRow row = dataGridView_Items.Rows[e.RowIndex];

                    // Assuming you want the data from the first column (index 0)
              

                    string cellValue = row.Cells[1].Value.ToString();
                    string cellValue1 = row.Cells[2].Value.ToString();
                    string cellValue2 = row.Cells[3].Value.ToString();
                 

                    // Set the value to the TextBox
                    txt_d_name.Text = cellValue;
                    txt_pack_size.Text = cellValue1;
                    numericUpDown_quantity.Value = Convert.ToDecimal(cellValue2);
               
                }
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
                 SELECT [ItemID] 
                 FROM [tbl_Order_Item] 
                
                  WHERE [OrderID] = @ordeId AND [Drug_Name]=@Dname AND [Pack_Size]=@size ";
                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@ordeId", this.txt_order_Id.Text);
                com.Parameters.AddWithValue("@Dname", this.txt_d_name.Text);
                com.Parameters.AddWithValue("@size", this.txt_pack_size.Text);


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow rows = ds.Tables[0].Rows[0];


                    ItemID = Convert.ToInt32(rows["ItemID"]);




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string sql = "DELETE  " +
               "FROM [tbl_Order_Item] " +

               "WHERE [ItemID] = @itemID ";


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@itemID",ItemID);  


                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Removed successfully");



                  
               
                


                    string sql2 = @"
                  SELECT[OrderID],[Drug_Name], [Pack_Size],[Quantity]
                    FROM[tbl_Order_Item]


                  WHERE [OrderID] = @ordeId";
                    SqlCommand com2 = new SqlCommand(sql2, con);

                    com2.Parameters.AddWithValue("@ordeId", this.txt_order_Id.Text);


                    SqlDataAdapter dap = new SqlDataAdapter(com2);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    this.dataGridView_Items.DataSource = ds.Tables[0];


                    con.Close();


                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_suppliers_Click(object sender, EventArgs e)
        {

            try
            {


                SqlConnection con = new SqlConnection(cs);
                con.Open();




                string sql2 = @"
                 SELECT * 
                 FROM [tbl_drug_supplier]";
                SqlCommand com2 = new SqlCommand(sql2, con);



                SqlDataAdapter dap = new SqlDataAdapter(com2);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_Items.DataSource = ds.Tables[0];


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_d_name.Clear();
            txt_pack_size.Clear();
            numericUpDown_quantity.Value = 0;
        }
    }
}
