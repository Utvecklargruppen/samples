using System;
using System.Collections.Generic;

namespace Samples.ApplicationLayer.Persons
{
    public interface IPersonQueries
    {
        /// <summary>
        /// Get all persons from the data store.
        /// </summary>
        IEnumerable<IPersonDto> GetAllPersons();

        /// <summary>
        /// Get one person from the data store.
        /// </summary>
        IPersonDto GetPerson(Guid id);
    }
}