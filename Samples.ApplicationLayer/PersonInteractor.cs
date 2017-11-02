using Samples.DomainLayer;
using System.Collections.Generic;

namespace Samples.ApplicationLayer
{
    public class PersonInteractor : IPersonInteractor
    {
        /// <inheritdoc />
        public IEnumerable<Person> GetPersons()
        {
            throw new System.NotImplementedException();
        }
    }
}