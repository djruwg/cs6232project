using RentMe.Controller;
using RentMe.Model;

namespace RentMe.UserControls
{
    public partial class FurnitureShow : UserControl
    {
        private FurnitureController _furnitureController;
        private Furniture _furniture;
        private CartController _cartController;
        public string _addToCartText;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureShow"/> class.
        /// </summary>
        public FurnitureShow()
        {
            InitializeComponent();
            this._furnitureController = new FurnitureController();
            this._cartController = new CartController();
            this._addToCartText = string.Empty;
        }

        /// <summary>
        /// Sets the furniture.
        /// </summary>
        /// <param name="furnitureId">The furniture identifier.</param>
        /// <exception cref="System.InvalidOperationException">No furniture was found with the given furniture ID.</exception>
        public void SetFurniture(int furnitureId)
        {
            this._furniture = this._furnitureController.GetFurnitureByID(furnitureId);

            this.ClearMessageLabel();

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

        private void FurnitureShowAddToCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = (int) this.FurnitureShowQuantityNumericUpDown.Value;
                
                // Should no longer need this since AddToCart returns true if sufficient inventory
                // int inStock = this._furniture.CalculateQuantityInStock();

                if (quantity <= 0)
                {
                    this.FurnitureShowErrorMessageLabel.Text = "Must add 1 or more items to cart";
                }
                else if (this._cartController.AddToCart(this._furniture.FurnitureID, quantity))
                {
                    this._addToCartText = quantity + " x " + this._furniture.Name + " added to cart";
                    ParentForm?.Close();
                }
                else
                {
                    this.FurnitureShowErrorMessageLabel.Text = "Not enough items in stock";
                }
            }
            catch
            {
                this.FurnitureShowErrorMessageLabel.Text = "Not a valid quantity";
            }
        }

        private void ClearMessageLabel_ChangeValue(object sender, EventArgs e)
        {
            this.ClearMessageLabel();
        }

        private void ClearMessageLabel()
        {
            this.FurnitureShowErrorMessageLabel.Text = string.Empty;
        }
    }
}
