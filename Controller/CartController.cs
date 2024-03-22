using RentMe.Model;
using System.Data;

namespace RentMe.Controller
{
    /// <summary>
    /// Manages the cart.
    /// </summary>
    internal class CartController
    {
        private static Cart? _cartDataTable;
        private static Member? _attachedMember;
        private FurnitureController _furnitureController;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartController"/> class.
        /// </summary>
        public CartController()
        {
            _cartDataTable = new Cart();
            _attachedMember = new Member();
            this._furnitureController = new FurnitureController();
        }

        /// <summary>
        /// Gets or sets the attached member.
        /// </summary>
        /// <value>
        /// The attached member.
        /// </value>
        public Member AttachedMember
        {
            get => _attachedMember!;
            set => _attachedMember = value ?? new Member();
        }

        /// <summary>
        /// Adds to cart.
        /// </summary>
        /// <param name="furniture">The furniture.</param>
        public void AddToCart(int furnitureID, int quantity)
        {
            Furniture furniture = this._furnitureController.GetFurnitureByID(furnitureID);

            ArgumentNullException.ThrowIfNull(furniture);

            _cartDataTable!.AddRow(furniture, quantity);
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            return _cartDataTable!.GetData();
        }

        /// <summary>
        /// Removes from cart.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        public void RemoveFromCart(int furnitureID)
        {
            _cartDataTable!.RemoveRow(furnitureID);
        }

        /// <summary>
        /// Clears the cart.
        /// </summary>
        public void ClearCart()
        {
            _attachedMember = new Member();
            _cartDataTable!.ClearRows();
        }
    }
}
