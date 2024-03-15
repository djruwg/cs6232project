using RentMe.Controller;
using RentMe.Model;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace RentMe.UserControls
{
    /// <summary>
    /// Member Editor User Control, Used by both the Add and Edit features
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
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

                this._member.IsModified = false;

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

        /// <summary>
        /// Populates the ComboBox.
        /// </summary>
        public void PopulateComboBox()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"Male", "M"},
                {"Female", "F"}
            };

            MemberEditorSexComboBox.DataSource = new BindingSource(dict, null);
            MemberEditorSexComboBox.DisplayMember = "Key";
            MemberEditorSexComboBox.ValueMember = "Value";
            MemberEditorSexComboBox.SelectedItem = null;
        }

        private bool ValidateInput(string input, int maxLength)
        {
            return string.IsNullOrWhiteSpace(input) == false && input.Length <= maxLength;
        }

        private bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, "\\A(\\+\\d{1,2}\\s?)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}\\z");
        }

        private bool ValidateZip(string zip)
        {
            return Regex.IsMatch(zip, "\\A\\d{5}(?:[-\\s]\\d{4})?\\z");
        }

        private void CopyInputToMemberObject()
        {
            ArgumentNullException.ThrowIfNull(this._member);

            this._member.FirstName = MemberEditorFirstNameTextField.Text;
            this._member.LastName = MemberEditorLastNameTextField.Text;
            this._member.Phone = Regex.Replace(MemberEditorPhoneTextField.Text, @"[-() ]", "");
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

            if (this.ValidateInput(MemberEditorFirstNameTextField.Text, 50) == false)
            {
                MemberEditorFirstNameMessageLabel.Text = "First name cannot be blank or over 50 characters.";
                hasErrors = true;
            }

            if (this.ValidateInput(MemberEditorLastNameTextField.Text, 50) == false)
            {
                MemberEditorLastNameMessageLabel.Text = "Last name cannot be blank or over 50 characters.";
                hasErrors = true;
            }

            if (this.ValidateInput(MemberEditorAddressTextField.Text, 100) == false)
            {
                MemberEditorAddressMessageLabel.Text = "Address cannot be blank or over 100 characters.";
                hasErrors = true;
            }

            if (this.ValidateInput(MemberEditorCityTextField.Text, 50) == false)
            {
                MemberEditorCityMessageLabel.Text = "Address cannot be blank or over 50 characters.";
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(MemberEditorStateComboBox.Text))
            {
                MemberEditorStateMessageLabel.Text = "Please select a state.";
                hasErrors = true;
            }

            if (MemberEditorSexComboBox.SelectedValue == null)
            {
                MemberEditorSexMessageLabel.Text = "Please select a gender.";
                hasErrors = true;
            }

            if (this.ValidateZip(MemberEditorZipTextField.Text) == false)
            {
                MemberEditorZipMessageLabel.Text = "Zip must be XXXXX or XXXXX-XXXX format.";
                hasErrors = true;
            }

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

            this.ClearMessages();

            this.CopyInputToMemberObject();

            if (this._member.IsModified == false)
            {
                MemberEditorMessageLabel.Text = "No modifications were made.";
                return;
            }

            if (this._member.MemberID == 0)
            {
                this._memberController.AddMember(this._member);

                this.ClearInput();

                MemberEditorMessageLabel.Text = "New member added.";
            }
            else
            {
                this._memberController.UpdateMember(this._member);

                MemberEditorMessageLabel.Text = "Member updated.";

                ParentForm.Close();
            }

            this._member.IsModified = false;
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
                ParentForm.Close();

                return;
            }

            this.ClearMessages();
            this.ClearInput();

            this._member = new Member();
        }
    }
}
