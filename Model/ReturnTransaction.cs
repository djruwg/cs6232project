using System.ComponentModel;

namespace RentMe.Model;

/// <summary>
/// ReturnTransaction model class
/// </summary>
public class ReturnTransaction
{

    /// <summary>
    /// Gets or sets the return identifier.
    /// </summary>
    /// <value>
    /// The return identifier.
    /// </value>
    public int ReturnID { get; set; }

    /// <summary>
    /// Gets or sets the date returned.
    /// </summary>
    /// <value>
    /// The date returned.
    /// </value>
    public DateTime DateReturned { get; set; }

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
    /// Gets or sets the line items.
    /// </summary>
    /// <value>
    /// The line items.
    /// </value>
    public BindingList<ReturnLineItem> LineItems { get; set; }
}