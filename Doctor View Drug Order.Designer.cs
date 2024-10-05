
namespace Diploma_Final_Project_1
{
    partial class Doctor_View_Drug_Order
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
            this.dataGridView_orders = new System.Windows.Forms.DataGridView();
            this.dataGridView_items = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_decline = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_orders
            // 
            this.dataGridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orders.Location = new System.Drawing.Point(15, 61);
            this.dataGridView_orders.Name = "dataGridView_orders";
            this.dataGridView_orders.RowHeadersWidth = 82;
            this.dataGridView_orders.RowTemplate.Height = 33;
            this.dataGridView_orders.Size = new System.Drawing.Size(1124, 994);
            this.dataGridView_orders.TabIndex = 124;
            this.dataGridView_orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_orders_CellContentClick);
            // 
            // dataGridView_items
            // 
            this.dataGridView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_items.Location = new System.Drawing.Point(6, 64);
            this.dataGridView_items.Name = "dataGridView_items";
            this.dataGridView_items.RowHeadersWidth = 82;
            this.dataGridView_items.RowTemplate.Height = 33;
            this.dataGridView_items.Size = new System.Drawing.Size(1178, 986);
            this.dataGridView_items.TabIndex = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_orders);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1163, 1061);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_items);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1195, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1213, 1056);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Item Details";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(222, 1237);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(285, 90);
            this.btn_confirm.TabIndex = 128;
            this.btn_confirm.Text = "Confirm Order";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_decline
            // 
            this.btn_decline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decline.Location = new System.Drawing.Point(853, 1237);
            this.btn_decline.Name = "btn_decline";
            this.btn_decline.Size = new System.Drawing.Size(285, 90);
            this.btn_decline.TabIndex = 129;
            this.btn_decline.Text = "Decline Order";
            this.btn_decline.UseVisualStyleBackColor = true;
            this.btn_decline.Click += new System.EventHandler(this.btn_decline_Click);
            // 
            // Doctor_View_Drug_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2427, 1449);
            this.Controls.Add(this.btn_decline);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Doctor_View_Drug_Order";
            this.Text = "Doctor_View_Drug_Order";
            this.Load += new System.EventHandler(this.Doctor_View_Drug_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_orders;
        private System.Windows.Forms.DataGridView dataGridView_items;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_decline;
    }
}