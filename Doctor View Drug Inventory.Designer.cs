
namespace Diploma_Final_Project_1
{
    partial class Doctor_View_Drug_Inventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_genarate = new System.Windows.Forms.Button();
            this.btn_All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(466, 27);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(216, 55);
            this.btn_search.TabIndex = 71;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(44, 36);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(372, 44);
            this.txt_search.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 42);
            this.label5.TabIndex = 73;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(2331, 1029);
            this.dataGridView1.TabIndex = 70;
            // 
            // btn_genarate
            // 
            this.btn_genarate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genarate.Location = new System.Drawing.Point(2038, 1250);
            this.btn_genarate.Name = "btn_genarate";
            this.btn_genarate.Size = new System.Drawing.Size(273, 104);
            this.btn_genarate.TabIndex = 116;
            this.btn_genarate.Text = "View Report";
            this.btn_genarate.UseVisualStyleBackColor = true;
            this.btn_genarate.Click += new System.EventHandler(this.btn_genarate_Click);
            // 
            // btn_All
            // 
            this.btn_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All.Location = new System.Drawing.Point(780, 33);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(216, 55);
            this.btn_All.TabIndex = 117;
            this.btn_All.Text = "View All";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // Doctor_View_Drug_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2427, 1449);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.btn_genarate);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Doctor_View_Drug_Inventory";
            this.Text = "Doctor_View_Drug_Inventory";
            this.Load += new System.EventHandler(this.Doctor_View_Drug_Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_genarate;
        private System.Windows.Forms.Button btn_All;
    }
}