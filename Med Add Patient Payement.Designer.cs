
namespace Diploma_Final_Project_1
{
    partial class Med_Add_Patient_Payement
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_genarate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_patient = new System.Windows.Forms.TextBox();
            this.txt_paymnet_number = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_pay_type = new System.Windows.Forms.ComboBox();
            this.btn_All_Search = new System.Windows.Forms.Button();
            this.txt_patientID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(815, 49);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(216, 55);
            this.btn_search.TabIndex = 67;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(362, 55);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(372, 44);
            this.txt_search.TabIndex = 68;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 42);
            this.label5.TabIndex = 69;
            this.label5.Text = "Search Patient";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 42);
            this.label3.TabIndex = 72;
            this.label3.Text = "Payment Type";
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(504, 519);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(372, 44);
            this.txt_date.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 42);
            this.label1.TabIndex = 74;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 42);
            this.label2.TabIndex = 76;
            this.label2.Text = "Total Cost";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCost.Location = new System.Drawing.Point(504, 627);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(372, 44);
            this.numericUpDownCost.TabIndex = 78;
            this.numericUpDownCost.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(441, 940);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(216, 90);
            this.btn_clear.TabIndex = 88;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(441, 777);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(216, 90);
            this.btn_add.TabIndex = 87;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_genarate
            // 
            this.btn_genarate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genarate.Location = new System.Drawing.Point(441, 1092);
            this.btn_genarate.Name = "btn_genarate";
            this.btn_genarate.Size = new System.Drawing.Size(212, 129);
            this.btn_genarate.TabIndex = 90;
            this.btn_genarate.Text = "Genarate Bil Invoice";
            this.btn_genarate.UseVisualStyleBackColor = true;
            this.btn_genarate.Click += new System.EventHandler(this.btn_genarate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 42);
            this.label4.TabIndex = 91;
            this.label4.Text = "Patient Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_patient
            // 
            this.txt_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patient.Location = new System.Drawing.Point(504, 304);
            this.txt_patient.Name = "txt_patient";
            this.txt_patient.Size = new System.Drawing.Size(372, 44);
            this.txt_patient.TabIndex = 92;
            // 
            // txt_paymnet_number
            // 
            this.txt_paymnet_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymnet_number.Location = new System.Drawing.Point(1088, 60);
            this.txt_paymnet_number.Name = "txt_paymnet_number";
            this.txt_paymnet_number.Size = new System.Drawing.Size(372, 44);
            this.txt_paymnet_number.TabIndex = 93;
            this.txt_paymnet_number.TextChanged += new System.EventHandler(this.txt_paymnet_number_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1197, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 1074);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox_pay_type
            // 
            this.comboBox_pay_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_pay_type.FormattingEnabled = true;
            this.comboBox_pay_type.Items.AddRange(new object[] {
            "Drug",
            "Lab Tets"});
            this.comboBox_pay_type.Location = new System.Drawing.Point(504, 420);
            this.comboBox_pay_type.Name = "comboBox_pay_type";
            this.comboBox_pay_type.Size = new System.Drawing.Size(372, 45);
            this.comboBox_pay_type.TabIndex = 95;
            // 
            // btn_All_Search
            // 
            this.btn_All_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All_Search.Location = new System.Drawing.Point(815, 151);
            this.btn_All_Search.Name = "btn_All_Search";
            this.btn_All_Search.Size = new System.Drawing.Size(216, 55);
            this.btn_All_Search.TabIndex = 96;
            this.btn_All_Search.Text = "Search All";
            this.btn_All_Search.UseVisualStyleBackColor = true;
            this.btn_All_Search.Click += new System.EventHandler(this.btn_All_Search_Click_1);
            // 
            // txt_patientID
            // 
            this.txt_patientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientID.Location = new System.Drawing.Point(1525, 58);
            this.txt_patientID.Name = "txt_patientID";
            this.txt_patientID.Size = new System.Drawing.Size(372, 44);
            this.txt_patientID.TabIndex = 97;
            // 
            // Med_Add_Patient_Payement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2427, 1449);
            this.Controls.Add(this.txt_patientID);
            this.Controls.Add(this.btn_All_Search);
            this.Controls.Add(this.comboBox_pay_type);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_paymnet_number);
            this.Controls.Add(this.txt_patient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_genarate);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.numericUpDownCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.Name = "Med_Add_Patient_Payement";
            this.Text = "Med_Add_Patient_Payement";
            this.Load += new System.EventHandler(this.Med_Add_Patient_Payement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_genarate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_patient;
        private System.Windows.Forms.TextBox txt_paymnet_number;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_pay_type;
        private System.Windows.Forms.Button btn_All_Search;
        private System.Windows.Forms.TextBox txt_patientID;
    }
}