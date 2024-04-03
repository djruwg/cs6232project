using RentMe.Model;
using System.ComponentModel;
using System.Data;

namespace RentMe.Controller
{
    /// <summary>
    /// Manages the cart.
    /// </summary>
    internal class CartController
    {
        private static RentalTransaction? _rentalTransaction;
        private static Member? _attachedMember;
        private FurnitureController _furnitureController;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartController"/> class.
        /// </summary>
        public CartController()
        {
            _rentalTransaction ??= new RentalTransaction();
            _attachedMember ??= new Member();
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
            _rentalTransaction!.AddLineItem(furnitureID, quantity);
        }

        /// <summary>
        /// Returns the transaction line items for this cart.
        /// </summary>
        /// <returns></returns>
        public BindingList<RentalLineItem> LineItems()
        {
            return _rentalTransaction!.RentalLineItems;
        }

        /// <summary>
        /// Removes transaciton line items from cart.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        public void RemoveFromCart(int furnitureID)
        {
            _rentalTransaction!.RemoveLineItem(furnitureID);
        }

        /// <summary>
        /// Clears the cart.
        /// </summary>
        public void ClearCart()
        {
            _attachedMember = new Member();
            _rentalTransaction!.ClearLineItems();
        }
    }
}
