using System.Data;

namespace RentMe.Model;

/// <summary>
///  RentalLineItem model class
/// </summary>
public class RentalLineItem
{
    private static DataTable? _dataTable;
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
        _dataTable.Columns.Add("QuantityRentedByCustomer", typeof(int));
        _dataTable.Columns.Add("QuantityReturnedByCustomer", typeof(int));
    }

    public DataTable GetDataTable()
    {
        return _dataTable!;
    }
}