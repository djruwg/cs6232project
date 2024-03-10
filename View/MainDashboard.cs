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

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                LogoutLinkLabel.Text = String.Empty;
                MainTabControl.SelectedIndex = 0;

                DialogResult result = loginForm.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }

                LogoutLinkLabel.Text = "Logout: " + loginForm.Username;
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
    }
}
