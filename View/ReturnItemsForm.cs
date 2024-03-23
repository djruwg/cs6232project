using RentMe.Controller;
using System.Data;
using System.Diagnostics;

namespace RentMe.View
{
    public partial class ReturnItemsForm : Form
    {
        public ReturnItemsForm(int memberID)
        {
            InitializeComponent();

            this.ConfigureDataGridView();

            /*
             * Select filters the data table by outstanding rentals and
             * returns a Row, which we convert back to a DataTable as a
             * data source.
             */
            ReturnItemsDataGridView.DataSource = new RentalsController()
                .GetRentalLineItemsByMemberID(memberID)
                .GetDataTable()
                .Select("QuantityReturnedByCustomer < QuantityRentedByCustomer")
                .CopyToDataTable();
        }

        private void ConfigureDataGridView()
        {
            ReturnItemsDataGridView.AutoGenerateColumns = false;

            this.AddColumn("Furniture ID", "FurnitureID", true);
            this.AddColumn("Name", "Name", true);
            this.AddColumn("Description", "Description", true);
            this.AddColumn("DailyRentalRate", "RailyRentalDate", true);
            this.AddColumn("QuantityRentedByCustomer", "QuantityRentedByCustomer", true);
            this.AddColumn("QuantityReturnedByCustomer", "QuantityReturnedByCustomer", false);
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
    }
}
