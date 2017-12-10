using AutoMapper;
using Samples.ApplicationLayer;
using Samples.ApplicationLayer.Organizations;
using Samples.InfrastructureLayer.DataContext;
using System;
using System.Collections.Generic;

namespace Samples.InfrastructureLayer.Organizations
{
    public class OrganizationQueries : Queries, IQueries<IOrganizationDto>
    {
        /// <inheritdoc />
        public OrganizationQueries(SampleContext context, IMapper mapper) : base(context, mapper)
        {
        }

        /// <inheritdoc />
        public IOrganizationDto Get(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<IOrganizationDto> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}