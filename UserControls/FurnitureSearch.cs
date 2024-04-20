using RentMe.Controller;
using RentMe.Model;
using RentMe.View;

namespace RentMe.UserControls
{
    /// <summary>
    /// User control to search Furniture
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class FurnitureSearch : UserControl
    {
        private FurnitureController _furnitureController;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureSearch"/> class.
        /// </summary>
        public FurnitureSearch()
        {
            InitializeComponent();
            this._furnitureController = new FurnitureController();
            this.FurnitureSearchSearchMessageLabel.ForeColor = Color.Red;
            FurnitureSearchSearchMessageLabel.Text = string.Empty;
        }

        private void UserControl_Resize(object sender, EventArgs e)
        {
            this.ResizeFurnitureSearchListViewColumns();
        }

        private void FurnitureSearchListView_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                ShowFurnitureForm showFurnitureForm =
                    new ShowFurnitureForm(Int32.Parse(this.FurnitureSearchListView.SelectedItems[0].Text));
                DialogResult result = showFurnitureForm.ShowDialog();
                this.PopulateSearchListView(this._furnitureController.GetSearchedFurniture(string.Empty));

                if (result == DialogResult.Continue)
                {
                    // This isn't great, since it ties the user control to the main window
                    MainDashboard mainDashboard = (MainDashboard)this.ParentForm!;
                    mainDashboard?.SelectCartTab();
                }
                this.FurnitureSearchSearchMessageLabel.ForeColor = Color.Green;
                this.FurnitureSearchSearchMessageLabel.Text = showFurnitureForm.GetAddedToCartText();
            }
            catch
            {
                this.FurnitureSearchSearchMessageLabel.ForeColor = Color.Red;
                this.FurnitureSearchSearchMessageLabel.Text = "Failed to open selected furniture";
            }
        }

        private void ResizeFurnitureSearchListViewColumns()
        {
            float[] columnWidthPercentages = { 0.10f, 0.10f, 0.15f, 0.20f, 0.15f, 0.15f, 0.15f };

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

        private void FurnitureSearchSearchButton_Click(object sender, EventArgs e)
        {
            this.SearchFurniture();
        }

        private void SearchFurniture()
        {
            string searchString = this.FurnitureSearchSearchTextBox.Text;
            this.PopulateSearchListView(this._furnitureController.GetSearchedFurniture(searchString));
        }

        private void PopulateSearchListView(List<Furniture> furnitureList)
        {
            this.FurnitureSearchSearchMessageLabel.ForeColor = Color.Red;
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
