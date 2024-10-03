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
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {

        }

        private void sytemMainatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel_backup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string backupFilePath = @"C:\Backup\hospital_db_backup.bak";
            string sqlBackup = $@"BACKUP DATABASE hospital_db TO DISK = '{backupFilePath}'";
            string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";


            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand(sqlBackup, conn);
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Database backup successful.");
            }

        }
    }
}
