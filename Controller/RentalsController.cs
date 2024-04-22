using RentMe.DAL;
using RentMe.Model;
using System.ComponentModel;
using System.Data.SqlClient;

namespace RentMe.Controller
{
    /// <summary>
    /// Manages the Rentals
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
        /// Gets the outstanding rental line items by member ID.
        /// </summary>
        /// <param name="memberID">The member ID.</param>
        /// <returns></returns>
        public BindingList<RentalLineItem> GetOutstandingRentalLineItemsByMemberID(int memberID)
        {
            BindingList<RentalLineItem> lineItems = this._rentalLineItemsDAL.GetRentalsLineItemsByMemberID((int)memberID);
            return new BindingList<RentalLineItem>(
                lineItems.Where(lineItem => lineItem.QuantityReturnedByMember < lineItem.QuantityRentedByMember)
                .ToList());
        }

        public RentalTransaction GetRentalTransactionByRentalID(int rentalID)
        {
            return _rentalsDAL.GetRentalTransactionByRentalID(rentalID);
        }

        public Boolean updateRentalLineItem(SqlCommand command, int rentalID, int furnitureID, int quantity)
        {
            return _rentalLineItemsDAL.updateRentalLineItem(command, rentalID, furnitureID, quantity);
        }

    }
}
