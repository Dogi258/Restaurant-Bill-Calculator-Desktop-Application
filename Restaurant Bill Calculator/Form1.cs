using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Bill_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float subtotal;
        float tax;
        float total;

        private void AddPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Convert the price of the selected item into a float for calculation

            ComboBox obj = sender as ComboBox;
            string selected = obj.SelectedItem.ToString();
            int index = selected.IndexOf('$');
            float selectedPrice = float.Parse(selected.Substring(index + 1));

            // Calculate Subtotal, Tax, and Total
            subtotal = float.Parse(lblSubtotalPrice.Text) + selectedPrice;
            tax = subtotal * 0.08f; // Sales tax is assumed to be 8%
            total = subtotal + tax;

            // Change lables to reflect price
            lblSubtotalPrice.Text = $"{subtotal:0.00}";
            lblTaxPrice.Text = $"{tax:0.00}";
            lblTotalPrice.Text = $"{total:0.00}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear the tables bill
            total = 0; tax = 0; subtotal = 0;
            lblSubtotalPrice.Text = $"{subtotal:0.00}";
            lblTaxPrice.Text = $"{tax:0.00}";
            lblTotalPrice.Text = $"{total:0.00}";
        }
    }
}
