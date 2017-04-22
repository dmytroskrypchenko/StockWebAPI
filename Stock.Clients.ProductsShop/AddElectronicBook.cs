namespace Stock.Clients.ProductsShop
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ProductService;

    public partial class AddElectronicBook : Form
    {
        public AddElectronicBook()
        {
            InitializeComponent();
        }

        private void AddElectronicBook_Load(object sender, EventArgs e)
        {
            //TODO: get using service
            List<ManufacturerDto> manufacturers = new List<ManufacturerDto>();

            comboBoxManufacturer.DataSource = new BindingSource(manufacturers, null);
            comboBoxManufacturer.DisplayMember = "Name";
            comboBoxManufacturer.ValueMember = "Id";

            List<ScreenTypeDto> screenTypes=new List<ScreenTypeDto>();

            comboBoxScreenType.DataSource=new BindingSource(screenTypes, null);
            comboBoxScreenType.DisplayMember = "Name";
            comboBoxScreenType.ValueMember = "Id";
        }

        private void buttonAddElectronicBook_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show("Please, fill the required fields");
            }
            else
            {
                ElectronicBookDto electronicBook = new ElectronicBookDto();
                electronicBook.Name = textBoxName.Text;
                electronicBook.Price = decimal.Parse(textBoxPrice.Text);
                electronicBook.Description = textBoxDescription.Text;
                electronicBook.Manufacturer = (ManufacturerDto)comboBoxManufacturer.SelectedItem;
                electronicBook.ScreenDiagonal = double.Parse(textBoxScreenDiagonal.Text);
                electronicBook.ScreenType = (ScreenTypeDto)comboBoxScreenType.SelectedItem;
                electronicBook.BatteryCapacity = int.Parse(textBoxBatteryCapacity.Text);
                electronicBook.WorkingTime = textBoxWorkingTime.Text;

                MessageBox.Show("Book successfully added");
                this.Close();
            }
        }
    }
}
