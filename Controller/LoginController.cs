using RentMe.DAL;
using RentMe.Helper;

namespace RentMe.Controller
{
    /// <summary>
    /// Manage the Login
    /// </summary>
    internal class LoginController
    {
        private static int _currentEmployeeID = 0;
        private LoginDAL _loginDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        public LoginController()
        {
            this._loginDAL = new LoginDAL();
        }

        /// <summary>
        /// Gets the current employee identifier.
        /// </summary>
        /// <value>
        /// The current employee identifier.
        /// </value>
        public static int CurrentEmployeeID { get { return _currentEmployeeID; } }

        /// <summary>
        /// Authenticates the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True on successfull authentication.</returns>
        public int Authenticate(string username, string password)
        {
            var hash = PasswordHelper.Hash(password);
            _currentEmployeeID = this._loginDAL.Authenticate(username, hash);
            return _currentEmployeeID;
        }
    }
}
