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
}