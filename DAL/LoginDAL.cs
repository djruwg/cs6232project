using System.Data;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Login data access layer
    /// </summary>
    internal class LoginDAL
    {
        /// <summary>
        /// Authenticates the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>Employee ID of loged in user</returns>
        public int Authenticate(string username, string password)
        {
            int employeeID = 0;

            string selectStatement = @"
                select
                    EmployeeID
                from
                    Employees
                where
                    Username = @username
                and
                    Password = @password";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.Add("@username", SqlDbType.VarChar, 20);
                    command.Parameters["@username"].Value = username;
                    command.Parameters.Add("@password", SqlDbType.VarChar, 256);
                    command.Parameters["@password"].Value = password;

                    employeeID = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return employeeID;
        }
    }
}
