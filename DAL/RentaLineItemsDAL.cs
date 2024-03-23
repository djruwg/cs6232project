using RentMe.Model;
using System.Data.SqlClient;
using System.Data;

namespace RentMe.DAL
{
    /// <summary>
    /// RentalLineItems data access layer.
    /// </summary>
    internal class RentaLineItemsDAL
    {
        private RentalLineItem _lineItem;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentaLineItemsDAL"/> class.
        /// </summary>
        public RentaLineItemsDAL()
        {
            _lineItem = new RentalLineItem();
        }

        /// <summary>
        /// Gets the rentals line items by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
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
                            DataRow workRow = _lineItem.GetDataTable().NewRow();
                            workRow["RentalID"] = (int)reader["RentalID"];
                            workRow["FurnitureID"] = (int)reader["FurnitureID"];
                            workRow["Name"] = (string)reader["Name"];
                            workRow["Description"] = (string)reader["Description"];
                            workRow["QuantityOwnedByStore"] = (int)reader["QuantityOwnedByStore"];
                            workRow["QuantityRentedByStore"] = (int)reader["QuantityRentedByStore"];
                            workRow["DailyRentalRate"] = Convert.ToDouble(reader["DailyRentalRate"]);
                            workRow["Category"] = (string)reader["Category"];
                            workRow["Style"] = (string)reader["Style"];
                            workRow["QuantityRentedByMember"] = (int)reader["QuantityRentedByMember"];
                            workRow["QuantityReturnedByMember"] = (int)reader["QuantityReturnedByMember"];

                            _lineItem.GetDataTable().Rows.Add(workRow);
                        }
                    }
                }
            }

            return _lineItem;
        }
    }
}
