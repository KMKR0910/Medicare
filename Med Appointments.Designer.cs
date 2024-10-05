
namespace Diploma_Final_Project_1
{
    partial class Med_Appointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_appointmentNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pending = new System.Windows.Forms.TextBox();
            this.txt_completed = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_complete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_appoinment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_appointment = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_AP_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 42);
            this.label1.TabIndex = 82;
            this.label1.Text = "Today\'s Appointments";
            // 
            // txt_appointmentNumber
            // 
            this.txt_appointmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appointmentNumber.Location = new System.Drawing.Point(483, 268);
            this.txt_appointmentNumber.Name = "txt_appointmentNumber";
            this.txt_appointmentNumber.Size = new System.Drawing.Size(229, 44);
            this.txt_appointmentNumber.TabIndex = 86;
            this.txt_appointmentNumber.TextChanged += new System.EventHandler(this.txt_appointmentNumber_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 42);
            this.label7.TabIndex = 84;
            this.label7.Text = "Appointment Number";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(483, 154);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(351, 44);
            this.txt_name.TabIndex = 85;
            // 
            // txt_pending
            // 
            this.txt_pending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pending.Location = new System.Drawing.Point(531, 464);
            this.txt_pending.Name = "txt_pending";
            this.txt_pending.Size = new System.Drawing.Size(351, 44);
            this.txt_pending.TabIndex = 86;
            // 
            // txt_completed
            // 
            this.txt_completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_completed.Location = new System.Drawing.Point(531, 339);
            this.txt_completed.Name = "txt_completed";
            this.txt_completed.Size = new System.Drawing.Size(351, 44);
            this.txt_completed.TabIndex = 85;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(347, 679);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 84;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 42);
            this.label5.TabIndex = 83;
            this.label5.Text = "Completed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_complete);
            this.groupBox1.Controls.Add(this.txt_appointmentNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 633);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1361, 572);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_complete
            // 
            this.btn_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_complete.Location = new System.Drawing.Point(48, 443);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(216, 108);
            this.btn_complete.TabIndex = 108;
            this.btn_complete.Text = "Complete";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 42);
            this.label6.TabIndex = 83;
            this.label6.Text = "Patient Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 42);
            this.label4.TabIndex = 82;
            this.label4.Text = "Pending";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 42);
            this.label2.TabIndex = 80;
            this.label2.Text = "Total Appointments";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 122);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_pending);
            this.splitContainer1.Panel1.Controls.Add(this.txt_completed);
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_appoinment);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_appointment);
            this.splitContainer1.Size = new System.Drawing.Size(2617, 1362);
            this.splitContainer1.SplitterDistance = 1211;
            this.splitContainer1.TabIndex = 84;
            // 
            // txt_appoinment
            // 
            this.txt_appoinment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appoinment.Location = new System.Drawing.Point(531, 205);
            this.txt_appoinment.Name = "txt_appoinment";
            this.txt_appoinment.Size = new System.Drawing.Size(351, 44);
            this.txt_appoinment.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 42);
            this.label3.TabIndex = 81;
            this.label3.Text = "Today\'s Overview";
            // 
            // dataGridView_appointment
            // 
            this.dataGridView_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_appointment.Location = new System.Drawing.Point(22, 122);
            this.dataGridView_appointment.Name = "dataGridView_appointment";
            this.dataGridView_appointment.RowHeadersWidth = 82;
            this.dataGridView_appointment.RowTemplate.Height = 33;
            this.dataGridView_appointment.Size = new System.Drawing.Size(1361, 476);
            this.dataGridView_appointment.TabIndex = 81;
            this.dataGridView_appointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_appointment_CellContentClick);
            // 
            // dateTimePicker_AP_date
            // 
            this.dateTimePicker_AP_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_AP_date.Location = new System.Drawing.Point(21, 33);
            this.dateTimePicker_AP_date.Name = "dateTimePicker_AP_date";
            this.dateTimePicker_AP_date.Size = new System.Drawing.Size(543, 44);
            this.dateTimePicker_AP_date.TabIndex = 83;
            // 
            // Med_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2427, 1449);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dateTimePicker_AP_date);
            this.Name = "Med_Appointments";
            this.Text = "Med_Appointments";
            this.Load += new System.EventHandler(this.Med_Appointments_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_appointmentNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pending;
        private System.Windows.Forms.TextBox txt_completed;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_appoinment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_appointment;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AP_date;
        private System.Windows.Forms.Button btn_complete;
    }
}