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
    public partial class FurnitureSearch : UserControl
    {
        public FurnitureSearch()
        {
            InitializeComponent();
            FurnitureSearchSearchMessageLabel.Text = string.Empty;
        }

        private void UserControl_Resize(object sender, EventArgs e)
        {
            this.ResizeFurnitureSearchListViewColumns();
        }

        private void ResizeFurnitureSearchListViewColumns()
        {
            float[] columnWidthPercentages = { 0.05f, 0.15f, 0.2f, 0.15f, 0.15f, 0.15f, 0.15f };

            if (this.FurnitureSearchListView.Columns.Count != columnWidthPercentages.Length)
            {
                throw new ArgumentException("The number of columns in the ListView must match the number of width percentages provided.");
            }

            int totalWidth = this.FurnitureSearchListView.ClientSize.Width;
            totalWidth -= SystemInformation.VerticalScrollBarWidth;

            for (int i = 0; i < columnWidthPercentages.Length; i++)
            {
                this.FurnitureSearchListView.Columns[i].Width = (int)(totalWidth * columnWidthPercentages[i]);
            }
        }
    }
}
