using AutoMapper;
using System;

namespace Samples.InfrastructureLayer.DataContext
{
    public abstract class Commands
    {
        protected readonly IMapper Mapper;
        private readonly SampleContext _context;

        protected Commands(SampleContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        protected T Insert<T>(T entity) where T : class
        {
            _context.Add(entity);
            return entity;
        }
    }
}