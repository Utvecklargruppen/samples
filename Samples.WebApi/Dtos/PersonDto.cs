namespace Samples.WebApi.Dtos
{
    /// <summary>
    /// The person class.
    /// </summary>
    public class PersonDto : CreatePersonDto
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