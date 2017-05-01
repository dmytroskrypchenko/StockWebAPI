using System;
using System.Windows.Forms;
using Stock.Clients.ProductsShop.ConnectionTypeService;
using Stock.Clients.ProductsShop.ManufacturerService;
using Stock.Clients.ProductsShop.ProductService;
using Stock.Clients.ProductsShop.ScreenTypeService;

namespace Stock.Clients.ProductsShop
{
    public partial class AddProducts : Form
    {
        private readonly ProductServiceClient _productServiceClient;
        private readonly ManufacturerServiceClient _manufacturerServiceClient;
        private readonly ConnectionTypeServiceClient _connectionTypeServiceClient;
        private readonly ScreenTypeServiceClient _screenTypeServiceClient;

        public AddProducts(ProductServiceClient productServiceClient, ManufacturerServiceClient manufacturerServiceClient, ConnectionTypeServiceClient connectionTypeServiceClient, ScreenTypeServiceClient screenTypeServiceClient)
        {
            InitializeComponent();
            _productServiceClient = productServiceClient;
            _manufacturerServiceClient = manufacturerServiceClient;
            _connectionTypeServiceClient = connectionTypeServiceClient;
            _screenTypeServiceClient = screenTypeServiceClient;
        }

        private void buttonAddProducts_Click(object sender, EventArgs e)
        {

        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            var manufacturers = _manufacturerServiceClient.GetAll();
            var connectionTypes = _connectionTypeServiceClient.GetAll();
            var screenTypes = _screenTypeServiceClient.GetAll();

            //TODO:implement add data to combobox
        }
    }
}
