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

            // Load some demo data while waiting on other supporting features
            Member member = new MemberController().GetMemberByID(1);
            this._cartController.AttachedMember = member;

            this.RefreshTransactionView();

            this._cartController.AddToCart(new Furniture
            {
                FurnitureID = 7,
                Name = "Sofa",
                Description = "Fluffy Sofa",
                DailyRentalRate = 2,
                QuantityRented = 4
            });

            this._cartController.AddToCart(new Furniture
            {
                FurnitureID = 9,
                Name = "Rocking Chair",
                Description = "Wooden Rocking Chair",
                DailyRentalRate = 1,
                QuantityRented = 1
            });

            this.RefeshCartListView();
        }

        private void ClearMessages()
        {
            CartMessageLabel.Text = string.Empty;
        }

        private void RefreshTransactionView()
        {
            CartRentalIDTextBox.Text = "1";
            CartMemberIDTextBox.Text = this._cartController.AttachedMember.MemberID.ToString();
            CartFirstNameTextBox.Text = this._cartController.AttachedMember.FirstName;
            CartLastNameTextBox.Text = this._cartController.AttachedMember.LastName;
        }

        private void RefeshCartListView()
        {
            CartListView.Items.Clear();

            // This whole thing may need to be the rental transaction list items
            // since it requires the quantity rented.  How do we want to get this
            // value from the Furniture Details form?  Can pass this in as an
            // argument in AddToCart, but how do we associate it with a particular
            // furniture item to populate this list view?  Does the CartController
            // become a RentalTransactionController and I create a RentalLineItem
            // contained within a List in the RentalTransactionController?  The
            // RentalLineItem would then track a FurnitureItem and a quantity.  That
            // would be what I iterate through here.
            List<Furniture> furnitureList = this._cartController.FurnitureList;

            for (int i = 0; i < furnitureList.Count; i++)
            {
                CartListView.Items.Add(furnitureList[i].FurnitureID.ToString());
                CartListView.Items[i].SubItems.Add(furnitureList[i].Description);
                CartListView.Items[i].SubItems.Add(furnitureList[i].DailyRentalRate.ToString());
                // This is the same as the daily rental rate according to the specs right?
                CartListView.Items[i].SubItems.Add(furnitureList[i].DailyRentalRate.ToString())
                // This quantity rented is for the store.  Need to make this
                // the rental transaction's quantity for this piece of furniture.
                CartListView.Items[i].SubItems.Add(furnitureList[i].QuantityRented.ToString());
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
