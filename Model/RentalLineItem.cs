using System.Data;

namespace RentMe.Model;

/// <summary>
///  RentalLineItem model class
/// </summary>
public class RentalLineItem
{
    private DataTable? _dataTable;

    /// <summary>
    /// Initializes a new instance of the <see cref="RentalLineItem"/> class.
    /// </summary>
    public RentalLineItem()
    {
        _dataTable = new DataTable();

        // Transaction
        _dataTable.Columns.Add("RentalID");

        // Furniture
        _dataTable.Columns.Add("FurnitureID");
        _dataTable.Columns.Add("Name");
        _dataTable.Columns.Add("Description");
        _dataTable.Columns.Add("QuantityOwnedByStore", typeof(int));
        _dataTable.Columns.Add("QuantityRentedByStore", typeof(int));
        _dataTable.Columns.Add("DailyRentalRate", typeof(double));
        _dataTable.Columns.Add("Category");
        _dataTable.Columns.Add("Style");

        // Line Item
        _dataTable.Columns.Add("QuantityRentedByMember", typeof(int));
        _dataTable.Columns.Add("QuantityReturnedByMember", typeof(int));
    }

    /// <summary>
    /// Gets the data table.
    /// </summary>
    /// <returns></returns>
    public DataTable GetDataTable()
    {
        return _dataTable!;
    }
}