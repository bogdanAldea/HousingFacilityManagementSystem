﻿// <auto-generated />
using System;
using HousingFacilityManagementSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HousingFacilityManagementSystem.Infrastructure.Migrations
{
    [DbContext(typeof(HousingFacilityContext))]
    [Migration("20220413004448_AdministratorEntityConfigMigration")]
    partial class AdministratorEntityConfigMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("EmailAddress")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("NumberInBuilding")
                        .HasColumnType("int");

                    b.Property<double?>("PaymentDebt")
                        .HasColumnType("float");

                    b.Property<int?>("Residents")
                        .HasColumnType("int");

                    b.Property<double?>("SurfaceArea")
                        .HasColumnType("float");

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("TenantId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AdministratorId")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<int>("IssueDate")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<decimal>("Payment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Penalties")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Utilities.BranchedConsumableUtility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("AmountToPay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentMonthIndex")
                        .HasColumnType("int");

                    b.Property<int>("IndexMeter")
                        .HasColumnType("int");

                    b.Property<bool>("IsBranched")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("BranchedConsumableUtilities");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Utilities.MasterConsumableUtility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentMonthIndex")
                        .HasColumnType("int");

                    b.Property<int>("IndexMeter")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("MasterConsumableUtilities");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Utilities.UniversalUtility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("UniversalUtilities");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Apartment", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Building", null)
                        .WithMany("Apartments")
                        .HasForeignKey("BuildingId");

                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Building", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Administrator", "Administrator")
                        .WithMany()
                        .HasForeignKey("AdministratorId");

                    b.Navigation("Administrator");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Invoice", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Apartment", null)
                        .WithMany("Invoices")
                        .HasForeignKey("ApartmentId");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Utilities.BranchedConsumableUtility", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Apartment", null)
                        .WithMany("BranchedUtilities")
                        .HasForeignKey("ApartmentId");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Utilities.MasterConsumableUtility", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Building", null)
                        .WithMany("MasterConsumableUtilities")
                        .HasForeignKey("BuildingId");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Utilities.UniversalUtility", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Building", null)
                        .WithMany("UniversalUtilities")
                        .HasForeignKey("BuildingId");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Apartment", b =>
                {
                    b.Navigation("BranchedUtilities");

                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Building", b =>
                {
                    b.Navigation("Apartments");

                    b.Navigation("MasterConsumableUtilities");

                    b.Navigation("UniversalUtilities");
                });
#pragma warning restore 612, 618
        }
    }
}
