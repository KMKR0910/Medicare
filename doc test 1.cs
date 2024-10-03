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
    public partial class doc_test_1 : Form
    {
        public doc_test_1()
        {
            InitializeComponent();
        }

        private void btn_appoinments_Click(object sender, EventArgs e)
        {

        }

        private void btn_userProfile_Click(object sender, EventArgs e)
        {
            
                //Create an instance of Form2
                Doctor_Employee_User_Profile form2 = new Doctor_Employee_User_Profile();

                // Remove borders and make the form a child control
                form2.TopLevel = false;
                form2.FormBorderStyle = FormBorderStyle.None;
                form2.Dock = DockStyle.Fill;

                // Add the form to the GroupBox
                groupBox1.Controls.Clear();  // Optionally clear previous controls
                groupBox1.Controls.Add(form2);

                // Show the form inside the GroupBox
                form2.Show();
           
        }
    }
}
