using RentMe.Model;
using System.Data;
using System.Data.SqlClient;

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

        /// <summary>
        /// Gets all furniture from db.
        /// </summary>
        /// <returns>List of furniture model objects</returns>
        public List<Furniture> GetAllFurniture()
        {
            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement = @"
                SELECT *
                FROM Furniture;
                ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int furnitureIdOrdinal = reader.GetOrdinal("FurnitureID");
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int descriptionOrdinal = reader.GetOrdinal("Description");
                        int quantityOwnedOrdinal = reader.GetOrdinal("QuantityOwned");
                        int quantityRentedOrdinal = reader.GetOrdinal("QuantityRented");
                        int dailyRentalRateOrdinal = reader.GetOrdinal("DailyRentalRate");
                        int categoryOrdinal = reader.GetOrdinal("Category");
                        int styleOrdinal = reader.GetOrdinal("Style");

                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.FurnitureID = reader.GetInt32(furnitureIdOrdinal);
                            furniture.Name = reader.GetString(nameOrdinal);
                            furniture.Description = reader.GetString(descriptionOrdinal);
                            furniture.QuantityOwned = reader.GetInt32(quantityOwnedOrdinal);
                            furniture.QuantityRented = reader.GetInt32(quantityRentedOrdinal);
                            furniture.DailyRentalRate = reader.GetDecimal(dailyRentalRateOrdinal);
                            furniture.Category = reader.GetString(categoryOrdinal);
                            furniture.Style = reader.GetString(styleOrdinal);
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }

            return furnitureList;
        }

        /// <summary>
        /// Gets the searched furniture by search parameter.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns>A list of Furniture model objects found by search string</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public List<Furniture> GetSearchedFurniture(String searchString)
        {
            ArgumentNullException.ThrowIfNull(searchString);

            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement = @"
                DECLARE @SearchTerm NVARCHAR(100) = @searchString;

                SELECT * FROM Furniture
                WHERE 
                    Category LIKE '%' + @SearchTerm + '%' 
                    OR Style LIKE '%' + @SearchTerm + '%'
                    OR FurnitureID = TRY_CAST(@SearchTerm AS INT);
                ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@searchString", SqlDbType.VarChar);
                    selectCommand.Parameters["@searchString"].Value = searchString;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int furnitureIdOrdinal = reader.GetOrdinal("FurnitureID");
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int descriptionOrdinal = reader.GetOrdinal("Description");
                        int quantityOwnedOrdinal = reader.GetOrdinal("QuantityOwned");
                        int quantityRentedOrdinal = reader.GetOrdinal("QuantityRented");
                        int dailyRentalRateOrdinal = reader.GetOrdinal("DailyRentalRate");
                        int categoryOrdinal = reader.GetOrdinal("Category");
                        int styleOrdinal = reader.GetOrdinal("Style");

                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.FurnitureID = reader.GetInt32(furnitureIdOrdinal);
                            furniture.Name = reader.GetString(nameOrdinal);
                            furniture.Description = reader.GetString(descriptionOrdinal);
                            furniture.QuantityOwned = reader.GetInt32(quantityOwnedOrdinal);
                            furniture.QuantityRented = reader.GetInt32(quantityRentedOrdinal);
                            furniture.DailyRentalRate = reader.GetDecimal(dailyRentalRateOrdinal);
                            furniture.Category = reader.GetString(categoryOrdinal);
                            furniture.Style = reader.GetString(styleOrdinal);
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }
            return furnitureList;
        }

        /// <summary>
        /// Updates the furniture quantity rented.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <param name="quantity">The quantity. Note: May be negative to initiate return</param>
        /// <returns>Boolean success</returns>
        public Boolean UpdateFurnitureQuantityRented(SqlCommand command, int furnitureID, int quantity)
        {
            Furniture furniture;
            int newQuantity;

            furniture = GetFurnitureByID(furnitureID);

            if (furniture == null)
            {
                return false;
            }

            newQuantity = furniture.QuantityRented + quantity;

            if (newQuantity > furniture.QuantityOwned || newQuantity < 0)
            {
                return false;
            }

            string statement = @"
                update
                    Furniture
                set
                    QuantityRented = @QuantityRented
                where
                    FurnitureID = @FurnitureID";

            command.CommandText = statement;

            if (!command.Parameters.Contains("@QuantityRented"))
            {
                command.Parameters.Add("@QuantityRented", SqlDbType.Int);
            }
            command.Parameters["@QuantityRented"].Value = newQuantity;

            if (!command.Parameters.Contains("@FurnitureID"))
            {
                command.Parameters.Add("@FurnitureID", SqlDbType.Int);
            }
            command.Parameters["@FurnitureID"].Value = furnitureID;

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
