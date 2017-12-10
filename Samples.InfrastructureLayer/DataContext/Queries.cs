using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Samples.InfrastructureLayer.Organizations;
using Samples.InfrastructureLayer.Persons;
using System;
using System.Linq;

namespace Samples.InfrastructureLayer.DataContext
{
    public abstract class Queries
    {
        protected readonly IMapper Mapper;
        private readonly SampleContext _context;

        protected Queries(SampleContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        protected IQueryable<OrganizationDao> Organizations => _context.Organizations.AsNoTracking();

        protected IQueryable<PersonDao> Persons => _context.Persons.AsNoTracking();
    }
}