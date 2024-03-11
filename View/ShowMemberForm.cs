namespace RentMe.View
{
    /// <summary>
    /// Form to Show Members
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ShowMemberForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowMemberForm"/> class.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        public ShowMemberForm(int memberID)
        {
            InitializeComponent();
            ShowMemberMemberShowUserControl.SetMember(memberID);
        }

    }
}
