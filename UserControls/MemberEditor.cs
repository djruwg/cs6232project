using System.Diagnostics;
using System.Text.RegularExpressions;

namespace RentMe.UserControls
{
    public partial class MemberEditor : UserControl
    {
        public MemberEditor()
        {
            InitializeComponent();

            this.ClearMessages();
        }

        private bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, "\\A(\\+\\d{1,2}\\s?)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}\\z");
        }

        private void MemberEditorSaveButton_Click(object sender, EventArgs e)
        {
            this.ClearMessages();

            if (this.ValidatePhone(MemberEditorPhoneTextField.Text) == false)
            {
                MemberEditorPhoneMessageLabel.Text = "Not a valid phone number";
            }

            if (this.MemberEditorBirthdatePicker.Value.Date == DateTime.Now.Date)
            {
                MemberEditorBirthdateMessageLabel.Text = "Please set a birthdate";
            }

            Debug.WriteLine(MemberEditorBirthdatePicker.Text);
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
            this.ClearMessages();
            this.ClearInput();
        }
    }
}
