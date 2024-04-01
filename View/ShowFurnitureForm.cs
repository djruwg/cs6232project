using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class ShowFurnitureForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowFurnitureForm"/> class.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        public ShowFurnitureForm(int furnitureID)
        {
            InitializeComponent();
            ShowFurnitureFurnitureShowUserControl.SetFurniture(furnitureID);
        }
    }
}
