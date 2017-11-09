using Samples.DomainLayer;
using System;
using System.Collections.Generic;

namespace Samples.ApplicationLayer
{
    public class PersonInteractor : IPersonInteractor
    {
        private readonly IPersonCommands _commands;
        private readonly IPersonQueries _queries;
        private readonly IUnitOfWork _unitOfWork;

        public PersonInteractor(IPersonQueries queries, IPersonCommands commands, IUnitOfWork unitOfWork)
        {
            _queries = queries ?? throw new ArgumentNullException(nameof(queries));
            _commands = commands ?? throw new ArgumentNullException(nameof(commands));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        /// <inheritdoc />
        public Person CreatePerson(Person person)
        {
            var createdPerson = _commands.CreatePerson(person);
            _unitOfWork.Store();
            return createdPerson;
        }

        /// <inheritdoc />
        public Person GetPerson(Guid id) => _queries.GetPerson(id);

        /// <inheritdoc />
        public IEnumerable<Person> GetPersons() => _queries.GetAllPersons();
    }
}