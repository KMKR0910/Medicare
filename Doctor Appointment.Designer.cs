
namespace Diploma_Final_Project_1
{
    partial class Doctor_Appointment
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
            this.dateTimePicker_AP_date = new System.Windows.Forms.DateTimePicker();
            this.txt_appoinment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Diagnose = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Diagnose)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_AP_date
            // 
            this.dateTimePicker_AP_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_AP_date.Location = new System.Drawing.Point(36, 75);
            this.dateTimePicker_AP_date.Name = "dateTimePicker_AP_date";
            this.dateTimePicker_AP_date.Size = new System.Drawing.Size(520, 38);
            this.dateTimePicker_AP_date.TabIndex = 78;
            // 
            // txt_appoinment
            // 
            this.txt_appoinment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appoinment.Location = new System.Drawing.Point(398, 180);
            this.txt_appoinment.Name = "txt_appoinment";
            this.txt_appoinment.Size = new System.Drawing.Size(328, 38);
            this.txt_appoinment.TabIndex = 80;
            this.txt_appoinment.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 84);
            this.label1.TabIndex = 79;
            this.label1.Text = "No of Appoinments";
            // 
            // dataGridView_Diagnose
            // 
            this.dataGridView_Diagnose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Diagnose.Location = new System.Drawing.Point(73, 1136);
            this.dataGridView_Diagnose.Name = "dataGridView_Diagnose";
            this.dataGridView_Diagnose.RowHeadersWidth = 82;
            this.dataGridView_Diagnose.RowTemplate.Height = 33;
            this.dataGridView_Diagnose.Size = new System.Drawing.Size(1481, 256);
            this.dataGridView_Diagnose.TabIndex = 81;
            // 
            // Doctor_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 1472);
            this.Controls.Add(this.dataGridView_Diagnose);
            this.Controls.Add(this.txt_appoinment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_AP_date);
            this.Name = "Doctor_Appointment";
            this.Text = "Doctor_Appointment";
            this.Load += new System.EventHandler(this.Doctor_Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Diagnose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_AP_date;
        private System.Windows.Forms.TextBox txt_appoinment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Diagnose;
    }
}