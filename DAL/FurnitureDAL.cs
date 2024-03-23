using RentMe.Model;
using System.Data.SqlClient;
using System.Data;

namespace RentMe.DAL
{
    /// <summary>
    /// Furniture data access layer
    /// </summary>
    internal class FurnitureDAL
    {
        /// <summary>
        /// Gets the furniture by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Furniture GetFurnitureByID(int id)
        {
            Furniture returnValue = null;

            string statement = @"
                select
                    Name,
                    Description,
                    QuantityOwned,
                    QuantityRented,
                    DailyRentalRate,
                    Category,
                    Style
                from
                    Furniture
                where
                    FurnitureID = @FurnitureID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(statement, connection))
                {
                    command.Parameters.Add("@FurnitureID", SqlDbType.Int);
                    command.Parameters["@FurnitureID"].Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int desciptionOrdinal = reader.GetOrdinal("Description");
                        int quantityOwnedOrdinal = reader.GetOrdinal("QuantityOwned");
                        int quantityRentedOrdinal = reader.GetOrdinal("QuantityRented");
                        int dailyRentalRateOrdinal = reader.GetOrdinal("DailyRentalRate");
                        int categoryOrdinal = reader.GetOrdinal("Category");
                        int styleOrdinal = reader.GetOrdinal("Style");

                        reader.Read();

                        returnValue = new Furniture
                        {
                            FurnitureID = id,
                            Name = reader.GetString(nameOrdinal),
                            Description = reader.GetString(desciptionOrdinal),
                            QuantityOwned = reader.GetInt32(quantityOwnedOrdinal),
                            QuantityRented = reader.GetInt32(quantityRentedOrdinal),
                            DailyRentalRate = reader.GetDecimal(dailyRentalRateOrdinal),
                            Category = reader.GetString(categoryOrdinal),
                            Style = reader.GetString(styleOrdinal)
                        };
                    }
                }
            }

            return returnValue;
        }
    }
}
