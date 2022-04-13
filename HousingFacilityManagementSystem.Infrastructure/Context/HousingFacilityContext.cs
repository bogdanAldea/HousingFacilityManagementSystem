using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure.Context
{
    public class HousingFacilityContext : DbContext
    {

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<UniversalUtility> UniversalUtilities { get; set; }
        public DbSet<MasterConsumableUtility> MasterConsumableUtilities { get; set; }
        public DbSet<BranchedConsumableUtility> BranchedConsumableUtilities { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0FIHO2U\SQLEXPRESS; Database=HousingFacilityDatabase; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdministratorEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TenantEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ApartmentEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MasterUtilityEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new BranchedUtilityEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UniversalUtilityEntityTypeConfiguration());
        }
    }
}
