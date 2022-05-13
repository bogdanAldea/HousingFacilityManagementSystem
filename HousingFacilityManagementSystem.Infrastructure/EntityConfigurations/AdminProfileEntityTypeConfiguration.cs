using HousingFacilityManagementSystem.Core.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure.EntityConfigurations
{
    public class AdminProfileEntityTypeConfiguration : IEntityTypeConfiguration<AdministratorProfile>
    {
        public void Configure(EntityTypeBuilder<AdministratorProfile> builder)
        {
            builder
                .Property(admin => admin.FirstName)
                .HasMaxLength(25);

            builder
                .Property(admin => admin.LastName)
                .HasMaxLength(25);
        }
    }
}
