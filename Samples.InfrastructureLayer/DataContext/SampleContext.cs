﻿using Microsoft.EntityFrameworkCore;
using Samples.InfrastructureLayer.Daos;

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