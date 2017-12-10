using System;

namespace Samples.ApplicationLayer.Organizations
{
    public interface IOrganizationDto
    {
        /// <summary>
        /// Gets or sets the id. The primary key.
        /// </summary>
        Guid Id { get; set; }

        string Name { get; set; }
    }
}