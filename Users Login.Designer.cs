namespace Diploma_Final_Project_1
{
    partial class Users_Login
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_username = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_login = new MaterialSkin.Controls.MaterialButton();
            this.checkBox_password_check1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.linkLabel_forgot_password = new System.Windows.Forms.LinkLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(327, 264);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Username/Email";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(327, 457);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.AnimateReadOnly = false;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Depth = 0;
            this.txt_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_username.LeadingIcon = null;
            this.txt_username.Location = new System.Drawing.Point(327, 322);
            this.txt_username.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_username.MaxLength = 50;
            this.txt_username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(700, 50);
            this.txt_username.TabIndex = 2;
            this.txt_username.Text = "";
            this.txt_username.TrailingIcon = null;
            // 
            // txt_password
            // 
            this.txt_password.AnimateReadOnly = false;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.LeadingIcon = null;
            this.txt_password.Location = new System.Drawing.Point(327, 514);
            this.txt_password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_password.MaxLength = 50;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Password = true;
            this.txt_password.Size = new System.Drawing.Size(700, 50);
            this.txt_password.TabIndex = 3;
            this.txt_password.Text = "";
            this.txt_password.TrailingIcon = null;
            // 
            // btn_login
            // 
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_login.Depth = 0;
            this.btn_login.HighEmphasis = true;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(623, 749);
            this.btn_login.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_login.Size = new System.Drawing.Size(64, 36);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_login.UseAccentColor = false;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // checkBox_password_check1
            // 
            this.checkBox_password_check1.AutoSize = true;
            this.checkBox_password_check1.Depth = 0;
            this.checkBox_password_check1.Location = new System.Drawing.Point(1051, 534);
            this.checkBox_password_check1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_password_check1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox_password_check1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox_password_check1.Name = "checkBox_password_check1";
            this.checkBox_password_check1.ReadOnly = false;
            this.checkBox_password_check1.Ripple = true;
            this.checkBox_password_check1.Size = new System.Drawing.Size(75, 37);
            this.checkBox_password_check1.TabIndex = 5;
            this.checkBox_password_check1.Text = "Show";
            this.checkBox_password_check1.UseVisualStyleBackColor = true;
            this.checkBox_password_check1.CheckedChanged += new System.EventHandler(this.checkBox_password_check1_CheckedChanged);
            // 
            // linkLabel_forgot_password
            // 
            this.linkLabel_forgot_password.AutoSize = true;
            this.linkLabel_forgot_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_forgot_password.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_forgot_password.Location = new System.Drawing.Point(726, 657);
            this.linkLabel_forgot_password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel_forgot_password.Name = "linkLabel_forgot_password";
            this.linkLabel_forgot_password.Size = new System.Drawing.Size(301, 42);
            this.linkLabel_forgot_password.TabIndex = 6;
            this.linkLabel_forgot_password.TabStop = true;
            this.linkLabel_forgot_password.Text = "Forgot Password";
            this.linkLabel_forgot_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_forgot_password_LinkClicked);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(597, 181);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(78, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "MediCareX";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(597, 91);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(2, 0);
            this.materialLabel4.TabIndex = 8;
            // 
            // Users_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 1015);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.linkLabel_forgot_password);
            this.Controls.Add(this.checkBox_password_check1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Users_Login";
            this.Padding = new System.Windows.Forms.Padding(6, 123, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.User_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_username;
        private MaterialSkin.Controls.MaterialTextBox txt_password;
        private MaterialSkin.Controls.MaterialButton btn_login;
        private MaterialSkin.Controls.MaterialCheckbox checkBox_password_check1;
        private System.Windows.Forms.LinkLabel linkLabel_forgot_password;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}
