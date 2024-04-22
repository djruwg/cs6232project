using RentMe.Controller;
using RentMe.Model;

namespace RentMe.View
{
    /// <summary>
    /// Form to show rental details
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RentalDetailsForm : Form
    {
        private CartController _cartController;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalDetailsForm"/> class.
        /// </summary>
        public RentalDetailsForm()
        {
            InitializeComponent();
            this.ConfigureDataGridView();

            this._cartController = new CartController();
            DateTime pickerDate = DateTime.Now.AddDays(1);
            RentalDetailsDueDateTimePicker.MinDate = pickerDate;
            DateTime dueDate = new DateTime(pickerDate.Year, pickerDate.Month, pickerDate.Day, 23, 59, 59);
            this._cartController.SetDueDate(dueDate);
            
            RentalDetailsConfirmButton.Enabled = true;
            RentalDetailsCloseBotton.Enabled = false;
            RentalDetailsCancelButton.Enabled = true;
            RentalDetailsRentalIDTextBox.ReadOnly = true;

            this.RefeshDataGrid();
        }



        private void ConfigureDataGridView()
        {
            RentalDetailsDataGridView.AutoGenerateColumns = false;
            
            this.AddColumn("Furniture ID", "FurnitureID", true);
            this.AddColumn("Name", "Name", true);
            this.AddColumn("Description", "Description", true);
            this.AddColumn("DailyRentalRate", "DailyRentalRate", true);
            this.AddColumn("Quantity", "QuantityRentedByMember", true);
            this.AddColumn("Days Rented", "DaysRented", true);
            this.AddColumn("Cost of Rental", "RentalCost", true);

            RentalDetailsDataGridView.Columns["DailyRentalRate"].DefaultCellStyle.Format = "c";
            RentalDetailsDataGridView.Columns["RentalCost"].DefaultCellStyle.Format = "c";
        }

        private void RefeshDataGrid()
        {
            RentalDetailsDataGridView.DataSource = null; 
            RentalDetailsDataGridView.DataSource = this._cartController.LineItems();
            RentalDetailsTotalTextBox.Text = this._cartController.TotalRentalCost().ToString("C");
        }

        private void RentalDetailsCloseBotton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RentalDetailsCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RentalDetailsConfirmButton_Click(object sender, EventArgs e)
        {
            int rentalTransactionID;

            rentalTransactionID = this._cartController.SaveCartAsRentalTransaction();

            if (rentalTransactionID == -1)
            {
                RentalDetailsMessageLabel.Text = "Transaction failed, please try again or cancel";
                RentalDetailsMessageLabel.Visible = true;
            }
            else
            {
                RentalDetailsCloseBotton.Enabled = true;
                RentalDetailsConfirmButton.Enabled = false;
                RentalDetailsCancelButton.Enabled = false;
                RentalDetailsDueDateTimePicker.Enabled = false; 
                RentalDetailsMessageLabel.Text = $"Rental Transaction Successfully Saved ({rentalTransactionID})";
                RentalDetailsMessageLabel.Visible = true;
                RentalDetailsRentalIDTextBox.Text = rentalTransactionID.ToString();
            }

        }

        private void RentalDetailsDueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime pickerDate = RentalDetailsDueDateTimePicker.Value;
            DateTime dueDate = new DateTime(pickerDate.Year, pickerDate.Month, pickerDate.Day, 23, 59, 59);
            this._cartController.SetDueDate(dueDate);
            RentalDetailsMessageLabel.Visible = false;
            RefeshDataGrid();
        }

        private void AddColumn(string headerText, string properyName, bool readOnly)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = properyName;
            column.Name = properyName;
            column.HeaderText = headerText;
            column.ReadOnly = readOnly;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RentalDetailsDataGridView.Columns.Add(column);
        }
    }
}