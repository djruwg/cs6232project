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

        /// <summary>
        /// Gets all furniture from db.
        /// </summary>
        /// <returns>List of furniture model objects</returns>
        public List<Furniture> GetAllFurniture()
        {
            return this._furnitureDAL.GetAllFurniture();
        }

        /// <summary>
        /// Gets the searched furniture by search parameter.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns>A list of Furniture model objects found by search string</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public List<Furniture> GetSearchedFurniture(String searchString)
        {
            return this._furnitureDAL.GetSearchedFurniture(searchString);
        }
    }
}
