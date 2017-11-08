using AutoMapper;
using Samples.ApplicationLayer;
using Samples.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Samples.InfrastructureLayer.DataContext
{
    public class PersonQueries : Queries, IPersonQueries
    {
        public PersonQueries(SampleContext context, IMapper mapper) : base(context, mapper)
        {
        }

        /// <inheritdoc />
        public IEnumerable<Person> GetAllPersons()
            => Mapper.Map<IEnumerable<Person>>(Persons);

        /// <inheritdoc />
        public Person GetPerson(Guid id)
        {
            var personDao = Persons.SingleOrDefault(p => p.Id == id);

            return Mapper.Map<Person>(personDao);
        }
    }
}