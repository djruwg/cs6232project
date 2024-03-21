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
            this._cartController.AddToCart(7, 4);
            this._cartController.AddToCart(9, 4);

            this.ConfigureDataGridView();
            this.RefreshTransactionView();
            this.RefeshCartListView();
        }

        /// <summary>
        /// Updates the cart.
        /// </summary>
        public void UpdateCart()
        {
            this.ClearMessages();
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

        private void ConfigureDataGridView()
        {
            CartDataGridView.AutoGenerateColumns = false;
            // CartDataGridView.MultiSelect = true;
            // CartDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CartDataGridView.RowHeadersVisible = false;
            CartDataGridView.BackgroundColor = Color.White;

            DataGridViewCheckBoxColumn column1 = new DataGridViewCheckBoxColumn(false);
            column1.Name = "CheckBoxColumn";
            column1.HeaderText = "Selected";
            CartDataGridView.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "FurnitureID";
            column2.Name = "FurnitureID";
            column2.HeaderText = "Furniture ID";
            column2.ReadOnly = true;
            CartDataGridView.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "Quantity";
            column3.Name = "Quantity";
            column3.HeaderText = "Quantity";
            column3.ReadOnly = false;
            CartDataGridView.Columns.Add(column3);
        }

        private void RefeshCartListView()
        {            
            CartDataGridView.DataSource = null;
            CartDataGridView.DataSource = this._cartController.GetRentalTransaction.RentalLineItems;
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

        private void CartRemoveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in CartDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    int id = (int)row.Cells[1].Value;
                    this._cartController.RemoveFromCart(id);
                }
            }

            this.RefeshCartListView();
        }

        private void CartNewCartButton_Click(object sender, EventArgs e)
        {
            this._cartController.ClearCart();
            this._cartController.AttachedMember = new Member();
            this.ClearMessages();
            this.RefreshTransactionView();
            this.RefeshCartListView();
        }

        private void CartDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = CartDataGridView.SelectedRows;
            Debug.WriteLine("Call Furniture Details Form: " + e.RowIndex);
        }

        private void CartDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 2) return;

            if (CartDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int quantity = (int)CartDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                this._cartController.GetRentalTransaction.RentalLineItems[e.RowIndex].Quantity = quantity;
            }
        }
    }
}
