using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterbill
{
    public partial class AddInvoiceUsedControl : UserControl
    {
        public ManageInvoices ListInvoice;
        public AddInvoiceUsedControl()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string customerId = CustomerIDInput.Text.Trim();
            if (String.IsNullOrEmpty(customerId))
            {
                MessageBox.Show("Customer ID cannot be empty.Please enter a vaild.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string customerName = CustomerNameInput.Text;
            int thisMonthNumber, lastMonthNumber;
            try
            {
                thisMonthNumber = Convert.ToInt32(ThisMonthInput.Text);
                lastMonthNumber = Convert.ToInt32(LastMonthInput.Text);
                if (lastMonthNumber > thisMonthNumber)
                {
                    MessageBox.Show("Last Month Number cannot be greater than This Month Number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Both months must be valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int NumberOfPeople = 0;
            try
            {
                NumberOfPeople = Convert.ToInt32(NumberOfPeopleInput.Text);
                if (NumberOfPeople <= 0)
                {
                    MessageBox.Show("Number of People must be greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Number of People must be a vaild number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string customerType = TypeOfCustomerInput.Text;
            double price = 0;
            double VATFee = 0;
            double envFee = 0;
            double subtotal = 0;
            double total = 0;

            int amountConsumption = thisMonthNumber - lastMonthNumber;
            if (customerType == "Household customer")
            {
                double amouCondumptionPerPeople = amountConsumption / (double)NumberOfPeople;
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
                else
                {
                    price = 15929;
                    envFee = 1592.9;
                }
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
                MessageBox.Show("Invalid Type of customer", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                thisMonthNumber,
                lastMonthNumber,
                customerType,
                NumberOfPeople,
                amountConsumption,
                price, envFee, VATFee, subtotal, total
                );

            ListInvoice.AddInvoice( invoice );

            resultSubtotal.Text = Math.Round(subtotal, 2).ToString();
            resultEnvFee.Text = Math.Round(envFee, 2).ToString();
            resultVATFee.Text = Math.Round(VATFee, 2).ToString();
            resultTotal.Text = Math.Round(total, 2).ToString();
        }
    }
}

            



           
        


       
