
namespace Diploma_Final_Project_1
{
    partial class Doctor_Appoinments1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker_AP_date = new System.Windows.Forms.DateTimePicker();
            this.txt_appoinment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_pending = new System.Windows.Forms.TextBox();
            this.txt_completed = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_appointment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_AP_date
            // 
            this.dateTimePicker_AP_date.Enabled = false;
            this.dateTimePicker_AP_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_AP_date.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker_AP_date.Name = "dateTimePicker_AP_date";
            this.dateTimePicker_AP_date.Size = new System.Drawing.Size(543, 44);
            this.dateTimePicker_AP_date.TabIndex = 85;
            this.dateTimePicker_AP_date.ValueChanged += new System.EventHandler(this.dateTimePicker_AP_date_ValueChanged);
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
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 88);
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
            this.splitContainer1.TabIndex = 86;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 672);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 499);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(316, 230);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(328, 38);
            this.txt_status.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 42);
            this.label7.TabIndex = 84;
            this.label7.Text = "Status";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(316, 71);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(328, 38);
            this.txt_name.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 42);
            this.label6.TabIndex = 83;
            this.label6.Text = "Patient Name";
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
            // dataGridView_appointment
            // 
            this.dataGridView_appointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_appointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_appointment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_appointment.Location = new System.Drawing.Point(22, 122);
            this.dataGridView_appointment.Name = "dataGridView_appointment";
            this.dataGridView_appointment.RowHeadersWidth = 82;
            this.dataGridView_appointment.RowTemplate.Height = 33;
            this.dataGridView_appointment.Size = new System.Drawing.Size(1166, 476);
            this.dataGridView_appointment.TabIndex = 81;
            this.dataGridView_appointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_appointment_CellContentClick);
            // 
            // Doctor_Appoinments1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2427, 1449);
            this.Controls.Add(this.dateTimePicker_AP_date);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Doctor_Appoinments1";
            this.Text = "Doctor_Appoinments1";
            this.Load += new System.EventHandler(this.Doctor_Appoinments1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_AP_date;
        private System.Windows.Forms.TextBox txt_appoinment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_pending;
        private System.Windows.Forms.TextBox txt_completed;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_appointment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
    }
}