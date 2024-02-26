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

        /// <summary>
        /// Sets the logged in username that appears in the main form
        /// </summary>
        /// <param name="username">the username string to set</param>
        public void SetUsername(string username)
        {
            // this.UsernameLabel.Text = username;
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
                this.Hide();
                this.Opacity = 0;
                // this.UsernameLabel.Text = "";
                DialogResult result = loginForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }

                this.Opacity = 1;
                this.Show();
            }
        }
    }
}
