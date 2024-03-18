﻿using System.Data.SqlClient;
using System.Data;

namespace RentMe.DAL
{
    internal class ReportingDAL
    {
        /// <summary>
        /// Runs the report get most popular furniture during dates.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>A data table with the report data</returns>
        public DataTable RunReportGetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("getMostPopularFurnitureDuringDates", connection))
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
