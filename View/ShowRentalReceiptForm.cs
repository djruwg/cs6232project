using RentMe.Controller;
using RentMe.Model;

namespace RentMe.View
{
    /// <summary>
    /// Show a rental receipt
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ShowRentalReceiptForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowRentalReceiptForm"/> class.
        /// </summary>
        /// <param name="rentalID">The rental identifier.</param>
        public ShowRentalReceiptForm(int rentalID)
        {
            InitializeComponent();


            // Fix going through a controler


            RentalTransaction displayRentalTransaction;
            RentalsController rentalsController = new RentalsController();

            displayRentalTransaction = rentalsController.GetRentalTransactionByRentalID(rentalID);

            ShowRentalReceiptRentalIDTextBox.Text = displayRentalTransaction.RentalID.ToString();
            ShowRentalReceiptDateDueDatePicker.Value = displayRentalTransaction.DateDue;    
            ShowRentalReceiptDateRentedDatePicker.Value = displayRentalTransaction.DateRented;

            ConfigureDataGridView();
            LoadDataGridView(displayRentalTransaction);
            ShowRentalReceiptTotalCostTextBox.Text = displayRentalTransaction.TotalRentalCost.ToString("C");
        }

        private void ConfigureDataGridView()
        {
            ShowRentalReceiptDataGridView.AutoGenerateColumns = false;

            this.AddColumn("Furniture ID", "FurnitureID", true);
            this.AddColumn("Name", "Name", true);
            this.AddColumn("Description", "Description", true);
            this.AddColumn("DailyRentalRate", "DailyRentalRate", true);
            this.AddColumn("Quantity", "QuantityRentedByMember", true);
            this.AddColumn("Days Rented", "DaysRented", true);
            this.AddColumn("Cost of Rental", "RentalCost", true);

            ShowRentalReceiptDataGridView.Columns["DailyRentalRate"].DefaultCellStyle.Format = "c";
            ShowRentalReceiptDataGridView.Columns["RentalCost"].DefaultCellStyle.Format = "c";
        }

        private void LoadDataGridView(RentalTransaction displayRentalTransaction)
        {
            ShowRentalReceiptDataGridView.DataSource = displayRentalTransaction.RentalLineItems;
        }

        private void AddColumn(string headerText, string properyName, bool readOnly)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = properyName;
            column.Name = properyName;
            column.HeaderText = headerText;
            column.ReadOnly = readOnly;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ShowRentalReceiptDataGridView.Columns.Add(column);
        }

        private void ShowRentalReceiptCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
