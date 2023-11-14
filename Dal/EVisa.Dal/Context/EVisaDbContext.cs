using EVisa.Dal.FluentApi;
using EVisa.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dal.Context
{
    public class EVisaDbContext : DbContext
    {
        public EVisaDbContext()
        {

        }

        public EVisaDbContext(DbContextOptions<EVisaDbContext> ctx) : base(ctx)
        {

        }
        //fluent api
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CountryMap());
            builder.ApplyConfiguration(new ApplicationTypeMap());
            builder.ApplyConfiguration(new DestinationMap());
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<ApplicationType> ApplicationTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=YAGMUR;database=EVisaDb;integrated security=true;TrustServerCertificate=true");
        }
    }
}
