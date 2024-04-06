using RentMe.DAL;
using RentMe.Model;
using System.ComponentModel;

namespace RentMe.Controller
{
    /// <summary>
    /// Manages the cart.
    /// </summary>
    internal class CartController
    {
        private static RentalTransaction? _rentalTransaction;
        private static Member? _attachedMember;
        private RentalsDAL _rentalsDAL;


        /// <summary>
        /// Initializes a new instance of the <see cref="CartController"/> class.
        /// </summary>
        public CartController()
        {
            _rentalTransaction ??= new RentalTransaction();
            _attachedMember ??= new Member();
            this._rentalsDAL = new RentalsDAL();
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
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <param name="quantity">The quantity.</param>
        /// <returns></returns>
        public Boolean AddToCart(int furnitureID, int quantity)
        {
            return _rentalTransaction!.AddLineItem(furnitureID, quantity);
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

        /// <summary>
        /// Gets the quantity furniture in cart by identifier.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <returns></returns>
        public int GetQuantityFurnitureInCartByID(int furnitureID)
        {
            return _rentalTransaction!.GetQuantityFurnitureInTransactionByID(furnitureID);
        }

        /// <summary>
        /// Determines whether [has needed inventory to satisfy quantity requested] [the specified furniture identifier].
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <param name="quantity">The quantity.</param>
        /// <returns>
        ///   <c>true</c> if [has needed inventory to satisfy quantity requested] [the specified furniture identifier]; otherwise, <c>false</c>.
        /// </returns>
        public Boolean HasNeededInventoryToSatisfyQuantityRequested(int furnitureID, int quantity)
        {
            return _rentalTransaction!.HasNeededInventoryToSatisfyQuantityRequested(furnitureID, quantity);
        }

        /// <summary>
        /// Saves the cart as rental transaction.
        /// </summary>
        /// <returns>RentalTransaction RentalID</returns>
        public int SaveCartAsRentalTransaction()
        {
            _rentalTransaction.MemberID = _attachedMember.MemberID;
            _rentalTransaction.DateDue = DateTime.Today; 
            _rentalTransaction.EmployeeID = LoginController.CurrentEmployeeID;
            return _rentalsDAL.TransactionSaveOfRentalCart(_rentalTransaction);
        }
    }
}
