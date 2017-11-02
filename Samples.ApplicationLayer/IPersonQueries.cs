using Samples.DomainLayer;
using System.Collections.Generic;

namespace Samples.ApplicationLayer
{
    public interface IPersonQueries
    {
        /// <summary>
        /// Get all persons from the data store.
        /// </summary>
        IEnumerable<Person> GetAllPersons();
    }
}