namespace Stock.Clients.ProductsShop
{
    using System;
    using System.Windows.Forms;
    using ProductService;
    using ManufacturerService;

    public partial class AddPhone : Form
    {
        private ProductServiceClient _productServiceClient;
        private ManufacturerServiceClient _manufacturerServiceClient;
        public AddPhone(ProductServiceClient productServiceClient, ManufacturerServiceClient manufacturerServiceClient)
        {
            InitializeComponent();
            _productServiceClient = productServiceClient;
            _manufacturerServiceClient = manufacturerServiceClient;
        }

        private void AddPhone_Load(object sender, EventArgs e)
        {
            var manufacturers = _manufacturerServiceClient.GetAll();

            comboBoxManufacturer.DataSource = new BindingSource(manufacturers, null);
            comboBoxManufacturer.DisplayMember = "Name";
            comboBoxManufacturer.ValueMember = "Id";
        }

        private void buttonAddPhone_Click(object sender, EventArgs e)
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

                PhoneDto phone = new PhoneDto();
                phone.Name = textBoxName.Text;
                phone.Price = Parsers.DecimalParse(textBoxPrice.Text);
                phone.Description = textBoxDescription.Text;
                phone.Manufacturer = new ProductService.ManufacturerDto
                {
                    Id = ((ManufacturerService.ManufacturerDto)comboBoxManufacturer.SelectedItem).Id
                };
                phone.RAM = Parsers.IntParse(textBoxRAM.Text);
                phone.ROM = Parsers.IntParse(textBoxROM.Text);
                phone.CPU = textBoxCPU.Text;
                phone.BatteryCapacity = Parsers.IntParse(textBoxBatteryCapacity.Text);
                phone.ScreenDiagonal = Parsers.DoubleParse(textBoxScreenDiagonal.Text);
                phone.Camera = Parsers.DoubleParse(textBoxCamera.Text);

                _productServiceClient.AddPhone(phone);
                MessageBox.Show("Book successfully added");
                Close();
            }
        }
    }
}
