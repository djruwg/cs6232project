using RentMe.DAL;
using System.Data;

namespace RentMe.Controller
{
    internal class ReportingController
    {
        private ReportingDAL _reportingDAL;

        public ReportingController()
        {
            this._reportingDAL = new ReportingDAL();
        }

        public DataTable RunReportGetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            return this._reportingDAL.RunReportGetMostPopularFurnitureDuringDates(startDate, endDate);
        }

    }
}
