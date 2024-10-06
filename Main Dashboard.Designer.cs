
namespace Diploma_Final_Project_1
{
    partial class Main_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Dashboard));
            this.Medicare = new System.Windows.Forms.Label();
            this.checkBox_password_check1 = new System.Windows.Forms.CheckBox();
            this.linkLabel_forgot_password = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Medicare
            // 
            this.Medicare.AutoSize = true;
            this.Medicare.Font = new System.Drawing.Font("Microsoft Tai Le", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicare.Location = new System.Drawing.Point(1225, 393);
            this.Medicare.Name = "Medicare";
            this.Medicare.Size = new System.Drawing.Size(387, 88);
            this.Medicare.TabIndex = 5;
            this.Medicare.Text = "Medicare +";
            // 
            // checkBox_password_check1
            // 
            this.checkBox_password_check1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_password_check1.AutoSize = true;
            this.checkBox_password_check1.Location = new System.Drawing.Point(1633, 918);
            this.checkBox_password_check1.Name = "checkBox_password_check1";
            this.checkBox_password_check1.Size = new System.Drawing.Size(75, 35);
            this.checkBox_password_check1.TabIndex = 41;
            this.checkBox_password_check1.Text = "Show";
            this.checkBox_password_check1.UseVisualStyleBackColor = true;
            this.checkBox_password_check1.CheckedChanged += new System.EventHandler(this.checkBox_password_check1_CheckedChanged);
            // 
            // linkLabel_forgot_password
            // 
            this.linkLabel_forgot_password.AutoSize = true;
            this.linkLabel_forgot_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_forgot_password.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_forgot_password.Location = new System.Drawing.Point(1311, 989);
            this.linkLabel_forgot_password.Name = "linkLabel_forgot_password";
            this.linkLabel_forgot_password.Size = new System.Drawing.Size(301, 42);
            this.linkLabel_forgot_password.TabIndex = 40;
            this.linkLabel_forgot_password.TabStop = true;
            this.linkLabel_forgot_password.Text = "Forget Password";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(1233, 1083);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(294, 81);
            this.btn_login.TabIndex = 39;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(1171, 914);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(438, 38);
            this.txt_password.TabIndex = 38;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(1171, 757);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(441, 38);
            this.txt_username.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1164, 833);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 42);
            this.label2.TabIndex = 36;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1164, 678);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 42);
            this.label1.TabIndex = 35;
            this.label1.Text = "User Name";
            // 
            // Main_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2864, 1517);
            this.Controls.Add(this.checkBox_password_check1);
            this.Controls.Add(this.linkLabel_forgot_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Medicare);
            this.DoubleBuffered = true;
            this.Name = "Main_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Medicare;
        private System.Windows.Forms.CheckBox checkBox_password_check1;
        private System.Windows.Forms.LinkLabel linkLabel_forgot_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}