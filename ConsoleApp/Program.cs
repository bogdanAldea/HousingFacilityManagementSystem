using HousingFacilityManagementSystem.Application.Services;
using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Interfaces.Utilities;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Core.Services;
using HousingFacilityManagementSystem.Infrastructure;
using HousingFacilityManagementSystem.Infrastructure.Context;
using HousingFacilityManagementSystem.Infrastructure.GenericRepositories;


IGenericRepository<Administrator> adminRepo = new EFCoreRepository<Administrator>(new HousingFacilityContext());
IGenericRepository<Building> buildingRepo = new EFCoreRepository<Building>(new HousingFacilityContext());
