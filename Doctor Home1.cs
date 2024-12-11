using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_Final_Project_1
{
    public partial class Doctor_Home1 : Form
    {
        public Doctor_Home1(String UserID)
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_appoinments.BackColor = customC;
            btn_diaganosisData.BackColor = customC;

            btn_doctor_session.BackColor = customC;
            btn_drugInventory.BackColor = customC;
            btn_employee.BackColor = customC;
            btn_finance.BackColor = customC;
            btn_home.BackColor = customC;
            btn_patients.BackColor = customC;
            btn_userProfile.BackColor = customC;
            linkLabel1.LinkColor = customC;
            linkLabel2.LinkColor = customC;
            linkLabel3.LinkColor = customC;
            linkLabel4.LinkColor = customC;
            linkLabel5.LinkColor = customC;
            linkLabel6.LinkColor = customC;
          
            
            linkLabel9.LinkColor = customC;
           
          


            menuStrip1.BackColor = customC;


            this.UserID = UserID;




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
        private void Doctor_Home1_Load(object sender, EventArgs e)
        {
            SaveCurrentControls();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Dashboard form2 = new Main_Dashboard();
            form2.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreHomeControls();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadEmployeeInGroupBox1();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPatient();

        }

        private void appoinmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAppoinment();
        }

        private void diagnosisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox7_Enter(null, EventArgs.Empty);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            RestoreHomeControls();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            LoadAppoinment();
        }

        private void groupBox_doctor_session_Enter(object sender, EventArgs e)
        {
            LoadDoctorSession();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            viewLabTestPricelistsToolStripMenuItem_Click(null, EventArgs.Empty);
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

        private void groupBox9_Enter(object sender, EventArgs e)
        {
            LoadEmployeeInGroupBox1();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {
            Med_Finance form2 = new Med_Finance();
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

        private void addDiagnositicDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Diagnose_History form2 = new Add_Diagnose_History();
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

        private void editDiagnosticDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor_View_Diagnose_Histroy form2 = new Doctor_View_Diagnose_Histroy();
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

        private void medicalCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Doctor_Genarate_Medical_Certificate form2 = new Doctor_Genarate_Medical_Certificate();
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

        private void viewLabTestPricelistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor_View_Lab_Tests form2 = new Doctor_View_Lab_Tests();
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

        private void drugSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor_View_Supplier form2 = new Doctor_View_Supplier();
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

        private void viewPatientLabTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can now view the patient's lab test report.");

        }

        private void drugOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Doctor_View_Drug_Order form2 = new Doctor_View_Drug_Order();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadAppoinment();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDoctorSession();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            medicalCertificateToolStripMenuItem_Click(null, EventArgs.Empty);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addDiagnositicDataToolStripMenuItem_Click(null, EventArgs.Empty);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editDiagnosticDataToolStripMenuItem_Click(null, EventArgs.Empty);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPatient();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            financeToolStripMenuItem_Click(null, EventArgs.Empty);
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Main_Dashboard form2 = new Main_Dashboard();
            form2.Show();
            this.Hide();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            LoadPatient();
        }
    }
}
