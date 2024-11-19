
namespace Diploma_Final_Project_1
{
    partial class Med_Finance_ShortCuts
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_add_expenses = new System.Windows.Forms.LinkLabel();
            this.linkLabel_View_expenses = new System.Windows.Forms.LinkLabel();
            this.linkLabel1_Report = new System.Windows.Forms.LinkLabel();
            this.linkLabelView_Pa_pay = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quick Links";
            // 
            // linkLabel_add_expenses
            // 
            this.linkLabel_add_expenses.AutoSize = true;
            this.linkLabel_add_expenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_add_expenses.Location = new System.Drawing.Point(22, 208);
            this.linkLabel_add_expenses.Name = "linkLabel_add_expenses";
            this.linkLabel_add_expenses.Size = new System.Drawing.Size(228, 45);
            this.linkLabel_add_expenses.TabIndex = 14;
            this.linkLabel_add_expenses.TabStop = true;
            this.linkLabel_add_expenses.Text = "Add Expenses";
            this.linkLabel_add_expenses.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel_View_expenses
            // 
            this.linkLabel_View_expenses.AutoSize = true;
            this.linkLabel_View_expenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_View_expenses.Location = new System.Drawing.Point(22, 163);
            this.linkLabel_View_expenses.Name = "linkLabel_View_expenses";
            this.linkLabel_View_expenses.Size = new System.Drawing.Size(238, 45);
            this.linkLabel_View_expenses.TabIndex = 13;
            this.linkLabel_View_expenses.TabStop = true;
            this.linkLabel_View_expenses.Text = "View Expenses";
            // 
            // linkLabel1_Report
            // 
            this.linkLabel1_Report.AutoSize = true;
            this.linkLabel1_Report.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1_Report.Location = new System.Drawing.Point(18, 118);
            this.linkLabel1_Report.Name = "linkLabel1_Report";
            this.linkLabel1_Report.Size = new System.Drawing.Size(242, 45);
            this.linkLabel1_Report.TabIndex = 12;
            this.linkLabel1_Report.TabStop = true;
            this.linkLabel1_Report.Text = "Income Report";
            // 
            // linkLabelView_Pa_pay
            // 
            this.linkLabelView_Pa_pay.AutoSize = true;
            this.linkLabelView_Pa_pay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelView_Pa_pay.Location = new System.Drawing.Point(22, 253);
            this.linkLabelView_Pa_pay.Name = "linkLabelView_Pa_pay";
            this.linkLabelView_Pa_pay.Size = new System.Drawing.Size(360, 45);
            this.linkLabelView_Pa_pay.TabIndex = 16;
            this.linkLabelView_Pa_pay.TabStop = true;
            this.linkLabelView_Pa_pay.Text = "View Patient Payments";
            // 
            // Med_Finance_ShortCuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 1369);
            this.Controls.Add(this.linkLabelView_Pa_pay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel_add_expenses);
            this.Controls.Add(this.linkLabel_View_expenses);
            this.Controls.Add(this.linkLabel1_Report);
            this.Name = "Med_Finance_ShortCuts";
            this.Text = "Med_Finance_ShortCuts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_add_expenses;
        private System.Windows.Forms.LinkLabel linkLabel_View_expenses;
        private System.Windows.Forms.LinkLabel linkLabel1_Report;
        private System.Windows.Forms.LinkLabel linkLabelView_Pa_pay;
    }
}