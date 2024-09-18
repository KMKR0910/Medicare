using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;


namespace Diploma_Final_Project_1
{
    public partial class Med_Appointments : Form
    {
        private DateTime _currentDate;
        private List<Label> _dayLabels = new List<Label>();

        public Med_Appointments()
        {
            InitializeComponent();
            _currentDate = DateTime.Now;
            InitializeCalendar();
        }

        private void InitializeCalendar()
        {
            // Create labels for each day of the month
            int day = 1;
            int row = 0;
            int col = 0;

            // Calculate the starting day of the week for the current month
            int firstDay = (int)_currentDate.DayOfWeek;
            for (int i = 0; i < firstDay; i++)
            {
                Label label = new Label();
                label.Text = "";
                label.AutoSize = true;
                label.Location = new Point(col * 50 + 10, row * 30 + 10);
                calendarPanel.Controls.Add(label);
                _dayLabels.Add(label);
                col++;
                if (col == 7)
                {
                    col = 0;
                    row++;
                }
            }

            // Add labels for the remaining days of the month
            while (day <= DateTime.DaysInMonth(_currentDate.Year, _currentDate.Month))
            {
                Label label = new Label();
                label.Text = day.ToString();
                label.AutoSize = true;
                label.Location = new Point(col * 50 + 10, row * 30 + 10);
                calendarPanel.Controls.Add(label);
                _dayLabels.Add(label);
                day++;
                col++;
                if (col == 7)
                {
                    col = 0;
                    row++;
                }
            }
        }
        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            _currentDate = _currentDate.AddMonths(1);
            // Update the calendar with the new date
            UpdateCalendar();
        }

        private void PreviousMonthButton_Click(object sender, EventArgs e)
        {
            _currentDate = _currentDate.AddMonths(-1);
            UpdateCalendar();
        }

        private void UpdateCalendar()
        {
            // Clear existing day labels
            calendarPanel.Controls.Clear();
            _dayLabels.Clear();

            // Re-initialize the calendar with the updated date
            InitializeCalendar();
        }

        private void Med_Appointments_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar_appoinment_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

       
    }
}
