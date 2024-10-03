using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Diploma_Final_Project_1
{
    public partial class Doctor_Home : Form
    {
        public Doctor_Home()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
                btn_home.BackColor = customC;
            btn_userProfile.BackColor = customC;

            btn_appoinments.BackColor = customC;
            btn_patients.BackColor = customC;
            btn_prescription.BackColor = customC;
            btn_diaganosisData.BackColor = customC;
            btn_drugInventory.BackColor = customC;
            btn_employee.BackColor = customC;
            btn_finance.BackColor = customC;
            linkLabel1.LinkColor = customC;
            linkLabel2.LinkColor = customC;
            linkLabel3.LinkColor = customC;
            linkLabel4.LinkColor = customC;
            linkLabel5.LinkColor = customC;
            linkLabel6.LinkColor = customC;
            linkLabel7.LinkColor = customC;
            linkLabel8.LinkColor = customC;
            linkLabel9.LinkColor = customC;
            linkLabel10.LinkColor = customC;
            linkLabel11.LinkColor = customC;

            menuStrip1.BackColor = customC;
                      


       

            this.AutoScaleMode = AutoScaleMode.Dpi;

        }

       
      
        private void LoadEmployeeInGroupBox1()
        {
            //Create an instance of Form2
            Doctor_Employee_User_Profile form2 = new Doctor_Employee_User_Profile();

            // Remove borders and make the form a child control
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;

            // Add the form to the GroupBox
            groupBoxloc.Controls.Clear();  // Optionally clear previous controls
            groupBoxloc.Controls.Add(form2);

            // Show the form inside the GroupBox
            form2.Show();
        }
        private void LoadAppoinment()
        
            {
            //Create an instance of Form2
            Doctor_Appointment form2 = new Doctor_Appointment();

            // Remove borders and make the form a child control
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;

            // Add the form to the GroupBox
            groupBoxloc.Controls.Clear();  // Optionally clear previous controls
            groupBoxloc.Controls.Add(form2);

            // Show the form inside the GroupBox
            form2.Show();
        }
        private void LoadPatient()
        {
            SaveCurrentControls();
            //Create an instance of Form2
            Patient_Details_Doctor form2 = new Patient_Details_Doctor();

            // Remove borders and make the form a child control
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
            form2.Size = groupBox1.ClientSize;
            form2.Location = new Point(0, 0);
            // Add the form to the GroupBox
            groupBoxloc.Controls.Clear();  // Optionally clear previous controls
            groupBoxloc.Controls.Add(form2);

            // Show the form inside the GroupBox
            form2.Show();
        }
        private List<Control> previousControls = new List<Control>();
        private void SaveCurrentControls()
        {
            // Save the existing controls in the GroupBox to the list
            previousControls.Clear();
            foreach (Control ctrl in groupBoxloc.Controls)
            {
                previousControls.Add(ctrl);
            }
        }
        private void RestoreHomeControls()
        {
            // Clear the current controls in the GroupBox
            groupBoxloc.Controls.Clear();

            // Add the previously saved controls back into the GroupBox
            foreach (Control ctrl in previousControls)
            {
                groupBoxloc.Controls.Add(ctrl);
               
            }
        }
       

       

        private void btn_userProfile_Click(object sender, EventArgs e)
        {

            string postion = "Doctor";
            string cs = "Data Source=ASUS; Initial Catalog = Diploma Final Project DB1; Integrated Security=True";

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "select [User ID] from tbl_Internal_User WHERE [Postion]=@postion";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@postion", postion);

            var userId = com.ExecuteScalar()?.ToString();  // Fetch the first column of the first row

            if (userId != null)
            {
                Employee_User_Profile profileForm = new Employee_User_Profile(userId);
                profileForm.Show();
            }
            else
            {
                MessageBox.Show("No user found with the specified position.");
            }


            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            RestoreHomeControls();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            LoadAppoinment();
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {
            LoadEmployeeInGroupBox1();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadEmployeeInGroupBox1();
        }

        private void appoinmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAppoinment();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            LoadPatient();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPatient();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            RestoreHomeControls();
        }

        private void Doctor_Home_Load(object sender, EventArgs e)
        {
            SaveCurrentControls();
        }
    }
}
