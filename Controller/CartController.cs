using RentMe.Model;
using System.ComponentModel;

namespace RentMe.Controller
{
    internal class CartController
    {
        private static RentalTransaction _rentalTransaction;
        private static Member _attachedMember;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartController"/> class.
        /// </summary>
        public CartController()
        {
            CartController._rentalTransaction = new RentalTransaction();
            CartController._attachedMember = new Member();
        }

        public RentalTransaction GetRentalTransaction
        {
            get => CartController._rentalTransaction;
        }

        /// <summary>
        /// Gets the furniture list.
        /// </summary>
        /// <value>
        /// The furniture list.
        /// </value>
        // public List<Furniture> FurnitureList { get => CartController._furnitureList; }

        /// <summary>
        /// Gets or sets the attached member.
        /// </summary>
        /// <value>
        /// The attached member.
        /// </value>
        public Member AttachedMember
        {
            get => CartController._attachedMember;
            set => CartController._attachedMember = value ?? new Member();
        }

        /// <summary>
        /// Adds to cart.
        /// </summary>
        /// <param name="furniture">The furniture.</param>
        public void AddToCart(int furnitureID, int quantity)
        {
            CartController._rentalTransaction.AddLineItem(furnitureID, quantity);
        }

        /// <summary>
        /// Removes from cart.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        public void RemoveFromCart(int furnitureID)
        {
            CartController._rentalTransaction.RemoveLineItem(furnitureID);
        }

        public void ClearCart()
        {
            CartController._attachedMember = new Member();
            CartController._rentalTransaction.ClearLineItems();
        }
    }
}
