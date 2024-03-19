using RentMe.Model;
using System.ComponentModel;

namespace RentMe.Controller
{
    internal class CartController
    {
        private List<Furniture> _furnitureList;
        private Member _attachedMember;

        /// <summary>
        /// Initializes a new instance of the <see cref="CartController"/> class.
        /// </summary>
        public CartController()
        {
            this._furnitureList = new List<Furniture>();
            this._attachedMember = new Member();
        }

        /// <summary>
        /// Gets the furniture list.
        /// </summary>
        /// <value>
        /// The furniture list.
        /// </value>
        public List<Furniture> FurnitureList { get => this._furnitureList; }

        /// <summary>
        /// Gets or sets the attached member.
        /// </summary>
        /// <value>
        /// The attached member.
        /// </value>
        public Member AttachedMember
        {
            get => this._attachedMember;
            set => this._attachedMember = value ?? new Member();
        }

        /// <summary>
        /// Adds to cart.
        /// </summary>
        /// <param name="furniture">The furniture.</param>
        public void AddToCart(Furniture furniture)
        {
            this._furnitureList.Add(furniture);
        }

        public void ClearCart()
        {
            this._attachedMember = new Member();
            this._furnitureList?.Clear();
        }
    }
}
