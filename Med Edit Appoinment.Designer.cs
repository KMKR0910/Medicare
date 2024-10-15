
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
            this.txt_patient_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_appoinment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.dataGridView_appointment = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_patient_name
            // 
            this.txt_patient_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient_name.Location = new System.Drawing.Point(499, 352);
            this.txt_patient_name.Name = "txt_patient_name";
            this.txt_patient_name.Size = new System.Drawing.Size(372, 44);
            this.txt_patient_name.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 42);
            this.label3.TabIndex = 75;
            this.label3.Text = "Patient Name";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(848, 78);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(216, 55);
            this.btn_search.TabIndex = 72;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_appoinment
            // 
            this.txt_appoinment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appoinment.Location = new System.Drawing.Point(426, 84);
            this.txt_appoinment.Name = "txt_appoinment";
            this.txt_appoinment.Size = new System.Drawing.Size(372, 44);
            this.txt_appoinment.TabIndex = 73;
            this.txt_appoinment.TextChanged += new System.EventHandler(this.txt_appoinment_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 42);
            this.label5.TabIndex = 74;
            this.label5.Text = "Appoinment Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 77;
            this.label1.Text = "Time";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(481, 996);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(216, 100);
            this.btn_cancel.TabIndex = 81;
            this.btn_cancel.Text = "Clear";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(481, 828);
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
            this.btn_save.Location = new System.Drawing.Point(481, 667);
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
            this.txt_time.Location = new System.Drawing.Point(496, 507);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(372, 44);
            this.txt_time.TabIndex = 82;
            // 
            // dataGridView_appointment
            // 
            this.dataGridView_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_appointment.Location = new System.Drawing.Point(1198, 84);
            this.dataGridView_appointment.Name = "dataGridView_appointment";
            this.dataGridView_appointment.RowHeadersWidth = 82;
            this.dataGridView_appointment.RowTemplate.Height = 33;
            this.dataGridView_appointment.Size = new System.Drawing.Size(1194, 1071);
            this.dataGridView_appointment.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 42);
            this.label2.TabIndex = 78;
            this.label2.Text = "Date";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date.Location = new System.Drawing.Point(502, 206);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(565, 44);
            this.dateTimePicker_date.TabIndex = 83;
            this.dateTimePicker_date.ValueChanged += new System.EventHandler(this.dateTimePicker_date_ValueChanged);
            // 
            // Med_Edit_Appoinment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2427, 1449);
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
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_appoinment);
            this.Controls.Add(this.label5);
            this.Name = "Med_Edit_Appoinment";
            this.Text = "Med_Edit_Appoinment";
            this.Load += new System.EventHandler(this.Med_Edit_Appoinment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_appointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_patient_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_appoinment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.DataGridView dataGridView_appointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
    }
}