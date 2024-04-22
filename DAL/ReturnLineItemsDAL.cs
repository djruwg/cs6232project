using RentMe.Model;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    internal class ReturnLineItemsDAL
    {
        public Boolean SaveReturnlLineItem(SqlCommand command, ReturnLineItem returnLineItem)
        {
            ArgumentNullException.ThrowIfNull(returnLineItem);

            string statement = @"
                insert into ReturnLineItems (
                    ReturnID,
                    RentalID,
                    FurnitureID,
                    Quantity,
                    Fine,
                    Refund )
                values (
                    @ReturnID,
                    @RentalID,
                    @FurnitureID,
                    @Quantity,
                    @Fine,
                    @Refund )";

            command.CommandText = statement;
            if (!command.Parameters.Contains("@ReturnID"))
            {
                command.Parameters.Add("@ReturnID", SqlDbType.Int);
            }
            command.Parameters["@ReturnID"].Value = returnLineItem.ReturnID;

            if (!command.Parameters.Contains("@RentalID"))
            {
                command.Parameters.Add("@RentalID", SqlDbType.Int);
            }
            command.Parameters["@RentalID"].Value = returnLineItem.RentalID;

            if (!command.Parameters.Contains("@FurnitureID"))
            {
                command.Parameters.Add("@FurnitureID", SqlDbType.Int);
            }
            command.Parameters["@FurnitureID"].Value = returnLineItem.FurnitureID;

            if (!command.Parameters.Contains("@Quantity"))
            {
                command.Parameters.Add("@Quantity", SqlDbType.Int);
            }
            command.Parameters["@Quantity"].Value = returnLineItem.Quantity;

            if (!command.Parameters.Contains("@Fine"))
            {
                command.Parameters.Add("@Fine", SqlDbType.Money);
            }
            command.Parameters["@Fine"].Value = returnLineItem.Fine;

            if (!command.Parameters.Contains("@Refund"))
            {
                command.Parameters.Add("@Refund", SqlDbType.Money);
            }
            command.Parameters["@Refund"].Value = returnLineItem.Refund;

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

        /// <summary>
        /// Gets the return line items by return identifier.
        /// </summary>
        /// <param name="returnID">The return identifier.</param>
        /// <returns>BindingList<ReturnLineItem> based on matching returnIDs</returns>
        public BindingList<ReturnLineItem> GetReturnLineItemsByReturnID(int returnID)
        {
            BindingList<ReturnLineItem> lineItems = new BindingList<ReturnLineItem>();

            string selectStatement = @"
                SELECT 
                    t.ReturnID,
                    r.DateDue,
                    f.FurnitureID,
                    f.Name,
                    f.Style,
                    f.Category,
                    f.Description,
                    f.DailyRentalRate,
                    l.RentalID,
                    l.Quantity,
                    l.Fine,
                    l.Refund
                FROM ReturnTransactions t, ReturnLineItems l, Furniture f, RentalTransactions r
                WHERE t.ReturnID = @ReturnID and t.ReturnID = l.ReturnID and r.RentalID = l.RentalID and f.FurnitureID = l.FurnitureID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@ReturnID", SqlDbType.Int);
                    selectCommand.Parameters["@ReturnID"].Value = returnID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int returnIdOrdinal = reader.GetOrdinal("ReturnID");
                        int dueDateOrdinal = reader.GetOrdinal("DateDue");
                        int furnitureIdOrdinal = reader.GetOrdinal("FurnitureID");
                        int nameOrdinal = reader.GetOrdinal("Name");
                        int descriptionOrdinal = reader.GetOrdinal("Description");
                        int dailyRentalRateOrdinal = reader.GetOrdinal("DailyRentalRate");
                        int categoryOrdinal = reader.GetOrdinal("Category");
                        int styleOrdinal = reader.GetOrdinal("Style");
                        int rentalIdOrdinal = reader.GetOrdinal("RentalID");
                        int quantityOrdinal = reader.GetOrdinal("Quantity");
                        int fineOrdinal = reader.GetOrdinal("Fine");
                        int refundOrdinal = reader.GetOrdinal("Refund");

                        while (reader.Read())
                        {
                            ReturnLineItem lineItem = new ReturnLineItem
                            {
                                ReturnID = reader.GetInt32(rentalIdOrdinal),
                                RentalID = reader.GetInt32(rentalIdOrdinal),
                                FurnitureID = reader.GetInt32(furnitureIdOrdinal),
                                Quantity = reader.GetInt32(quantityOrdinal),
                                Fine = Convert.ToDouble(reader.GetDecimal(fineOrdinal)),
                                Refund = Convert.ToDouble(reader.GetDecimal(refundOrdinal)),
                                Name = reader.GetString(nameOrdinal),
                                Description = reader.GetString(descriptionOrdinal),
                                DailyRentalRate = Convert.ToDouble(reader.GetDecimal(dailyRentalRateOrdinal)),
                                DateDue = reader.GetDateTime(dueDateOrdinal)
                            };

                            lineItems.Add(lineItem);
                        }
                    }
                }
            }

            return lineItems;
        }

    }

}
