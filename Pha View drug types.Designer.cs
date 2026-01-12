
namespace Diploma_Final_Project_1
{
    partial class Pha_View_drug_types
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dataGridView_drug_types = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_serach_drug = new System.Windows.Forms.Button();
            this.txt_search_drug = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_drug_types)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(419, 215);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(372, 44);
            this.txt_name.TabIndex = 129;
            // 
            // txt_company
            // 
            this.txt_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_company.Location = new System.Drawing.Point(419, 139);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(372, 44);
            this.txt_company.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 42);
            this.label5.TabIndex = 128;
            this.label5.Text = "Supplier Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 42);
            this.label4.TabIndex = 132;
            this.label4.Text = "Company Name";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(451, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(216, 55);
            this.btn_search.TabIndex = 130;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(29, 39);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(372, 44);
            this.txt_search.TabIndex = 131;
            // 
            // dataGridView_drug_types
            // 
            this.dataGridView_drug_types.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_drug_types.Location = new System.Drawing.Point(89, 211);
            this.dataGridView_drug_types.Name = "dataGridView_drug_types";
            this.dataGridView_drug_types.RowHeadersWidth = 82;
            this.dataGridView_drug_types.RowTemplate.Height = 33;
            this.dataGridView_drug_types.Size = new System.Drawing.Size(2154, 760);
            this.dataGridView_drug_types.TabIndex = 134;
            this.dataGridView_drug_types.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Items_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_serach_drug);
            this.groupBox1.Controls.Add(this.dataGridView_drug_types);
            this.groupBox1.Controls.Add(this.txt_search_drug);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2345, 1128);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Drug Name";
            // 
            // btn_serach_drug
            // 
            this.btn_serach_drug.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serach_drug.Location = new System.Drawing.Point(450, 70);
            this.btn_serach_drug.Name = "btn_serach_drug";
            this.btn_serach_drug.Size = new System.Drawing.Size(216, 55);
            this.btn_serach_drug.TabIndex = 136;
            this.btn_serach_drug.Text = "Search";
            this.btn_serach_drug.UseVisualStyleBackColor = true;
            // 
            // txt_search_drug
            // 
            this.txt_search_drug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_drug.Location = new System.Drawing.Point(28, 79);
            this.txt_search_drug.Name = "txt_search_drug";
            this.txt_search_drug.Size = new System.Drawing.Size(372, 44);
            this.txt_search_drug.TabIndex = 137;
            // 
            // Pha_View_drug_types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2334, 1442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_company);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Name = "Pha_View_drug_types";
            this.Text = "Pha_View_drug_types";
            this.Load += new System.EventHandler(this.Pha_View_drug_types_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_drug_types)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dataGridView_drug_types;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_serach_drug;
        private System.Windows.Forms.TextBox txt_search_drug;
    }
}