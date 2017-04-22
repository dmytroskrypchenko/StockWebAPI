namespace Stock.Clients.ProductsShop
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ProductService;

    public partial class AddPhone : Form
    {
        public AddPhone()
        {
            InitializeComponent();
        }
        private void AddPhone_Load(object sender, EventArgs e)
        {
            //TODO: get using service
            List<ManufacturerDto> manufacturers = new List<ManufacturerDto>();

            comboBoxManufacturer.DataSource = new BindingSource(manufacturers, null);
            comboBoxManufacturer.DisplayMember = "Name";
            comboBoxManufacturer.ValueMember = "Id";
        }

        private void buttonAddPhone_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show("Please, fill the required fields");
            }
            else
            {
                PhoneDto phone = new PhoneDto();
                phone.Name = textBoxName.Text;
                phone.Price = decimal.Parse(textBoxPrice.Text);
                phone.Description = textBoxDescription.Text;
                phone.Manufacturer = (ManufacturerDto)comboBoxManufacturer.SelectedItem;
                phone.RAM = int.Parse(textBoxRAM.Text);
                phone.ROM = int.Parse(textBoxROM.Text);
                phone.CPU = textBoxCPU.Text;
                phone.BatteryCapacity = int.Parse(textBoxBatteryCapacity.Text);
                phone.ScreenDiagonal = double.Parse(textBoxScreenDiagonal.Text);
                phone.Camera = double.Parse(textBoxCamera.Text);

                MessageBox.Show("Book successfully added");
                this.Close();
            }
        }
    }
}
