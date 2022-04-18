using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Interfaces.Utilities;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Infrastructure;
using HousingFacilityManagementSystem.Infrastructure.Context;
using HousingFacilityManagementSystem.Infrastructure.GenericRepositories;


IGenericRepository<Apartment> apartmentRepo = new EFCoreRepository<Apartment>(new HousingFacilityContext());
IGenericRepository<BranchedConsumableUtility> branchedUtilRepo = new EFCoreRepository<BranchedConsumableUtility>(new HousingFacilityContext());
IGenericRepository<Administrator> adminRepo = new EFCoreRepository<Administrator>(new HousingFacilityContext());
IGenericRepository<Building> buildingRepo = new EFCoreRepository<Building>(new HousingFacilityContext());
IGenericRepository<Tenant> tenantRepo = new EFCoreRepository<Tenant>(new HousingFacilityContext());

// create new tenant
Tenant tenantA = new Tenant("Guthrirnir", "Thryr", "guthri.thryr@gmail.com", "guthtri10");
var ap = apartmentRepo.GetById(2);
ap.Tenant = tenantA;
apartmentRepo.Save();