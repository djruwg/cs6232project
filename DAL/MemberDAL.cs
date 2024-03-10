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
        /// <param name="id">The member ID.</param>
        /// <returns>A Member object</returns>
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
                        int lastNameOrdinal = reader.GetOrdinal("LastName");
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

        /// <summary>
        /// Adds the member.
        /// </summary>
        /// <param name="member">The Member object.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
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

        /// <summary>
        /// Updates the member.
        /// </summary>
        /// <param name="member">The Member object.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public void UpdateMember(Member member)
        {
            ArgumentNullException.ThrowIfNull(member);

            string statement = @"
                update
                    Members
                set
                    FirstName = @FirstName,
                    LastName = @LastName,
                    Phone = @Phone,
                    Address = @Address,
                    City = @City,
                    State = @State,
                    Zip = @Zip,
                    DateOfBirth = @DateOfBirth,
                    Sex = @Sex
                where
                    MemberID = @MemberID";

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
                    command.Parameters.Add("@MemberID", SqlDbType.Int);
                    command.Parameters["@MemberID"].Value = member.MemberID;

                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Gets all members from Members table.
        /// </summary>
        /// <returns>List of Member objects</returns>
        public List<Member> GetAllMembers()
        {
            List<Member> memberList = new List<Member>();

            string selectStatement = @"
                SELECT *
                FROM Members;
                ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member();
                            member.MemberID = (int)reader["MemberID"];
                            member.FirstName = reader["FirstName"].ToString();
                            member.LastName = reader["LastName"].ToString();
                            member.Sex = reader["Sex"].ToString();
                            member.DateOfBirth = (DateTime)reader["DateOfBirth"];
                            member.Phone = reader["Phone"].ToString();
                            member.Address = reader["Address"].ToString();
                            member.City = reader["City"].ToString();
                            member.State = reader["State"].ToString();
                            member.Zip = reader["Zip"].ToString();
                            memberList.Add(member);
                        }
                    }
                }
            }

            return memberList;
        }

        /// <summary>
        /// Gets the searched members.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns>List of matching Member objects</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public List<Member> GetSearchedMembers(String searchString)
        {
            ArgumentNullException.ThrowIfNull(searchString);

            List<Member> memberList = new List<Member>();

            string selectStatement = @"
                DECLARE @SearchTerm NVARCHAR(100) = @searchString;

                SELECT * FROM Members
                WHERE 
                    FirstName LIKE '%' + @SearchTerm + '%' 
                    OR LastName LIKE '%' + @SearchTerm + '%'
                    OR MemberID = TRY_CAST(@SearchTerm AS INT)
                    OR Phone LIKE '%' + @SearchTerm + '%';
                ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@searchString", SqlDbType.VarChar);
                    selectCommand.Parameters["@searchString"].Value = searchString;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member();
                            member.MemberID = (int)reader["MemberID"];
                            member.FirstName = reader["FirstName"].ToString();
                            member.LastName = reader["LastName"].ToString();
                            member.Sex = reader["Sex"].ToString();
                            member.DateOfBirth = (DateTime)reader["DateOfBirth"];
                            member.Phone = reader["Phone"].ToString();
                            member.Address = reader["Address"].ToString();
                            member.City = reader["City"].ToString();
                            member.State = reader["State"].ToString();
                            member.Zip = reader["Zip"].ToString();
                            memberList.Add(member);
                        }
                    }
                }
            }

            return memberList;
        }
    }
}
