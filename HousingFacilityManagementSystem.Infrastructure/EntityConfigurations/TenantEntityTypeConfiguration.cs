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
    public class TenantEntityTypeConfiguration : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder
                .Property(tenant => tenant.FirstName)
                .HasMaxLength(25);
            
            builder
                .Property(tenant => tenant.LastName)
                .HasMaxLength(25);
            
            builder
                .Property(tenant => tenant.Username)
                .HasMaxLength(25);
            
            builder
                .HasIndex(tenant => tenant.EmailAddress)
                .IsUnique();
            
            builder
                .HasIndex(tenant => tenant.Username)
                .IsUnique();
        }
    }
}
