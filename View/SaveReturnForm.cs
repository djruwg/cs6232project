using RentMe.Controller;
using RentMe.Model;

namespace RentMe.View
{
    public partial class SaveReturnForm : Form
    {
        private ReturnsController returnsController;
        private ReturnTransaction returnTransaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveReturnForm"/> class.
        /// </summary>
        /// <param name="returnCart">The return cart.</param>
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

            this.PopulateLineItemListView();
            this.ResizeSaveRentalListViewColumns();
            this.SaveReturnRentalIDTextBox.Text = "Set on Save";
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
            float[] columnWidthPercentages = { 0.15f, 0.15f, 0.2f, 0.15f, 0.15f, 0.15f, 0.15f };

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

        private void PopulateLineItemListView()
        {
            this.SaveReturnListView.Items.Clear();
            int rowNumber = 0;
            foreach (ReturnLineItem lineItem in this.returnTransaction.LineItems)
            {
                this.SaveReturnListView.Items.Add(lineItem.RentalID.ToString());
                this.SaveReturnListView.Items[rowNumber].SubItems.Add(lineItem.FurnitureID.ToString());
                this.SaveReturnListView.Items[rowNumber].SubItems.Add(lineItem.Name.ToString());
                this.SaveReturnListView.Items[rowNumber].SubItems.Add(lineItem.Description.ToString());
                this.SaveReturnListView.Items[rowNumber].SubItems.Add(lineItem.DailyRentalRate.ToString("c"));
                this.SaveReturnListView.Items[rowNumber].SubItems.Add(lineItem.Quantity.ToString());
                this.SaveReturnListView.Items[rowNumber].SubItems.Add(lineItem.AmountOwed.ToString("c"));
                rowNumber++;
            }
        }

        private void SaveReturnCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveReturnSaveButton_Click(object sender, EventArgs e)
        {
            returnsController.SaveReturnTransaction(returnTransaction);
            DialogResult = DialogResult.OK; 
            Close();
        }
    }
}
