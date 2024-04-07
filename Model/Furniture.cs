namespace RentMe.Model;

/// <summary>
/// Furniture model class
/// </summary>
public class Furniture
{
    /// <summary>
    /// Gets or sets the dbo.
    /// </summary>
    /// <value>
    /// The dbo.
    /// </value>
    public int dbo { get; set; }

    /// <summary>
    /// Gets or sets the furniture identifier.
    /// </summary>
    /// <value>
    /// The furniture identifier.
    /// </value>
    public int FurnitureID { get; set; }

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
    /// Gets or sets the quantity owned.
    /// </summary>
    /// <value>
    /// The quantity owned.
    /// </value>
    public int QuantityOwned { get; set; }

    /// <summary>
    /// Gets or sets the quantity rented.
    /// </summary>
    /// <value>
    /// The quantity rented.
    /// </value>
    public int QuantityRented { get; set; }

    /// <summary>
    /// Gets or sets the daily rental rate.
    /// </summary>
    /// <value>
    /// The daily rental rate.
    /// </value>
    public decimal DailyRentalRate { get; set; }

    /// <summary>
    /// Gets or sets the category.
    /// </summary>
    /// <value>
    /// The category.
    /// </value>
    public string Category { get; set; }

    /// <summary>
    /// Gets or sets the style.
    /// </summary>
    /// <value>
    /// The style.
    /// </value>
    public string Style { get; set; }

    /// <summary>
    /// Calculates the quantity in stock by taking Owned - Rented
    /// </summary>
    /// <returns>Quantity in Stock of furniture</returns>
    public int CalculateQuantityInStock()
    {
        return this.QuantityOwned - this.QuantityRented;
    }
}