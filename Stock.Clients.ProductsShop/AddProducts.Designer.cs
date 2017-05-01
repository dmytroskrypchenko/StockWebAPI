namespace Stock.Clients.ProductsShop
{
    partial class AddProducts
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewPhones = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatteryCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenDiagonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewElectronicBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewSmartWatches = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.InterfaceForConnecting = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pulsometer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SimCard = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonAddProducts = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhones)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElectronicBooks)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmartWatches)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(907, 362);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewPhones);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPhones
            // 
            this.dataGridViewPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Price,
            this.Description,
            this.Manufacturer,
            this.RAM,
            this.ROM,
            this.CPU,
            this.BatteryCapacity,
            this.ScreenDiagonal,
            this.Camera});
            this.dataGridViewPhones.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPhones.Name = "dataGridViewPhones";
            this.dataGridViewPhones.Size = new System.Drawing.Size(899, 340);
            this.dataGridViewPhones.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            // 
            // RAM
            // 
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            // 
            // ROM
            // 
            this.ROM.HeaderText = "ROM";
            this.ROM.Name = "ROM";
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            // 
            // BatteryCapacity
            // 
            this.BatteryCapacity.HeaderText = "BatteryCapacity";
            this.BatteryCapacity.Name = "BatteryCapacity";
            // 
            // ScreenDiagonal
            // 
            this.ScreenDiagonal.HeaderText = "ScreenDiagonal";
            this.ScreenDiagonal.Name = "ScreenDiagonal";
            // 
            // Camera
            // 
            this.Camera.HeaderText = "Camera";
            this.Camera.Name = "Camera";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewElectronicBooks);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(899, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ElectronicBooks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewElectronicBooks
            // 
            this.dataGridViewElectronicBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElectronicBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.ScreenType,
            this.dataGridViewTextBoxColumn5,
            this.WorkingTime});
            this.dataGridViewElectronicBooks.Location = new System.Drawing.Point(0, -2);
            this.dataGridViewElectronicBooks.Name = "dataGridViewElectronicBooks";
            this.dataGridViewElectronicBooks.Size = new System.Drawing.Size(655, 340);
            this.dataGridViewElectronicBooks.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Manufacturer";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ScreenDiagonal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ScreenType
            // 
            this.ScreenType.HeaderText = "ScreenType";
            this.ScreenType.Name = "ScreenType";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "BatteryCapacity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // WorkingTime
            // 
            this.WorkingTime.HeaderText = "WorkingTime";
            this.WorkingTime.Name = "WorkingTime";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewSmartWatches);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(899, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SmartWatchers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSmartWatches
            // 
            this.dataGridViewSmartWatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSmartWatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewComboBoxColumn2,
            this.InterfaceForConnecting,
            this.dataGridViewTextBoxColumn9,
            this.Pulsometer,
            this.SimCard});
            this.dataGridViewSmartWatches.Location = new System.Drawing.Point(0, -2);
            this.dataGridViewSmartWatches.Name = "dataGridViewSmartWatches";
            this.dataGridViewSmartWatches.Size = new System.Drawing.Size(655, 340);
            this.dataGridViewSmartWatches.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.HeaderText = "Manufacturer";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            // 
            // InterfaceForConnecting
            // 
            this.InterfaceForConnecting.HeaderText = "InterfaceForConnecting";
            this.InterfaceForConnecting.Name = "InterfaceForConnecting";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "ScreenDiagonal";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Pulsometer
            // 
            this.Pulsometer.HeaderText = "Pulsometer";
            this.Pulsometer.Name = "Pulsometer";
            // 
            // SimCard
            // 
            this.SimCard.HeaderText = "SimCard";
            this.SimCard.Name = "SimCard";
            // 
            // buttonAddProducts
            // 
            this.buttonAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAddProducts.Location = new System.Drawing.Point(696, 380);
            this.buttonAddProducts.Name = "buttonAddProducts";
            this.buttonAddProducts.Size = new System.Drawing.Size(219, 35);
            this.buttonAddProducts.TabIndex = 68;
            this.buttonAddProducts.Text = "Add Products";
            this.buttonAddProducts.UseVisualStyleBackColor = true;
            this.buttonAddProducts.Click += new System.EventHandler(this.buttonAddProducts_Click);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 426);
            this.Controls.Add(this.buttonAddProducts);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Text = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhones)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElectronicBooks)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmartWatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewPhones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewComboBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatteryCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenDiagonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camera;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewElectronicBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn ScreenType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingTime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewSmartWatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn InterfaceForConnecting;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pulsometer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SimCard;
        private System.Windows.Forms.Button buttonAddProducts;
    }
}