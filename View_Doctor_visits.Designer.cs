
namespace Diploma_Final_Project_1
{
    partial class View_Doctor_visits
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_visits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_visits)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 40);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(584, 44);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dataGridView_visits
            // 
            this.dataGridView_visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_visits.Location = new System.Drawing.Point(53, 153);
            this.dataGridView_visits.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_visits.Name = "dataGridView_visits";
            this.dataGridView_visits.RowHeadersWidth = 82;
            this.dataGridView_visits.RowTemplate.Height = 33;
            this.dataGridView_visits.Size = new System.Drawing.Size(2334, 1151);
            this.dataGridView_visits.TabIndex = 3;
            // 
            // View_Doctor_visits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2453, 1520);
            this.Controls.Add(this.dataGridView_visits);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "View_Doctor_visits";
            this.Text = "View_Doctor_visits";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_visits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView_visits;
    }
}