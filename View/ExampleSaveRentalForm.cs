using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Model;

namespace RentMe.View
{
    public partial class ExampleSaveRentalForm : Form
    {
        private ReturnTransaction returnTransaction;
        public ExampleSaveRentalForm(ReturnTransaction returnCart)
        {
            InitializeComponent();
            returnTransaction = returnCart;
            double sum = 0;
            foreach (ReturnLineItem lineItem in returnTransaction.LineItems)
            {
                sum += lineItem.AmountOwed;
            }
            TheSum.Text = sum.ToString();
            TheReturnID.Text = returnTransaction.ReturnID.ToString();
            TheCount.Text = returnTransaction.LineItems.Count().ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
