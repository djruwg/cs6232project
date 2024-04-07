using System.Data.SqlClient;

namespace RentMe.DAL
{

    /// <summary>
    /// Create a database connection
    /// </summary>
    internal class DBConnection
    {
        /// <summary>
        /// Gets the database connection.
        /// </summary>
        /// <returns>A connection object.</returns>
        public static SqlConnection GetConnection()
        {
            var connectionString = "Data Source=localhost;Initial Catalog=cs6232-g1;Integrated Security=True;";

            return new SqlConnection(connectionString);
        }
    }
}
