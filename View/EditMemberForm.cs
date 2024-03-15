namespace RentMe.View
{
    /// <summary>
    /// Form wrapper around the MemberEditor user control when called in edit mode
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EditMemberForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditMemberForm"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public EditMemberForm(int id)
        {
            InitializeComponent();

            EditMemberFormMemberIDTextBox.Text = id.ToString();

            EditMemberMemberEditorUserControl.EditMember(id);
        }
    }
}
