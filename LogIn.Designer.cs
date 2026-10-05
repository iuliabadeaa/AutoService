using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoServiceCuNET
{
    partial class LogIn
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
            this.emaillbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.loginFinishBtn = new System.Windows.Forms.Button();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.emaillbl.ForeColor = System.Drawing.SystemColors.Control;
            this.emaillbl.Location = new System.Drawing.Point(44, 64);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(103, 45);
            this.emaillbl.TabIndex = 0;
            this.emaillbl.Text = "Email";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.passwordlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordlbl.Location = new System.Drawing.Point(44, 151);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(164, 45);
            this.passwordlbl.TabIndex = 1;
            this.passwordlbl.Text = "Password";
            // 
            // emailtextbox
            // 
            this.emailtextbox.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.emailtextbox.Location = new System.Drawing.Point(172, 62);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(418, 51);
            this.emailtextbox.TabIndex = 2;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backBtn.Location = new System.Drawing.Point(117, 264);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(111, 60);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // loginFinishBtn
            // 
            this.loginFinishBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.loginFinishBtn.Location = new System.Drawing.Point(506, 264);
            this.loginFinishBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginFinishBtn.Name = "loginFinishBtn";
            this.loginFinishBtn.Size = new System.Drawing.Size(157, 60);
            this.loginFinishBtn.TabIndex = 5;
            this.loginFinishBtn.Text = "Log In";
            this.loginFinishBtn.UseVisualStyleBackColor = true;
            this.loginFinishBtn.Click += new System.EventHandler(this.loginFinishBtn_Click);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.passwordtextbox.Location = new System.Drawing.Point(231, 148);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(359, 51);
            this.passwordtextbox.TabIndex = 6;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(729, 363);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.loginFinishBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.emaillbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label emaillbl;
        private Label passwordlbl;
        private TextBox emailtextbox;
        private Button backBtn;
        private TextBox passwordtextbox;
        public Button loginFinishBtn;
    }
}