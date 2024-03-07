﻿using RentMe.Controller;
using RentMe.Model;
using System.Text.RegularExpressions;

namespace RentMe.UserControls
{
    public partial class MemberEditor : UserControl
    {
        private MemberController _memberController;
        private Member _member;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberEditor"/> class.
        /// </summary>
        public MemberEditor()
        {
            InitializeComponent();

            this._memberController = new MemberController();

            this.PopulateComboBox();

            this.ClearMessages();

            this._member = new Member();
        }

        /// <summary>
        /// Given a member ID of zero, creates a new member else
        /// looked up an existing member to update.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void EditMember(int id)
        {
            if (id > 0)
            {
                this._member = this._memberController.GetMemberByID(id);

                if (this._member == null)
                {
                    throw new InvalidOperationException("No member was found with the given member ID.");
                }

                MemberEditorFirstNameTextField.Text = this._member.FirstName;
                MemberEditorLastNameTextField.Text = this._member.LastName;
                MemberEditorPhoneTextField.Text = this._member.Phone;
                MemberEditorAddressTextField.Text = this._member.Address;
                MemberEditorCityTextField.Text = this._member.City;
                MemberEditorStateComboBox.SelectedItem = this._member.State;
                MemberEditorZipTextField.Text = this._member.Zip;
                MemberEditorBirthdatePicker.Value = this._member.DateOfBirth;
                MemberEditorSexComboBox.SelectedIndex = MemberEditorSexComboBox.FindString(this._member.Sex);

                MemberEditorClearButton.Text = "Cancel";
            }
            else
            {
                this._member = new Member();
            }
        }

        public void PopulateComboBox()
        {
            Dictionary<string, char> dict = new Dictionary<string, char>()
            {
                {"Male ",'M'},
                {"Female", 'F'}
            };

            MemberEditorSexComboBox.DataSource = new BindingSource(dict, null);
            MemberEditorSexComboBox.DisplayMember = "Key";
            MemberEditorSexComboBox.ValueMember = "Value";
        }

        private bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, "\\A(\\+\\d{1,2}\\s?)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}\\z");
        }

        private void CopyInputToMemberObject()
        {
            ArgumentNullException.ThrowIfNull(this._member);

            this._member.FirstName = MemberEditorFirstNameTextField.Text;
            this._member.LastName = MemberEditorLastNameTextField.Text;
            this._member.Phone = MemberEditorPhoneTextField.Text;
            this._member.Address = MemberEditorAddressTextField.Text;
            this._member.City = MemberEditorCityTextField.Text;
            this._member.State = MemberEditorStateComboBox.Text;
            this._member.Zip = MemberEditorZipTextField.Text;
            this._member.DateOfBirth = MemberEditorBirthdatePicker.Value.Date;
            this._member.Sex = MemberEditorSexComboBox.SelectedValue != null ? MemberEditorSexComboBox.SelectedValue.ToString() : "";
        }

        private void MemberEditorSaveButton_Click(object sender, EventArgs e)
        {
            bool hasErrors = false;

            this.ClearMessages();

            if (this.ValidatePhone(MemberEditorPhoneTextField.Text) == false)
            {
                MemberEditorPhoneMessageLabel.Text = "Not a valid phone number";
                hasErrors = true;
            }

            if (this.MemberEditorBirthdatePicker.Value.Date == DateTime.Now.Date)
            {
                MemberEditorBirthdateMessageLabel.Text = "Please set a birthdate";
                hasErrors = true;
            }

            if (hasErrors)
            {
                return;
            }

            this.CopyInputToMemberObject();
            this.ClearMessages();
            this.ClearInput();

            if (this._member.MemberID == 0)
            {
                this._memberController.AddMember(this._member);

                MemberEditorMessageLabel.Text = "New member added.";
            }
            else
            {
                this._memberController.UpdateMember(this._member);

                MemberEditorMessageLabel.Text = "Member updated.";
            }
        }

        private void ClearMessages()
        {
            MemberEditorFirstNameMessageLabel.Text = "";
            MemberEditorLastNameMessageLabel.Text = "";
            MemberEditorPhoneMessageLabel.Text = "";
            MemberEditorAddressMessageLabel.Text = "";
            MemberEditorCityMessageLabel.Text = "";
            MemberEditorStateMessageLabel.Text = "";
            MemberEditorZipMessageLabel.Text = "";
            MemberEditorBirthdateMessageLabel.Text = "";
            MemberEditorSexMessageLabel.Text = "";
            MemberEditorMessageLabel.Text = "";
        }

        private void ClearInput()
        {
            MemberEditorFirstNameTextField.Text = "";
            MemberEditorLastNameTextField.Text = "";
            MemberEditorPhoneTextField.Text = "";
            MemberEditorAddressTextField.Text = "";
            MemberEditorCityTextField.Text = "";
            MemberEditorStateComboBox.SelectedItem = null;
            MemberEditorZipTextField.Text = "";
            MemberEditorBirthdatePicker.Value = DateTime.Now;
            MemberEditorSexComboBox.SelectedItem = null;
        }

        private void MemberEditorClearButton_Click(object sender, EventArgs e)
        {
            if (this._member == null)
            {
                throw new InvalidOperationException("No member object was referenced.");
            }

            if (this._member.MemberID != 0)
            {
                this.ParentForm.Close();

                return;
            }

            this.ClearMessages();
            this.ClearInput();

            this._member = new Member();
        }
    }
}
