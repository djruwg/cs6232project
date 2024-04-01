using RentMe.Controller;
using RentMe.Model;

namespace RentMe.UserControls
{
    public partial class FurnitureSearch : UserControl
    {
        private FurnitureController _furnitureController;

        public FurnitureSearch()
        {
            InitializeComponent();
            this._furnitureController = new FurnitureController();
            FurnitureSearchSearchMessageLabel.Text = string.Empty;
        }

        private void UserControl_Resize(object sender, EventArgs e)
        {
            this.ResizeFurnitureSearchListViewColumns();
        }

        private void ResizeFurnitureSearchListViewColumns()
        {
            float[] columnWidthPercentages = { 0.05f, 0.15f, 0.2f, 0.15f, 0.15f, 0.15f, 0.15f };

            if (this.FurnitureSearchListView.Columns.Count != columnWidthPercentages.Length)
            {
                throw new ArgumentException("The number of columns in the ListView must match the number of width percentages provided.");
            }

            int totalWidth = this.FurnitureSearchListView.ClientSize.Width;
            totalWidth -= SystemInformation.VerticalScrollBarWidth;

            for (int i = 0; i < columnWidthPercentages.Length; i++)
            {
                this.FurnitureSearchListView.Columns[i].Width = (int)(totalWidth * columnWidthPercentages[i]);
            }
        }

        private void PopulateSearchListView(List<Furniture> furnitureList)
        {
            this.FurnitureSearchSearchMessageLabel.Text = string.Empty;
            this.FurnitureSearchListView.Items.Clear();
            if (furnitureList.Count > 0)
            {
                Furniture item;
                for (int i = 0; i < furnitureList.Count; i++)
                {
                    item = furnitureList[i];
                    this.FurnitureSearchListView.Items.Add(item.FurnitureID.ToString());
                    this.FurnitureSearchListView.Items[i].SubItems.Add(item.Name.ToString());
                    this.FurnitureSearchListView.Items[i].SubItems.Add(item.Description.ToString());
                    this.FurnitureSearchListView.Items[i].SubItems.Add(item.Category.ToString());
                    this.FurnitureSearchListView.Items[i].SubItems.Add(item.Style.ToString());
                    this.FurnitureSearchListView.Items[i].SubItems.Add(item.CalculateQuantityInStock().ToString());
                    this.FurnitureSearchListView.Items[i].SubItems.Add(item.DailyRentalRate.ToString("C"));
                }
            }
            else
            {
                this.FurnitureSearchSearchMessageLabel.Text = "No furniture found";
            }
        }

        /// <summary>
        /// Populates the search with all furniture.
        /// </summary>
        public void PopulateSearchWithAllFurniture()
        {
            try
            {
                this.PopulateSearchListView(this._furnitureController.GetAllFurniture());
            }
            catch (Exception ex)
            {
                FurnitureSearchSearchMessageLabel.Text = ex.Message;
            }
        }
    }
}
