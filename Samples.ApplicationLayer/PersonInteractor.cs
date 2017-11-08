using Samples.DomainLayer;
using System;
using System.Collections.Generic;

namespace Samples.ApplicationLayer
{
    public class PersonInteractor : IPersonInteractor
    {
        private readonly IPersonQueries _queries;

        public PersonInteractor(IPersonQueries queries) => _queries = queries ?? throw new ArgumentNullException(nameof(queries));

        /// <inheritdoc />
        public Person GetPerson(Guid id) => _queries.GetPerson(id);

        /// <inheritdoc />
        public IEnumerable<Person> GetPersons() => _queries.GetAllPersons();
    }
}