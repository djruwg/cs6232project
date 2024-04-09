namespace RentMe.View
{
    /// <summary>
    /// Form to Show Furniture 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ShowFurnitureForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowFurnitureForm"/> class.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        public ShowFurnitureForm(int furnitureID)
        {
            InitializeComponent();
            this.ShowFurnitureFurnitureShowUserControl.SetFurniture(furnitureID);
        }

        /// <summary>
        /// Gets the added to cart text.
        /// </summary>
        /// <returns>String to update the label on parent</returns>
        public string GetAddedToCartText()
        {
            return this.ShowFurnitureFurnitureShowUserControl._addToCartText;
        }
    }
}
