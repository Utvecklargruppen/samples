using AutoMapper;
using Samples.ApplicationLayer;
using Samples.ApplicationLayer.Persons;
using Samples.InfrastructureLayer.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Samples.InfrastructureLayer.Persons
{
    public class PersonQueries : Queries, IQueries<IPersonDto>
    {
        public PersonQueries(SampleContext context, IMapper mapper) : base(context, mapper)
        {
        }

        /// <inheritdoc />
        public IPersonDto Get(Guid id)
        {
            var personDao = Persons.SingleOrDefault(p => p.Id == id);
            return Mapper.Map<PersonDto>(personDao); // TODO: Map organizations
        }

        /// <inheritdoc />
        public IEnumerable<IPersonDto> GetAll()
            => Mapper.Map<IEnumerable<PersonDto>>(Persons);  // TODO: Map organizations
    }
}