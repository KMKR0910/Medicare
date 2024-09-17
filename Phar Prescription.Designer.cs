
namespace Diploma_Final_Project_1
{
    partial class Phar_Prescription
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
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_prescription = new System.Windows.Forms.TextBox();
            this.txt_drugs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Prescription = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prescription)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(471, 147);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(216, 55);
            this.btn_search.TabIndex = 56;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(55, 147);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(372, 44);
            this.txt_search.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 42);
            this.label5.TabIndex = 58;
            this.label5.Text = "Search Patient";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_contact);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_age);
            this.groupBox1.Controls.Add(this.dateTimePicker_DOB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 729);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient\'s Detail";
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(318, 554);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(328, 38);
            this.txt_contact.TabIndex = 56;
            this.txt_contact.TextChanged += new System.EventHandler(this.txt_contact_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 42);
            this.label6.TabIndex = 55;
            this.label6.Text = "Contact Number";
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(304, 465);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(146, 38);
            this.txt_age.TabIndex = 54;
            // 
            // dateTimePicker_DOB
            // 
            this.dateTimePicker_DOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DOB.Location = new System.Drawing.Point(315, 371);
            this.dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            this.dateTimePicker_DOB.Size = new System.Drawing.Size(317, 44);
            this.dateTimePicker_DOB.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 42);
            this.label4.TabIndex = 52;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 42);
            this.label3.TabIndex = 51;
            this.label3.Text = "Date of birth";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(304, 116);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(328, 38);
            this.txt_Name.TabIndex = 50;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(304, 191);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(328, 141);
            this.txt_address.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 42);
            this.label2.TabIndex = 48;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 42);
            this.label1.TabIndex = 47;
            this.label1.Text = "Patient Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_description);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_prescription);
            this.groupBox2.Controls.Add(this.txt_drugs);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(779, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 639);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prescription Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_prescription
            // 
            this.txt_prescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prescription.Location = new System.Drawing.Point(454, 90);
            this.txt_prescription.Name = "txt_prescription";
            this.txt_prescription.Size = new System.Drawing.Size(328, 38);
            this.txt_prescription.TabIndex = 54;
            this.txt_prescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_drugs
            // 
            this.txt_drugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_drugs.Location = new System.Drawing.Point(454, 165);
            this.txt_drugs.Multiline = true;
            this.txt_drugs.Name = "txt_drugs";
            this.txt_drugs.Size = new System.Drawing.Size(328, 141);
            this.txt_drugs.TabIndex = 53;
            this.txt_drugs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 84);
            this.label7.TabIndex = 52;
            this.label7.Text = "Drugs";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(357, 42);
            this.label8.TabIndex = 51;
            this.label8.Text = "Prescription Number";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(454, 399);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(328, 141);
            this.txt_description.TabIndex = 56;
            this.txt_description.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 42);
            this.label9.TabIndex = 55;
            this.label9.Text = "Description";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_Prescription);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(794, 755);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(972, 256);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prescrpition Details";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // dataGridView_Prescription
            // 
            this.dataGridView_Prescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Prescription.Location = new System.Drawing.Point(29, 52);
            this.dataGridView_Prescription.Name = "dataGridView_Prescription";
            this.dataGridView_Prescription.RowHeadersWidth = 82;
            this.dataGridView_Prescription.RowTemplate.Height = 33;
            this.dataGridView_Prescription.Size = new System.Drawing.Size(919, 193);
            this.dataGridView_Prescription.TabIndex = 2;
            this.dataGridView_Prescription.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Prescription_CellContentClick);
            // 
            // Phar_Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2024, 1270);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.Name = "Phar_Prescription";
            this.Text = "Phar_Prescription";
            this.Load += new System.EventHandler(this.Phar_Prescription_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_prescription;
        private System.Windows.Forms.TextBox txt_drugs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_Prescription;
    }
}