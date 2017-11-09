using AutoMapper;
using Samples.ApplicationLayer;
using Samples.DomainLayer;
using Samples.InfrastructureLayer.Daos;
using System;

namespace Samples.InfrastructureLayer.DataContext
{
    public class PersonCommands : Commands, IPersonCommands
    {
        /// <inheritdoc />
        public PersonCommands(SampleContext context, IMapper mapper) : base(context, mapper)
        {
        }

        /// <inheritdoc />
        public Person CreatePerson(Person person)
        {
            person.Id = Guid.NewGuid();
            var personDao = Mapper.Map<PersonDao>(person);

            Insert(personDao);
            return person;
        }
    }
}