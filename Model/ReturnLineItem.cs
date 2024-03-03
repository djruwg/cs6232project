﻿using System.ComponentModel;

namespace RentMe.Model;

/// <summary>
///  ReturnLineItem model class
/// </summary>
public class ReturnLineItem
{
    // Standard autogenerated getter/setters

    public int ReturnID { get; set; }
    public int RentalID { get; set; }
    public int FurnitureID { get; set; }
    public int Quantity { get; set; }
}