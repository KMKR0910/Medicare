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

using System.Globalization;

namespace Diploma_Final_Project_1
{
    public partial class Doctor_Visit : Form
    {
        public Doctor_Visit()
        {
            InitializeComponent();
            
        }
      


        private void Doctor_Visit_Load(object sender, EventArgs e)
        {
            txt_today.Text = DateTime.Now.ToString("MM/dd/yyyy");

        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker_Week.Value;

            // Find the Monday of the selected week
            int delta = DayOfWeek.Monday - selectedDate.DayOfWeek;
            DateTime startOfWeek = selectedDate.AddDays(delta);

            // You can display this or use it as reference for the selected week
            MessageBox.Show("Week starts on: " + startOfWeek.ToShortDateString());

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            DateTime selectedDate = dateTimePicker_Week.Value;

            // Find the Monday of the selected week
            int delta = DayOfWeek.Monday - selectedDate.DayOfWeek;
            DateTime startOfWeek = selectedDate.AddDays(delta);

            // List to store selected days and times
            List<string> selectedDays = new List<string>();

            if (checkBox1.Checked)
            {
                DateTime monday = startOfWeek;
                selectedDays.Add(monday.ToShortDateString());
            }
            if (checkBox2.Checked)
            {
                DateTime tuesday = startOfWeek.AddDays(1);
                selectedDays.Add(tuesday.ToShortDateString());
            }
            if (checkBox3.Checked)
            {
                DateTime wednesday = startOfWeek.AddDays(2);
                selectedDays.Add(wednesday.ToShortDateString());
            }
            if (checkBox4.Checked)
            {
                DateTime thursday = startOfWeek.AddDays(3);
                selectedDays.Add(thursday.ToShortDateString());
            }
            if (checkBox5.Checked)
            {
                DateTime friday = startOfWeek.AddDays(4);
                selectedDays.Add(friday.ToShortDateString());
            }
            if (checkBox6.Checked)
            {
                DateTime saturday = startOfWeek.AddDays(5);
                selectedDays.Add(saturday.ToShortDateString());
            }
            if (checkBox7.Checked)
            {
                DateTime sunday = startOfWeek.AddDays(6);
                selectedDays.Add(sunday.ToShortDateString());
            }

            // Get the doctor's arrival and departure times
            DateTime doctorArrival = dateTimePicker2.Value;
            DateTime doctorDeparture = dateTimePicker3.Value;
            int appointmentNumber = 1;

            // Loop through each selected day and generate 10-minute sessions
            foreach (string day in selectedDays)
            {
                DateTime dayStartTime = DateTime.Parse(day + " " + doctorArrival.ToShortTimeString());
                DateTime dayEndTime = DateTime.Parse(day + " " + doctorDeparture.ToShortTimeString());

                // Calculate 10-minute intervals
                TimeSpan sessionDuration = TimeSpan.FromMinutes(10);
                DateTime currentSessionStartTime = dayStartTime;

                while (currentSessionStartTime.Add(sessionDuration) <= dayEndTime)
                {
                    DateTime currentSessionEndTime = currentSessionStartTime.Add(sessionDuration);

                    // Save each session (10 minutes) to the database along with the appointment number
                    SaveToDatabase(currentSessionStartTime.ToString(), currentSessionStartTime.ToShortTimeString(), currentSessionEndTime.ToShortTimeString(), appointmentNumber);

                    // Increment the appointment number for the next session
                    appointmentNumber++;

                    // Move to the next session
                    currentSessionStartTime = currentSessionEndTime;
                }
            }

        }

        private void SaveToDatabase(string day, string startTime, string endTime, int appointmentNumber)
        {
            try
            {
                string cs = "Data Source=ASUS; Initial Catalog =Diploma Final Project DB1; Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    string query = "INSERT INTO DoctorSessions (SessionDate, StartTime, EndTime, AppointmentNumber,AppointmentStatus) VALUES (@day, @startTime, @endTime, @appointmentNumber,@status)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@day", day);
                        cmd.Parameters.AddWithValue("@startTime", startTime);
                        cmd.Parameters.AddWithValue("@endTime", endTime);
                        cmd.Parameters.AddWithValue("@appointmentNumber", appointmentNumber);
                        cmd.Parameters.AddWithValue("@status",true);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

   
        
    

