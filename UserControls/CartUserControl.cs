using RentMe.Controller;
using RentMe.Model;
using System.Data;
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
            this.AddColumn("Quantity", "QuantityRentedByCustomer", false);
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
            CartDataGridView.DataSource = this._cartController.GetData();
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
                    int id = Int32.Parse((string)row.Cells[1].Value);
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
                int quantity = Int32.Parse((string)CartDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                DataTable dataTable = this._cartController.GetData();
                dataTable.Rows[e.RowIndex]["Quantity"] = quantity;
            }
        }
    }
}
