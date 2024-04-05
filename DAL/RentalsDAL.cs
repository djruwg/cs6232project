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


        public Boolean SaveRentalTransaction(RentalTransaction rentalTransaction)
        {
            int rentalID = SaveRentalTransactionRecord(rentalTransaction);
            if (rentalID == -1)
            {
                return false;
            }
            else
            {
                rentalTransaction.RentalID = rentalID;
            }
            return true;
        }


        public int SaveRentalTransactionRecord(RentalTransaction rentalTransaction)
        {
            ArgumentNullException.ThrowIfNull(rentalTransaction);

            string statement = @"
                insert into RentalTransactions (
                    DateRented,
                    DateDue,
                    EmployeeID,
                    MemberID )
                values (
                    GETDATE(),
                    @DateDue,
                    @EmployeeID,
                    @MemberID );
                    SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(statement, connection))
                {
                    command.Parameters.Add("@DateDue", SqlDbType.DateTime);
                    command.Parameters["@DateDue"].Value = rentalTransaction.DateDue;
                    command.Parameters.Add("@EmployeeID", SqlDbType.Int);
                    command.Parameters["@EmployeeID"].Value = rentalTransaction.EmployeeID;
                    command.Parameters.Add("@MemberID", SqlDbType.Int);
                    command.Parameters["@MemberID"].Value = rentalTransaction.MemberID;

                    object result = command.ExecuteScalar();
                    if (result == null)
                    {
                        return -1;
                    }
                    else
                    {
                        rentalTransaction.RentalID = Convert.ToInt32(result);
                        return rentalTransaction.RentalID;
                    }


                }
            }
        }

    }
}
