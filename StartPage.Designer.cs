
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace AutoServiceCuNET
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.greetinglabel = new System.Windows.Forms.Label();
            this.signinbtnstart = new System.Windows.Forms.Button();
            this.loginbtnstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetinglabel
            // 
            this.greetinglabel.AutoSize = true;
            this.greetinglabel.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetinglabel.ForeColor = System.Drawing.SystemColors.Control;
            this.greetinglabel.Location = new System.Drawing.Point(263, 61);
            this.greetinglabel.Name = "greetinglabel";
            this.greetinglabel.Size = new System.Drawing.Size(193, 45);
            this.greetinglabel.TabIndex = 0;
            this.greetinglabel.Text = "Hello, user!";
            // 
            // signinbtnstart
            // 
            this.signinbtnstart.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.signinbtnstart.Location = new System.Drawing.Point(271, 126);
            this.signinbtnstart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signinbtnstart.Name = "signinbtnstart";
            this.signinbtnstart.Size = new System.Drawing.Size(172, 61);
            this.signinbtnstart.TabIndex = 1;
            this.signinbtnstart.Text = "Sign In";
            this.signinbtnstart.UseVisualStyleBackColor = true;
            this.signinbtnstart.Click += new System.EventHandler(this.signinbtnstart_Click_1);
            // 
            // loginbtnstart
            // 
            this.loginbtnstart.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.loginbtnstart.Location = new System.Drawing.Point(271, 220);
            this.loginbtnstart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbtnstart.Name = "loginbtnstart";
            this.loginbtnstart.Size = new System.Drawing.Size(172, 61);
            this.loginbtnstart.TabIndex = 2;
            this.loginbtnstart.Text = "Log In";
            this.loginbtnstart.UseVisualStyleBackColor = true;
            this.loginbtnstart.Click += new System.EventHandler(this.loginbtnstart_Click_1);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(727, 366);
            this.Controls.Add(this.loginbtnstart);
            this.Controls.Add(this.signinbtnstart);
            this.Controls.Add(this.greetinglabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void signinbtnstart_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn(this);
            signIn.Show();
            this.Hide();
        }

        private void loginbtnstart_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn(this);
            login.Show();
            this.Hide();
        }

        #endregion

        private Label greetinglabel;
        private Button signinbtnstart;
        private Button loginbtnstart;
    }
}