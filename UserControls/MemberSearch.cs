﻿using RentMe.Controller;
using RentMe.Model;
using RentMe.View;
using System.Text.RegularExpressions;

namespace RentMe.UserControls
{
    /// <summary>
    /// Member Search User Control
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
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
            MemberSearchSearchMessageLabel.Text = string.Empty;
        }

        private void UserControl_Resize(object sender, EventArgs e)
        {
            this.ResizeMemberSearchListViewColumns();
        }

        private void MemberSearchListView_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                ShowMemberForm showMemberForm =
                    new ShowMemberForm(Int32.Parse(this.MemberSearchListView.SelectedItems[0].Text));
                DialogResult result = showMemberForm.ShowDialog();
                this.PopulateSearchListView(this._memberController.GetSearchedMembers(string.Empty));

                if (result == DialogResult.Continue)
                {
                    // This isn't great, since it ties the user control to the main window
                    MainDashboard mainDashboard = (MainDashboard)this.ParentForm!;
                    mainDashboard?.SelectCartTab();
                }
            }
            catch
            {
                this.MemberSearchSearchMessageLabel.Text = "Failed to open selected member";
            }
        }

        private void MemberSearchSearchButton_Click(object sender, EventArgs e)
        {
            this.SearchMembers();
        }

        private void SearchMembers()
        {
            string searchString = Regex.Replace(this.MemberSearchSearchTextBox.Text, @"\s+", " ");

            try
            {
                this.PopulateSearchListView(this._memberController.GetSearchedMembers(searchString));
            }
            catch (Exception ex)
            {
                this.MemberSearchSearchMessageLabel.Text = ex.Message;
            }
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
            this.MemberSearchSearchMessageLabel.Text = string.Empty;
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
                this.MemberSearchSearchMessageLabel.Text = "No members found";
            }
        }

        /// <summary>
        /// Populates the search with all members.
        /// </summary>
        public void PopulateSearchWithAllMembers()
        {
            try
            {
                this.PopulateSearchListView(this._memberController.GetAllMembers());
            }
            catch (Exception ex)
            {
                MemberSearchSearchMessageLabel.Text = ex.Message;
            }
        }
    }
}
