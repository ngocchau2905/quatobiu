namespace Waterbill
{
    public partial class Form1 : Form
    {
        public ManageInvoices FormListInvoices = new ManageInvoices();
        public Form1()
        {
            InitializeComponent();
            addInvoiceUsedControl.Hide();
            ManageInvoicesUserControl.Hide();

            addInvoiceUsedControl.ListInvoice = FormListInvoices;
            ManageInvoicesUserControl.ListInvoices = FormListInvoices;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void AddInvoiceMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUsedControl.Show();
            
            ManageInvoicesUserControl.Hide();
            AddInvoiceMenuButton.BackColor = Color.Pink;
            AddInvoiceMenuButton.ForeColor = Color.Black;

            ManageInvoicesMenuButton.BackColor = Color.White;
            ManageInvoicesMenuButton.ForeColor = Color.Black;
        }

        private void addInvoiceUsedControl_Load(object sender, EventArgs e)
        {

        }

        private void managelnvoicesUserControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void ManageInvoicesMenuButton_Click(object sender, EventArgs e)
        {
            addInvoiceUsedControl.Hide();
            ManageInvoicesUserControl.RefreshInvoiceList();
            ManageInvoicesUserControl.Show();

            AddInvoiceMenuButton.BackColor = Color.Pink;
            AddInvoiceMenuButton.ForeColor = Color.Black;

            ManageInvoicesMenuButton.BackColor = Color.Gray;
            ManageInvoicesMenuButton.ForeColor = Color.Yellow;
        }
    }
}
