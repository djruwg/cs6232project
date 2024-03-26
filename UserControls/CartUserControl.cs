using RentMe.Controller;
using RentMe.Model;
using System.Diagnostics;
using System.Windows.Forms;


namespace RentMe.UserControls
{
    /// <summary>
    /// Provides a cart user control.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
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
            this._cartController.AddToCart(9, 2);
            this._cartController.AddToCart(5, 3);

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
            CartMemberIDTextBox.Text = this._cartController.AttachedMember.MemberID.ToString();
            CartFirstNameTextBox.Text = this._cartController.AttachedMember.FirstName;
            CartLastNameTextBox.Text = this._cartController.AttachedMember.LastName;
        }

        private void ConfigureDataGridView()
        {
            CartDataGridView.AutoGenerateColumns = false;

            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn(false);
            column.Name = "CheckBoxColumn";
            column.HeaderText = "Selected";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            CartDataGridView.Columns.Add(column);

            this.AddColumn("Furniture ID", "FurnitureID", true);
            this.AddColumn("Name", "Name", true);
            this.AddColumn("Description", "Description", true);
            this.AddColumn("DailyRentalRate", "DailyRentalRate", true);
            this.AddColumn("Quantity", "QuantityRentedByMember", false);

            CartDataGridView.Columns["DailyRentalRate"].DefaultCellStyle.Format = "c";
        }

        private void AddColumn(string headerText, string properyName, bool readOnly)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = properyName;
            column.Name = properyName;
            column.HeaderText = headerText;
            column.ReadOnly = readOnly;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CartDataGridView.Columns.Add(column);
        }

        private void RefeshCartListView()
        {
            CartDataGridView.DataSource = null;
            CartDataGridView.DataSource = this._cartController.LineItems();
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
            if (e.RowIndex < 0 || e.ColumnIndex != 5) return;

            if (CartDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int quantity = (int)CartDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                _cartController.LineItems().ElementAt(e.RowIndex).QuantityRentedByMember = quantity;
            }
        }

        private void CartDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 5) return;

            if (!int.TryParse(e.FormattedValue?.ToString(), out int newInteger) || newInteger < 0)
            {
                e.Cancel = true;
            }
        }
    }
}
