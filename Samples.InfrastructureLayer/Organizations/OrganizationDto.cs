using Samples.ApplicationLayer;
using System;

namespace Samples.InfrastructureLayer.Organizations
{
    public class OrganizationDto : IOrganizationDto
    {
        /// <summary>
        /// Gets or sets the id. The primary key.
        /// </summary>
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}