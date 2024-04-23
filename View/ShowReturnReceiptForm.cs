using RentMe.Controller;
using RentMe.Model;

namespace RentMe.View
{
    /// <summary>
    /// Form for displaying the return transaction receipt.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ShowReturnReceiptForm : Form
    {
        private ReturnsController returnsController;
        private ReturnTransaction returnTransaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShowReturnReceiptForm"/> class.
        /// </summary>
        /// <param name="returnID">The return identifier.</param>
        public ShowReturnReceiptForm(int returnID)
        {
            InitializeComponent();
            returnsController = new ReturnsController();
            returnTransaction = returnsController.GetReturnTransactionByReturnID(returnID);
            double sum = 0;
            int count = 0;
            foreach (ReturnLineItem lineItem in returnTransaction.LineItems)
            {
                sum += lineItem.AmountOwed;
                count += lineItem.Quantity;
            }

            this.PopulateLineItemListView();
            this.ResizeSaveRentalListViewColumns();
            this.ShowReturnReceiptRentalIDTextBox.Text = returnID.ToString();
            this.ShowReturnReceiptMemberIDTextBox.Text = returnTransaction.MemberID.ToString();
            this.ShowReturnReceiptEmployeeIDTextBox.Text = returnTransaction.EmployeeID.ToString();
            this.ShowReturnReceiptReturnDateDateTimePicker.Value = returnTransaction.DateReturned;
            this.ShowReturnReceiptTotalCostTextBox.Text = sum.ToString("c");
            this.ShowReturnReceiptQuantityTextBox.Text = count.ToString();
        }

        private void View_Resize(object sender, EventArgs e)
        {
            this.ResizeSaveRentalListViewColumns();
        }

        private void ResizeSaveRentalListViewColumns()
        {
            float[] columnWidthPercentages = { 0.15f, 0.15f, 0.2f, 0.15f, 0.15f, 0.15f, 0.15f };

            if (this.ShowReturnReceiptListView.Columns.Count != columnWidthPercentages.Length)
            {
                throw new ArgumentException("The number of columns in the ListView must match the number of width percentages provided.");
            }

            int totalWidth = this.ShowReturnReceiptListView.ClientSize.Width;
            totalWidth -= SystemInformation.VerticalScrollBarWidth;

            for (int i = 0; i < columnWidthPercentages.Length; i++)
            {
                this.ShowReturnReceiptListView.Columns[i].Width = (int)(totalWidth * columnWidthPercentages[i]);
            }
        }

        private void PopulateLineItemListView()
        {
            this.ShowReturnReceiptListView.Items.Clear();
            int rowNumber = 0;
            foreach (ReturnLineItem lineItem in this.returnTransaction.LineItems)
            {
                this.ShowReturnReceiptListView.Items.Add(lineItem.RentalID.ToString());
                this.ShowReturnReceiptListView.Items[rowNumber].SubItems.Add(lineItem.FurnitureID.ToString());
                this.ShowReturnReceiptListView.Items[rowNumber].SubItems.Add(lineItem.Name.ToString());
                this.ShowReturnReceiptListView.Items[rowNumber].SubItems.Add(lineItem.Description.ToString());
                this.ShowReturnReceiptListView.Items[rowNumber].SubItems.Add(lineItem.DailyRentalRate.ToString("c"));
                this.ShowReturnReceiptListView.Items[rowNumber].SubItems.Add(lineItem.Quantity.ToString());
                this.ShowReturnReceiptListView.Items[rowNumber].SubItems.Add(lineItem.AmountOwed.ToString("c"));
                rowNumber++;
            }
        }

        private void ShowReturnReceiptCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
