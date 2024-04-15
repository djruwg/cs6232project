using System.Diagnostics;
using RentMe.Controller;

namespace RentMe.View
{
    /// <summary>
    /// Form for returning furniture.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReturnItemsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnItemsForm"/> class.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        public ReturnItemsForm(int memberID)
        {
            InitializeComponent();

            this.ConfigureDataGridView();

            ReturnItemsDataGridView.DataSource = new RentalsController().GetOutstandingRentalLineItemsByMemberID(memberID);
        }

        private void ConfigureDataGridView()
        {
            ReturnItemsDataGridView.AutoGenerateColumns = false;

            //DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn(false);
            //column.Name = "CheckBoxColumn";
            //column.HeaderText = "Selected";
            //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //ReturnItemsDataGridView.Columns.Add(column);

            this.AddColumn("Rental ID", "RentalID", true);
            this.AddColumn("Furniture ID", "FurnitureID", true);
            this.AddColumn("Name", "Name", true);
            this.AddColumn("Description", "Description", true);
            this.AddColumn("Daily Rate", "DailyRentalRate", true);
            this.AddColumn("Qty Rented", "QuantityRentedByMember", true);
            this.AddColumn("Qty Returned", "QuantityReturnedByMember", false);
            this.AddColumn("Net Cost", "NetCost", true);

            ReturnItemsDataGridView.Columns["DailyRentalRate"].DefaultCellStyle.Format = "c";
            ReturnItemsDataGridView.Columns["NetCost"].DefaultCellStyle.Format = "c";

        }

        private void AddColumn(string headerText, string properyName, bool readOnly)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = properyName;
            column.Name = properyName;
            column.HeaderText = headerText;
            column.ReadOnly = readOnly;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReturnItemsDataGridView.Columns.Add(column);
        }

        private void ReturnItemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReturnItemsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 6) return;

            if (ReturnItemsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int quantity = (int)ReturnItemsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                Debug.WriteLine($"make sure you update the proper item");
                //_cartController.LineItems().ElementAt(e.RowIndex).QuantityRentedByMember = quantity;
            }
        }

        private void ReturnItemsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 6) return;

            //CartMessageLabel.Text = string.Empty;

            //if (!int.TryParse(e.FormattedValue?.ToString(), out int newInteger) || newInteger < 0)
            //{
            //CartMessageLabel.Text = "Cell must be a positive integer";

            //e.Cancel = true;
            //}

            int rentalID = (int)ReturnItemsDataGridView.Rows[e.RowIndex].Cells[0].Value;
            int furnitureID = (int)ReturnItemsDataGridView.Rows[e.RowIndex].Cells[1].Value;


            //if (_cartController.HasNeededInventoryToSatisfyQuantityRequested(furnitureID, newInteger) == false)
            //{
            //CartMessageLabel.Text = "Insufficient inventory";

            //e.Cancel = true;
            //}
        }
    }
}
