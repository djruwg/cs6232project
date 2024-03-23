using RentMe.Controller;

namespace RentMe.View
{
    public partial class ReturnItemsForm : Form
    {
        public ReturnItemsForm(int memberID)
        {
            InitializeComponent();

            this.ConfigureDataGridView();

            ReturnItemsDataGridView.DataSource = new RentalsController().GetRentalLineItemsByMemberID(memberID).GetDataTable();
        }

        private void ConfigureDataGridView()
        {
            ReturnItemsDataGridView.AutoGenerateColumns = false;

            this.AddColumn("Furniture ID", "FurnitureID", true);
            this.AddColumn("Name", "Name", true);
            this.AddColumn("Description", "Description", true);
            this.AddColumn("DailyRentalRate", "RailyRentalDate", true);
            this.AddColumn("Quantity", "Quantity", false);
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
