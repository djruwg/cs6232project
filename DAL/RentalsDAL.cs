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

        /// <summary>
        /// Gets the rental transaction by rental identifier.
        /// </summary>
        /// <param name="rentalID">The rental identifier.</param>
        /// <returns>A fully populated rentals line Item</returns>
        public RentalTransaction GetRentalTransactionByRentalID(int rentalID)
        {
            RentaLineItemsDAL rentaLineItemsDAL = new RentaLineItemsDAL();
            RentalTransaction rentalTransaction;
            rentalTransaction = GetRentalTransactionRowByRentalID(rentalID);
            rentalTransaction.RentalLineItems = rentaLineItemsDAL.GetRentalLineItemsByRentalID(rentalID);
            return rentalTransaction;
        }

        /// <summary>
        /// Gets the rental transaction by rental identifier.
        /// </summary>
        /// <param name="RentalID">The rental identifier.</param>
        /// <returns></returns>
        public RentalTransaction GetRentalTransactionRowByRentalID(int rentalID)
        {
            RentalTransaction rentalTransaction = new RentalTransaction();

            string selectStatement = @"
                SELECT RentalID, DateRented, DateDue, EmployeeID, MemberID
                FROM RentalTransactions
                WHERE RentalID = @RentalID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.Add("@RentalID", SqlDbType.Int);
                    selectCommand.Parameters["@RentalID"].Value = rentalID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        reader.Read();

                        int rentalIdOrdinal = reader.GetOrdinal("RentalID");
                        int dateRentedOrdinal = reader.GetOrdinal("DateRented");
                        int dueDateOrdinal = reader.GetOrdinal("DateDue");
                        int employeeIdOrdinal = reader.GetOrdinal("EmployeeID");
                        int memberIdOrdinal = reader.GetOrdinal("MemberID");

                        rentalTransaction.RentalID = reader.GetInt32(rentalIdOrdinal);
                        rentalTransaction.DateRented = reader.GetDateTime(dateRentedOrdinal);
                        rentalTransaction.DateDue = reader.GetDateTime(dueDateOrdinal);
                        rentalTransaction.EmployeeID = reader.GetInt32(employeeIdOrdinal);
                        rentalTransaction.MemberID = reader.GetInt32(memberIdOrdinal);
                    }
                }
            }

            return rentalTransaction;
        }

        /// <summary>
        /// Transactions the save of rental cart.
        /// </summary>
        /// <param name="RentalTransaction">The rental transaction.</param>
        /// <returns>int: Rental Transaction Number or -1</returns>
        public int TransactionSaveOfRentalCart(RentalTransaction rentalTransaction)
        {
            int TransactionID = -1;
            RentaLineItemsDAL rentalLineItemsDAL = new RentaLineItemsDAL();
            FurnitureDAL furnitureDAL = new FurnitureDAL();

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    using (SqlTransaction transaction = connection.BeginTransaction("SampleTransaction"))
                    {
                        Boolean success = false;

                        command.Connection = connection;
                        command.Transaction = transaction;

                        try
                        {
                            TransactionID = SaveRentalTransactionRecord(command, rentalTransaction);
                            if (TransactionID == -1)
                            {
                                success = false;
                            }
                            else
                            {

                                // Update furniture quantities and save rental line items.
                                foreach (RentalLineItem rentalLineItem in rentalTransaction.RentalLineItems)
                                {
                                    rentalLineItem.RentalID = TransactionID;

                                    success = furnitureDAL.UpdateFurnitureQuantityRented(command,
                                        rentalLineItem.FurnitureID, rentalLineItem.QuantityRentedByMember);
                                    if (!success)
                                    {
                                        break;
                                    }

                                    success = rentalLineItemsDAL.SaveRentalLineItem(command, rentalLineItem);
                                    if (!success)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return -1;
                        }

                        if (success)
                        {
                            transaction.Commit();
                            return TransactionID;
                        }
                        else
                        {
                            transaction.Rollback();
                            return -1;
                        }
                    }
                }
            }

            return -1;
        }


        /// <summary>
        /// Saves the rental transaction record.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="rentalTransaction">The rental transaction.</param>
        /// <returns>TransactionID</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public int SaveRentalTransactionRecord(SqlCommand command, RentalTransaction rentalTransaction)
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

            command.CommandText = statement;

            command.Parameters.Add("@DateDue", SqlDbType.DateTime);
            command.Parameters["@DateDue"].Value = rentalTransaction.DateDue;
            command.Parameters.Add("@EmployeeID", SqlDbType.Int);
            command.Parameters["@EmployeeID"].Value = rentalTransaction.EmployeeID;
            command.Parameters.Add("@MemberID", SqlDbType.Int);
            command.Parameters["@MemberID"].Value = rentalTransaction.MemberID;

            object result = command.ExecuteScalar();
            if (result == null)
            {
                return -2;
            }
            else
            {
                rentalTransaction.RentalID = Convert.ToInt32(result);
                return rentalTransaction.RentalID;
            }
            
        }

    }
}
