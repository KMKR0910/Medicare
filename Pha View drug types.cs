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
    public partial class Pha_View_drug_types : Form
    {
        public Pha_View_drug_types()
        {
            InitializeComponent();
            Color customC = ColorTranslator.FromHtml("#9083D5 ");
            btn_search.BackColor = customC;
            btn_serach_drug.BackColor = customC;

        }

        private void dataGridView_Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pha_View_drug_types_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
