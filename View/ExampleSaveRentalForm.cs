using RentMe.Controller;
using RentMe.Model;

namespace RentMe.View
{
    public partial class ExampleSaveRentalForm : Form
    {
        private ReturnsController returnsController;
        private ReturnTransaction returnTransaction;
        public ExampleSaveRentalForm(ReturnTransaction returnCart)
        {
            InitializeComponent();
            returnsController = new ReturnsController();
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
            int rentalID;
            rentalID = returnsController.SaveReturnTransaction(returnTransaction);
            TheReturnID.Text = rentalID.ToString();
        }
    }
}
