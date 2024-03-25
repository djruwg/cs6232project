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

            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn(false);
            column.Name = "CheckBoxColumn";
            column.HeaderText = "Selected";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ReturnItemsDataGridView.Columns.Add(column);

            this.AddColumn("Rental ID", "RentalID", true);
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
