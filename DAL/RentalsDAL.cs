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

        public Boolean SaveRentalTransaction(RentalTransaction rentalTransaction)
        {
            ArgumentNullException.ThrowIfNull(rentalTransaction);

            string statement = @"
                insert into RentalLineItem (
                    RentalID,
                    DateRented,
                    DateDue,
                    EmployeeID,
                    MemberID )
                values (
                    @RentalID,
                    @DateRented,
                    @DateDue,
                    @EmployeeID,
                    @MemberID )";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(statement, connection))
                {
                    command.Parameters.Add("@RentalID", SqlDbType.Int);
                    command.Parameters["@RentalID"].Value = rentalTransaction.RentalID;
                    command.Parameters.Add("@DateRented", SqlDbType.DateTime);
                    command.Parameters["@DateRented"].Value = rentalTransaction.DateRented;
                    command.Parameters.Add("@DateDue", SqlDbType.DateTime);
                    command.Parameters["@DateDue"].Value = rentalTransaction.DateDue;
                    command.Parameters.Add("@EmployeeID", SqlDbType.Int);
                    command.Parameters["@EmployeeID"].Value = rentalTransaction.EmployeeID;
                    command.Parameters.Add("@MemberID", SqlDbType.Int);
                    command.Parameters["@MemberID"].Value = rentalTransaction.MemberID;

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
