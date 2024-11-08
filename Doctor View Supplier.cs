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
    public partial class Doctor_View_Supplier : Form
    {
        public Doctor_View_Supplier()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
           
        }

        private void Doctor_View_Supplier_Load(object sender, EventArgs e)
        {

        }
    }
}
