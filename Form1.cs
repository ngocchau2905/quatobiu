namespace Waterbill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addInvoiceUsedControl.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void AddInvoiceMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUsedControl.Show();
            AddInvoiceMenuButton.BackColor = Color.Pink;
            AddInvoiceMenuButton.ForeColor = Color.Black;

        }
    }
}
