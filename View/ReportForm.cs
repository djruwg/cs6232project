using RentMe.Controller;

namespace RentMe.View
{
    public partial class ReportForm : Form
    {
        private ReportingController _reportingController;

        public ReportForm()
        {
            InitializeComponent();

            this._reportingController = new ReportingController();

            this.ClearInput();
        }

        private void ClearInput()
        {
            ReportFormStartDatePicker.Value = DateTime.Now;
            ReportFormEndDatePicker.Value = DateTime.Now;
        }

        private void ReportFormRunReportButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = ReportFormStartDatePicker.Value.Date;
            DateTime endDate = ReportFormEndDatePicker.Value.Date;

            ReportFormDataGridView.DataSource = this._reportingController.RunReportGetMostPopularFurnitureDuringDates(startDate, endDate);
        }
    }
}
