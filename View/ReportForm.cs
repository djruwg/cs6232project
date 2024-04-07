using RentMe.Controller;

namespace RentMe.View
{
    /// <summary>
    /// Form to handle admin reports
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReportForm : Form
    {
        private ReportingController _reportingController;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportForm"/> class.
        /// </summary>
        public ReportForm()
        {
            InitializeComponent();

            ReportFormDataGridView.AutoResizeColumns();

            this._reportingController = new ReportingController();

            ReportFormMessageLabel.Text = string.Empty;

            this.ClearInput();
        }

        /// <summary>
        /// Clears the input.
        /// </summary>
        private void ClearInput()
        {
            ReportFormStartDatePicker.Value = DateTime.Now.AddDays(-30);
            ReportFormEndDatePicker.Value = DateTime.Now.AddDays(1);
        }

        /// <summary>
        /// Handles the Click event of the ReportFormRunReportButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ReportFormRunReportButton_Click(object sender, EventArgs e)
        {
            ReportFormMessageLabel.Text = string.Empty;

            DateTime startDate = ReportFormStartDatePicker.Value.Date;
            DateTime endDate = ReportFormEndDatePicker.Value.Date;

            try
            {
                ReportFormDataGridView.DataSource = this._reportingController.RunReportGetMostPopularFurnitureDuringDates(startDate, endDate);
            }
            catch
            {
                ReportFormMessageLabel.Text = "Error running report.";
            }
        }
    }
}
