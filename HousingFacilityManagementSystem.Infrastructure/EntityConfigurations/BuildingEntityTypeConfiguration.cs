using HousingFacilityManagementSystem.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace HousingFacilityManagementSystem.Infrastructure.EntityConfigurations
{
    internal class BuildingEntityTypeConfiguration : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {

        }
    }
}
