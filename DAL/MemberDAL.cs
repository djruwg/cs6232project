using RentMe.Model;
using System.Data;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    internal class MemberDAL
    {
        /// <summary>
        /// Gets the member by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>a Member object</returns>
        public Member GetMemberByID(int id)
        {
            Member returnValue = null;

            string statement = @"
                select
                    FirstName,
                    LastName,
                    Phone,
                    Address,
                    City,
                    State,
                    Zip,
                    DateOfBirth,
                    Sex
                from
                    Members
                where
                    MemberID = @MemberID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(statement, connection))
                {
                    command.Parameters.Add("@MemberID", SqlDbType.Int);
                    command.Parameters["@MemberID"].Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int firstNameOrdinal = reader.GetOrdinal("FirstName");
                        int lastNameOrdinal = reader.GetOrdinal("FirstName");
                        int phoneOrdinal = reader.GetOrdinal("Phone");
                        int addressOrdinal = reader.GetOrdinal("Address");
                        int cityOrdinal = reader.GetOrdinal("City");
                        int stateOrdinal = reader.GetOrdinal("State");
                        int zipOrdinal = reader.GetOrdinal("Zip");
                        int dateOfBirthOrdinal = reader.GetOrdinal("DateOfBirth");
                        int sexOrdinal = reader.GetOrdinal("Sex");

                        reader.Read();

                        returnValue = new Member
                        {
                            MemberID = id,
                            FirstName = reader.GetString(firstNameOrdinal),
                            LastName = reader.GetString(lastNameOrdinal),
                            Phone = reader.GetString(phoneOrdinal),
                            Address = reader.GetString(addressOrdinal),
                            City = reader.GetString(cityOrdinal),
                            State = reader.GetString(stateOrdinal),
                            Zip = reader.GetString(zipOrdinal),
                            DateOfBirth = reader.GetDateTime(dateOfBirthOrdinal),
                            Sex = reader.GetString(sexOrdinal)
                        };
                    }
                }
            }

            return returnValue;
        }

        public void AddMember(Member member)
        {
            ArgumentNullException.ThrowIfNull(member);

            string statement = @"
                insert into Members (
                    FirstName,
                    LastName,
                    Phone,
                    Address,
                    City,
                    State,
                    Zip,
                    DateOfBirth,
                    Sex )
                values (
                    @FirstName,
                    @LastName,
                    @Phone,
                    @Address,
                    @City,
                    @State,
                    @Zip,
                    @DateOfBirth,
                    @Sex )";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(statement, connection))
                {
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50);
                    command.Parameters["@FirstName"].Value = member.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar, 50);
                    command.Parameters["@LastName"].Value = member.LastName;
                    command.Parameters.Add("@Phone", SqlDbType.VarChar, 13);
                    command.Parameters["@Phone"].Value = member.Phone;
                    command.Parameters.Add("@Address", SqlDbType.VarChar, 100);
                    command.Parameters["@Address"].Value = member.Address;
                    command.Parameters.Add("@City", SqlDbType.VarChar, 50);
                    command.Parameters["@City"].Value = member.City;
                    command.Parameters.Add("@State", SqlDbType.VarChar, 13);
                    command.Parameters["@State"].Value = member.State;
                    command.Parameters.Add("@Zip", SqlDbType.VarChar, 13);
                    command.Parameters["@Zip"].Value = member.Zip;
                    command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime);
                    command.Parameters["@DateOfBirth"].Value = member.DateOfBirth;
                    command.Parameters.Add("@Sex", SqlDbType.Char, 1);
                    command.Parameters["@Sex"].Value = member.Sex;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
