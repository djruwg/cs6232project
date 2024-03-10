using RentMe.DAL;
using RentMe.Model;

namespace RentMe.Controller
{
    internal class MemberController
    {
        private MemberDAL _memberDAL;

        public MemberController()
        {
            this._memberDAL = new MemberDAL();
        }

        /// <summary>
        /// Gets the member by member ID.
        /// </summary>
        /// <param name="id">A member ID.</param>
        /// <returns>A Member object</returns>
        public Member GetMemberByID(int id)
        {
            return this._memberDAL.GetMemberByID(id);
        }

        /// <summary>
        /// Adds the member.
        /// </summary>
        /// <param name="member">The member object to add.</param>
        public void AddMember(Member member)
        {
            this._memberDAL.AddMember(member);
        }

        /// <summary>
        /// Updates the member.
        /// </summary>
        /// <param name="member">The member object to update.</param>
        public void UpdateMember(Member member)
        {
            this._memberDAL.UpdateMember(member);
        }

        /// <summary>
        /// Gets all members from Members table.
        /// </summary>
        /// <returns>List of Member objects</returns>
        public List<Member> GetAllMembers()
        {
            return this._memberDAL.GetAllMembers();
        }

        /// <summary>
        /// Gets the searched members.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns>List of matching Member objects</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public List<Member> GetSearchedMembers(String searchString)
        {
            return this._memberDAL.GetSearchedMembers(searchString);
        }
    }
}
