using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoServiceCuNET
{
    partial class StartMenu
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
            this.GerrtingLabel = new System.Windows.Forms.Label();
            this.AppointmentBtn = new System.Windows.Forms.Button();
            this.SeeServicesBtn = new System.Windows.Forms.Button();
            this.ContactDtlBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GerrtingLabel
            // 
            this.GerrtingLabel.AutoSize = true;
            this.GerrtingLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.GerrtingLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GerrtingLabel.Location = new System.Drawing.Point(116, 62);
            this.GerrtingLabel.Name = "GerrtingLabel";
            this.GerrtingLabel.Size = new System.Drawing.Size(473, 90);
            this.GerrtingLabel.TabIndex = 0;
            this.GerrtingLabel.Text = "               Hello!\r\nHow can we help you today? ";
            // 
            // AppointmentBtn
            // 
            this.AppointmentBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentBtn.Location = new System.Drawing.Point(32, 206);
            this.AppointmentBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppointmentBtn.Name = "AppointmentBtn";
            this.AppointmentBtn.Size = new System.Drawing.Size(170, 79);
            this.AppointmentBtn.TabIndex = 1;
            this.AppointmentBtn.Text = "Make an \r\nappointment";
            this.AppointmentBtn.UseVisualStyleBackColor = true;
            this.AppointmentBtn.Click += new System.EventHandler(this.AppointmentBtn_Click);
            // 
            // SeeServicesBtn
            // 
            this.SeeServicesBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SeeServicesBtn.Location = new System.Drawing.Point(280, 206);
            this.SeeServicesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeServicesBtn.Name = "SeeServicesBtn";
            this.SeeServicesBtn.Size = new System.Drawing.Size(135, 79);
            this.SeeServicesBtn.TabIndex = 2;
            this.SeeServicesBtn.Text = "See services";
            this.SeeServicesBtn.UseVisualStyleBackColor = true;
            this.SeeServicesBtn.Click += new System.EventHandler(this.SeeServicesBtn_Click);
            // 
            // ContactDtlBtn
            // 
            this.ContactDtlBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ContactDtlBtn.Location = new System.Drawing.Point(522, 206);
            this.ContactDtlBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactDtlBtn.Name = "ContactDtlBtn";
            this.ContactDtlBtn.Size = new System.Drawing.Size(124, 79);
            this.ContactDtlBtn.TabIndex = 3;
            this.ContactDtlBtn.Text = "Contact details";
            this.ContactDtlBtn.UseVisualStyleBackColor = true;
            this.ContactDtlBtn.Click += new System.EventHandler(this.ContactDtlBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ExitBtn.Location = new System.Drawing.Point(303, 324);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 44);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(694, 399);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ContactDtlBtn);
            this.Controls.Add(this.SeeServicesBtn);
            this.Controls.Add(this.AppointmentBtn);
            this.Controls.Add(this.GerrtingLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GerrtingLabel;
        private Button AppointmentBtn;
        private Button SeeServicesBtn;
        private Button ContactDtlBtn;
        private Button ExitBtn;
    }
}