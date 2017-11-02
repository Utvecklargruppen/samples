using Samples.DomainLayer;
using System.Collections.Generic;

namespace Samples.ApplicationLayer
{
    /// <summary>
    /// The person interactor interface.
    /// </summary>
    public interface IPersonInteractor
    {
        /// <summary>
        /// Get all persons.
        /// </summary>
        IEnumerable<Person> GetPersons();
    }
}