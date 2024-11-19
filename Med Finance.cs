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
    public partial class Med_Finance : Form
    {
        
        public Med_Finance()
        {
            InitializeComponent();
        }

        private void Med_Finance_Load(object sender, EventArgs e)
        {

        }
        
        private void LoadFinance3()
        {
            //Create an instance of Form2
            Med_Add_expenses form2 = new Med_Add_expenses();

            // Remove borders and make the form a child control
            
         

            
          

            // Show the form inside the GroupBox
            form2.Show();
            this.Hide();
        }



        private void btn_add_expenses_Click(object sender, EventArgs e)
        {
            LoadFinance3();

        }

        private void btn_viewExpenses_Click(object sender, EventArgs e)
        {
            LoadFinance3();
        }

        private void btn_income_report_Click(object sender, EventArgs e)
        {

        }
    }
}