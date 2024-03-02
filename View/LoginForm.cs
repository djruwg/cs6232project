using RentMe.Controller;

namespace RentMe.View
{
    /// <summary>
    /// Presents a login modal form
    /// </summary>
    public partial class LoginForm : Form
    {
        private LoginController _loginController;

        /// <summary>
        /// Constructor for the login form
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();

            this._loginController = new LoginController();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._loginController.Authenticate(UsernameTextBox.Text, PasswordTextBox.Text) == true)
                {
                    MainDashboard? mainDashboard = this.Owner as MainDashboard;

                    if (mainDashboard != null)
                    {
                        // mainDashboard.SetUsername(this.UsernameTextBox.Text);
                    }

                    this.Hide();

                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    this.ErrorMessageLabel.Text = "Invalid username/password.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ErrorMessageLabel.Text.Equals(""))
            {
                this.ErrorMessageLabel.Text = "";
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ErrorMessageLabel.Text.Equals(""))
            {
                this.ErrorMessageLabel.Text = "";
            }
        }
    }
}
