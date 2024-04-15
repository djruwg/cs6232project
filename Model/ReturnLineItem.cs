namespace RentMe.Model;

/// <summary>
///  ReturnLineItem model class
/// </summary>
public class ReturnLineItem
{

    /// <summary>
    /// Gets or sets the return identifier.
    /// </summary>
    /// <value>
    /// The return identifier.
    /// </value>
    public int ReturnID { get; set; }

    /// <summary>
    /// Gets or sets the rental identifier.
    /// </summary>
    /// <value>
    /// The rental identifier.
    /// </value>
    public int RentalID { get; set; }

    /// <summary>
    /// Gets or sets the furniture identifier.
    /// </summary>
    /// <value>
    /// The furniture identifier.
    /// </value>
    public int FurnitureID { get; set; }

    /// <summary>
    /// Gets or sets the quantity.
    /// </summary>
    /// <value>
    /// The quantity.
    /// </value>
    public int Quantity { get; set; }
    
    /// <summary>
    /// Gets or sets the date rented.
    /// </summary>
    /// <value>
    /// The date rented.
    /// </value>
    public DateTime DateRented { get; set; }

    /// <summary>
    /// Gets or sets the date due.
    /// </summary>
    /// <value>
    /// The date due.
    /// </value>
    public DateTime DateDue { get; set; }

    /// <summary>
    /// Gets or sets the net cost.
    /// </summary>
    /// <value>
    /// The net cost.
    /// </value>
    public double NetCost
    {
        get
        {
            return 0.0;
        }

    }

}