using RentMe.DAL;
using RentMe.Model;
using System.ComponentModel;

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
    }
}
