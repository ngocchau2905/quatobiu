using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterbill
{
    public class ManageInvoices
    {
        List<Invoice> invoices;
        public ManageInvoices()
        {
            invoices = new List<Invoice>(); 
        }
        public void AddInvoice(Invoice invoice)
        { 
            invoices.Add(invoice); 
        }
        public List<Invoice> GetInvoices()
        {
            return invoices;
        }
    }
}
