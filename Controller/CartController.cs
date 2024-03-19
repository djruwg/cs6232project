using RentMe.Model;
using System.ComponentModel;

namespace RentMe.Controller
{
    internal class CartController
    {
        private List<Furniture> _furnitureList;
        private Member _attachedMember;

        public CartController()
        {
            this._furnitureList = new List<Furniture>();
        }

        public List<Furniture> FurnitureList { get => this._furnitureList; }

        public void AddToCart(Furniture furniture)
        {
            this._furnitureList.Add(furniture);
        }
    }
}
