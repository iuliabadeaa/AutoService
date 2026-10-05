namespace AutoServiceCuNET
{
    partial class ServicesAdmin
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
            this.productTable = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceAutoDataSet1 = new AutoServiceCuNET.serviceAutoDataSet1();
            this.serviceAutoDataSet = new AutoServiceCuNET.serviceAutoDataSet();
            this.serviceAutoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new AutoServiceCuNET.serviceAutoDataSet1TableAdapters.servicesTableAdapter();
            this.backbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.savedata = new System.Windows.Forms.Button();
            this.productNamelbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.ProductTxtBox = new System.Windows.Forms.TextBox();
            this.PriceTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.convertEur = new System.Windows.Forms.Button();
            this.priceEur = new System.Windows.Forms.Label();
            this.ValueInEur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productTable
            // 
            this.productTable.AllowUserToOrderColumns = true;
            this.productTable.AutoGenerateColumns = false;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.productTable.DataSource = this.servicesBindingSource;
            this.productTable.Location = new System.Drawing.Point(97, 266);
            this.productTable.Name = "productTable";
            this.productTable.RowHeadersWidth = 51;
            this.productTable.RowTemplate.Height = 24;
            this.productTable.Size = new System.Drawing.Size(617, 111);
            this.productTable.TabIndex = 0;
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
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.serviceAutoDataSet1;
            // 
            // serviceAutoDataSet1
            // 
            this.serviceAutoDataSet1.DataSetName = "serviceAutoDataSet1";
            this.serviceAutoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceAutoDataSet
            // 
            this.serviceAutoDataSet.DataSetName = "serviceAutoDataSet";
            this.serviceAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceAutoDataSetBindingSource
            // 
            this.serviceAutoDataSetBindingSource.DataSource = this.serviceAutoDataSet;
            this.serviceAutoDataSetBindingSource.Position = 0;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.backbtn.Location = new System.Drawing.Point(76, 446);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(95, 44);
            this.backbtn.TabIndex = 1;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exitbtn.Location = new System.Drawing.Point(625, 446);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(103, 44);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // savedata
            // 
            this.savedata.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.savedata.Location = new System.Drawing.Point(661, 173);
            this.savedata.Name = "savedata";
            this.savedata.Size = new System.Drawing.Size(95, 44);
            this.savedata.TabIndex = 3;
            this.savedata.Text = "Save";
            this.savedata.UseVisualStyleBackColor = true;
            this.savedata.Click += new System.EventHandler(this.savedata_Click);
            // 
            // productNamelbl
            // 
            this.productNamelbl.AutoSize = true;
            this.productNamelbl.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNamelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.productNamelbl.Location = new System.Drawing.Point(34, 39);
            this.productNamelbl.Name = "productNamelbl";
            this.productNamelbl.Size = new System.Drawing.Size(127, 38);
            this.productNamelbl.TabIndex = 4;
            this.productNamelbl.Text = "Product:";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.pricelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.pricelbl.Location = new System.Drawing.Point(34, 138);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(90, 38);
            this.pricelbl.TabIndex = 5;
            this.pricelbl.Text = "Price:";
            // 
            // ProductTxtBox
            // 
            this.ProductTxtBox.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ProductTxtBox.Location = new System.Drawing.Point(184, 36);
            this.ProductTxtBox.Name = "ProductTxtBox";
            this.ProductTxtBox.Size = new System.Drawing.Size(419, 43);
            this.ProductTxtBox.TabIndex = 6;
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PriceTxtBox.Location = new System.Drawing.Point(150, 133);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.Size = new System.Drawing.Size(167, 43);
            this.PriceTxtBox.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.searchBtn.Location = new System.Drawing.Point(661, 39);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(95, 43);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.deleteBtn.Location = new System.Drawing.Point(661, 104);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(95, 43);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // convertEur
            // 
            this.convertEur.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.convertEur.Location = new System.Drawing.Point(345, 133);
            this.convertEur.Name = "convertEur";
            this.convertEur.Size = new System.Drawing.Size(139, 43);
            this.convertEur.TabIndex = 10;
            this.convertEur.Text = "Convert  €";
            this.convertEur.UseVisualStyleBackColor = true;
            this.convertEur.Click += new System.EventHandler(this.convertEur_Click);
            // 
            // priceEur
            // 
            this.priceEur.AutoSize = true;
            this.priceEur.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.priceEur.ForeColor = System.Drawing.SystemColors.Control;
            this.priceEur.Location = new System.Drawing.Point(34, 201);
            this.priceEur.Name = "priceEur";
            this.priceEur.Size = new System.Drawing.Size(0, 38);
            this.priceEur.TabIndex = 11;
            // 
            // ValueInEur
            // 
            this.ValueInEur.AutoSize = true;
            this.ValueInEur.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ValueInEur.ForeColor = System.Drawing.SystemColors.Control;
            this.ValueInEur.Location = new System.Drawing.Point(199, 201);
            this.ValueInEur.Name = "ValueInEur";
            this.ValueInEur.Size = new System.Drawing.Size(0, 38);
            this.ValueInEur.TabIndex = 12;
            // 
            // ServicesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(793, 515);
            this.Controls.Add(this.ValueInEur);
            this.Controls.Add(this.priceEur);
            this.Controls.Add(this.convertEur);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.PriceTxtBox);
            this.Controls.Add(this.ProductTxtBox);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.productNamelbl);
            this.Controls.Add(this.savedata);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.productTable);
            this.Name = "ServicesAdmin";
            this.Text = "ServicesAdmin";
            this.Load += new System.EventHandler(this.ServicesAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAutoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productTable;
        private serviceAutoDataSet serviceAutoDataSet;
        private System.Windows.Forms.BindingSource serviceAutoDataSetBindingSource;
        private serviceAutoDataSet1 serviceAutoDataSet1;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private serviceAutoDataSet1TableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button savedata;
        private System.Windows.Forms.Label productNamelbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.TextBox ProductTxtBox;
        private System.Windows.Forms.TextBox PriceTxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button convertEur;
        private System.Windows.Forms.Label priceEur;
        private System.Windows.Forms.Label ValueInEur;
    }
}