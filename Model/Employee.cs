namespace RentMe.Model;

/// <summary>
/// Employee model class
/// </summary>
public class Employee
{

    /// <summary>
    /// Gets or sets the employee identifier.
    /// </summary>
    /// <value>
    /// The employee identifier.
    /// </value>
    public int EmployeeID { get; set; }

    /// <summary>
    /// Gets or sets the first name.
    /// </summary>
    /// <value>
    /// The first name.
    /// </value>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name.
    /// </summary>
    /// <value>
    /// The last name.
    /// </value>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the sex.
    /// </summary>
    /// <value>
    /// The sex.
    /// </value>
    public string Sex { get; set; }

    /// <summary>
    /// Gets or sets the date of birth.
    /// </summary>
    /// <value>
    /// The date of birth.
    /// </value>
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the phone.
    /// </summary>
    /// <value>
    /// The phone.
    /// </value>
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    /// <value>
    /// The address.
    /// </value>
    public string Address { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    /// <value>
    /// The city.
    /// </value>
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the state.
    /// </summary>
    /// <value>
    /// The state.
    /// </value>
    public string State { get; set; }

    /// <summary>
    /// Gets or sets the zip.
    /// </summary>
    /// <value>
    /// The zip.
    /// </value>
    public string Zip { get; set; }

    /// <summary>
    /// Gets or sets the name of the user.
    /// </summary>
    /// <value>
    /// The name of the user.
    /// </value>
    public string UserName { get; set; }

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    /// <value>
    /// The password.
    /// </value>
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is admin.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is admin; otherwise, <c>false</c>.
    /// </value>
    public Boolean IsAdmin { get; set; }

}