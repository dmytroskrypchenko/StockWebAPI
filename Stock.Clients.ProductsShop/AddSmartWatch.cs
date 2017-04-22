namespace Stock.Clients.ProductsShop
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ProductService;

    public partial class AddSmartWatch : Form
    {
        public AddSmartWatch()
        {
            InitializeComponent();
        }

        private void AddSmartWatch_Load(object sender, EventArgs e)
        {
            //TODO: get using service
            List<ManufacturerDto> manufacturers = new List<ManufacturerDto>();

            comboBoxManufacturer.DataSource = new BindingSource(manufacturers, null);
            comboBoxManufacturer.DisplayMember = "Name";
            comboBoxManufacturer.ValueMember = "Id";

            List<InterfaceForConnectingDto> connectionTypes = new List<InterfaceForConnectingDto>();

            comboBoxConnectionType.DataSource = new BindingSource(connectionTypes, null);
            comboBoxConnectionType.DisplayMember = "Name";
            comboBoxConnectionType.ValueMember = "Id";
        }

        private void buttonSmartWatch_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show("Please, fill the required fields");
            }
            else
            {
                SmartWatchDto smartWatch = new SmartWatchDto();
                smartWatch.Name = textBoxName.Text;
                smartWatch.Price = decimal.Parse(textBoxPrice.Text);
                smartWatch.Description = textBoxDescription.Text;
                smartWatch.Manufacturer = (ManufacturerDto)comboBoxManufacturer.SelectedItem;
                smartWatch.InterfaceForConnecting = (InterfaceForConnectingDto)comboBoxConnectionType.SelectedItem;
                smartWatch.ScreenDiagonal = double.Parse(textBoxScreenDiagonal.Text);
                smartWatch.Pulsometer = checkBoxPulsometer.Checked;
                smartWatch.SimCard = checkBoxSimCard.Checked;

                MessageBox.Show("Book successfully added");
                this.Close();
            }
        }
    }
}
