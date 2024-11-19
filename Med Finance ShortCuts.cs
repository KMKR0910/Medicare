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
    public partial class Med_Finance_ShortCuts : Form
    {
        public Med_Finance_ShortCuts()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
                //Create an instance of Form2
                Med_Add_expenses form2 = new Med_Add_expenses();

                // Remove borders and make the form a child control
                form2.TopLevel = false;
                form2.FormBorderStyle = FormBorderStyle.None;
                form2.Dock = DockStyle.Fill;

                // Add the form to the GroupBox
                //.Controls.Clear();  // Optionally clear previous controls
                //groupBox1.Controls.Add(form2);

                // Show the form inside the GroupBox
                form2.Show();
            
        }
    }
}
