using RentMe.Model;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


namespace RentMe.DAL
{
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
                        while (reader.Read())
                        {
                            RentalTransaction rentals = new RentalTransaction();
                            rentals.RentalID = (int)reader["RentalID"];
                            rentals.DateRented = (DateTime)reader["DateRented"];
                            rentals.DateDue = (DateTime) reader["DateDue"];
                            rentals.EmployeeID = (int)reader["EmployeeID"];
                            rentals.MemberID = (int)reader["MemberID"];
                            rentalsList.Add(rentals);
                        }
                    }
                }
            }

            return rentalsList;
        }
    }
}
