using AutoMapper;
using Samples.ApplicationLayer;
using Samples.DomainLayer;
using System.Collections.Generic;

namespace Samples.InfrastructureLayer.DataContext
{
    public class PersonQueries : Queries, IPersonQueries
    {
        public PersonQueries(SampleContext context, IMapper mapper) : base(context, mapper)
        {
        }

        /// <inheritdoc />
        public IEnumerable<Person> GetAllPersons()
        {
            return Mapper.Map<IEnumerable<Person>>(Persons);
        }
    }
}