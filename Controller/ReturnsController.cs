using RentMe.DAL;
using RentMe.Model;
using System.ComponentModel;
using System.Diagnostics;

namespace RentMe.Controller
{

    /// <summary>
    /// Manage Returns
    /// </summary>
    internal class ReturnsController
    {
        private ReturnsDAL _returnsDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnsController"/> class.
        /// </summary>
        public ReturnsController()
        {
            this._returnsDAL = new ReturnsDAL();
        }

        /// <summary>
        /// Gets the rentals by member.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>A list of return transactions</returns>
        public BindingList<ReturnTransaction> GetReturnsByMember(int memberID)
        {
            return this._returnsDAL.GetReturnsByMember(memberID);
        }

        public ReturnTransaction GetReturnableForMember(int memberID)
        {
            ReturnTransaction returnTransaction = new ReturnTransaction();
            returnTransaction.ReturnID = -1;
            returnTransaction.MemberID = memberID;
            returnTransaction.EmployeeID = LoginController.CurrentEmployeeID;
            returnTransaction.DateReturned = DateTime.Now;
            returnTransaction.LineItems = new BindingList<ReturnLineItem>();

            BindingList<RentalLineItem> rentalLineItem = new RentalsController().GetOutstandingRentalLineItemsByMemberID(memberID);

            foreach (RentalLineItem lineItem in rentalLineItem)
            {
                ReturnLineItem returnLineItem = new ReturnLineItem();
                returnLineItem.ReturnID = -1;
                returnLineItem.RentalID = lineItem.RentalID;
                returnLineItem.FurnitureID = lineItem.FurnitureID;
                returnLineItem.Name = lineItem.Name;
                returnLineItem.Description = lineItem.Description;
                returnLineItem.DailyRentalRate = lineItem.DailyRentalRate;
                returnLineItem.DateRented = lineItem.DateRented;
                returnLineItem.DateDue = lineItem.DateDue;
                returnLineItem.QuantityOutStanding =
                    lineItem.QuantityRentedByMember - lineItem.QuantityReturnedByMember;
                returnLineItem.Quantity = 0;
                returnTransaction.LineItems.Add(returnLineItem);
            }
            
            return returnTransaction;
        }
    }
}
