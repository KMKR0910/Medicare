
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_income_report = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_income_report
            // 
            this.btn_income_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_income_report.Location = new System.Drawing.Point(484, 493);
            this.btn_income_report.Name = "btn_income_report";
            this.btn_income_report.Size = new System.Drawing.Size(260, 118);
            this.btn_income_report.TabIndex = 0;
            this.btn_income_report.Text = "Genarate Report";
            this.btn_income_report.UseVisualStyleBackColor = true;
            this.btn_income_report.Click += new System.EventHandler(this.btn_income_report_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1206, 1196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress Report";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_category);
            this.groupBox2.Controls.Add(this.dateTimePicker_end);
            this.groupBox2.Controls.Add(this.dateTimePicker_start);
            this.groupBox2.Controls.Add(this.btn_income_report);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1235, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1206, 1196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Income Statement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 42);
            this.label3.TabIndex = 83;
            this.label3.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 42);
            this.label2.TabIndex = 82;
            this.label2.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 42);
            this.label5.TabIndex = 81;
            this.label5.Text = "Category";
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Items.AddRange(new object[] {
            "Rent",
            "Salary"});
            this.comboBox_category.Location = new System.Drawing.Point(234, 171);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(328, 45);
            this.comboBox_category.TabIndex = 80;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_end.Location = new System.Drawing.Point(739, 86);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(220, 44);
            this.dateTimePicker_end.TabIndex = 79;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_start.Location = new System.Drawing.Point(244, 86);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(249, 44);
            this.dateTimePicker_start.TabIndex = 78;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(49, 164);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1052, 949);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Med_Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2453, 1520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Med_Finance";
            this.Text = "Med_Finance";
            this.Load += new System.EventHandler(this.Med_Finance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_income_report;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}