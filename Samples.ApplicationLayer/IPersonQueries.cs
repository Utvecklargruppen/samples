using Samples.DomainLayer;
using System;
using System.Collections.Generic;

namespace Samples.ApplicationLayer
{
    public interface IPersonQueries
    {
        /// <summary>
        /// Get all persons from the data store.
        /// </summary>
        IEnumerable<Person> GetAllPersons();

        /// <summary>
        /// Get one person from the data store.
        /// </summary>
        Person GetPerson(Guid id);
    }
}