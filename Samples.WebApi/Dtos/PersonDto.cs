﻿namespace Samples.WebApi.Dtos
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
            Description = string.Empty;
            Mail = string.Empty;
            Name = string.Empty;
        }

        /// <summary>
        /// Gets or sets the description. A text field that describes the user.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the users id.
        /// </summary>
        public int Id { get; set; }

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