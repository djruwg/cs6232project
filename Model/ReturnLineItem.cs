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
    /// Gets or sets the fine.
    /// </summary>
    /// <value>
    /// The fine.
    /// </value>
    public double Fine { get; set; }

    /// <summary>
    /// Gets or sets the refund.
    /// </summary>
    /// <value>
    /// The refund.
    /// </value>
    public double Refund { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>
    /// The description.
    /// </value>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the daily rate.
    /// </summary>
    /// <value>
    /// The daily rate.
    /// </value>
    public double DailyRentalRate { get; set; }

    /// <summary>
    /// Gets or sets the quantity out standing.
    /// </summary>
    /// <value>
    /// The quantity out standing.
    /// </value>
    public int QuantityOutStanding { get; set; }

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
    /// Gets or sets the date returned.
    /// </summary>
    /// <value>
    /// The date returned.
    /// </value>
    public DateTime DateReturned { get; set; }

    /// <summary>
    /// Gets or sets the due delta.
    /// </summary>
    /// <value>
    /// The due delta.
    /// </value>
    public int DueDelta
    {
        get
        {
            return (DateTime.Now.Date - DateDue.Date).Days;
        }

    }

    /// <summary>
    /// Gets or sets the net cost.
    /// </summary>
    /// <value>
    /// The net cost.
    /// </value>
    public double AmountOwed
    {
        get
        {
            int deltaDays = (this.DateReturned.Date - DateDue.Date).Days;
            return deltaDays * Quantity * DailyRentalRate;
        }

    }

}