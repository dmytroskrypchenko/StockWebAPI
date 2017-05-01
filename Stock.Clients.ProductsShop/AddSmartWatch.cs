namespace Stock.Clients.ProductsShop
{
    using System;
    using System.Windows.Forms;
    using ProductService;
    using ManufacturerService;
    using ConnectionTypeService;

    public partial class AddSmartWatch : Form
    {
        private readonly ProductServiceClient _productServiceClient;
        private readonly ManufacturerServiceClient _manufacturerServiceClient;
        private readonly ConnectionTypeServiceClient _connectionTypeServiceClient;
        public AddSmartWatch(ProductServiceClient productServiceClient, ManufacturerServiceClient manufacturerServiceClient, ConnectionTypeServiceClient connectionTypeServiceClient)
        {
            InitializeComponent();
            _productServiceClient = productServiceClient;
            _manufacturerServiceClient = manufacturerServiceClient;
            _connectionTypeServiceClient = connectionTypeServiceClient;
        }

        private void AddSmartWatch_Load(object sender, EventArgs e)
        {
            var manufacturers = _manufacturerServiceClient.GetAll();
            comboBoxManufacturer.DataSource = new BindingSource(manufacturers, null);
            comboBoxManufacturer.DisplayMember = "Name";
            comboBoxManufacturer.ValueMember = "Id";

            var connectionTypes = _connectionTypeServiceClient.GetAll();
            comboBoxConnectionType.DataSource = new BindingSource(connectionTypes, null);
            comboBoxConnectionType.DisplayMember = "Name";
            comboBoxConnectionType.ValueMember = "Id";
        }

        private void buttonSmartWatch_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty || textBoxPrice.Text == string.Empty)
            {
                errorProviderName.SetError(textBoxName, "Please enter a value to Name field");
                errorProviderPrice.SetError(textBoxPrice, "Please enter a value to Price field");
            }
            else
            {
                errorProviderName.Clear();
                errorProviderPrice.Clear();

                SmartWatchDto smartWatch = new SmartWatchDto();
                smartWatch.Name = textBoxName.Text;
                smartWatch.Price = Parsers.DecimalParse(textBoxPrice.Text);
                smartWatch.Description = textBoxDescription.Text;
                smartWatch.Manufacturer = new ProductService.ManufacturerDto
                {
                    Id = ((ManufacturerService.ManufacturerDto)comboBoxManufacturer.SelectedItem).Id
                };
                smartWatch.InterfaceForConnecting = new ProductService.InterfaceForConnectingDto
                {
                    Id = ((ConnectionTypeService.InterfaceForConnectingDto)comboBoxConnectionType.SelectedItem).Id
                };
                smartWatch.ScreenDiagonal = Parsers.DoubleParse(textBoxScreenDiagonal.Text);
                smartWatch.Pulsometer = checkBoxPulsometer.Checked;
                smartWatch.SimCard = checkBoxSimCard.Checked;

                _productServiceClient.AddSmartWatch(smartWatch);
                MessageBox.Show("Book successfully added");
                Close();
            }
        }
    }
}
