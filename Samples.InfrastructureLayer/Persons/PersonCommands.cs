using AutoMapper;
using Samples.ApplicationLayer.Persons;
using Samples.DomainLayer.Persons;
using Samples.InfrastructureLayer.DataContext;
using System;

namespace Samples.InfrastructureLayer.Persons
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