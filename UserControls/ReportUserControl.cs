using RentMe.Controller;

namespace RentMe.UserControls
{
    public partial class ReportUserControl : UserControl
    {
        private ReportingController _reportingController;

        public ReportUserControl()
        {
            InitializeComponent();

            ReportUserControlDataGridView.AutoResizeColumns();

            this._reportingController = new ReportingController();

            ReportUserControlMessageLabel.Text = string.Empty;

            this.ClearInput();
        }

        /// <summary>
        /// Clears the input.
        /// </summary>
        private void ClearInput()
        {
            ReportUserControlStartDatePicker.Value = DateTime.Now.AddDays(-30);
            ReportUserControlEndDatePicker.Value = DateTime.Now.AddDays(1);
        }

        /// <summary>
        /// Handles the Click event of the ReportFormRunReportButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ReportFormRunReportButton_Click(object sender, EventArgs e)
        {
            ReportUserControlMessageLabel.Text = string.Empty;

            DateTime startDate = ReportUserControlStartDatePicker.Value.Date;
            DateTime endDate = ReportUserControlEndDatePicker.Value.Date;

            if (startDate > endDate)
            {
                ReportUserControlMessageLabel.Text = "Start date must be ealier than end date.";
                return;
            }

            try
            {
                ReportUserControlDataGridView.DataSource = this._reportingController.RunReportGetMostPopularFurnitureDuringDates(startDate, endDate);
            }
            catch
            {
                ReportUserControlMessageLabel.Text = "Error running report.";
            }
        }
    }
}
