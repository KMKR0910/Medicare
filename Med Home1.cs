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
    public partial class Med_Home1 : Form
    {
        public Med_Home1(String UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        public string UserID { get; private set; }
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
        private void LoadAppoinments()
        {



            Med_Appointments form2 = new Med_Appointments();
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



            Med_Patient_Details form2 = new Med_Patient_Details();
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
        private void LoadViewDoctorSession()
        {



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
        private void LoadAddDoctorSession()
        {



            Med_Patient_Details form2 = new Med_Patient_Details();
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



        private void Med_Home1_Load(object sender, EventArgs e)
        {
            SaveCurrentControls();
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
            LoadAppoinments();
        }

        private void appoinmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAppoinments();

        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPatient();
        }

        private void groupBox_Patients_Enter(object sender, EventArgs e)
        {
            LoadPatient();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void doctorSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void view_doctor_sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadViewDoctorSession();
        }

        private void add_doctor_sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAddDoctorSession();
        }

        private void edit_doctor_sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadViewDoctorSession();
        }
    }
}
