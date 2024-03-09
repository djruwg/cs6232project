using RentMe.Controller;

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

        private void ResizeMemberSearchListViewColumns()
        {
            float[] columnWidthPercentages = { 0.2f, 0.3f, 0.2f, 0.3f };

            if (this.MemberSearchListView.Columns.Count != columnWidthPercentages.Length)
            {
                throw new ArgumentException("The number of columns in the ListView must match the number of width percentages provided.");
            }

            int totalWidth = this.MemberSearchListView.ClientSize.Width;
            // Accounting for scroll bar
            totalWidth -= SystemInformation.VerticalScrollBarWidth;

            for (int i = 0; i < columnWidthPercentages.Length; i++)
            {
                this.MemberSearchListView.Columns[i].Width = (int)(totalWidth * columnWidthPercentages[i]);
            }
        }
    }
}
