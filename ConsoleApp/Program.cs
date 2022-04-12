using HousingFacilityManagementSystem.Application.Services;
using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Interfaces.Utilities;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Core.Services;
using HousingFacilityManagementSystem.Infrastructure;


// Administrator repository
ICollection<Administrator> adminContext = new List<Administrator>()
{
    new Administrator("Bogdan", "Aldea", "bogdan.aldea@gmail.com", "bogdan_aldea"){Id = 1},
    new Administrator("AdminFirstName", "AdminLastName", "user_admin@gmail.com", "user_admin"){Id=2},
};

IGenericRepository<Administrator> adminRepo = new InMemoryGenericRepository<Administrator>(adminContext);


// Tenant repository
ICollection<Tenant> tenantContext = new List<Tenant>()
{
    new Tenant("TenantX", "TenantY", "x.y@gmail.com", "x_y"){Id = 1},
    new Tenant("TenantA", "TenantB", "a.b@gmail.com", "a_b"){Id = 2}
};

IGenericRepository<Tenant> tenantRepo = new InMemoryGenericRepository<Tenant>(tenantContext);

// Building repository
ICollection<Building> buildingContext = new List<Building>()
{
    new Building(capacity: 10, administrator: adminContext.ToList()[0]){Id = 1},
    new Building(capacity: 5, administrator: adminContext.ToList()[1]){Id = 2},
};

IGenericRepository<Building> buildingRepo = new InMemoryGenericRepository<Building>(buildingContext);

Building b = buildingRepo.GetById(1);

Console.WriteLine($"{b.Capacity}, {b.Administrator.FirstName}");