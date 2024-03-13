namespace RentMe.View
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
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

                MainDashboardLogoutLinkLabel.Text = "Logout: " + loginForm.Username;
                MainDashboardAdminLinkLabel.Show();
            }
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedTab == MainTabControl.TabPages["WelcomeTabPage"])
            {
                // Placeholder
            }
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
    }
}
