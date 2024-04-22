using RentMe.Model;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// RentalLineItems data access layer.
    /// </summary>
    internal class RentaLineItemsDAL
    {

        /// <summary>
        /// Gets the rentals line items by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public BindingList<RentalLineItem> GetRentalsLineItemsByMemberID(int memberID)
        {
            BindingList<RentalLineItem> lineItems = new BindingList<RentalLineItem>();

            string selectStatement = @"
                SELECT 
                    t.RentalID,
                    t.DateRented,
                    t.DateDue,
                    t.EmployeeID,
                    t.MemberID,
                    f.FurnitureID,
                    f.Name,
                    f.Style,
                    f.Category,
                    f.Description,
                    f.QuantityOwned as QuantityOwnedByStore,
                    f.QuantityRented as QuantityRentedByStore,
                    f.DailyRentalRate,
                    l.QuantityRented as QuantityRentedByMember,
                    l.QuantityReturned as QuantityReturnedByMember
                FROM RentalTransactions t, RentalLineItems l, Furniture f
                WHERE t.MemberID = @MemberID and t.RentalID = l.RentalID and f.FurnitureID = l.FurnitureID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@MemberID", SqlDbType.Int);
                    selectCommand.Parameters["@MemberID"].Value = memberID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int rentalIdOrdinal = reader.GetOrdinal("RentalID");
                        int dateRentedOrdinal = reader.GetOrdinal("DateRented");
                        int dateDueOrdinal = reader.GetOrdinal("DateDue");
                        int furnitureIdOrdinal = reader.GetOrdinal("FurnitureID");
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int descriptionOrdinal = reader.GetOrdinal("Description");
                        int quantityOwnedByStoreOrdinal = reader.GetOrdinal("QuantityOwnedByStore");
                        int quantityRentedByStoreOrdinal = reader.GetOrdinal("QuantityRentedByStore");
                        int dailyRentalRateOrdinal = reader.GetOrdinal("DailyRentalRate");
                        int categoryOrdinal = reader.GetOrdinal("Category");
                        int styleOrdinal = reader.GetOrdinal("Style");
                        int quantityRentedByMemberOrdinal = reader.GetOrdinal("QuantityRentedByMember");
                        int quantityReturnedByMemberOrdinal = reader.GetOrdinal("QuantityReturnedByMember");

                        while (reader.Read())
                        {
                            RentalLineItem lineItem = new RentalLineItem
                            {
                                RentalID = reader.GetInt32(rentalIdOrdinal),
                                FurnitureID = reader.GetInt32(furnitureIdOrdinal),
                                Name = reader.GetString(nameOrdinal),
                                Description = reader.GetString(descriptionOrdinal),
                                QuantityOwnedByStore = reader.GetInt32(quantityOwnedByStoreOrdinal),
                                QuantityRentedByStore = reader.GetInt32(quantityRentedByStoreOrdinal),
                                DailyRentalRate = Convert.ToDouble(reader.GetDecimal(dailyRentalRateOrdinal)),
                                Category = reader.GetString(categoryOrdinal),
                                Style = reader.GetString(styleOrdinal),
                                QuantityRentedByMember = reader.GetInt32(quantityRentedByMemberOrdinal),
                                QuantityReturnedByMember = reader.GetInt32(quantityReturnedByMemberOrdinal),
                                DateRented = reader.GetDateTime(dateRentedOrdinal),
                                DateDue = reader.GetDateTime(dateDueOrdinal)
                            };

                            lineItems.Add(lineItem);
                        }
                    }
                }
            }

            return lineItems;
        }

        /// <summary>
        /// Gets the rental line items by rental identifier.
        /// </summary>
        /// <param name="rentalID">The rental identifier.</param>
        /// <returns>All rental line items related to RentalID</returns>
        public BindingList<RentalLineItem> GetRentalLineItemsByRentalID(int rentalID)
        {
            BindingList<RentalLineItem> lineItems = new BindingList<RentalLineItem>();

            string selectStatement = @"
                SELECT 
                    t.RentalID,
                    t.DateRented,
                    t.DateDue,
                    t.EmployeeID,
                    t.MemberID,
                    f.FurnitureID,
                    f.Name,
                    f.Style,
                    f.Category,
                    f.Description,
                    f.QuantityOwned as QuantityOwnedByStore,
                    f.QuantityRented as QuantityRentedByStore,
                    f.DailyRentalRate,
                    l.QuantityRented as QuantityRentedByMember,
                    l.QuantityReturned as QuantityReturnedByMember
                FROM RentalTransactions t, RentalLineItems l, Furniture f
                WHERE t.RentalID = @RentalID and t.RentalID = l.RentalID and f.FurnitureID = l.FurnitureID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@RentalID", SqlDbType.Int);
                    selectCommand.Parameters["@RentalID"].Value = rentalID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int rentalIdOrdinal = reader.GetOrdinal("RentalID");
                        int furnitureIdOrdinal = reader.GetOrdinal("FurnitureID");
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int descriptionOrdinal = reader.GetOrdinal("Description");
                        int quantityOwnedByStoreOrdinal = reader.GetOrdinal("QuantityOwnedByStore");
                        int quantityRentedByStoreOrdinal = reader.GetOrdinal("QuantityRentedByStore");
                        int dailyRentalRateOrdinal = reader.GetOrdinal("DailyRentalRate");
                        int categoryOrdinal = reader.GetOrdinal("Category");
                        int styleOrdinal = reader.GetOrdinal("Style");
                        int quantityRentedByMemberOrdinal = reader.GetOrdinal("QuantityRentedByMember");
                        int quantityReturnedByMemberOrdinal = reader.GetOrdinal("QuantityReturnedByMember");

                        while (reader.Read())
                        {
                            RentalLineItem lineItem = new RentalLineItem
                            {
                                RentalID = reader.GetInt32(rentalIdOrdinal),
                                FurnitureID = reader.GetInt32(furnitureIdOrdinal),
                                Name = reader.GetString(nameOrdinal),
                                Description = reader.GetString(descriptionOrdinal),
                                QuantityOwnedByStore = reader.GetInt32(quantityOwnedByStoreOrdinal),
                                QuantityRentedByStore = reader.GetInt32(quantityRentedByStoreOrdinal),
                                DailyRentalRate = Convert.ToDouble(reader.GetDecimal(dailyRentalRateOrdinal)),
                                Category = reader.GetString(categoryOrdinal),
                                Style = reader.GetString(styleOrdinal),
                                QuantityRentedByMember = reader.GetInt32(quantityRentedByMemberOrdinal),
                                QuantityReturnedByMember = reader.GetInt32(quantityReturnedByMemberOrdinal)
                            };

                            lineItems.Add(lineItem);
                        }
                    }
                }
            }

            return lineItems;
        }


        /// <summary>
        /// Saves the rental line item with support for being a subpart of a transaction
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="rentalLineItem">The rental line item.</param>
        /// <returns>boolean success</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public Boolean SaveRentalLineItem(SqlCommand command, RentalLineItem rentalLineItem)
        {
            ArgumentNullException.ThrowIfNull(rentalLineItem);

            string statement = @"
                insert into RentalLineItems (
                    RentalID,
                    FurnitureID,
                    QuantityRented,
                    QuantityReturned,
                    Cost )
                values (
                    @RentalID,
                    @FurnitureID,
                    @QuantityRented,
                    @QuantityReturned,
                    @Cost )";

            command.CommandText = statement;

            if (!command.Parameters.Contains("@RentalID"))
            {
                command.Parameters.Add("@RentalID", SqlDbType.Int);
            }
            command.Parameters["@RentalID"].Value = rentalLineItem.RentalID;

            if (!command.Parameters.Contains("@FurnitureID"))
            {
                command.Parameters.Add("@FurnitureID", SqlDbType.Int);
            }
            command.Parameters["@FurnitureID"].Value = rentalLineItem.FurnitureID;

            if (!command.Parameters.Contains("@QuantityRented"))
            {
                command.Parameters.Add("@QuantityRented", SqlDbType.Int);
            }
            command.Parameters["@QuantityRented"].Value = rentalLineItem.QuantityRentedByMember;

            if (!command.Parameters.Contains("@QuantityReturned"))
            {
                command.Parameters.Add("@QuantityReturned", SqlDbType.Int);
            }
            command.Parameters["@QuantityReturned"].Value = rentalLineItem.QuantityReturnedByMember;

            if (!command.Parameters.Contains("@Cost"))
            {
                command.Parameters.Add("@Cost", SqlDbType.Money);
            }
            command.Parameters["@Cost"].Value = rentalLineItem.DailyRentalRate;

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                return true; // The operation was successful
            }
            else
            {
                return false; // The operation failed
            }
        }

        public Boolean updateRentalLineItem(SqlCommand command, int rentalID, int furnitureID, int quantity)
        {
            string statement = @"
                update
                    RentalLineItems
                set
                    QuantityReturned = QuantityReturned + @Quantity
                where
                    RentalID = @RentalID AND FurnitureID = @FurnitureID";

            command.CommandText = statement;

            if (!command.Parameters.Contains("@Quantity"))
            {
                command.Parameters.Add("@Quantity", SqlDbType.Int);
            }
            command.Parameters["@Quantity"].Value = quantity;

            if (!command.Parameters.Contains("@RentalID"))
            {
                command.Parameters.Add("@RentalID", SqlDbType.Int);
            }
            command.Parameters["@RentalID"].Value = rentalID;

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
