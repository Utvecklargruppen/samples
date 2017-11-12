using Samples.DomainLayer.Persons;
using System;

namespace Samples.ApplicationLayer.Persons
{
    public class PersonInteractor : IPersonInteractor
    {
        private readonly IPersonCommands _commands;
        private readonly IUnitOfWork _unitOfWork;

        public PersonInteractor(IPersonCommands commands, IUnitOfWork unitOfWork)
        {
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
    }
}