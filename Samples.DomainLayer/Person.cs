using System.Net.Mail;

namespace Samples.DomainLayer
{
    /// <summary>
    /// The person domain class.
    /// NOTE: The is an example for a fictitious domain. Do not use!
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
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
        public MailAddress MailAddress { get; set; }

        /// <summary>
        /// Gets or sets the persons name.
        /// </summary>
        public string Name { get; set; }
    }
}