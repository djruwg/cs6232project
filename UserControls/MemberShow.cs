using RentMe.Controller;
using RentMe.Model;
using RentMe.View;

namespace RentMe.UserControls
{
    /// <summary>
    /// UserControl For Showing Member info
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class MemberShow : UserControl
    {
        private MemberController _memberController;
        private Member _member;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberShow"/> class.
        /// </summary>
        public MemberShow()
        {
            InitializeComponent();
            this._memberController = new MemberController();
        }

        /// <summary>
        /// Sets the member.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <exception cref="System.InvalidOperationException">No member was found with the given member ID.</exception>
        public void SetMember(int memberID)
        {
            this._member = this._memberController.GetMemberByID(memberID);

            if (this._member == null)
            {
                throw new InvalidOperationException("No member was found with the given member ID.");
            }

            MemberShowIDTextBox.Text = _member.MemberID.ToString();
            MemberShowFirstNameTextBox.Text = _member.FirstName;
            MemberShowLastNameTextBox.Text = _member.LastName;
        }

        private void MemberShowEditMemberButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Not Yet Implemented", "Not Yet Implemented");
            EditMemberForm editMemberForm = new EditMemberForm(this._member.MemberID);
            editMemberForm.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Implemented", "Not Yet Implemented");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Implemented", "Not Yet Implemented");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
