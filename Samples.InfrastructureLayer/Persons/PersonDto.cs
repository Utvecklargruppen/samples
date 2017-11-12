using Samples.ApplicationLayer.Persons;

namespace Samples.InfrastructureLayer.Persons
{
    /// <summary>
    /// The person class.
    /// </summary>
    public class PersonDto : CreatePersonDto, IPersonDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonDto"/> class.
        /// </summary>
        public PersonDto() => Id = string.Empty;

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }
    }
}