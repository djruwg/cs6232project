using RentMe.DAL;
using RentMe.Model;

namespace RentMe.Controller
{
    /// <summary>
    /// Manages the furniture data access layer.
    /// </summary>
    internal class FurnitureController
    {
        private FurnitureDAL _furnitureDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureController"/> class.
        /// </summary>
        public FurnitureController()
        {
            this._furnitureDAL = new FurnitureDAL();
        }

        /// <summary>
        /// Gets the furniture by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Furniture GetFurnitureByID(int id)
        {
            return this._furnitureDAL.GetFurnitureByID(id);
        }
    }
}
