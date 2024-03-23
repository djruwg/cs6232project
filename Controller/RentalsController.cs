using RentMe.DAL;
using RentMe.Model;
using System.ComponentModel;

namespace RentMe.Controller
{
    /// <summary>
    /// Manages rental data access layers.
    /// </summary>
    internal class RentalsController
    {
        private RentalsDAL _rentalsDAL;
        private RentaLineItemsDAL _rentalLineItemsDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalsController"/> class.
        /// </summary>
        public RentalsController()
        {
            this._rentalsDAL = new RentalsDAL();
            this._rentalLineItemsDAL = new RentaLineItemsDAL();
        }

        /// <summary>
        /// Gets the rentals by member.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public BindingList<RentalTransaction> GetRentalsByMember(int memberID)
        {
            return this._rentalsDAL.GetRentalsByMember(memberID);
        }

        /// <summary>
        /// Gets the rental line items by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public RentalLineItem GetRentalLineItemsByMemberID(int memberID)
        {
            return this._rentalLineItemsDAL.GetRentalsLineItemsByMemberID((int)memberID);
        }
    }
}
