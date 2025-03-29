using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterbill
{
    public partial class AddInvoiceUsedControl : UserControl
    {
        public AddInvoiceUsedControl()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string customerId = CustomerIDInput.Text;
            string customerName = CustomerNameInput.Text;
            int thismonthNumber = Convert.ToInt32(ThisMonthInput.Text);
            int lastmonthNumber = Convert.ToInt32(LastMonthInput.Text);
            string customerType = TypeOfCustomerInput.Text;
            int numberOfPeople = Convert.ToInt32(NumberOfPeopleInput.Text);
            double price = 0;
            double VATFee = 0;
            double envFee = 0;
            double subtotal = 0;
            double total = 0;
            int amountConsumption = thismonthNumber - lastmonthNumber;
            if (customerType == " Household customer")
            {
                double amouCondumptionPerPeople = amountConsumption / numberOfPeople;
                if (amouCondumptionPerPeople <= 10)
                {
                    price = 5973;
                    envFee = 597.3;
                }
                else if (amouCondumptionPerPeople <= 20)
                {
                    price = 7052;
                    envFee = 705.2;
                }
                else if (amouCondumptionPerPeople <= 30)
                {
                    price = 8699;
                    envFee = 869.9;
                }
                else if (customerType == "Administrative agency, public services")
                {
                    price = 9955;
                    envFee = 995.5;
                }
                else if (customerType == "Production units")
                {
                    price = 11615;
                    envFee = 1161.5;
                }
                else if (customerType == "Business services")
                {
                    price = 22068;
                    envFee = 2206.8;
                }
                else
                {
                    MessageBox.Show("Invalid Type of customer");
                    return;
                }
                subtotal = (amountConsumption * price) + envFee;
                VATFee = subtotal * 0.1;
                total = subtotal + VATFee;

                string invoiceId = DateTime.Now.ToFileTime().ToString();
                Invoice invoice = new Invoice(
                    customerId,
                    customerName,
                    invoiceId,
                    DateTime.Now,
                    thismonthNumber,
                    lastmonthNumber,
                    customerType,
                    numberOfPeople,
                    amountConsumption,
                    price, envFee, VATFee, subtotal, total
                    );


            }
        }

        private void AddInvoiceUsedControl_Load(object sender, EventArgs e)
        {

        }
    }
}

