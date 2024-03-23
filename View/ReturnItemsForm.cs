using RentMe.Controller;
using System.Data;

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

            /*
             * Select filters the data table by outstanding rentals and
             * returns a Row, which we convert back to a DataTable as a
             * data source.
             */
            ReturnItemsDataGridView.DataSource = new RentalsController()
                .GetRentalLineItemsByMemberID(memberID)
                .GetDataTable()
                .Select("QuantityReturnedByMember < QuantityRentedByMember")
                .CopyToDataTable();
        }

        private void ConfigureDataGridView()
        {
            ReturnItemsDataGridView.AutoGenerateColumns = false;

            this.AddColumn("Furniture ID", "FurnitureID", true);
            this.AddColumn("Name", "Name", true);
            this.AddColumn("Description", "Description", true);
            this.AddColumn("DailyRentalRate", "DailyRentalRate", true);
            this.AddColumn("QuantityRentedByMember", "QuantityRentedByMember", true);
            this.AddColumn("QuantityReturnedByMember", "QuantityReturnedByMember", false);

            ReturnItemsDataGridView.Columns["DailyRentalRate"].DefaultCellStyle.Format = "c";
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
