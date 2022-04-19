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
    public class MasterUtilityEntityTypeConfiguration : IEntityTypeConfiguration<MasterConsumableUtility>
    {
        public void Configure(EntityTypeBuilder<MasterConsumableUtility> builder)
        {

            builder
                .HasIndex(utility => utility.Name)
                .IsUnique();

            builder
                .Property(utility => utility.IndexMeter)
                .HasDefaultValue(0);
            
            builder
                .Property(utility => utility.Price)
                .HasDefaultValue(0.0m);
            
            builder
                .Property(utility => utility.CurrentMonthIndex)
                .HasDefaultValue(0);
        }
    }
}
