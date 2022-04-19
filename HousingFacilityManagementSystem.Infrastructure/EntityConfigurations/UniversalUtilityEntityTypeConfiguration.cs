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
    internal class UniversalUtilityEntityTypeConfiguration : IEntityTypeConfiguration<UniversalUtility>
    {
        public void Configure(EntityTypeBuilder<UniversalUtility> builder)
        {
            builder
                .HasIndex(utility => utility.Name)
                .IsUnique();

            builder
                .Property(utility => utility.Price)
                .HasDefaultValue(0.0m);
        }
    }
}
