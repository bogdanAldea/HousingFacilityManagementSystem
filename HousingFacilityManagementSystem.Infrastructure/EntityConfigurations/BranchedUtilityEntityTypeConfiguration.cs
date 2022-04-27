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
    public class BranchedUtilityEntityTypeConfiguration : IEntityTypeConfiguration<BranchedConsumableUtility>
    {
        public void Configure(EntityTypeBuilder<BranchedConsumableUtility> builder)
        {   
            builder.
                Property(utility => utility.IsBranched)
                .HasDefaultValue(false);
            
            builder
                .Property(utility => utility.IndexMeter)
                .HasDefaultValue(0);
            
            builder
                .Property(utility => utility.CurrentMonthIndex)
                .HasDefaultValue(0);
            
            builder
                .Property(utility => utility.AmountToPay)
                .HasDefaultValue(0);
        }
    }
}
