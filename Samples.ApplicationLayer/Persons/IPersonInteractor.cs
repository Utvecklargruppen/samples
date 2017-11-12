using Samples.DomainLayer.Persons;

namespace Samples.ApplicationLayer.Persons
{
    /// <summary>
    /// The person interactor interface.
    /// </summary>
    public interface IPersonInteractor
    {
        /// <summary>
        /// Create a new person.
        /// </summary>
        Person CreatePerson(Person person);
    }
}