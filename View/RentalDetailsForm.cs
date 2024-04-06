using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using RentMe.Controller;
using RentMe.Model;

namespace RentMe.View
{
    public partial class RentalDetailsForm : Form
    {
        private CartController _cartController;
        private RentalTransaction rentalTransaction;

        public RentalDetailsForm()
        {
            InitializeComponent();
            this._cartController = new CartController();
            RentalDetailsDueDateTimePicker.MinDate = DateTime.Now.AddDays(1);
            this._cartController.SetDueDate(RentalDetailsDueDateTimePicker.Value);
            RentalDetailsConfirmButton.Enabled = true;
            RentalDetailsCloseBotton.Enabled = false;
            RentalDetailsCancelButton.Enabled = true;
            RentalDetailsRentalIDTextBox.ReadOnly = true;

            this.ConfigureDataGridView();
            this.RefeshCartListView();
        }



        private void ConfigureDataGridView()
        {
            RentalDetailsDataGridView.AutoGenerateColumns = false;

            this.AddColumn("XFurniture ID", "FurnitureID", true);
            this.AddColumn("XName", "Name", true);
            this.AddColumn("XDescription", "Description", true);
            this.AddColumn("XDailyRentalRate", "DailyRentalRate", true);
            this.AddColumn("XQuantity", "QuantityRentedByMember", true);
            this.AddColumn("XDays Rented", "DaysRented", true);
            this.AddColumn("XCost of Rental", "RentalCost", true);

            RentalDetailsDataGridView.Columns["DailyRentalRate"].DefaultCellStyle.Format = "c";
            RentalDetailsDataGridView.Columns["RentalCost"].DefaultCellStyle.Format = "c";
            RentalDetailsDataGridView.Columns["XCost of Rental"].DefaultCellStyle.Format = "c";


        }

        private void RefeshCartListView()
        {
            RentalDetailsDataGridView.DataSource = null; 
            RentalDetailsDataGridView.DataSource = this._cartController.LineItems();
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
                // log error
            }
            else
            {
                RentalDetailsCloseBotton.Enabled = true;
                RentalDetailsCancelButton.Enabled = false;
            }

        }

        private void RentalDetailsDueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this._cartController.SetDueDate(RentalDetailsDueDateTimePicker.Value);
            RefeshCartListView();
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