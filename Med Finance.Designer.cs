
namespace Diploma_Final_Project_1
{
    partial class Med_Finance
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
            this.btn_income_report = new System.Windows.Forms.Button();
            this.btn_add_expenses = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btn_income_report
            // 
            this.btn_income_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_income_report.Location = new System.Drawing.Point(35, 84);
            this.btn_income_report.Name = "btn_income_report";
            this.btn_income_report.Size = new System.Drawing.Size(260, 118);
            this.btn_income_report.TabIndex = 0;
            this.btn_income_report.Text = "Income Report";
            this.btn_income_report.UseVisualStyleBackColor = true;
            this.btn_income_report.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add_expenses
            // 
            this.btn_add_expenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_expenses.Location = new System.Drawing.Point(35, 208);
            this.btn_add_expenses.Name = "btn_add_expenses";
            this.btn_add_expenses.Size = new System.Drawing.Size(260, 118);
            this.btn_add_expenses.TabIndex = 1;
            this.btn_add_expenses.Text = "Add Expenses";
            this.btn_add_expenses.UseVisualStyleBackColor = true;
            this.btn_add_expenses.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(35, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 118);
            this.button3.TabIndex = 2;
            this.button3.Text = "View Expenses";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(301, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1437, 1274);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Med_Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1999, 1437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_add_expenses);
            this.Controls.Add(this.btn_income_report);
            this.Name = "Med_Finance";
            this.Text = "Med_Finance";
            this.Load += new System.EventHandler(this.Med_Finance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_income_report;
        private System.Windows.Forms.Button btn_add_expenses;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}