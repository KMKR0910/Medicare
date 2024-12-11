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
    public partial class Lab_Home : Form
    {
        public string UserID { get; private set; }

        public Lab_Home(String UserID)
        {
            InitializeComponent();
            this.UserID = UserID;

            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_home.BackColor = customC;
            btn_userProfile.BackColor = customC;

            btn_doctor_session.BackColor = customC;
            btn_LabTests.BackColor = customC;
            btn_prescription.BackColor = customC;
            linkLabel1.LinkColor = customC;
            linkLabel2.LinkColor = customC;
            linkLabel3.LinkColor = customC;
            

            menuStrip1.BackColor = customC;
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
        private void laboratoryTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Create an instance of Form2
            Lab_view_lab_test form2 = new Lab_view_lab_test();

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

        private void groupBox_lab_test_Enter(object sender, EventArgs e)
        {
            laboratoryTestsToolStripMenuItem_Click(this, EventArgs.Empty);

        }

        

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create an instance of Form2
            Lab_Prescription form2 = new Lab_Prescription();

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
        private void LoadDoctorSessions()
        {
            View_Doctor_visits form2 = new View_Doctor_visits();
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


        private void groupBox_prescription_Enter(object sender, EventArgs e)
        {
            prescriptionToolStripMenuItem_Click(this, EventArgs.Empty);

        }

        private void groupBox_employee_Enter(object sender, EventArgs e)
        {

        }

        private void Lab_Home_Load(object sender, EventArgs e)
        {
            SaveCurrentControls();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreHomeControls();
        }

        private void view_doctor_sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox_UserProfile_Enter(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void groupBox_doctor_session_Enter(object sender, EventArgs e)
        {
            LoadDoctorSessions();
        }

        private void groupBox_finance_Enter(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Dashboard form2 = new Main_Dashboard();
            form2.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void doctorSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDoctorSessions();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            laboratoryTestsToolStripMenuItem_Click(null, EventArgs.Empty);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            prescriptionToolStripMenuItem_Click(null, EventArgs.Empty);
        }
    }
}
