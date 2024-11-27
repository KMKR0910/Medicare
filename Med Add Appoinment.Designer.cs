
namespace Diploma_Final_Project_1
{
    partial class Med_Add_Appoinment
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
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_patient_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AppoinmentNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.dataGridView_appointment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date.Location = new System.Drawing.Point(248, 162);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_date.TabIndex = 95;
            // 
            // txt_time
            // 
            this.txt_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time.Location = new System.Drawing.Point(298, 360);
            this.txt_time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(122, 26);
            this.txt_time.TabIndex = 94;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(208, 602);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(108, 39);
            this.btn_clear.TabIndex = 93;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(208, 470);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 38);
            this.btn_add.TabIndex = 91;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 90;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 352);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 89;
            this.label1.Text = "Time";
            // 
            // txt_patient_name
            // 
            this.txt_patient_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_name.Location = new System.Drawing.Point(248, 111);
            this.txt_patient_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_patient_name.Name = "txt_patient_name";
            this.txt_patient_name.Size = new System.Drawing.Size(188, 26);
            this.txt_patient_name.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 87;
            this.label3.Text = "Patient Name";
            // 
            // txt_AppoinmentNumber
            // 
            this.txt_AppoinmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AppoinmentNumber.Location = new System.Drawing.Point(298, 303);
            this.txt_AppoinmentNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_AppoinmentNumber.Name = "txt_AppoinmentNumber";
            this.txt_AppoinmentNumber.Size = new System.Drawing.Size(118, 26);
            this.txt_AppoinmentNumber.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 24);
            this.label5.TabIndex = 86;
            this.label5.Text = "Appoinment Number";
            // 
            // txt_contact
            // 
            this.txt_contact.AcceptsTab = true;
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(248, 71);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(188, 26);
            this.txt_contact.TabIndex = 97;
            this.txt_contact.TextChanged += new System.EventHandler(this.txt_contact_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 24);
            this.label4.TabIndex = 96;
            this.label4.Text = "Patient Contact Number";
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.Location = new System.Drawing.Point(208, 225);
            this.btn_check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(108, 29);
            this.btn_check.TabIndex = 98;
            this.btn_check.Text = "Check Avalibility";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // dataGridView_appointment
            // 
            this.dataGridView_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_appointment.Location = new System.Drawing.Point(506, 70);
            this.dataGridView_appointment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_appointment.Name = "dataGridView_appointment";
            this.dataGridView_appointment.RowHeadersWidth = 82;
            this.dataGridView_appointment.RowTemplate.Height = 33;
            this.dataGridView_appointment.Size = new System.Drawing.Size(666, 595);
            this.dataGridView_appointment.TabIndex = 99;
            this.dataGridView_appointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_appointment_CellContentClick);
            // 
            // Med_Add_Appoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1214, 753);
            this.Controls.Add(this.dataGridView_appointment);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_patient_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AppoinmentNumber);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Med_Add_Appoinment";
            this.Text = "Med_Add_Appoinment";
            this.Load += new System.EventHandler(this.Med_Add_Appoinment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_patient_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AppoinmentNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.DataGridView dataGridView_appointment;
    }
}