using Samples.DomainLayer;

namespace Samples.ApplicationLayer
{
    public interface IPersonCommands
    {
        /// <summary>
        /// Create a new person.
        /// </summary>
        Person CreatePerson(Person person);
    }
}