using System.Data;
using System.Diagnostics;

namespace RentMe.Model
{
    /// <summary>
    /// Manages a data table to represent the contents of the cart.
    /// </summary>
    internal class Cart
    {
        private static DataTable? _dataTable;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cart"/> class.
        /// </summary>
        public Cart()
        {
            _dataTable = new DataTable();

            _dataTable.Columns.Add("FurnitureID");
            _dataTable.Columns.Add("Name");
            _dataTable.Columns.Add("Description");
            _dataTable.Columns.Add("QuantityOwned", typeof(int));
            _dataTable.Columns.Add("QuantityRented", typeof(int));
            _dataTable.Columns.Add("DailyRentalRate", typeof(decimal));
            _dataTable.Columns.Add("Category");
            _dataTable.Columns.Add("Style");
            _dataTable.Columns.Add("Quantity");
        }

        /// <summary>
        /// Adds the row.
        /// </summary>
        /// <param name="furniture">The furniture.</param>
        /// <param name="quantity">The quantity.</param>
        public void AddRow(Furniture furniture, int quantity)
        {
            DataRow workRow = _dataTable!.NewRow();
            workRow["FurnitureID"] = furniture.FurnitureID;
            workRow["Name"] = furniture.Name;
            workRow["Description"] = furniture.Description;
            workRow["QuantityOwned"] = furniture.QuantityOwned;
            workRow["QuantityRented"] = furniture.QuantityRented;
            workRow["DailyRentalRate"] = furniture.DailyRentalRate;
            workRow["Category"] = furniture.Category;
            workRow["Style"] = furniture.Style;
            workRow["Quantity"] = quantity;

            _dataTable.Rows.Add(workRow);
        }

        /// <summary>
        /// Removes the row.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        public void RemoveRow(int furnitureID)
        {
            var rows = _dataTable!.Select($"FurnitureID = {furnitureID}");
            
            foreach (var row in rows)
            {
                row.Delete();
            }

            _dataTable!.AcceptChanges();
        }

        /// <summary>
        /// Clears the rows.
        /// </summary>
        public void ClearRows()
        {
            _dataTable!.Clear();
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            return _dataTable!;
        }
    }
}
