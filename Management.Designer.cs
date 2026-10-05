namespace AutoServiceCuNET
{
    partial class Management
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
            this.SeeProducts = new System.Windows.Forms.Button();
            this.seeAppointments = new System.Windows.Forms.Button();
            this.seeClients = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SeeProducts
            // 
            this.SeeProducts.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SeeProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SeeProducts.Location = new System.Drawing.Point(72, 160);
            this.SeeProducts.Name = "SeeProducts";
            this.SeeProducts.Size = new System.Drawing.Size(123, 72);
            this.SeeProducts.TabIndex = 0;
            this.SeeProducts.Text = "Services\r\nlist";
            this.SeeProducts.UseVisualStyleBackColor = true;
            this.SeeProducts.Click += new System.EventHandler(this.SeeProducts_Click);
            // 
            // seeAppointments
            // 
            this.seeAppointments.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.seeAppointments.Location = new System.Drawing.Point(282, 160);
            this.seeAppointments.Name = "seeAppointments";
            this.seeAppointments.Size = new System.Drawing.Size(196, 72);
            this.seeAppointments.TabIndex = 1;
            this.seeAppointments.Text = "Appointments\r\nlist";
            this.seeAppointments.UseVisualStyleBackColor = true;
            this.seeAppointments.Click += new System.EventHandler(this.seeAppointments_Click);
            // 
            // seeClients
            // 
            this.seeClients.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.seeClients.Location = new System.Drawing.Point(564, 160);
            this.seeClients.Name = "seeClients";
            this.seeClients.Size = new System.Drawing.Size(122, 72);
            this.seeClients.TabIndex = 2;
            this.seeClients.Text = "Clients\r\n list\r\n";
            this.seeClients.UseVisualStyleBackColor = true;
            this.seeClients.Click += new System.EventHandler(this.seeClients_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exitbtn.Location = new System.Drawing.Point(333, 360);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(101, 54);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(237, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hello, administrator!";
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.seeClients);
            this.Controls.Add(this.seeAppointments);
            this.Controls.Add(this.SeeProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Management";
            this.Text = "Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SeeProducts;
        private System.Windows.Forms.Button seeAppointments;
        private System.Windows.Forms.Button seeClients;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label1;
    }
}