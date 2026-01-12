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
    public partial class Doctor_View_Drug_Order : Form
    {

        private string _userId;
        public Doctor_View_Drug_Order(string userID)
        {
            InitializeComponent();
            _userId = userID;
        }
        string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";
        string orderID;


        private void Doctor_View_Drug_Order_Load(object sender, EventArgs e)
        {
            try
            {



                SqlConnection con = new SqlConnection(cs);
                con.Open();





                string sql = @"
                 SELECT p.[Company_Name],p.[Supplier_Name],td.[Order_Status],td.[Total_Amount],td.[Ordered_date],td.[Received_date],td.[OrderID]
                 FROM tbl_Drug_order td
INNER JOIN 
[tbl_drug_supplier] p    ON 
        td.[Supplier_ID] = p.[Supplier_ID] ORDER BY
        td.[OrderID] DESC";



                SqlCommand com = new SqlCommand(sql, con);

              


                SqlDataAdapter dap = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView_orders.DataSource = ds.Tables[0];
                dataGridView_orders.Columns[0].HeaderText = "Company Name";
                dataGridView_orders.Columns[1].HeaderText = "Supplier Name";
                dataGridView_orders.Columns[2].HeaderText = "Status";
                dataGridView_orders.Columns[3].HeaderText = "Amount";
                dataGridView_orders.Columns[4].HeaderText = "Ordered Date";
                dataGridView_orders.Columns[5].HeaderText = "Received Date";
                dataGridView_orders.Columns[6].HeaderText = "Order ID";


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dataGridView_orders.Rows[e.RowIndex];

                // Assuming you want the data from the first column (index 0)
              orderID = row.Cells[6].Value.ToString();
                try
                {



                    SqlConnection con = new SqlConnection(cs);
                    con.Open();





                    string sql = @"
                 SELECT 
      
      [Drug_Name]
      ,[Pack_Size]
      ,[Quantity]
                 FROM [tbl_Order_Item] WHERE OrderID=@orderID 
                
                  ";
                    SqlCommand com = new SqlCommand(sql, con);


                    com.Parameters.AddWithValue("@orderID", orderID);


                    SqlDataAdapter dap = new SqlDataAdapter(com);
                    DataSet ds = new DataSet();
                    dap.Fill(ds);

                    this.dataGridView_items.DataSource = ds.Tables[0];
                    dataGridView_items.Columns[1].HeaderText = "Pack Size";



                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string status1 = "Doctor Confirmed";
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string query = "UPDATE [tbl_Drug_order] SET [Order_Status]= @status,[Ordered_date]=@date,[DoctorID]=@doctorID  WHERE [OrderID]=@orderID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", status1);
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@date", DateTime.Today);
                cmd.Parameters.AddWithValue("@doctorID", _userId);

                int ret = cmd.ExecuteNonQuery();
                Doctor_View_Drug_Order_Load(this, EventArgs.Empty);



                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_decline_Click(object sender, EventArgs e)
        {
            string status1 = "Doctor Declined";
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                string query = "UPDATE [tbl_Drug_order] SET[Order_Status]= @status WHERE [OrderID]=@orderID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", status1);
                cmd.Parameters.AddWithValue("@orderID", orderID);
                int ret = cmd.ExecuteNonQuery();
                Doctor_View_Drug_Order_Load(this, EventArgs.Empty);



                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
