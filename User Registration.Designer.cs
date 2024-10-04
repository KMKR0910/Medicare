
namespace Diploma_Final_Project_1
{
    partial class User_Registration
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
            this.components = new System.ComponentModel.Container();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.numericUpDown_salary = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_DOB = new System.Windows.Forms.DateTimePicker();
            this.comboBox_postion = new System.Windows.Forms.ComboBox();
            this.txt_L_Name = new System.Windows.Forms.TextBox();
            this.txt_address_HNO = new System.Windows.Forms.TextBox();
            this.txt_address_StreetName = new System.Windows.Forms.TextBox();
            this.txt_address_city = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_qulifications = new System.Windows.Forms.TextBox();
            this.txt_F_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.txt_userpwd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_contact2 = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.autoComplete1 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(687, 1285);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(216, 90);
            this.btn_cancel.TabIndex = 51;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(53, 1285);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(216, 90);
            this.btn_save.TabIndex = 50;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // numericUpDown_salary
            // 
            this.numericUpDown_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_salary.Location = new System.Drawing.Point(318, 884);
            this.numericUpDown_salary.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_salary.Name = "numericUpDown_salary";
            this.numericUpDown_salary.Size = new System.Drawing.Size(328, 38);
            this.numericUpDown_salary.TabIndex = 49;
            this.numericUpDown_salary.ValueChanged += new System.EventHandler(this.numericUpDown_salary_ValueChanged);
            // 
            // dateTimePicker_DOB
            // 
            this.dateTimePicker_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DOB.Location = new System.Drawing.Point(326, 597);
            this.dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            this.dateTimePicker_DOB.Size = new System.Drawing.Size(329, 38);
            this.dateTimePicker_DOB.TabIndex = 48;
            this.dateTimePicker_DOB.ValueChanged += new System.EventHandler(this.dateTimePicker_DOB_ValueChanged);
            // 
            // comboBox_postion
            // 
            this.comboBox_postion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_postion.FormattingEnabled = true;
            this.comboBox_postion.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Medical Centre Assistant",
            "Pharamacists",
            "Laboratary Assistant"});
            this.comboBox_postion.Location = new System.Drawing.Point(327, 142);
            this.comboBox_postion.Name = "comboBox_postion";
            this.comboBox_postion.Size = new System.Drawing.Size(424, 39);
            this.comboBox_postion.TabIndex = 47;
            this.comboBox_postion.SelectedIndexChanged += new System.EventHandler(this.comboBox_postion_SelectedIndexChanged);
            // 
            // txt_L_Name
            // 
            this.txt_L_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_L_Name.Location = new System.Drawing.Point(325, 290);
            this.txt_L_Name.Name = "txt_L_Name";
            this.txt_L_Name.Size = new System.Drawing.Size(328, 38);
            this.txt_L_Name.TabIndex = 46;
            this.txt_L_Name.TextChanged += new System.EventHandler(this.txt_L_Name_TextChanged);
            // 
            // txt_address_HNO
            // 
            this.txt_address_HNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address_HNO.Location = new System.Drawing.Point(327, 361);
            this.txt_address_HNO.Name = "txt_address_HNO";
            this.txt_address_HNO.Size = new System.Drawing.Size(179, 38);
            this.txt_address_HNO.TabIndex = 45;
            this.txt_address_HNO.TextChanged += new System.EventHandler(this.txt_address_HNO_TextChanged);
            // 
            // txt_address_StreetName
            // 
            this.txt_address_StreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address_StreetName.Location = new System.Drawing.Point(329, 444);
            this.txt_address_StreetName.Name = "txt_address_StreetName";
            this.txt_address_StreetName.Size = new System.Drawing.Size(686, 38);
            this.txt_address_StreetName.TabIndex = 44;
            this.txt_address_StreetName.TextChanged += new System.EventHandler(this.txt_address_StreetName_TextChanged);
            // 
            // txt_address_city
            // 
            this.txt_address_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address_city.Location = new System.Drawing.Point(329, 517);
            this.txt_address_city.Name = "txt_address_city";
            this.txt_address_city.Size = new System.Drawing.Size(686, 38);
            this.txt_address_city.TabIndex = 43;
            this.txt_address_city.TextChanged += new System.EventHandler(this.txt_address_city_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(329, 674);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(686, 38);
            this.txt_email.TabIndex = 42;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(326, 747);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(329, 38);
            this.txt_contact.TabIndex = 41;
            this.txt_contact.TextChanged += new System.EventHandler(this.txt_contact_TextChanged);
            // 
            // txt_qulifications
            // 
            this.txt_qulifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qulifications.Location = new System.Drawing.Point(318, 960);
            this.txt_qulifications.Multiline = true;
            this.txt_qulifications.Name = "txt_qulifications";
            this.txt_qulifications.Size = new System.Drawing.Size(336, 194);
            this.txt_qulifications.TabIndex = 40;
            this.txt_qulifications.TextChanged += new System.EventHandler(this.txt_qulifications_TextChanged);
            // 
            // txt_F_name
            // 
            this.txt_F_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_F_name.Location = new System.Drawing.Point(329, 215);
            this.txt_F_name.Name = "txt_F_name";
            this.txt_F_name.Size = new System.Drawing.Size(328, 38);
            this.txt_F_name.TabIndex = 39;
            this.txt_F_name.TextChanged += new System.EventHandler(this.txt_F_name_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 971);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 42);
            this.label11.TabIndex = 38;
            this.label11.Text = "Qualifications";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 877);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 42);
            this.label10.TabIndex = 37;
            this.label10.Text = "Salary";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 747);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 42);
            this.label9.TabIndex = 36;
            this.label9.Text = "Conatct Number";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 670);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 42);
            this.label8.TabIndex = 35;
            this.label8.Text = "Email Address";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 597);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 42);
            this.label7.TabIndex = 34;
            this.label7.Text = "DOB";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 42);
            this.label6.TabIndex = 33;
            this.label6.Text = "City";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 42);
            this.label5.TabIndex = 32;
            this.label5.Text = "Street Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 42);
            this.label4.TabIndex = 31;
            this.label4.Text = "House No";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 42);
            this.label3.TabIndex = 30;
            this.label3.Text = "User Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 42);
            this.label2.TabIndex = 29;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 42);
            this.label1.TabIndex = 28;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userID.Location = new System.Drawing.Point(1234, 49);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.ReadOnly = true;
            this.txt_userID.Size = new System.Drawing.Size(252, 44);
            this.txt_userID.TabIndex = 52;
            // 
            // txt_userpwd
            // 
            this.txt_userpwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_userpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userpwd.Location = new System.Drawing.Point(1234, 123);
            this.txt_userpwd.Name = "txt_userpwd";
            this.txt_userpwd.ReadOnly = true;
            this.txt_userpwd.Size = new System.Drawing.Size(252, 44);
            this.txt_userpwd.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(926, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 42);
            this.label12.TabIndex = 54;
            this.label12.Text = "User Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(926, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(272, 42);
            this.label13.TabIndex = 55;
            this.label13.Text = "User Password";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txt_contact2
            // 
            this.txt_contact2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact2.Location = new System.Drawing.Point(325, 811);
            this.txt_contact2.Name = "txt_contact2";
            this.txt_contact2.Size = new System.Drawing.Size(329, 38);
            this.txt_contact2.TabIndex = 56;
            this.txt_contact2.TextChanged += new System.EventHandler(this.txt_contact2_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(383, 1285);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(216, 90);
            this.btn_clear.TabIndex = 57;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // autoComplete1
            // 
            this.autoComplete1.HeaderFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.autoComplete1.ItemFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.autoComplete1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.autoComplete1.ParentForm = this;
            this.autoComplete1.Style = Syncfusion.Windows.Forms.Tools.AutoCompleteStyle.Default;
            this.autoComplete1.ThemeName = "Default";
            // 
            // User_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2427, 1449);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_contact2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_userpwd);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.numericUpDown_salary);
            this.Controls.Add(this.dateTimePicker_DOB);
            this.Controls.Add(this.comboBox_postion);
            this.Controls.Add(this.txt_L_Name);
            this.Controls.Add(this.txt_address_HNO);
            this.Controls.Add(this.txt_address_StreetName);
            this.Controls.Add(this.txt_address_city);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_qulifications);
            this.Controls.Add(this.txt_F_name);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "User_Registration";
            this.Text = "User_Registration";
            this.Load += new System.EventHandler(this.User_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NumericUpDown numericUpDown_salary;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DOB;
        private System.Windows.Forms.ComboBox comboBox_postion;
        private System.Windows.Forms.TextBox txt_L_Name;
        private System.Windows.Forms.TextBox txt_address_HNO;
        private System.Windows.Forms.TextBox txt_address_StreetName;
        private System.Windows.Forms.TextBox txt_address_city;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_qulifications;
        private System.Windows.Forms.TextBox txt_F_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.TextBox txt_userpwd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_contact2;
        private System.Windows.Forms.Button btn_clear;
        private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete1;
    }
}