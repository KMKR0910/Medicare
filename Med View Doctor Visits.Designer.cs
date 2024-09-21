
namespace Diploma_Final_Project_1
{
    partial class Med_View_Doctor_Visits
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
            this.dataGridView_visits = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_visits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_visits
            // 
            this.dataGridView_visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_visits.Location = new System.Drawing.Point(62, 164);
            this.dataGridView_visits.Name = "dataGridView_visits";
            this.dataGridView_visits.RowHeadersWidth = 82;
            this.dataGridView_visits.RowTemplate.Height = 33;
            this.dataGridView_visits.Size = new System.Drawing.Size(1259, 928);
            this.dataGridView_visits.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(463, 31);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Med_View_Doctor_Visits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 1219);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView_visits);
            this.Name = "Med_View_Doctor_Visits";
            this.Text = "Med_View_Doctor_Visits";
            this.Load += new System.EventHandler(this.Med_View_Doctor_Visits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_visits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_visits;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}