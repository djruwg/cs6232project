using RentMe.Controller;
using RentMe.Model;

namespace RentMe.UserControls
{
    public partial class MemberSearch : UserControl
    {
        private MemberController _memberController;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberSearch"/> class.
        /// </summary>
        public MemberSearch()
        {
            InitializeComponent();
            this._memberController = new MemberController();
        }

        private void UserControl_Resize(object sender, EventArgs e)
        {
            this.ResizeMemberSearchListViewColumns();
        }

        private void MemberSearchListView_ItemActivate(object sender, EventArgs e)
        {
            // Event that will trigger show customer
            MessageBox.Show("MemberID: " + this.MemberSearchListView.SelectedItems[0].Text + " selected");
        }

        private void MemberSearchSearchButton_Click(object sender, EventArgs e)
        {
            this.PopulateSearchListView(this._memberController.GetSearchedMembers(this.MemberSearchSearchTextBox.Text));
        }

        private void ResizeMemberSearchListViewColumns()
        {
            float[] columnWidthPercentages = { 0.2f, 0.3f, 0.2f, 0.3f };

            if (this.MemberSearchListView.Columns.Count != columnWidthPercentages.Length)
            {
                throw new ArgumentException("The number of columns in the ListView must match the number of width percentages provided.");
            }

            int totalWidth = this.MemberSearchListView.ClientSize.Width;
            totalWidth -= SystemInformation.VerticalScrollBarWidth;

            for (int i = 0; i < columnWidthPercentages.Length; i++)
            {
                this.MemberSearchListView.Columns[i].Width = (int)(totalWidth * columnWidthPercentages[i]);
            }
        }

        private void PopulateSearchListView(List<Member> memberList)
        {
            this.MemberSearchSeachMessageLabel.Hide();
            this.MemberSearchListView.Items.Clear();
            if (memberList.Count > 0)
            {
                Member member;
                for (int i = 0; i < memberList.Count; i++)
                {
                    member = memberList[i];
                    this.MemberSearchListView.Items.Add(member.MemberID.ToString());
                    this.MemberSearchListView.Items[i].SubItems.Add(member.LastName.ToString());
                    this.MemberSearchListView.Items[i].SubItems.Add(member.FirstName.ToString());
                    this.MemberSearchListView.Items[i].SubItems.Add(member.Phone.ToString());
                }
            }
            else
            {
                this.MemberSearchSeachMessageLabel.Text = "No members found";
                this.MemberSearchSeachMessageLabel.Show();
            }
        }

        /// <summary>
        /// Populates the search with all members.
        /// </summary>
        public void PopulateSearchWithAllMembers()
        {
            this.PopulateSearchListView(this._memberController.GetAllMembers());
        }
    }
}
