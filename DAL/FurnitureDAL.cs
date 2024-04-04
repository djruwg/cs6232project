﻿using RentMe.Model;
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
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.FurnitureID = (int)reader["FurnitureID"];
                            furniture.Name = reader["Name"].ToString();
                            furniture.Description = reader["Description"].ToString();
                            furniture.QuantityOwned = (int)reader["QuantityOwned"];
                            furniture.QuantityRented = (int)reader["QuantityRented"];
                            furniture.DailyRentalRate = (decimal)reader["DailyRentalRate"];
                            furniture.Category = reader["Category"].ToString();
                            furniture.Style = reader["Style"].ToString();
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
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.FurnitureID = (int)reader["FurnitureID"];
                            furniture.Name = reader["Name"].ToString();
                            furniture.Description = reader["Description"].ToString();
                            furniture.QuantityOwned = (int)reader["QuantityOwned"];
                            furniture.QuantityRented = (int)reader["QuantityRented"];
                            furniture.DailyRentalRate = (decimal)reader["DailyRentalRate"];
                            furniture.Category = reader["Category"].ToString();
                            furniture.Style = reader["Style"].ToString();
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }
            return furnitureList;
        }

        public Boolean UpdateFurnitureQuantityRented(int furnitureID, int quantity)
        {
            string statement = @"
                update
                    Furniture
                set
                    QuantityRented = @QuantityRented
                where
                    FurnitureID = @FurnitureID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(statement, connection))
                {
                    command.Parameters.Add("@QuantityRented", SqlDbType.Int);
                    command.Parameters["@QuantityRented"].Value = quantity;
                    command.Parameters.Add("@FurnitureID", SqlDbType.Int);
                    command.Parameters["@FurnitureID"].Value = furnitureID;

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true; // The operation was successful
                    }
                    else
                    {
                        return false; // The operation failed
                    }
                }
            }
        }
    }
}
