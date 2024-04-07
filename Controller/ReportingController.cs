using RentMe.DAL;
using System.Data;

namespace RentMe.Controller
{
    internal class ReportingController
    {
        /// <summary>
        /// The reporting DAL
        /// </summary>
        private ReportingDAL _reportingDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingController"/> class.
        /// </summary>
        public ReportingController()
        {
            this._reportingDAL = new ReportingDAL();
        }

        /// <summary>
        /// Runs the report get most popular furniture during dates.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>DataTable which is the report output</returns>
        public DataTable RunReportGetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            return this._reportingDAL.RunReportGetMostPopularFurnitureDuringDates(startDate, endDate);
        }

    }
}
