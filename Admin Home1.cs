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
    public partial class Admin_Home1 : Form
    {
        public Admin_Home1(String UserID)
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_employee.BackColor = customC;
            btn_home.BackColor = customC;
            
            btn_userProfile.BackColor = customC;
            linkLabel1.LinkColor = customC;
            linkLabel2.LinkColor = customC;
            linkLabel2.LinkColor = customC;

            menuStrip1.BackColor = customC;
            this.UserID = UserID;
            this.AutoScaleMode = AutoScaleMode.Dpi;
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

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Create an instance of Form2
            User_Registration form2 = new User_Registration();

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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreHomeControls();
        }

        private void Admin_Home1_Load(object sender, EventArgs e)
        {
            SaveCurrentControls();
        }

        private void groupBox_home_Enter(object sender, EventArgs e)
        {
            RestoreHomeControls();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void userProfileToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Dashboard form2 = new Main_Dashboard();
            form2.Show();
            this.Hide();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Create an instance of Form2
            Admin_View_Users form2 = new Admin_View_Users();

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

        private void groupBox_userprofile_Enter(object sender, EventArgs e)
        {
            userProfileToolStripMenuItem_Click(null, EventArgs.Empty);
        }

        private void groupBox_users_Enter(object sender, EventArgs e)
        {
            viewUsersToolStripMenuItem_Click(null, EventArgs.Empty);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userRegistrationToolStripMenuItem_Click(null, EventArgs.Empty);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewUsersToolStripMenuItem_Click(null, EventArgs.Empty);
        }
    }
}
