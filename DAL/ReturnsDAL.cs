using RentMe.Model;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;


namespace RentMe.DAL
{
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
                        while (reader.Read())
                        {
                            ReturnTransaction returns = new ReturnTransaction();
                            returns.ReturnID = (int)reader["ReturnID"];
                            returns.DateReturned = (DateTime)reader["DateReturned"];
                            returns.EmployeeID = (int)reader["EmployeeID"];
                            returns.MemberID = (int)reader["MemberID"];
                            returnsList.Add(returns);
                        }
                    }
                }
            }

            return returnsList;
        }
    }
}
