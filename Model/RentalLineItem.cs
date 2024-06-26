﻿namespace RentMe.Model;

/// <summary>
///  RentalLineItem model class
/// </summary>
public class RentalLineItem
{
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
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>
    /// The description.
    /// </value>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the quantity owned by store.
    /// </summary>
    /// <value>
    /// The quantity owned by store.
    /// </value>
    public int QuantityOwnedByStore { get; set; }

    /// <summary>
    /// Gets or sets the quantity rented by store.
    /// </summary>
    /// <value>
    /// The quantity rented by store.
    /// </value>
    public int QuantityRentedByStore { get; set; }

    /// <summary>
    /// Gets the quantity available.
    /// </summary>
    /// <value>
    /// The quantity available.
    /// </value>
    public int QuantityAvailable { get => QuantityOwnedByStore - QuantityRentedByStore; }

    /// <summary>
    /// Gets or sets the daily rental rate.
    /// </summary>
    /// <value>
    /// The daily rental rate.
    /// </value>
    public double DailyRentalRate { get; set; }

    /// <summary>
    /// Gets or sets the category.
    /// </summary>
    /// <value>
    /// The category.
    /// </value>
    public string? Category { get; set; }

    /// <summary>
    /// Gets or sets the style.
    /// </summary>
    /// <value>
    /// The style.
    /// </value>
    public string? Style { get; set; }

    /// <summary>
    /// Gets or sets the quantity rented by member.
    /// </summary>
    /// <value>
    /// The quantity rented by member.
    /// </value>
    public int QuantityRentedByMember { get; set; }

    /// <summary>
    /// Gets or sets the quantity returned by member.
    /// </summary>
    /// <value>
    /// The quantity returned by member.
    /// </value>
    public int QuantityReturnedByMember { get; set; }

    /// <summary>
    /// Gets or sets the days rented.
    /// </summary>
    /// <value>
    /// The days rented.
    /// </value>
    public int DaysRented { get; set; }

    /// <summary>
    /// Gets the rental cost.
    /// </summary>
    /// <value>
    /// The rental cost.
    /// </value>
    public double RentalCost { get => DaysRented * QuantityRentedByMember * DailyRentalRate; }

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

}