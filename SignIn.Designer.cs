using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoServiceCuNET
{
    partial class SignIn
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameBtn = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NameLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLbl.Location = new System.Drawing.Point(42, 39);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(119, 45);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name:";
            // 
            // SurnameBtn
            // 
            this.SurnameBtn.AutoSize = true;
            this.SurnameBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SurnameBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SurnameBtn.Location = new System.Drawing.Point(42, 95);
            this.SurnameBtn.Name = "SurnameBtn";
            this.SurnameBtn.Size = new System.Drawing.Size(164, 45);
            this.SurnameBtn.TabIndex = 1;
            this.SurnameBtn.Text = "Surname:";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EmailLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.EmailLbl.Location = new System.Drawing.Point(42, 156);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(111, 45);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.Text = "Email:";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PasswordLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordLbl.Location = new System.Drawing.Point(42, 213);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(172, 45);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Password:";
            // 
            // SignInBtn
            // 
            this.SignInBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SignInBtn.Location = new System.Drawing.Point(538, 286);
            this.SignInBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(153, 63);
            this.SignInBtn.TabIndex = 4;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BackBtn.Location = new System.Drawing.Point(108, 286);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(128, 63);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click_1);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NameTextBox.Location = new System.Drawing.Point(169, 37);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(394, 51);
            this.NameTextBox.TabIndex = 6;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SurnameTextBox.Location = new System.Drawing.Point(215, 93);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(348, 51);
            this.SurnameTextBox.TabIndex = 7;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EmailTextBox.Location = new System.Drawing.Point(169, 154);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(394, 51);
            this.EmailTextBox.TabIndex = 8;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PasswordTextBox.Location = new System.Drawing.Point(229, 210);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(334, 51);
            this.PasswordTextBox.TabIndex = 9;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(734, 369);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.SurnameBtn);
            this.Controls.Add(this.NameLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLbl;
        private Label SurnameBtn;
        private Label EmailLbl;
        private Label PasswordLbl;
        private Button BackBtn;
        private TextBox NameTextBox;
        private TextBox SurnameTextBox;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private Button SignInBtn;
    }
}