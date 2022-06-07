using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Infrastructure.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace HousingFacilityManagementSystem.Infrastructure.Context
{
    public class HousingFacilityContext : IdentityDbContext
    {
        public HousingFacilityContext() : base() { }
        public HousingFacilityContext(DbContextOptions options) : base(options) { }

        public DbSet<AdministratorProfile> Administrators { get; set; }
        public DbSet<TenantProfile> Tenants { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<UniversalUtility> UniversalUtilities { get; set; }
        public DbSet<MasterConsumableUtility> MasterConsumableUtilities { get; set; }
        public DbSet<BranchedConsumableUtility> BranchedConsumableUtilities { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-0FIHO2U\SQLEXPRESS; Database=ProjectDemoDatabase; Trusted_Connection=True;"
);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ApartmentEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MasterUtilityEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BranchedUtilityEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UniversalUtilityEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BuildingEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AdminProfileEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TenantProfileEntityTypeConfigurations());
        }
    }
}
