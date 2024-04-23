using RentMe.DAL;
using RentMe.Model;
using System.ComponentModel;
using System.Data.SqlClient;

namespace RentMe.Controller
{

    /// <summary>
    /// Manage Returns
    /// </summary>
    internal class ReturnsController
    {
        private ReturnsDAL _returnsDAL;
        private ReturnLineItemsDAL _ReturnLineItemDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnsController"/> class.
        /// </summary>
        public ReturnsController()
        {
            this._returnsDAL = new ReturnsDAL();
            this._ReturnLineItemDAL = new ReturnLineItemsDAL();
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

        /// <summary>
        /// Gets the returnable for member.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Saves the return transaction.
        /// </summary>
        /// <param name="stuffToReturn">The stuff to return.</param>
        /// <returns></returns>
        public int SaveReturnTransaction(ReturnTransaction stuffToReturn)
        {
            return _returnsDAL.SaveReturnTransaction(stuffToReturn);
        }

        /// <summary>
        /// Saves the returnl line item.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="returnLineItem">The return line item.</param>
        /// <returns></returns>
        public Boolean SaveReturnlLineItem(SqlCommand command, ReturnLineItem returnLineItem)
        {
            return _ReturnLineItemDAL.SaveReturnlLineItem(command, returnLineItem);
        }

        /// <summary>
        /// Gets the return transaction by return identifier.
        /// </summary>
        /// <param name="returnID">The return identifier.</param>
        /// <returns></returns>
        public ReturnTransaction GetReturnTransactionByReturnID(int returnID)
        {
            return _returnsDAL.GetReturnTransactionByReturnID(returnID);
        }
    }
}
