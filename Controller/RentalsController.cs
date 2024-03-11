using RentMe.DAL;
using RentMe.Model;
using System.ComponentModel;

namespace RentMe.Controller
{
    internal class RentalsController
    {
        private RentalsDAL _rentalsDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalsController"/> class.
        /// </summary>
        public RentalsController()
        {
            this._rentalsDAL = new RentalsDAL();
        }

        /// <summary>
        /// Gets the rentals by member.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>returns a list of rental transactions</returns>
        public BindingList<RentalTransaction> GetRentalsByMember(int memberID)
        {
            return this._rentalsDAL.GetRentalsByMember(memberID);
        }
    }
}
