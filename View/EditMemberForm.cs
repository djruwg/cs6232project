namespace RentMe.View
{
    public partial class EditMemberForm : Form
    {
        public EditMemberForm(int id)
        {
            InitializeComponent();

            EditMemberFormMemberIDTextBox.Text = id.ToString();

            EditMemberMemberEditorUserControl.EditMember(id);
        }
    }
}
