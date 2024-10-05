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
    public partial class Pha_Home : Form
    {
        public Pha_Home(String UserID)
        {
            InitializeComponent();
            this.UserID = UserID;

            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_home.BackColor = customC;
            btn_userProfile.BackColor = customC;

            btn_prescription.BackColor = customC;
            btn_patients.BackColor = customC;
            btn_doctor_session.BackColor = customC;
            btn_diaganosisData.BackColor = customC;
            btn_drugInventory.BackColor = customC;
          
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
        }

        private void groupBox_Patients_Enter(object sender, EventArgs e)
        {

            Phar_Prescription form2 = new Phar_Prescription();
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

        private void Pha_Home_Load(object sender, EventArgs e)
        {
            SaveCurrentControls();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreHomeControls();
        }

        private void groupBox_inventrory_Enter(object sender, EventArgs e)
        {

            Pha_View_Drug_inventory form2 = new Pha_View_Drug_inventory();
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

        private void viewDrugOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            groupBox_drugOrder_Enter(this, EventArgs.Empty);
        }

        private void addDrugOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pha_Drug_Order form2 = new Pha_Drug_Order();
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

        private void viewDrugInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox_inventrory_Enter(this, EventArgs.Empty);

        }

        private void addDrugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pha_Add_drugs form2 = new Pha_Add_drugs();
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

        private void groupBox_drugOrder_Enter(object sender, EventArgs e)
        {
            Pha_View_Drug_Order form2 = new Pha_View_Drug_Order();
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

       
    }
}
