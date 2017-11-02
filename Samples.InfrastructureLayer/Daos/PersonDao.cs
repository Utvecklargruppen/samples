﻿using Samples.DomainLayer;
using System;

namespace Samples.InfrastructureLayer.Daos
{
    public class PersonDao
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonDao"/> class.
        /// </summary>
        public PersonDao()
        {
            DateOfBirth = BirthDate.DefaultDate;
            FirstName = string.Empty;
            LastName = string.Empty;
            MailAddress = string.Empty;
        }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the id. The primary key.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the last four digits.
        /// </summary>
        public int LastFourDigits { get; set; }

        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the mail address.
        /// </summary>
        public string MailAddress { get; set; }
    }
}