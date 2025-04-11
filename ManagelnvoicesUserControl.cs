using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterbill
{
    public partial class ManagelnvoicesUserControl : UserControl
    {
        public ManageInvoices ListInvoices;
        public ManagelnvoicesUserControl()
        {
            InitializeComponent();
        }
        public void RefreshInvoiceList()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("No");
            dataTable.Columns.Add("Customer ID");
            dataTable.Columns.Add("Customer Name");
            dataTable.Columns.Add("Customer Tyoe");
            dataTable.Columns.Add("Last Month");
            dataTable.Columns.Add("This Month");
            dataTable.Columns.Add("Total");



            if (ListInvoices != null)
            {
                List<Invoice> invoices = ListInvoices.GetInvoices();
                int i = 1;
                foreach (Invoice invoice in invoices)
                {
                    dataTable.Rows.Add(
                      i++,
                    invoice.customerId,
                    invoice.customerName,
                    invoice.typeOfCustomer,
                    invoice.lastMonthNumber,
                    invoice.total
                    );
                    
                    
                }
            }

            invoicesDataGridView.DataSource = dataTable;

        }
    }
}
