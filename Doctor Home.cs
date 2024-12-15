using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Diploma_Final_Project_1
{
    public partial class Doctor_Home : Form
    {
        public Doctor_Home(String UserID)
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
                button1.BackColor = customC;
            button2.BackColor = customC;

            button3.BackColor = customC;
            button4.BackColor = customC;
            button5.BackColor = customC;
            button6.BackColor = customC;
            button7.BackColor = customC;
            button8.BackColor = customC;
            button9.BackColor = customC;
            linkLabel22.LinkColor = customC;
            linkLabel21.LinkColor = customC;
            linkLabel20.LinkColor = customC;
            linkLabel19.LinkColor = customC;
            linkLabel18.LinkColor = customC;
            linkLabel17.LinkColor = customC;
            linkLabel16.LinkColor = customC;
         

            menuStrip1.BackColor = customC;


            this.UserID = UserID;




            this.AutoScaleMode = AutoScaleMode.Dpi;

        }

       
      
        private void LoadEmployeeInGroupBox1()
        {
            //Create an instance of Form2
            Doctor_Employee_User_Profile form2 = new Doctor_Employee_User_Profile(UserID);

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
        private void LoadDoctorSession()
        {
            //Create an instance of Form2
            Med_View_Doctor_Visits form2 = new Med_View_Doctor_Visits();

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
            Doctor_Appoinments1 form2 = new Doctor_Appoinments1();

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

        public string UserID { get; private set; }

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
        private void LoadUserProfile()
        {

            

                Employee_User_Profile form2 = new Employee_User_Profile(UserID);
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



        private void btn_userProfile_Click(object sender, EventArgs e)
        {

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void btn_userProfile_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox_doctor_session_Enter(object sender, EventArgs e)
        {
            LoadDoctorSession();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Dashboard form2 = new Main_Dashboard();
            form2.Show();
            this.Hide();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

            //Create an instance of Form2
            Doctor_View_Drug_Inventory form2 = new Doctor_View_Drug_Inventory();

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

        private void drugInventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewDrugInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox8_Enter(this, EventArgs.Empty);

        }

        private void viewDrugInventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Gen_Drug_Inventory r1 = new Report_Gen_Drug_Inventory();
            r1.Show();
        }

        private void genarateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create an instance of Form2
            Doctor_Genarate_Medical_Certificate  form2 = new Doctor_Genarate_Medical_Certificate(UserID);

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

        private void groupBox_Home_Enter(object sender, EventArgs e)
        {
            RestoreHomeControls();
        }

        private void groupBox_UserProfile_Enter(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void groupBox_Appoinments_Enter(object sender, EventArgs e)
        {
            LoadAppoinment();
        }

        private void groupBox_Patients_Enter(object sender, EventArgs e)
        {
            LoadPatient();
        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {
            LoadDoctorSession();
        }

        private void groupBox_inventrory_Enter(object sender, EventArgs e)
        {
            
        }

        private void viewDrugInventoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            //Create an instance of Form2
            Doctor_View_Drug_Inventory form2 = new Doctor_View_Drug_Inventory();

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

        private void viewDrugInventoryReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Report_Gen_Drug_Inventory r1 = new Report_Gen_Drug_Inventory();
            r1.Show();
        }

        private void groupBox_employee_Enter(object sender, EventArgs e)
        {
            LoadEmployeeInGroupBox1();
        }

        private void diagnosisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
