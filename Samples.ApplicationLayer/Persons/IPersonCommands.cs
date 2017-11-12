using Samples.DomainLayer.Persons;

namespace Samples.ApplicationLayer.Persons
{
    public interface IPersonCommands
    {
        /// <summary>
        /// Create a new person.
        /// </summary>
        Person CreatePerson(Person person);
    }
}