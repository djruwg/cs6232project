using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace RentMe.DAL
{
    internal class RentaLineItemsDAL
    {
        private RentalLineItem _lineItem;

        public RentaLineItemsDAL()
        {
            _lineItem = new RentalLineItem();
        }

        public RentalLineItem GetRentalsLineItemsByMemberID(int memberID)
        {
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
                    f.QuantityOwned,
                    f.QuantityRented as QuantityStoreRented,
                    f.DailyRentalRate,
                    l.QuantityRented
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
                            DataRow workRow = _lineItem.GetDataTable().NewRow();
                            workRow["RentalID"] = (int)reader["RentalID"];
                            workRow["FurnitureID"] = (int)reader["FurnitureID"];
                            workRow["Name"] = (string)reader["Name"];
                            workRow["Description"] = (string)reader["Description"];
                            workRow["QuantityOwned"] = (int)reader["QuantityOwned"];
                            workRow["QuantityRented"] = (int)reader["QuantityRented"];
                            // workRow["DailyRentalRate"] = (double)reader["DailyRentalRate"];
                            workRow["Category"] = (string)reader["Category"];
                            workRow["Style"] = (string)reader["Style"];
                            // workRow["Quantity"] = (int)reader["QuantityRented"];

                            _lineItem.GetDataTable().Rows.Add(workRow);
                        }
                    }
                }
            }

            return _lineItem;
        }
    }
}
