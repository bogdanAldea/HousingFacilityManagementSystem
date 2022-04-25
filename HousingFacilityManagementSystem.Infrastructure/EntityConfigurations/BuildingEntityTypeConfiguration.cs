using HousingFacilityManagementSystem.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure.EntityConfigurations
{
    internal class BuildingEntityTypeConfiguration : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder
                .HasOne(building => building.Administrator)
                .WithOne(building => building.Building)
                .HasForeignKey<Building>(building => building.AdministratorId)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasMany(building => building.Apartments)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(building => building.MasterConsumableUtilities)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
