using RentMe.Controller;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe.UserControls
{
    public partial class CartUserControl : UserControl
    {
        private CartController _cartController;

        public CartUserControl()
        {
            InitializeComponent();

            this._cartController = new CartController();

            CartRentalIDTextBox.Text = "009874";
            CartMemberIDTextBox.Text = "001321";
            CartFirstNameTextBox.Text = "Billy";
            CartLastNameTextBox.Text = "Jones";

            this._cartController.AddToCart(new Furniture
            {
                FurnitureID = 1,
                Name = "Sofa",
                Description = "Fluffy Sofa",
                DailyRentalRate = 2,
                QuantityRented = 4
            });

            this._cartController.AddToCart(new Furniture
            {
                FurnitureID = 2,
                Name = "Rocking Chair",
                Description = "Wooden Rocking Chair",
                DailyRentalRate = 1,
                QuantityRented = 1
            });

            this.RefeshCartListView();
        }

        public void RefeshCartListView()
        {
            CartListView.Items.Clear();

            List<Furniture> furnitureList = this._cartController.FurnitureList;

            for (int i = 0; i < furnitureList.Count; i++)
            {
                CartListView.Items.Add(furnitureList[i].FurnitureID.ToString());
                CartListView.Items[i].SubItems.Add(furnitureList[i].Description);
                CartListView.Items[i].SubItems.Add(furnitureList[i].DailyRentalRate.ToString());
                CartListView.Items[i].SubItems.Add("0");
                CartListView.Items[i].SubItems.Add(furnitureList[i].QuantityRented.ToString());
            }

            CartListView.Columns[0].Width = -2;
            CartListView.Columns[1].Width = -2;
            CartListView.Columns[2].Width = -2;
            CartListView.Columns[3].Width = -2;
            CartListView.Columns[4].Width = -2;

            // CartListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
