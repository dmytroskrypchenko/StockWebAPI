namespace Stock.Clients.ProductsShop
{
    using System;
    using System.Windows.Forms;
    using ProductService;
    using ManufacturerService;
    using ScreenTypeService;

    public partial class AddElectronicBook : Form
    {
        private readonly ProductServiceClient _productServiceClient;
        private readonly ManufacturerServiceClient _manufacturerServiceClient;
        private readonly ScreenTypeServiceClient _screenTypeServiceClient;

        public AddElectronicBook(ProductServiceClient productServiceClient, ManufacturerServiceClient manufacturerServiceClient, ScreenTypeServiceClient screenTypeServiceClient)
        {
            InitializeComponent();
            _productServiceClient = productServiceClient;
            _manufacturerServiceClient = manufacturerServiceClient;
            _screenTypeServiceClient = screenTypeServiceClient;
        }

        private void AddElectronicBook_Load(object sender, EventArgs e)
        {
            var manufacturers = _manufacturerServiceClient.GetAll();
            comboBoxManufacturer.DataSource = new BindingSource(manufacturers, null);
            comboBoxManufacturer.DisplayMember = "Name";
            comboBoxManufacturer.ValueMember = "Id";

            var screenTypes = _screenTypeServiceClient.GetAll();
            comboBoxScreenType.DataSource = new BindingSource(screenTypes, null);
            comboBoxScreenType.DisplayMember = "Name";
            comboBoxScreenType.ValueMember = "Id";
        }

        private void buttonAddElectronicBook_Click(object sender, EventArgs e)
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

                ElectronicBookDto electronicBook = new ElectronicBookDto();
                electronicBook.Name = textBoxName.Text;
                electronicBook.Price = Parsers.DecimalParse(textBoxPrice.Text);
                electronicBook.Description = textBoxDescription.Text;
                electronicBook.Manufacturer = new ProductService.ManufacturerDto
                {
                    Id = ((ManufacturerService.ManufacturerDto)comboBoxManufacturer.SelectedItem).Id
                };
                electronicBook.ScreenDiagonal = Parsers.DoubleParse(textBoxScreenDiagonal.Text);
                electronicBook.ScreenType = new ProductService.ScreenTypeDto
                {
                    Id = ((ScreenTypeService.ScreenTypeDto)comboBoxScreenType.SelectedItem).Id
                };
                electronicBook.BatteryCapacity = Parsers.IntParse(textBoxBatteryCapacity.Text);
                electronicBook.WorkingTime = textBoxWorkingTime.Text;

                _productServiceClient.AddElectronicBook(electronicBook);
                MessageBox.Show("Book successfully added");
                Close();
            }
        }
    }
}
