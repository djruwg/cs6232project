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
    }
}
