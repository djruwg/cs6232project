using RentMe.DAL;
using RentMe.Helper;

namespace RentMe.Controller
{
    internal class LoginController
    {
        /// <summary>
        /// Authenticates the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True on successfull authentication.</returns>
        public static bool Authenticate(string username, string password)
        {
            var hash = PasswordHelper.Hash(password);

            return LoginDAL.Authenticate(username, hash);
        }
    }
}
