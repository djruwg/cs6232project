using System.Data.SqlClient;
using System.Data;

namespace RentMe.DAL
{
    internal class ReportingDAL
    {
        public DataTable RunReportGetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("getMostPopularFurnitureDuringDatesTesting", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@startDate", SqlDbType.Date);
                    command.Parameters["@startDate"].Value = startDate;
                    command.Parameters.Add("@endDate", SqlDbType.Date);
                    command.Parameters["@endDate"].Value = endDate;

                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
        }
    }
}
