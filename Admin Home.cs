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
    public partial class Admin_Home : Form
    {
        public Admin_Home(String UserID)
        {
            InitializeComponent();
            this.UserID = UserID;

            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_home.BackColor = customC;
            btn_home.BackColor = customC;
            btn_userProfile.BackColor = customC;

           
          
            btn_employee.BackColor = customC;
           
            //linkLabel1.LinkColor = customC;
            //linkLabel2.LinkColor = customC;
            //linkLabel3.LinkColor = customC;


            menuStrip1.BackColor = customC;

        }

        private List<Control> previousControls = new List<Control>();

        public string UserID { get; private set; }

        private void SaveCurrentControls()
        {
            // Save the existing controls in the GroupBox to the list
            previousControls.Clear();
            foreach (Control ctrl in groupBox_Main.Controls)
            {
                previousControls.Add(ctrl);
            }
        }
        private void RestoreHomeControls()
        {
            // Clear the current controls in the GroupBox
            groupBox_Main.Controls.Clear();

            // Add the previously saved controls back into the GroupBox
            foreach (Control ctrl in previousControls)
            {
                groupBox_Main.Controls.Add(ctrl);

            }
        }

        private void LoadUserRegister()
        {
            //Create an instance of Form2
            User_Registration form2 = new User_Registration();

            // Remove borders and make the form a child control
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;

            // Add the form to the GroupBox
            groupBox_Main.Controls.Clear();  // Optionally clear previous controls
            groupBox_Main.Controls.Add(form2);

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
            groupBox_Main.Controls.Clear();  // Optionally clear previous controls
            groupBox_Main.Controls.Add(form2);

            // Show the form inside the GroupBox
            form2.Show();
        }


        private void groupBox_Users_Enter(object sender, EventArgs e)
        {
            //Create an instance of Form2
            Admin_View_Users form2 = new Admin_View_Users();

            // Remove borders and make the form a child control
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;

            // Add the form to the GroupBox
            groupBox_Main.Controls.Clear();  // Optionally clear previous controls
            groupBox_Main.Controls.Add(form2);

            // Show the form inside the GroupBox
            form2.Show();
           
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {
            SaveCurrentControls();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreHomeControls();
        }

        private void UserRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserRegister();
           
        }

        private void groupBox_UserProfile_Enter(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Dashboard form2 = new Main_Dashboard();
            form2.Show();
            this.Hide();
        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserRegister();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox_Users_Enter(this, EventArgs.Empty);
        }

        private void userProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox_UserProfile_Enter(this, EventArgs.Empty);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserRegister();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox_Users_Enter(this, EventArgs.Empty);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserProfile();
        }

        private void groupBox_Main_Enter(object sender, EventArgs e)
        {

        }
    }
}
