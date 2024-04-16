using System.Diagnostics;
using System.Numerics;
using RentMe.Controller;
using RentMe.Model;

namespace RentMe.View
{
    /// <summary>
    /// Form for returning furniture.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReturnItemsForm : Form
    {
        private ReturnTransaction returnTransaction;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnItemsForm"/> class.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        public ReturnItemsForm(int memberID)
        {
            InitializeComponent();

            this.ConfigureDataGridView();

            returnTransaction = new ReturnsController().GetReturnableForMember(memberID);

            ReturnItemsDataGridView.DataSource = returnTransaction.LineItems;
            //ReturnItemsDataGridView.DataSource = new RentalsController().GetOutstandingRentalLineItemsByMemberID(memberID);
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
            this.AddColumn("Qty Rented", "QuantityOutStanding", true);
            this.AddColumn("Qty Returned", "Quantity", false);
            this.AddColumn("Net Cost", "AmountOwed", true);

            ReturnItemsDataGridView.Columns["DailyRentalRate"].DefaultCellStyle.Format = "c";
            ReturnItemsDataGridView.Columns["AmountOwed"].DefaultCellStyle.Format = "c";

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

        private void RefreshDataGridView()
        {
            ReturnItemsDataGridView.DataSource = null;
            ReturnItemsDataGridView.DataSource = returnTransaction.LineItems;
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
                Debug.WriteLine($"testing: {returnTransaction.LineItems[e.RowIndex].Quantity}");
            }
        }

        private void ReturnItemsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 6) return;

            ReturnItemsFormLabel.Visible = false;

            int.TryParse(e.FormattedValue?.ToString(), out int newValue);
            int.TryParse(ReturnItemsDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString(), out int maxValue);

            if (newValue > maxValue)
            {
                ReturnItemsFormLabel.Text = "Can't return more than is outstanding";
                ReturnItemsFormLabel.Visible = true;
                e.Cancel = true;

            }

            if (!int.TryParse(e.FormattedValue?.ToString(), out int newInteger) || newInteger < 0)
            {
                ReturnItemsFormLabel.Text = "Cell must be a positive integer";
                ReturnItemsFormLabel.Visible = true;
                e.Cancel = true;
            }
            
        }
    }
}
