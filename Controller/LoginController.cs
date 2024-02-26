using RentMe.DAL;

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
            return LoginDAL.Authenticate(username, password);
        }
    }
}
