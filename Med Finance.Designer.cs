
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
            this.btn_viewExpenses = new System.Windows.Forms.Button();
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
            this.btn_add_expenses.Click += new System.EventHandler(this.btn_add_expenses_Click);
            // 
            // btn_viewExpenses
            // 
            this.btn_viewExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewExpenses.Location = new System.Drawing.Point(35, 332);
            this.btn_viewExpenses.Name = "btn_viewExpenses";
            this.btn_viewExpenses.Size = new System.Drawing.Size(260, 118);
            this.btn_viewExpenses.TabIndex = 2;
            this.btn_viewExpenses.Text = "View Expenses";
            this.btn_viewExpenses.UseVisualStyleBackColor = true;
            this.btn_viewExpenses.Click += new System.EventHandler(this.btn_viewExpenses_Click);
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
            this.ClientSize = new System.Drawing.Size(1738, 1378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_viewExpenses);
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
        private System.Windows.Forms.Button btn_viewExpenses;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}