
namespace RentMe.Model
{
    /// <summary>
    /// Member model class
    /// </summary>
    public class Member
    {
        private bool _modified;
        private string? _firstName;
        private string? _lastName;
        private string? _sex;
        private string? _phone;
        private string? _address;
        private string? _city;
        private string? _state;
        private string? _zip;

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        public Member()
        {
            this._modified = false;
            this._firstName = string.Empty;
            this._lastName = string.Empty;
            this._sex = string.Empty;
            this._phone = string.Empty;
            this._address = string.Empty;
            this._city = string.Empty;
            this._state = string.Empty;
            this._zip = string.Empty;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is modified.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is modified; otherwise, <c>false</c>.
        /// </value>
        public bool IsModified
        {
            get => this._modified;
            set => this._modified = value;
        }

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>
        /// The member identifier.
        /// </value>
        public int MemberID { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            get => this._firstName!;
            set
            {
                this._modified = this._modified ? true : (this._firstName!.Equals(value) == false);
                this._firstName = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName
        {
            get => this._lastName!;
            set
            {
                this._modified = this._modified ? true : (this._lastName!.Equals(value) == false);
                this._lastName = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the sex.
        /// </summary>
        /// <value>
        /// The sex.
        /// </value>
        public string Sex
        {
            get => this._sex!;
            set
            {
                this._modified = this._modified ? true : (this._sex!.Equals(value) == false);
                this._sex = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public string Phone
        {
            get => this._phone!;
            set
            {
                this._modified = this._modified ? true : (this._phone!.Equals(value) == false);
                this._phone = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        {
            get => this._address!;
            set
            {
                this._modified = this._modified ? true : (this._address!.Equals(value) == false);
                this._address = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City
        {
            get => this._city!;
            set
            {
                this._modified = this._modified ? true : (this._city!.Equals(value) == false);
                this._city = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State
        {
            get => this._state!;
            set
            {
                this._modified = this._modified ? true : (this._state!.Equals(value) == false);
                this._state = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public string Zip
        {
            get => this._zip!;
            set
            {
                this._modified = this._modified ? true : (this._zip!.Equals(value) == false);
                this._zip = value ?? string.Empty;
            }
        }
    }
}
