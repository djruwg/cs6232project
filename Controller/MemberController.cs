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
    }
}
