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

        _dataTable.Columns.Add("RentalID");
        _dataTable.Columns.Add("FurnitureID");
        _dataTable.Columns.Add("Name");
        _dataTable.Columns.Add("Description");
        _dataTable.Columns.Add("QuantityOwned", typeof(int));
        _dataTable.Columns.Add("QuantityRented", typeof(int));
        _dataTable.Columns.Add("DailyRentalRate", typeof(double));
        _dataTable.Columns.Add("Category");
        _dataTable.Columns.Add("Style");
        _dataTable.Columns.Add("Quantity");
    }

    public DataTable GetDataTable()
    {
        return _dataTable!;
    }
}