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
    public class ApartmentEntityTypeConfiguration : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {
            builder
                .Property(apartment => apartment.SurfaceArea)
                .HasDefaultValue(0);
            
            builder
                .Property(apartment => apartment.Residents)
                .HasDefaultValue(0);   
            
            builder
                .Property(apartment => apartment.PaymentDebt)
                .HasDefaultValue((double)0);

            builder
                .HasOne(apartment => apartment.Tenant)
                .WithOne(tenant => tenant.Apartment)
                .HasForeignKey<Apartment>(apartment => apartment.TenantId)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasMany(apartment => apartment.BranchedUtilities)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
