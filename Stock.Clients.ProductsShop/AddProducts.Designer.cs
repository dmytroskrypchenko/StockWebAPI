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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewElectronicBooks = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewSmartWatches = new System.Windows.Forms.DataGridView();
            this.buttonAddProducts = new System.Windows.Forms.Button();
            this.textBoxSmartWatchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSmartWatchPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSmartWatchDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxSmartWatchManufacturer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboBoxSmartWatchInterfaceForConnection = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBoxSmartWatchScreenDiagonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxSmartWatchPulsometer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkBoxSmartWatchSimCard = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textBoxElectronicBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxElectronicBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxElectronicBookDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxElectronicBookManufacturer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBoxElectronicBookScreenDiagonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxElectronicBookScreenType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBoxElectronicBookBatteryCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxElectronicBookWorkingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPhoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPhonePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPhoneDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxPhoneManufacturer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBoxPhoneRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPhoneROM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPhoneCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPhoneBatteryCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPhoneScreenDiagonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPhoneCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textBoxPhoneName,
            this.textBoxPhonePrice,
            this.textBoxPhoneDescription,
            this.comboBoxPhoneManufacturer,
            this.textBoxPhoneRAM,
            this.textBoxPhoneROM,
            this.textBoxPhoneCPU,
            this.textBoxPhoneBatteryCapacity,
            this.textBoxPhoneScreenDiagonal,
            this.textBoxPhoneCamera});
            this.dataGridViewPhones.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPhones.Name = "dataGridViewPhones";
            this.dataGridViewPhones.Size = new System.Drawing.Size(899, 340);
            this.dataGridViewPhones.TabIndex = 0;
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
            this.textBoxElectronicBookName,
            this.textBoxElectronicBookPrice,
            this.textBoxElectronicBookDescription,
            this.comboBoxElectronicBookManufacturer,
            this.textBoxElectronicBookScreenDiagonal,
            this.comboBoxElectronicBookScreenType,
            this.textBoxElectronicBookBatteryCapacity,
            this.textBoxElectronicBookWorkingTime});
            this.dataGridViewElectronicBooks.Location = new System.Drawing.Point(0, -2);
            this.dataGridViewElectronicBooks.Name = "dataGridViewElectronicBooks";
            this.dataGridViewElectronicBooks.Size = new System.Drawing.Size(899, 340);
            this.dataGridViewElectronicBooks.TabIndex = 1;
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
            this.textBoxSmartWatchName,
            this.textBoxSmartWatchPrice,
            this.textBoxSmartWatchDescription,
            this.comboBoxSmartWatchManufacturer,
            this.comboBoxSmartWatchInterfaceForConnection,
            this.textBoxSmartWatchScreenDiagonal,
            this.checkBoxSmartWatchPulsometer,
            this.checkBoxSmartWatchSimCard});
            this.dataGridViewSmartWatches.Location = new System.Drawing.Point(0, -2);
            this.dataGridViewSmartWatches.Name = "dataGridViewSmartWatches";
            this.dataGridViewSmartWatches.Size = new System.Drawing.Size(899, 340);
            this.dataGridViewSmartWatches.TabIndex = 2;
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
            // textBoxSmartWatchName
            // 
            this.textBoxSmartWatchName.HeaderText = "Name";
            this.textBoxSmartWatchName.Name = "textBoxSmartWatchName";
            // 
            // textBoxSmartWatchPrice
            // 
            this.textBoxSmartWatchPrice.HeaderText = "Price";
            this.textBoxSmartWatchPrice.Name = "textBoxSmartWatchPrice";
            // 
            // textBoxSmartWatchDescription
            // 
            this.textBoxSmartWatchDescription.HeaderText = "Description";
            this.textBoxSmartWatchDescription.Name = "textBoxSmartWatchDescription";
            // 
            // comboBoxSmartWatchManufacturer
            // 
            this.comboBoxSmartWatchManufacturer.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.comboBoxSmartWatchManufacturer.HeaderText = "Manufacturer";
            this.comboBoxSmartWatchManufacturer.Name = "comboBoxSmartWatchManufacturer";
            // 
            // comboBoxSmartWatchInterfaceForConnection
            // 
            this.comboBoxSmartWatchInterfaceForConnection.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.comboBoxSmartWatchInterfaceForConnection.HeaderText = "InterfaceForConnecting";
            this.comboBoxSmartWatchInterfaceForConnection.Name = "comboBoxSmartWatchInterfaceForConnection";
            // 
            // textBoxSmartWatchScreenDiagonal
            // 
            this.textBoxSmartWatchScreenDiagonal.HeaderText = "ScreenDiagonal";
            this.textBoxSmartWatchScreenDiagonal.Name = "textBoxSmartWatchScreenDiagonal";
            // 
            // checkBoxSmartWatchPulsometer
            // 
            this.checkBoxSmartWatchPulsometer.HeaderText = "Pulsometer";
            this.checkBoxSmartWatchPulsometer.Name = "checkBoxSmartWatchPulsometer";
            // 
            // checkBoxSmartWatchSimCard
            // 
            this.checkBoxSmartWatchSimCard.HeaderText = "SimCard";
            this.checkBoxSmartWatchSimCard.Name = "checkBoxSmartWatchSimCard";
            // 
            // textBoxElectronicBookName
            // 
            this.textBoxElectronicBookName.HeaderText = "Name";
            this.textBoxElectronicBookName.Name = "textBoxElectronicBookName";
            // 
            // textBoxElectronicBookPrice
            // 
            this.textBoxElectronicBookPrice.HeaderText = "Price";
            this.textBoxElectronicBookPrice.Name = "textBoxElectronicBookPrice";
            // 
            // textBoxElectronicBookDescription
            // 
            this.textBoxElectronicBookDescription.HeaderText = "Description";
            this.textBoxElectronicBookDescription.Name = "textBoxElectronicBookDescription";
            // 
            // comboBoxElectronicBookManufacturer
            // 
            this.comboBoxElectronicBookManufacturer.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.comboBoxElectronicBookManufacturer.HeaderText = "Manufacturer";
            this.comboBoxElectronicBookManufacturer.Name = "comboBoxElectronicBookManufacturer";
            // 
            // textBoxElectronicBookScreenDiagonal
            // 
            this.textBoxElectronicBookScreenDiagonal.HeaderText = "ScreenDiagonal";
            this.textBoxElectronicBookScreenDiagonal.Name = "textBoxElectronicBookScreenDiagonal";
            // 
            // comboBoxElectronicBookScreenType
            // 
            this.comboBoxElectronicBookScreenType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.comboBoxElectronicBookScreenType.HeaderText = "ScreenType";
            this.comboBoxElectronicBookScreenType.Name = "comboBoxElectronicBookScreenType";
            // 
            // textBoxElectronicBookBatteryCapacity
            // 
            this.textBoxElectronicBookBatteryCapacity.HeaderText = "BatteryCapacity";
            this.textBoxElectronicBookBatteryCapacity.Name = "textBoxElectronicBookBatteryCapacity";
            // 
            // textBoxElectronicBookWorkingTime
            // 
            this.textBoxElectronicBookWorkingTime.HeaderText = "WorkingTime";
            this.textBoxElectronicBookWorkingTime.Name = "textBoxElectronicBookWorkingTime";
            // 
            // textBoxPhoneName
            // 
            this.textBoxPhoneName.HeaderText = "Name";
            this.textBoxPhoneName.Name = "textBoxPhoneName";
            // 
            // textBoxPhonePrice
            // 
            this.textBoxPhonePrice.HeaderText = "Price";
            this.textBoxPhonePrice.Name = "textBoxPhonePrice";
            // 
            // textBoxPhoneDescription
            // 
            this.textBoxPhoneDescription.HeaderText = "Description";
            this.textBoxPhoneDescription.Name = "textBoxPhoneDescription";
            // 
            // comboBoxPhoneManufacturer
            // 
            this.comboBoxPhoneManufacturer.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.comboBoxPhoneManufacturer.HeaderText = "Manufacturer";
            this.comboBoxPhoneManufacturer.Name = "comboBoxPhoneManufacturer";
            // 
            // textBoxPhoneRAM
            // 
            this.textBoxPhoneRAM.HeaderText = "RAM";
            this.textBoxPhoneRAM.Name = "textBoxPhoneRAM";
            // 
            // textBoxPhoneROM
            // 
            this.textBoxPhoneROM.HeaderText = "ROM";
            this.textBoxPhoneROM.Name = "textBoxPhoneROM";
            // 
            // textBoxPhoneCPU
            // 
            this.textBoxPhoneCPU.HeaderText = "CPU";
            this.textBoxPhoneCPU.Name = "textBoxPhoneCPU";
            // 
            // textBoxPhoneBatteryCapacity
            // 
            this.textBoxPhoneBatteryCapacity.HeaderText = "BatteryCapacity";
            this.textBoxPhoneBatteryCapacity.Name = "textBoxPhoneBatteryCapacity";
            // 
            // textBoxPhoneScreenDiagonal
            // 
            this.textBoxPhoneScreenDiagonal.HeaderText = "ScreenDiagonal";
            this.textBoxPhoneScreenDiagonal.Name = "textBoxPhoneScreenDiagonal";
            // 
            // textBoxPhoneCamera
            // 
            this.textBoxPhoneCamera.HeaderText = "Camera";
            this.textBoxPhoneCamera.Name = "textBoxPhoneCamera";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 426);
            this.Controls.Add(this.buttonAddProducts);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "AddProducts";
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewElectronicBooks;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewSmartWatches;
        private System.Windows.Forms.Button buttonAddProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxPhoneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxPhonePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxPhoneDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBoxPhoneManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxPhoneRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxPhoneROM;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxPhoneCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxPhoneBatteryCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxPhoneScreenDiagonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxPhoneCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxElectronicBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxElectronicBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxElectronicBookDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBoxElectronicBookManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxElectronicBookScreenDiagonal;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBoxElectronicBookScreenType;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxElectronicBookBatteryCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxElectronicBookWorkingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxSmartWatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxSmartWatchPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxSmartWatchDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBoxSmartWatchManufacturer;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboBoxSmartWatchInterfaceForConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBoxSmartWatchScreenDiagonal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxSmartWatchPulsometer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxSmartWatchSimCard;
    }
}