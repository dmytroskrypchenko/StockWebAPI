namespace Stock.Clients.ProductsShop
{
    using System.Windows.Forms;
    using System.IO;
    using System;
    using System.Collections.Generic;
    using ProductService;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addPhoneToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var addPhoneForm = new AddPhone();
            addPhoneForm.ShowDialog();
        }

        private void addSmartWatchToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var addSmartWatchForm = new AddSmartWatch();
            addSmartWatchForm.ShowDialog();
        }

        private void addElectronicBookToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var addElectronicBookForm = new AddElectronicBook();
            addElectronicBookForm.ShowDialog();
        }

        private void importProductsFromFileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            byte[] array = File.ReadAllBytes(openFileDialog.FileName);

            FileDto fileDto = new FileDto
            {
                FileName = openFileDialog.SafeFileName,
                FileLength = array.Length,
                FileByteStream = array
            };


        }
    }
}
