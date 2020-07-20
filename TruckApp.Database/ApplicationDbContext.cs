using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TruckApp.Domain.Models;

namespace TruckApp.Database
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Broker> Brokers { get; set; }
        public DbSet<Dispatch> Dispatches { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<Truck> Trucks { get; set; }

        public DbSet<BrokerStaff> BrokerStaff { get; set; }
        public DbSet<FactoryStaff> FactoryStaff { get; set; }

        public DbSet<Load> Loads { get; set; }
        public DbSet<LoadDataRelationship> LoadDataRelationships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<LoadDataRelationship>()
                .HasKey(x => new { x.LoadId, x.BrokerId, x.DispatchId, x.DriverId, x.FactoryId, x.TrailerId, x.TruckId });
        }
    }
}
