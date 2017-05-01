namespace Stock.Clients.ProductsShop
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPhoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addSmartWatchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addElectronicBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importProductsFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPrToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // addPrToolStripMenuItem
            // 
            this.addPrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPhoneToolStripMenuItem1,
            this.addSmartWatchToolStripMenuItem1,
            this.addElectronicBookToolStripMenuItem1,
            this.importProductsFromFileToolStripMenuItem});
            this.addPrToolStripMenuItem.Name = "addPrToolStripMenuItem";
            this.addPrToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.addPrToolStripMenuItem.Text = "Add Products";
            // 
            // addPhoneToolStripMenuItem1
            // 
            this.addPhoneToolStripMenuItem1.Name = "addPhoneToolStripMenuItem1";
            this.addPhoneToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.addPhoneToolStripMenuItem1.Text = "Add Phone";
            this.addPhoneToolStripMenuItem1.Click += new System.EventHandler(this.addPhoneToolStripMenuItem1_Click);
            // 
            // addSmartWatchToolStripMenuItem1
            // 
            this.addSmartWatchToolStripMenuItem1.Name = "addSmartWatchToolStripMenuItem1";
            this.addSmartWatchToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.addSmartWatchToolStripMenuItem1.Text = "Add Smart Watch";
            this.addSmartWatchToolStripMenuItem1.Click += new System.EventHandler(this.addSmartWatchToolStripMenuItem1_Click);
            // 
            // addElectronicBookToolStripMenuItem1
            // 
            this.addElectronicBookToolStripMenuItem1.Name = "addElectronicBookToolStripMenuItem1";
            this.addElectronicBookToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.addElectronicBookToolStripMenuItem1.Text = "Add Electronic Book";
            this.addElectronicBookToolStripMenuItem1.Click += new System.EventHandler(this.addElectronicBookToolStripMenuItem1_Click);
            // 
            // importProductsFromFileToolStripMenuItem
            // 
            this.importProductsFromFileToolStripMenuItem.Name = "importProductsFromFileToolStripMenuItem";
            this.importProductsFromFileToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.importProductsFromFileToolStripMenuItem.Text = "Import Products From File";
            this.importProductsFromFileToolStripMenuItem.Click += new System.EventHandler(this.importProductsFromFileToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 300);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ProductsShop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPhoneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addSmartWatchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addElectronicBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importProductsFromFileToolStripMenuItem;
    }
}

