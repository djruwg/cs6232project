using RentMe.DAL;
using RentMe.Model;

namespace RentMe.Controller
{
    internal class FurnitureController
    {
        private FurnitureDAL _furnitureDAL;

        public FurnitureController()
        {
            this._furnitureDAL = new FurnitureDAL();
        }

        public Furniture GetFurnitureByID(int id)
        {
            return this._furnitureDAL.GetFurnitureByID(id);
        }
    }
}
