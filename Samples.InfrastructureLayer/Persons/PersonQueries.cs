using AutoMapper;
using Samples.ApplicationLayer.Persons;
using Samples.InfrastructureLayer.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Samples.InfrastructureLayer.Persons
{
    public class PersonQueries : Queries, IPersonQueries
    {
        public PersonQueries(SampleContext context, IMapper mapper) : base(context, mapper)
        {
        }

        /// <inheritdoc />
        public IEnumerable<IPersonDto> GetAllPersons()
            => Mapper.Map<IEnumerable<PersonDto>>(Persons);

        /// <inheritdoc />
        public IPersonDto GetPerson(Guid id)
        {
            var personDao = Persons.SingleOrDefault(p => p.Id == id);
            return Mapper.Map<PersonDto>(personDao);
        }
    }
}