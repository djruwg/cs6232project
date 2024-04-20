using RentMe.Model;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Diagnostics;
using RentMe.Controller;

namespace RentMe.DAL
{
    /// <summary>
    /// Returns data access layer.
    /// </summary>
    internal class ReturnsDAL
    {
        /// <summary>
        /// Gets the returns by member.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>List of Returns for memberID</returns>
        public BindingList<ReturnTransaction> GetReturnsByMember(int memberID)
        {
            BindingList<ReturnTransaction> returnsList = new BindingList<ReturnTransaction>();

            string selectStatement = @"
                SELECT ReturnID, DateReturned, EmployeeID, MemberID
                FROM ReturnTransactions
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
                        int returnIdOrdinal = reader.GetOrdinal("ReturnID");
                        int dateReturnedOrdinal = reader.GetOrdinal("DateReturned");
                        int employeeIdOrdinal = reader.GetOrdinal("EmployeeID");
                        int memberIdOrdinal = reader.GetOrdinal("MemberID");

                        while (reader.Read())
                        {
                            ReturnTransaction returns = new ReturnTransaction();
                            returns.ReturnID = reader.GetInt32(returnIdOrdinal);
                            returns.DateReturned = reader.GetDateTime(dateReturnedOrdinal);
                            returns.EmployeeID = reader.GetInt32(employeeIdOrdinal);
                            returns.MemberID = reader.GetInt32(memberIdOrdinal);
                            returnsList.Add(returns);
                        }
                    }
                }
            }

            return returnsList;
        }

        public int SaveReturnTransaction(ReturnTransaction returnTransaction)
        {
            ReturnsController returnsController = new ReturnsController();
            RentalsController rentalsController = new RentalsController();


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

                            TransactionID = SaveReturnTransactionRecord(command, returnTransaction);
                            if (TransactionID == -1)
                            {
                                success = false;
                            }
                            else
                            {
                                success = true;
                                foreach (ReturnLineItem lineItem in returnTransaction.LineItems)
                                {
                                    Debug.WriteLine("loop 1");
                                    lineItem.ReturnID = TransactionID;

                                    lineItem.Fine = 0;
                                    lineItem.Refund = 0;
                                    if (lineItem.AmountOwed > 0)
                                    {
                                        lineItem.Fine = lineItem.AmountOwed;
                                    }

                                    if (lineItem.AmountOwed < 0)
                                    {
                                        lineItem.Refund = -1 * lineItem.AmountOwed;
                                    }
                                    success = returnsController.SaveReturnlLineItem(command, lineItem);
                                    if (!success)
                                    {
                                        break;
                                    }

                                    success = rentalsController.updateRentalLineItem(command, lineItem.RentalID,
                                        lineItem.FurnitureID, lineItem.Quantity);
                                    if (!success)
                                    {
                                        break;
                                    }

                                    success = furnitureDAL.UpdateFurnitureQuantityRented(command, lineItem.FurnitureID,
                                        (-1 * lineItem.Quantity));
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
            return -2;
        }

        public int SaveReturnTransactionRecord(SqlCommand command, ReturnTransaction returnTransaction)
        {
            ArgumentNullException.ThrowIfNull(returnTransaction);

            string statement = @"
                insert into ReturnTransactions (
                    DateReturned,
                    EmployeeID,
                    MemberID )
                values (
                    GETDATE(),
                    @EmployeeID,
                    @MemberID );
                    SELECT SCOPE_IDENTITY();";

            command.CommandText = statement;

            command.Parameters.Add("@EmployeeID", SqlDbType.Int);
            command.Parameters["@EmployeeID"].Value = returnTransaction.EmployeeID;
            command.Parameters.Add("@MemberID", SqlDbType.Int);
            command.Parameters["@MemberID"].Value = returnTransaction.MemberID;

            object result = command.ExecuteScalar();
            if (result == null)
            {
                return -2;
            }
            else
            {
                returnTransaction.ReturnID = Convert.ToInt32(result);
                return returnTransaction.ReturnID;
            } ;
        }
        
    }
}