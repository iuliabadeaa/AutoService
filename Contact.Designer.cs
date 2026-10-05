namespace AutoServiceCuNET
{
    partial class Contact
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
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.contactlbl = new System.Windows.Forms.Label();
            this.workTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.back.Location = new System.Drawing.Point(91, 472);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(99, 46);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exit.Location = new System.Drawing.Point(426, 472);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(88, 46);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.contactlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.contactlbl.Location = new System.Drawing.Point(12, 28);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(536, 114);
            this.contactlbl.TabIndex = 2;
            this.contactlbl.Text = "Tel: +40 724 827 122| +40 314 382 034\r\n\r\nEmail: office@service.eu\r\n";
            // 
            // workTime
            // 
            this.workTime.AutoSize = true;
            this.workTime.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.workTime.ForeColor = System.Drawing.SystemColors.Control;
            this.workTime.Location = new System.Drawing.Point(12, 180);
            this.workTime.Name = "workTime";
            this.workTime.Size = new System.Drawing.Size(351, 266);
            this.workTime.TabIndex = 3;
            this.workTime.Text = "Monday   10:00-18:00\r\nTuesday   10:00-18:00\r\nWednesday   10:00-18:00\r\nThursday   " +
    "10:00-18:00\r\nFriday   10:00-18:00\r\nSaturday   CLOSED\r\nSunday    CLOSED\r\n";
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(616, 550);
            this.Controls.Add(this.workTime);
            this.Controls.Add(this.contactlbl);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back);
            this.Name = "Contact";
            this.Text = "Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label contactlbl;
        private System.Windows.Forms.Label workTime;
    }
}