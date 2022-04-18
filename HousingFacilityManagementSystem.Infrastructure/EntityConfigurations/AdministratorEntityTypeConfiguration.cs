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
    public class AdministratorEntityTypeConfiguration : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> builder)
        {
            builder
                .Property(admin => admin.FirstName)
                .HasMaxLength(25);
            
            builder
                .Property(admin => admin.LastName)
                .HasMaxLength(25);
            
            builder
                .Property(admin => admin.Username)
                .HasMaxLength(25);
            
            builder
                .HasIndex(admin => admin.EmailAddress)
                .IsUnique();
            
            builder
                .HasIndex(admin => admin.Username)
                .IsUnique();  
        }
    }
}
