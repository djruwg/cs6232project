using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Model;
using RentMe.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentMe.UserControls
{
    public partial class MemberShow : UserControl
    {
        private MemberController _memberController;
        private Member _member;

        public MemberShow()
        {
            InitializeComponent();
            this._memberController = new MemberController();
        }

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
