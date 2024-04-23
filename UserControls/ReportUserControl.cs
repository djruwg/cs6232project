using RentMe.Controller;

namespace RentMe.UserControls
{
    /// <summary>
    /// User Control for reporting view
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ReportUserControl : UserControl
    {
        private ReportingController _reportingController;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportUserControl"/> class.
        /// </summary>
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
                ReportUserControlMessageLabel.Text = "Start date cannot be after end date.";
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
