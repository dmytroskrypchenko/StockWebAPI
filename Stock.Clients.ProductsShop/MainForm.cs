namespace Stock.Clients.ProductsShop
{
    using System.Windows.Forms;
    using System.IO;
    using System;
    using System.Collections.Generic;
    using ProductService;
    using ManufacturerService;
    using ScreenTypeService;
    using ConnectionTypeService;

    public partial class MainForm : Form
    {
        private ProductServiceClient _productServiceClient;
        private ManufacturerServiceClient _manufacturerServiceClient;
        private ScreenTypeServiceClient _screenTypeServiceClient;
        private ConnectionTypeServiceClient _connectionTypeServiceClient;

        public MainForm()
        {
            InitializeComponent();
            _productServiceClient = new ProductServiceClient();
            _manufacturerServiceClient = new ManufacturerServiceClient();
            _screenTypeServiceClient = new ScreenTypeServiceClient();
            _connectionTypeServiceClient = new ConnectionTypeServiceClient();
        }

        private void addPhoneToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var addPhoneForm = new AddPhone(_productServiceClient, _manufacturerServiceClient);
            addPhoneForm.ShowDialog();
        }

        private void addSmartWatchToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var addSmartWatchForm = new AddSmartWatch(_productServiceClient, _manufacturerServiceClient, _connectionTypeServiceClient);
            addSmartWatchForm.ShowDialog();
        }

        private void addElectronicBookToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var addElectronicBookForm = new AddElectronicBook(_productServiceClient, _manufacturerServiceClient, _screenTypeServiceClient);
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

            _productServiceClient.ImportProducts(fileDto);
        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProductsForm = new AddProducts(_productServiceClient, _manufacturerServiceClient, _connectionTypeServiceClient, _screenTypeServiceClient);
            addProductsForm.ShowDialog();
        }
    }
}
