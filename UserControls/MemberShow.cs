using System.ComponentModel;
using System.Diagnostics;
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
        private RentalsController _rentalsController;
        private ReturnsController _returnsController;
        private Member _member;
        private BindingList<RentalTransaction> _rentals;
        private BindingList<ReturnTransaction> _returns;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberShow"/> class.
        /// </summary>
        public MemberShow()
        {
            InitializeComponent();
            this._memberController = new MemberController();
            this._rentalsController = new RentalsController();
            this._returnsController = new ReturnsController();
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

            this._rentals = this._rentalsController.GetRentalsByMember(this._member.MemberID);
            PopulateRentalsListView();
            this._returns = this._returnsController.GetReturnsByMember(this._member.MemberID);
            PopulateReturnsListView();

            MemberShowIDTextBox.Text = this._member.MemberID.ToString();
            MemberShowFirstNameTextBox.Text = this._member.FirstName;
            MemberShowLastNameTextBox.Text = this._member.LastName;
        }

        private void MemberShowEditMemberButton_Click(object sender, EventArgs e)
        {
            EditMemberForm editMemberForm = new EditMemberForm(this._member.MemberID);
            DialogResult result = editMemberForm.ShowDialog();
            this.SetMember(this._member.MemberID);
        }

        private void PopulateRentalsListView()
        {

            this.MemberShowRentalsListView.Items.Clear();

            int width = MemberShowRentalsListView.Width;
            MemberShowRentalsListView.Columns[0].Width = width / 2;
            MemberShowRentalsListView.Columns[1].Width = width / 2;

            if (this._rentals.Count > 0)
            {
                RentalTransaction rentalT;

                for (int i = 0; i < this._rentals.Count; i++)
                {
                    rentalT = this._rentals[i];
                    MemberShowRentalsListView.Items.Add(rentalT.RentalID.ToString());
                    MemberShowRentalsListView.Items[i].SubItems.Add(rentalT.DateRented.ToString("MM/dd/yyyy"));
                }
            }
        }

        private void PopulateReturnsListView()
        {
            this.MemberShowReturnsListView.Items.Clear();

            int width = MemberShowReturnsListView.Width;
            MemberShowReturnsListView.Columns[0].Width = width / 2;
            MemberShowReturnsListView.Columns[1].Width = width / 2;


            if (this._returns.Count > 0)
            {
                ReturnTransaction returnT;

                for (int i = 0; i < this._returns.Count; i++)
                {
                    returnT = this._returns[i];
                    MemberShowReturnsListView.Items.Add(returnT.ReturnID.ToString());
                    MemberShowReturnsListView.Items[i].SubItems.Add(returnT.DateReturned.ToString("MM/dd/yyyy"));
                }
            }
        }

        private void MemberShowReturnItemsButton_Click(object sender, EventArgs e)
        {
            ReturnItemsForm returnItems = new ReturnItemsForm(this._member.MemberID);
            returnItems.ShowDialog();
        }

        private void MemberShowAttachCartButton_Click(object sender, EventArgs e)
        {
            CartController cartController = new CartController();
            cartController.AttachedMember = this._member;

            ParentForm.DialogResult = DialogResult.Continue;
            ParentForm.Close();
        }

        private void MemberShowCancelButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
