using System;

namespace Samples.WebApi.Dtos
{
    /// <summary>
    /// The person class.
    /// </summary>
    public class PersonDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonDto"/> class.
        /// </summary>
        public PersonDto()
        {
            Mail = string.Empty;
            Name = string.Empty;
        }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the last four digits.
        /// </summary>
        public int LastFourDigits { get; set; }

        /// <summary>
        /// Gets or sets the mail.
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Gets or sets the users name.
        /// </summary>
        public string Name { get; set; }
    }
}