using RentMe.Model;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// Rentals data access layer
    /// </summary>
    internal class RentalsDAL
    {

        /// <summary>
        /// Gets the rentals by member.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>List of Rentals for memberID</returns>
        public BindingList<RentalTransaction> GetRentalsByMember(int memberID)
        {
            BindingList<RentalTransaction> rentalsList = new BindingList<RentalTransaction>();

            string selectStatement = @"
                SELECT RentalID, DateRented, DateDue, EmployeeID, MemberID
                FROM RentalTransactions
                WHERE MemberID = @MemberID";

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
                        int dueDateOrdinal = reader.GetOrdinal("DateDue");
                        int employeeIdOrdinal = reader.GetOrdinal("EmployeeID");
                        int memberIdOrdinal = reader.GetOrdinal("MemberID");


                        while (reader.Read())
                        {
                            RentalTransaction rentals = new RentalTransaction();
                            rentals.RentalID = reader.GetInt32(rentalIdOrdinal);
                            rentals.DateRented = reader.GetDateTime(dateRentedOrdinal);
                            rentals.DateDue = reader.GetDateTime(dueDateOrdinal);
                            rentals.EmployeeID = reader.GetInt32(employeeIdOrdinal);
                            rentals.MemberID = reader.GetInt32(memberIdOrdinal);
                            rentalsList.Add(rentals);
                        }
                    }
                }
            }

            return rentalsList;
        }
    }
}
