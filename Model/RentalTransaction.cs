using RentMe.DAL;
using System.ComponentModel;

namespace RentMe.Model;

/// <summary>
/// RentalTransaction model class
/// </summary>
public class RentalTransaction
{
    private BindingList<RentalLineItem> _rentalLineItems;
    private FurnitureDAL _furnitureDAL;

    /// <summary>
    /// Initializes a new instance of the <see cref="RentalTransaction"/> class.
    /// </summary>
    public RentalTransaction()
    {
        this._rentalLineItems = new BindingList<RentalLineItem>();
        this._furnitureDAL = new FurnitureDAL();
    }

    /// <summary>
    /// Gets or sets the rental identifier.
    /// </summary>
    /// <value>
    /// The rental identifier.
    /// </value>
    public int RentalID { get; set; }

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
    /// Gets or sets the employee identifier.
    /// </summary>
    /// <value>
    /// The employee identifier.
    /// </value>
    public int EmployeeID { get; set; }

    /// <summary>
    /// Gets or sets the member identifier.
    /// </summary>
    /// <value>
    /// The member identifier.
    /// </value>
    public int MemberID { get; set; }

    /// <summary>
    /// Gets the rental line items.
    /// </summary>
    /// <value>
    /// The rental line items as a BindingList
    /// </value>
    public BindingList<RentalLineItem> RentalLineItems
    {
        get => this._rentalLineItems;
    }

    /// <summary>
    /// Adds a line item.
    /// </summary>
    /// <param name="lineItem">The line item.</param>
    public void AddLineItem(int furnitureID, int quantity)
    {
        Furniture furniture = this._furnitureDAL.GetFurnitureByID(furnitureID);

        ArgumentNullException.ThrowIfNull(furniture);

        RentalLineItem lineItem = new RentalLineItem
        {
            RentalID = this.RentalID,
            FurnitureID = furnitureID,
            Name = furniture.Name,
            Description = furniture.Description,
            QuantityOwnedByStore = furniture.QuantityOwned,
            QuantityRentedByStore = furniture.QuantityRented,
            DailyRentalRate = Convert.ToDouble(furniture.DailyRentalRate),
            Category = furniture.Category,
            Style = furniture.Style,
            QuantityRentedByMember = quantity,
            QuantityReturnedByMember = 0
        };

        _rentalLineItems.Add(lineItem);
    }

    /// <summary>
    /// Removes a line item.
    /// </summary>
    /// <param name="furnitureID">The furniture identifier.</param>
    public void RemoveLineItem(int furnitureID)
    {
        _rentalLineItems.Remove(_rentalLineItems.Single(lineItem => lineItem.FurnitureID == furnitureID));
    }

    /// <summary>
    /// Clears the line items.
    /// </summary>
    public void ClearLineItems()
    {
        this._rentalLineItems.Clear();
    }
}