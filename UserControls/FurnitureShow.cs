using RentMe.Controller;
using RentMe.Model;

namespace RentMe.UserControls
{
    public partial class FurnitureShow : UserControl
    {
        private FurnitureController _furnitureController;
        private Furniture _furniture;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureShow"/> class.
        /// </summary>
        public FurnitureShow()
        {
            InitializeComponent();
            this._furnitureController = new FurnitureController();
        }

        /// <summary>
        /// Sets the furniture.
        /// </summary>
        /// <param name="furnitureId">The furniture identifier.</param>
        /// <exception cref="System.InvalidOperationException">No furniture was found with the given furniture ID.</exception>
        public void SetFurniture(int furnitureId)
        {
            this._furniture = this._furnitureController.GetFurnitureByID(furnitureId);

            if (this._furniture == null)
            {
                throw new InvalidOperationException("No furniture was found with the given furniture ID.");
            }

            this.FurnitureShowIDTextBox.Text = this._furniture.FurnitureID.ToString();
            this.FurnitureShowNameTextBox.Text = this._furniture.Name;
            this.FurnitureShowDescriptionTextBox.Text = this._furniture.Description;
            this.FurnitureShowCategoryTextBox.Text = this._furniture.Category;
            this.FurnitureShowStyleTextBox.Text = this._furniture.Style;
            this.FurnitureShowOwnedTextBox.Text = this._furniture.QuantityOwned.ToString();
            this.FurnitureShowRentedTextBox.Text = this._furniture.QuantityRented.ToString();
            this.FurnitureShowInStockTextBox.Text = this._furniture.CalculateQuantityInStock().ToString();
            this.FurnitureShowDailyRateTextBox.Text = this._furniture.DailyRentalRate.ToString("C");
        }

        private void FurnitureShowCancelButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
