namespace Stock.Clients.ProductsShop
{
    using System.Windows.Forms;

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
    }
}
