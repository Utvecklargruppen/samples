using Microsoft.EntityFrameworkCore;
using Samples.InfrastructureLayer.Persons;

namespace Samples.InfrastructureLayer.DataContext
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options) : base(options)
        {
        }

        public DbSet<PersonDao> Persons { get; set; }
    }
}