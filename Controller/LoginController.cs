using RentMe.DAL;
using RentMe.Helper;

namespace RentMe.Controller
{
    internal class LoginController
    {
        private LoginDAL _loginDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        public LoginController()
        {
            this._loginDAL = new LoginDAL();
        }

        /// <summary>
        /// Authenticates the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True on successfull authentication.</returns>
        public bool Authenticate(string username, string password)
        {
            var hash = PasswordHelper.Hash(password);

            return this._loginDAL.Authenticate(username, hash);
        }
    }
}
