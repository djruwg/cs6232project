using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Controller
{
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
