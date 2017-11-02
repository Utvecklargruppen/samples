namespace Samples.DomainLayer
{
    /// <summary>
    /// The person domain class.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
            MailAddress = string.Empty;
            Name = string.Empty;
        }

        /// <summary>
        /// Gets or sets a persons date of birth.
        /// </summary>
        public BirthDate DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the last four digits.
        /// </summary>
        public int LastFourDigits { get; set; }

        /// <summary>
        /// Gets or sets the mail.
        /// </summary>
        public string MailAddress { get; set; }

        /// <summary>
        /// Gets or sets the persons name.
        /// </summary>
        public string Name { get; set; }
    }
}