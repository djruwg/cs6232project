using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.UserControls;

namespace RentMe.View
{
    public partial class ShowMemberForm : Form
    {
        public ShowMemberForm(int memberID)
        {
            InitializeComponent();
            Debug.WriteLine($"Member ID passed is {memberID}");
            ShowMemberMemberShowUserControl.SetMember(memberID);

        }

        private void ShowMemberReturnItemsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Implemented", "Not Yet Implemented");

        }

        private void ShowMembersAttachCartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Yet Implemented", "Not Yet Implemented");

        }

        private void ShowMemberCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
