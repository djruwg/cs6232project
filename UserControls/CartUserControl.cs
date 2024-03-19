using RentMe.Controller;
using RentMe.Model;
using System.Diagnostics;

namespace RentMe.UserControls
{
    public partial class CartUserControl : UserControl
    {
        private CartController _cartController;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartUserControl"/> class.
        /// </summary>
        public CartUserControl()
        {
            InitializeComponent();

            this.ClearMessages();

            this._cartController = new CartController();

            // Load some demo data while waiting on other supporting forms.
            Member member = new MemberController().GetMemberByID(1);
            this._cartController.AttachedMember = member;
            this._cartController.AddToCart(7, 4);
            this._cartController.AddToCart(9, 4);

            this.RefreshTransactionView();
            this.RefeshCartListView();
        }

        private void ClearMessages()
        {
            CartMessageLabel.Text = string.Empty;
        }

        private void RefreshTransactionView()
        {
            // Can this be eliminated, since we don't have the ID until the database assigns one?
            CartRentalIDTextBox.Text = this._cartController.GetRentalTransaction.RentalID.ToString();
            CartMemberIDTextBox.Text = this._cartController.AttachedMember.MemberID.ToString();
            CartFirstNameTextBox.Text = this._cartController.AttachedMember.FirstName;
            CartLastNameTextBox.Text = this._cartController.AttachedMember.LastName;
        }

        private void RefeshCartListView()
        {
            CartListView.Items.Clear();

            List<RentalLineItem> lineItems = this._cartController.GetRentalTransaction.RentalLineItems;

            for (int i = 0; i < lineItems.Count; i++)
            {
                // Call this once the FurnitureController exists:
                // Furniture furniture = this._furnitureController.GetFurnitureByID(id);

                CartListView.Items.Add(lineItems[i].FurnitureID.ToString());
                CartListView.Items[i].SubItems.Add(""); // furniture.Description
                CartListView.Items[i].SubItems.Add(""); // furniture.DailyRentalRate.ToString()
                // This is the same as the daily rental rate according to the specs right?
                CartListView.Items[i].SubItems.Add(""); // furniture.DailyRentalRate.ToString()
                CartListView.Items[i].SubItems.Add(lineItems[i].Quantity.ToString());
            }

            CartListView.Columns[0].Width = -2;
            CartListView.Columns[1].Width = -2;
            CartListView.Columns[2].Width = -2;
            CartListView.Columns[3].Width = -2;
            CartListView.Columns[4].Width = -2;

            // CartListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void CartRentItemsButton_Click(object sender, EventArgs e)
        {
            this.ClearMessages();

            if (this._cartController.AttachedMember.MemberID == 0)
            {
                CartMessageLabel.Text = "You must attach a member to the transaction.";
                return;
            }
        }

        private void CartListView_ItemActivate(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = CartListView.SelectedItems;

            // Call the "Furniture Details" form to update quantity.
            Debug.WriteLine("Call Furniture Details Form: " + items[0]);
        }

        private void CartRemoveButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = CartListView.SelectedItems;

            foreach (ListViewItem item in items)
            {
                int id = int.Parse(item.SubItems[0].Text);
                this._cartController.RemoveFromCart(id);
            }

            this.RefeshCartListView();
        }

        private void CartCancelButton_Click(object sender, EventArgs e)
        {
            this._cartController.ClearCart();
            this._cartController.AttachedMember = new Member();
            this.ClearMessages();
            this.RefreshTransactionView();
            this.RefeshCartListView();
        }
    }
}
