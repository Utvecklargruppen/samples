using AutoMapper;
using Samples.ApplicationLayer;
using Samples.ApplicationLayer.Organizations;
using Samples.InfrastructureLayer.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var organizationDao = Organizations.SingleOrDefault(o => o.Id == id);
            return Mapper.Map<OrganizationDto>(organizationDao);
        }

        /// <inheritdoc />
        public IEnumerable<IOrganizationDto> GetAll()
            => Mapper.Map<IEnumerable<OrganizationDto>>(Organizations);
    }
}