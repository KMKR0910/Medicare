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
    public partial class Doctor_User_Profile : Form
    {
        public Doctor_User_Profile()
        {
            InitializeComponent();
           this.Size = new Size(1024, 768);
        }

        private void Doctor_User_Profile_Load(object sender, EventArgs e)
        {
            LoadFormInGroupBox();
        }
        private void LoadFormInGroupBox()
        {
            /*// Create an instance of Form2
            Med_Add_Appoinment form2 = new Med_Add_Appoinment();

            // Remove borders and make the form a child control
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;

            // Add the form to the GroupBox
            groupBox1.Controls.Clear();  // Optionally clear previous controls
            groupBox1.Controls.Add(form2);

            // Show the form inside the GroupBox
            form2.Show();*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
