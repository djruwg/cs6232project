using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class ShowReturnReceiptForm : Form
    {
        private ReturnsController returnsController;
        private ReturnTransaction returnTransaction;

        public ShowReturnReceiptForm(int returnID)
        {
            InitializeComponent();
            //returnsController = new ReturnsController();
            //returnTransaction = returnCart;
            //double sum = 0;
            //int count = 0;
            //foreach (ReturnLineItem lineItem in returnTransaction.LineItems)
            //{
            //    sum += lineItem.AmountOwed;
            //    count += lineItem.Quantity;
            //}

            //this.PopulateLineItemListView();
            //this.ResizeSaveRentalListViewColumns();
            this.ShowReturnReceiptRentalIDTextBox.Text = returnID.ToString();
            //this.SaveReturnMemberIDTextBox.Text = returnTransaction.MemberID.ToString();
            //this.SaveReturnEmployeeIDTextBox.Text = returnTransaction.EmployeeID.ToString();
            //this.SaveReturnReturnDateDateTimePicker.Value = returnTransaction.DateReturned;
            //this.SaveReturnTotalCostTextBox.Text = sum.ToString("c");
            //this.SaveReturnQuantityTextBox.Text = count.ToString();
        }

        private void ShowReturnReceiptCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
