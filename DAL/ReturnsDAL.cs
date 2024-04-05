using RentMe.Model;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;

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
    }
}
