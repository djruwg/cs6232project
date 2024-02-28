﻿using System.Data;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    internal class LoginDAL
    {
        public static bool Authenticate(string username, string password)
        {
            int count = 0;

            string selectStatement = @"
                select
                    count(*)
                from
                    Employees
                where
                    Username = @username
                and
                    Password = @password";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.Add("@username", SqlDbType.VarChar, 20);
                    command.Parameters["@username"].Value = username;
                    command.Parameters.Add("@password", SqlDbType.VarChar, 256);
                    command.Parameters["@password"].Value = password;

                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return count != 0;
        }
    }
}
