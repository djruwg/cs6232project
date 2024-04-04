﻿using RentMe.Model;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;

namespace RentMe.DAL
{
    /// <summary>
    /// RentalLineItems data access layer.
    /// </summary>
    internal class RentaLineItemsDAL
    {
        // private RentalLineItem _lineItem;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentaLineItemsDAL"/> class.
        /// </summary>
        public RentaLineItemsDAL()
        {
            // _lineItem = new RentalLineItem();
        }

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
                        while (reader.Read())
                        {
                            RentalLineItem lineItem = new RentalLineItem
                            {
                                RentalID = (int)reader["RentalID"],
                                FurnitureID = (int)reader["FurnitureID"],
                                Name = (string)reader["Name"],
                                Description = (string)reader["Description"],
                                QuantityOwnedByStore = (int)reader["QuantityOwnedByStore"],
                                QuantityRentedByStore = (int)reader["QuantityRentedByStore"],
                                DailyRentalRate = Convert.ToDouble(reader["DailyRentalRate"]),
                                Category = (string)reader["Category"],
                                Style = (string)reader["Style"],
                                QuantityRentedByMember = (int)reader["QuantityRentedByMember"],
                                QuantityReturnedByMember = (int)reader["QuantityReturnedByMember"]
                            };

                            lineItems.Add(lineItem);
                        }
                    }
                }
            }

            return lineItems;
        }


        public Boolean SaveRentalLineItem(RentalLineItem rentalLineItem)
        {
            ArgumentNullException.ThrowIfNull(rentalLineItem);

            string statement = @"
                insert into RentalLineItem (
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

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(statement, connection))
                {
                    command.Parameters.Add("@RentalID", SqlDbType.Int);
                    command.Parameters["@RentalID"].Value = rentalLineItem.RentalID;
                    command.Parameters.Add("@FurnitureID", SqlDbType.Int);
                    command.Parameters["@FurnitureID"].Value = rentalLineItem.FurnitureID;
                    command.Parameters.Add("@QuantityRented", SqlDbType.Int);
                    command.Parameters["@QuantityRented"].Value = rentalLineItem.QuantityRentedByMember;
                    command.Parameters.Add("@QuantityReturned", SqlDbType.Int);
                    command.Parameters["@QuantityReturned"].Value = rentalLineItem.QuantityReturnedByMember;
                    command.Parameters.Add("@Cost", SqlDbType.Money);
                    command.Parameters["@Cost"].Value = rentalLineItem.DailyRentalRate;

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
