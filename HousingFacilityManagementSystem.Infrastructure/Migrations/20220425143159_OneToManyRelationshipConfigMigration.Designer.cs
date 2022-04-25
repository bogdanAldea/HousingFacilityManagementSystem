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
    [Migration("20220425143159_OneToManyRelationshipConfigMigration")]
    partial class OneToManyRelationshipConfigMigration
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

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("NumberInBuilding")
                        .HasColumnType("int");

                    b.Property<double>("PaymentDebt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<int>("Residents")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<double>("SurfaceArea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<int?>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("TenantId")
                        .IsUnique()
                        .HasFilter("[TenantId] IS NOT NULL");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.BranchedConsumableUtility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("AmountToPay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("ApartmentId1")
                        .HasColumnType("int");

                    b.Property<int>("CurrentMonthIndex")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("IndexMeter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<bool>("IsBranched")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("ApartmentId1");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("BranchedConsumableUtilities");
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

                    b.HasIndex("AdministratorId")
                        .IsUnique()
                        .HasFilter("[AdministratorId] IS NOT NULL");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ApartmentId")
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

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.MasterConsumableUtility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int?>("BuildingId1")
                        .HasColumnType("int");

                    b.Property<int>("CurrentMonthIndex")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("IndexMeter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0.0m);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("BuildingId1");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("MasterConsumableUtilities");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Tenant", b =>
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

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.UniversalUtility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0.0m);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("UniversalUtilities");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Apartment", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Building", null)
                        .WithMany("Apartments")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Tenant", "Tenant")
                        .WithOne("Apartment")
                        .HasForeignKey("HousingFacilityManagementSystem.Core.Models.Apartment", "TenantId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.BranchedConsumableUtility", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Apartment", "Apartment")
                        .WithMany()
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Apartment", null)
                        .WithMany("BranchedUtilities")
                        .HasForeignKey("ApartmentId1");

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Building", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Administrator", "Administrator")
                        .WithOne("Building")
                        .HasForeignKey("HousingFacilityManagementSystem.Core.Models.Building", "AdministratorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Administrator");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Invoice", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Apartment", null)
                        .WithMany("Invoices")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.MasterConsumableUtility", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Building", null)
                        .WithMany("MasterConsumableUtilities")
                        .HasForeignKey("BuildingId1");

                    b.Navigation("Building");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.UniversalUtility", b =>
                {
                    b.HasOne("HousingFacilityManagementSystem.Core.Models.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Administrator", b =>
                {
                    b.Navigation("Building");
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
                });

            modelBuilder.Entity("HousingFacilityManagementSystem.Core.Models.Tenant", b =>
                {
                    b.Navigation("Apartment");
                });
#pragma warning restore 612, 618
        }
    }
}
