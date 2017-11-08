using Samples.DomainLayer;
using System;
using System.Collections.Generic;

namespace Samples.ApplicationLayer
{
    /// <summary>
    /// The person interactor interface.
    /// </summary>
    public interface IPersonInteractor
    {
        /// <summary>
        /// Get one person.
        /// </summary>
        Person GetPerson(Guid id);

        /// <summary>
        /// Get all persons.
        /// </summary>
        IEnumerable<Person> GetPersons();
    }
}