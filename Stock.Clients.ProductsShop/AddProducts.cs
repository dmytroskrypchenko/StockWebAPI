namespace Stock.Clients.ProductsShop
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ConnectionTypeService;
    using ManufacturerService;
    using ProductService;
    using ScreenTypeService;
    using ManufacturerDto = ManufacturerService.ManufacturerDto;

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
            var products = new List<ProductDto>();
            products.AddRange(ParsePhones());
            products.AddRange(ParseElectronicBooks());
            products.AddRange(ParseSmartWatches());

            _productServiceClient.AddProducts(products);

            MessageBox.Show("Products successfully added");
            Close();
        }

        private List<SmartWatchDto> ParseSmartWatches()
        {
            var smartWatches = new List<SmartWatchDto>();
            foreach (DataGridViewRow row in dataGridViewSmartWatches.Rows)
            {
                var name = row.Cells["textBoxSmartWatchName"].Value?.ToString();
                var price = row.Cells["textBoxSmartWatchPrice"].Value?.ToString();
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
                {
                    break;
                }
                var smartWatch = new SmartWatchDto();
                smartWatch.Name = name;
                smartWatch.Price = Parsers.DecimalParse(price);
                smartWatch.Description = row.Cells["textBoxSmartWatchDescription"].Value?.ToString();
                smartWatch.Manufacturer = row.Cells["comboBoxSmartWatchManufacturer"].Value == null
                    ? null
                    : new ProductService.ManufacturerDto
                    {
                        Id = (int)row.Cells["comboBoxSmartWatchManufacturer"].Value
                    };
                smartWatch.InterfaceForConnecting = row.Cells["comboBoxSmartWatchInterfaceForConnection"].Value == null
                    ? null
                    : new ProductService.InterfaceForConnectingDto
                    {
                        Id = (int)row.Cells["comboBoxSmartWatchInterfaceForConnection"].Value
                    };
                smartWatch.ScreenDiagonal = Parsers.DoubleParse(row.Cells["textBoxSmartWatchScreenDiagonal"].Value?.ToString());
                smartWatch.Pulsometer = (bool?)row.Cells["checkBoxSmartWatchPulsometer"].Value ?? false;
                smartWatch.SimCard = (bool?)row.Cells["checkBoxSmartWatchSimCard"].Value ?? false;

                smartWatches.Add(smartWatch);
            }
            return smartWatches;
        }

        private List<ElectronicBookDto> ParseElectronicBooks()
        {
            var electronicBooks = new List<ElectronicBookDto>();
            foreach (DataGridViewRow row in dataGridViewElectronicBooks.Rows)
            {
                var name = row.Cells["textBoxElectronicBookName"].Value?.ToString();
                var price = row.Cells["textBoxElectronicBookPrice"].Value?.ToString();
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
                {
                    break;
                }

                var electronicBook = new ElectronicBookDto();
                electronicBook.Name = name;
                electronicBook.Price = Parsers.DecimalParse(price);
                electronicBook.Description = row.Cells["textBoxElectronicBookName"].Value?.ToString();
                electronicBook.Manufacturer = row.Cells["comboBoxElectronicBookManufacturer"].Value == null
                    ? null
                    : new ProductService.ManufacturerDto
                    {
                        Id = (int)row.Cells["comboBoxElectronicBookManufacturer"].Value
                    };
                electronicBook.ScreenDiagonal =
                    Parsers.DoubleParse(row.Cells["textBoxElectronicBookScreenDiagonal"].Value?.ToString());
                electronicBook.ScreenType = row.Cells["comboBoxElectronicBookScreenType"].Value == null
                    ? null
                    : new ProductService.ScreenTypeDto
                    {
                        Id = (int)row.Cells["comboBoxElectronicBookScreenType"].Value
                    };
                electronicBook.BatteryCapacity =
                    Parsers.IntParse(row.Cells["textBoxElectronicBookBatteryCapacity"].Value?.ToString());
                electronicBook.WorkingTime = row.Cells["textBoxElectronicBookWorkingTime"].Value?.ToString();

                electronicBooks.Add(electronicBook);
            }
            return electronicBooks;
        }

        private List<PhoneDto> ParsePhones()
        {
            var phones = new List<PhoneDto>();
            foreach (DataGridViewRow row in dataGridViewPhones.Rows)
            {
                var name = row.Cells["textBoxPhoneName"].Value?.ToString();
                var price = row.Cells["textBoxPhonePrice"].Value?.ToString();
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
                {
                    break;
                }

                var phone = new PhoneDto();
                phone.Name = name;
                phone.Price = Parsers.DecimalParse(price);
                phone.Description = row.Cells["textBoxPhoneDescription"].Value?.ToString();
                phone.Manufacturer = row.Cells["comboBoxPhoneManufacturer"].Value == null
                    ? null
                    : new ProductService.ManufacturerDto
                    {
                        Id = (int)row.Cells["comboBoxPhoneManufacturer"].Value
                    };
                phone.RAM = Parsers.IntParse(row.Cells["textBoxPhoneRAM"].Value?.ToString());
                phone.ROM = Parsers.IntParse(row.Cells["textBoxPhoneROM"].Value?.ToString());
                phone.CPU = row.Cells["textBoxPhoneCPU"].Value?.ToString();
                phone.BatteryCapacity = Parsers.IntParse(row.Cells["textBoxPhoneBatteryCapacity"].Value?.ToString());
                phone.ScreenDiagonal = Parsers.DoubleParse(row.Cells["textBoxPhoneScreenDiagonal"].Value?.ToString());
                phone.Camera = Parsers.DoubleParse(row.Cells["textBoxPhoneCamera"].Value?.ToString());

                phones.Add(phone);
            }
            return phones;
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            var manufacturers = _manufacturerServiceClient.GetAll();
            var connectionTypes = _connectionTypeServiceClient.GetAll();
            var screenTypes = _screenTypeServiceClient.GetAll();

            SetUpPhonesGrid(manufacturers);
            SetUpElectronicBooksGrid(manufacturers, screenTypes);
            SetUpSmartWatchesGrid(manufacturers, connectionTypes);
        }

        private void SetUpPhonesGrid(List<ManufacturerDto> manufacturers)
        {
            comboBoxPhoneManufacturer.DataSource = new BindingSource(manufacturers, null);
            comboBoxPhoneManufacturer.DisplayMember = "Name";
            comboBoxPhoneManufacturer.ValueMember = "Id";
        }

        private void SetUpElectronicBooksGrid(List<ManufacturerDto> manufacturers, List<ScreenTypeService.ScreenTypeDto> screenTypes)
        {
            comboBoxElectronicBookManufacturer.DataSource = new BindingSource(manufacturers, null);
            comboBoxElectronicBookManufacturer.DisplayMember = "Name";
            comboBoxElectronicBookManufacturer.ValueMember = "Id";

            comboBoxElectronicBookScreenType.DataSource = new BindingSource(screenTypes, null);
            comboBoxElectronicBookScreenType.DisplayMember = "Name";
            comboBoxElectronicBookScreenType.ValueMember = "Id";
        }

        private void SetUpSmartWatchesGrid(List<ManufacturerDto> manufacturers, List<ConnectionTypeService.InterfaceForConnectingDto> connectionTypes)
        {
            comboBoxSmartWatchManufacturer.DataSource = new BindingSource(manufacturers, null);
            comboBoxSmartWatchManufacturer.DisplayMember = "Name";
            comboBoxSmartWatchManufacturer.ValueMember = "Id";

            comboBoxSmartWatchInterfaceForConnection.DataSource = new BindingSource(connectionTypes, null);
            comboBoxSmartWatchInterfaceForConnection.DisplayMember = "Name";
            comboBoxSmartWatchInterfaceForConnection.ValueMember = "Id";
        }
    }
}
