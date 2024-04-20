using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Model;

namespace RentMe.View
{
    public partial class SaveReturnForm : Form
    {
        private ReturnsController returnsController;
        private ReturnTransaction returnTransaction;
        public SaveReturnForm(ReturnTransaction returnCart)
        {
            InitializeComponent();
            returnsController = new ReturnsController();
            returnTransaction = returnCart;
            double sum = 0;
            int count = 0;
            foreach (ReturnLineItem lineItem in returnTransaction.LineItems)
            {
                sum += lineItem.AmountOwed;
                count += lineItem.Quantity;
            }

            this.SaveReturnRentalIDTextBox.Text = returnTransaction.ReturnID.ToString();
            this.SaveReturnMemberIDTextBox.Text = returnTransaction.MemberID.ToString();
            this.SaveReturnEmployeeIDTextBox.Text = returnTransaction.EmployeeID.ToString();
            this.SaveReturnReturnDateDateTimePicker.Value = returnTransaction.DateReturned;
            this.SaveReturnTotalCostTextBox.Text = sum.ToString("c");
            this.SaveReturnQuantityTextBox.Text = count.ToString();
        }

        private void View_Resize(object sender, EventArgs e)
        {
            this.ResizeSaveRentalListViewColumns();
        }

        private void ResizeSaveRentalListViewColumns()
        {
            float[] columnWidthPercentages = { 0.05f, 0.15f, 0.2f, 0.15f, 0.15f, 0.15f, 0.15f };

            if (this.SaveReturnListView.Columns.Count != columnWidthPercentages.Length)
            {
                throw new ArgumentException("The number of columns in the ListView must match the number of width percentages provided.");
            }

            int totalWidth = this.SaveReturnListView.ClientSize.Width;
            totalWidth -= SystemInformation.VerticalScrollBarWidth;

            for (int i = 0; i < columnWidthPercentages.Length; i++)
            {
                this.SaveReturnListView.Columns[i].Width = (int)(totalWidth * columnWidthPercentages[i]);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            int rentalID;
            rentalID = returnsController.SaveReturnTransaction(returnTransaction);
            //TheReturnID.Text = rentalID.ToString();
        }
    }
}
