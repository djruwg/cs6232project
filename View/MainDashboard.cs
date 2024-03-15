using RentMe.Controller;
using RentMe.Model;
using System.Windows.Forms;

namespace RentMe.View
{
    public partial class MainDashboard : Form
    {
        private EmployeeController _employeeController;

        public MainDashboard()
        {
            InitializeComponent();

            this._employeeController = new EmployeeController();
        }

        private void MainDashboard_Shown(object sender, EventArgs e)
        {
            this.PresentLoginForm();
        }

        private void MainDashboardLogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.PresentLoginForm();
        }

        /// <summary>
        /// Displays the login form and hides the main window.
        /// </summary>
        private void PresentLoginForm()
        {
            using (LoginForm loginForm = new LoginForm())
            {
                MainDashboardAdminLinkLabel.Hide();
                MainDashboardLogoutLinkLabel.Text = String.Empty;
                MainTabControl.SelectedIndex = 0;

                DialogResult result = loginForm.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }

                Employee employee = this._employeeController.GetEmployeeByID(LoginController.CurrentEmployeeID);

                MainDashboardLogoutLinkLabel.Text = $"Logout:  {employee.FirstName} {employee.LastName} ({employee.UserName})";

                if (employee.IsAdmin)
                {
                    MainDashboardAdminLinkLabel.Show();
                    this.EnableTabs(false);
                }
                else
                {
                    MainDashboardAdminLinkLabel.Hide();
                    this.EnableTabs(true);
                }
            }
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedTab == MainTabControl.TabPages["SearchMembersTabPage"])
            {
                this.MemberSearchUserControl.PopulateSearchWithAllMembers();
            }
        }

        private void MainDashboardAdminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportForm report = new ReportForm();
            report.ShowDialog();
        }

        private void EnableTabs(bool enabled)
        {
            foreach (TabPage page in MainTabControl.TabPages)
            {
                page.Enabled = enabled;
            }
        }

        private void MainTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !((Control)e.TabPage).Enabled;
        }
    }
}
