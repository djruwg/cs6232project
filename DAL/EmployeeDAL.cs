using RentMe.Model;
using System.Data;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Employee data access layer.
    /// </summary>
    internal class EmployeeDAL
    {
        /// <summary>
        /// Gets the employee by identifier.
        /// </summary>
        /// <param name="id">The employee ID.</param>
        /// <returns>A Employee object</returns>
        public Employee GetEmployeeByID(int id)
        {
            Employee returnValue = null;

            string statement = @"
                select
                    FirstName,
                    LastName,
                    Phone,
                    Address,
                    City,
                    State,
                    Zip,
                    DateOfBirth,
                    Sex,
                    UserName,
                    Password,
                    IsAdmin
                from
                    Employees
                where
                    EmployeeID = @EmployeeID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(statement, connection))
                {
                    command.Parameters.Add("@EmployeeID", SqlDbType.Int);
                    command.Parameters["@EmployeeID"].Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int firstNameOrdinal = reader.GetOrdinal("FirstName");
                        int lastNameOrdinal = reader.GetOrdinal("LastName");
                        int phoneOrdinal = reader.GetOrdinal("Phone");
                        int addressOrdinal = reader.GetOrdinal("Address");
                        int cityOrdinal = reader.GetOrdinal("City");
                        int stateOrdinal = reader.GetOrdinal("State");
                        int zipOrdinal = reader.GetOrdinal("Zip");
                        int dateOfBirthOrdinal = reader.GetOrdinal("DateOfBirth");
                        int sexOrdinal = reader.GetOrdinal("Sex");
                        int userNameOrdinal = reader.GetOrdinal("UserName");
                        int passwordOrdinal = reader.GetOrdinal("Password");
                        int isAdminOrdinal = reader.GetOrdinal("IsAdmin");

                        reader.Read();

                        returnValue = new Employee
                        {
                            EmployeeID = id,
                            FirstName = reader.GetString(firstNameOrdinal),
                            LastName = reader.GetString(lastNameOrdinal),
                            Phone = reader.GetString(phoneOrdinal),
                            Address = reader.GetString(addressOrdinal),
                            City = reader.GetString(cityOrdinal),
                            State = reader.GetString(stateOrdinal),
                            Zip = reader.GetString(zipOrdinal),
                            DateOfBirth = reader.GetDateTime(dateOfBirthOrdinal),
                            Sex = reader.GetString(sexOrdinal),
                            UserName = reader.GetString(userNameOrdinal),
                            Password = reader.GetString(passwordOrdinal),
                            IsAdmin = reader.GetBoolean(isAdminOrdinal)
                        };
                    }
                }
            }

            return returnValue;
        }
    }
}
