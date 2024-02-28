using System.Data.SqlClient;

namespace RentMe.DAL
{
    internal class DBConnection
    {
        /// <summary>
        /// Gets the database connection.
        /// </summary>
        /// <returns>A connection object.</returns>
        public static SqlConnection GetConnection()
        {
            var connectionString = "Data Source=localhost;Initial Catalog=Rental;Integrated Security=True;";

            return new SqlConnection(connectionString);
        }
    }
}
