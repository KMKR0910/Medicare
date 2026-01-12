
namespace Diploma_Final_Project_1
{
    partial class Med_Edit_Appoinment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_patient_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_appoinment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.dataGridView_appointment = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_searchDate = new System.Windows.Forms.DateTimePicker();
            this.btn_search_date = new System.Windows.Forms.Button();
            this.dateTimePicker_check_Doctor = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_patient_name
            // 
            this.txt_patient_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_name.Location = new System.Drawing.Point(500, 352);
            this.txt_patient_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_patient_name.Name = "txt_patient_name";
            this.txt_patient_name.ReadOnly = true;
            this.txt_patient_name.Size = new System.Drawing.Size(372, 44);
            this.txt_patient_name.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 42);
            this.label3.TabIndex = 75;
            this.label3.Text = "Patient Name";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(776, 38);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(377, 58);
            this.btn_search.TabIndex = 72;
            this.btn_search.Text = "Appoinment Number";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_appoinment
            // 
            this.txt_appoinment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appoinment.Location = new System.Drawing.Point(196, 38);
            this.txt_appoinment.Margin = new System.Windows.Forms.Padding(4);
            this.txt_appoinment.Name = "txt_appoinment";
            this.txt_appoinment.Size = new System.Drawing.Size(564, 44);
            this.txt_appoinment.TabIndex = 73;
            this.txt_appoinment.TextChanged += new System.EventHandler(this.txt_appoinment_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 504);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 77;
            this.label1.Text = "Time";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(480, 996);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(216, 100);
            this.btn_cancel.TabIndex = 81;
            this.btn_cancel.Text = "Clear";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(480, 829);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(216, 96);
            this.btn_delete.TabIndex = 80;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(480, 667);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(216, 96);
            this.btn_save.TabIndex = 79;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_time
            // 
            this.txt_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time.Location = new System.Drawing.Point(496, 508);
            this.txt_time.Margin = new System.Windows.Forms.Padding(4);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(372, 44);
            this.txt_time.TabIndex = 82;
            // 
            // dataGridView_appointment
            // 
            this.dataGridView_appointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_appointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_appointment.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_appointment.Location = new System.Drawing.Point(1198, 85);
            this.dataGridView_appointment.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_appointment.Name = "dataGridView_appointment";
            this.dataGridView_appointment.RowHeadersWidth = 82;
            this.dataGridView_appointment.RowTemplate.Height = 33;
            this.dataGridView_appointment.Size = new System.Drawing.Size(1194, 1071);
            this.dataGridView_appointment.TabIndex = 100;
            this.dataGridView_appointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_appointment_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 42);
            this.label2.TabIndex = 78;
            this.label2.Text = "Check Doctor Avalibility";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date.Location = new System.Drawing.Point(500, 287);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(564, 44);
            this.dateTimePicker_date.TabIndex = 83;
            this.dateTimePicker_date.ValueChanged += new System.EventHandler(this.dateTimePicker_date_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search_date);
            this.groupBox1.Controls.Add(this.dateTimePicker_searchDate);
            this.groupBox1.Controls.Add(this.txt_appoinment);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 174);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // dateTimePicker_searchDate
            // 
            this.dateTimePicker_searchDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_searchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_searchDate.Location = new System.Drawing.Point(196, 98);
            this.dateTimePicker_searchDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_searchDate.Name = "dateTimePicker_searchDate";
            this.dateTimePicker_searchDate.Size = new System.Drawing.Size(564, 44);
            this.dateTimePicker_searchDate.TabIndex = 103;
            this.dateTimePicker_searchDate.ValueChanged += new System.EventHandler(this.dateTimePicker_searchDate_ValueChanged);
            // 
            // btn_search_date
            // 
            this.btn_search_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_date.Location = new System.Drawing.Point(776, 104);
            this.btn_search_date.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search_date.Name = "btn_search_date";
            this.btn_search_date.Size = new System.Drawing.Size(377, 54);
            this.btn_search_date.TabIndex = 104;
            this.btn_search_date.Text = "Date";
            this.btn_search_date.UseVisualStyleBackColor = true;
            this.btn_search_date.Click += new System.EventHandler(this.btn_search_date_Click);
            // 
            // dateTimePicker_check_Doctor
            // 
            this.dateTimePicker_check_Doctor.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_check_Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_check_Doctor.Location = new System.Drawing.Point(496, 205);
            this.dateTimePicker_check_Doctor.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_check_Doctor.Name = "dateTimePicker_check_Doctor";
            this.dateTimePicker_check_Doctor.Size = new System.Drawing.Size(564, 44);
            this.dateTimePicker_check_Doctor.TabIndex = 103;
            this.dateTimePicker_check_Doctor.ValueChanged += new System.EventHandler(this.dateTimePicker_check_Doctor_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 42);
            this.label4.TabIndex = 104;
            this.label4.Text = "Date";
            // 
            // Med_Edit_Appoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2428, 1448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_check_Doctor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_appointment);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_patient_name);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Med_Edit_Appoinment";
            this.Text = "Med_Edit_Appoinment";
            this.Load += new System.EventHandler(this.Med_Edit_Appoinment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_patient_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_appoinment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.DataGridView dataGridView_appointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_searchDate;
        private System.Windows.Forms.Button btn_search_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_check_Doctor;
        private System.Windows.Forms.Label label4;
    }
}