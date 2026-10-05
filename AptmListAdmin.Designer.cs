namespace AutoServiceCuNET
{
    partial class AptmListAdmin
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
            this.components = new System.ComponentModel.Container();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceAutoDataSet2 = new AutoServiceCuNET.serviceAutoDataSet2();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new AutoServiceCuNET.serviceAutoDataSet2TableAdapters.appointmentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricationYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hpwrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.backBtn.Location = new System.Drawing.Point(42, 369);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(94, 44);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exitBtn.Location = new System.Drawing.Point(590, 369);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 44);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.licenseNumberDataGridViewTextBoxColumn,
            this.fabricationYearDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.hpwrDataGridViewTextBoxColumn,
            this.transmissionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 321);
            this.dataGridView1.TabIndex = 2;
            // 
            // serviceAutoDataSet2
            // 
            this.serviceAutoDataSet2.DataSetName = "serviceAutoDataSet2";
            this.serviceAutoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.serviceAutoDataSet2;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // licenseNumberDataGridViewTextBoxColumn
            // 
            this.licenseNumberDataGridViewTextBoxColumn.DataPropertyName = "licenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn.HeaderText = "licenseNumber";
            this.licenseNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.licenseNumberDataGridViewTextBoxColumn.Name = "licenseNumberDataGridViewTextBoxColumn";
            this.licenseNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenseNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // fabricationYearDataGridViewTextBoxColumn
            // 
            this.fabricationYearDataGridViewTextBoxColumn.DataPropertyName = "fabricationYear";
            this.fabricationYearDataGridViewTextBoxColumn.HeaderText = "fabricationYear";
            this.fabricationYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fabricationYearDataGridViewTextBoxColumn.Name = "fabricationYearDataGridViewTextBoxColumn";
            this.fabricationYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.fabricationYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // hpwrDataGridViewTextBoxColumn
            // 
            this.hpwrDataGridViewTextBoxColumn.DataPropertyName = "hpwr";
            this.hpwrDataGridViewTextBoxColumn.HeaderText = "hpwr";
            this.hpwrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hpwrDataGridViewTextBoxColumn.Name = "hpwrDataGridViewTextBoxColumn";
            this.hpwrDataGridViewTextBoxColumn.ReadOnly = true;
            this.hpwrDataGridViewTextBoxColumn.Width = 125;
            // 
            // transmissionDataGridViewTextBoxColumn
            // 
            this.transmissionDataGridViewTextBoxColumn.DataPropertyName = "transmission";
            this.transmissionDataGridViewTextBoxColumn.HeaderText = "transmission";
            this.transmissionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transmissionDataGridViewTextBoxColumn.Name = "transmissionDataGridViewTextBoxColumn";
            this.transmissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.transmissionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // AptmListAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "AptmListAdmin";
            this.Text = "AptmListAdmin";
            this.Load += new System.EventHandler(this.AptmListAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private serviceAutoDataSet2 serviceAutoDataSet2;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private serviceAutoDataSet2TableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hpwrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}