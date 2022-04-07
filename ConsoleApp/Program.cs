using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Factories;
using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Infrastructure;

List<Utility> coreUtilities = new List<Utility>() 
{ 
    new Utility(name: "Cold Water", utilityType: UtilityType.Consumable),
    new Utility(name: "Hot Water", utilityType: UtilityType.Consumable),
    new Utility(name: "Gas", utilityType: UtilityType.Consumable),
    new Utility(name: "Heat", utilityType: UtilityType.Consumable),
    new Utility(name: "Electricity", utilityType: UtilityType.Consumable),
};

List<MasterConsumableUtility> masterUtilities = new List<MasterConsumableUtility>()
{
    new MasterConsumableUtility(utility: coreUtilities[0], indexMeter: 54686453),
    new MasterConsumableUtility(utility: coreUtilities[1], indexMeter: 84653212),
    new MasterConsumableUtility(utility: coreUtilities[2], indexMeter: 48970134),
    new MasterConsumableUtility(utility: coreUtilities[3], indexMeter: 36520124),
};

InMemoryMasterConsumableUtilityRepository masterUtilityRepo = new InMemoryMasterConsumableUtilityRepository(masterUtilities);

var x = new MasterConsumableUtility(utility: coreUtilities[4], indexMeter: 54682312);
masterUtilityRepo.Add(x);


foreach (var master in masterUtilityRepo.GetAll())
{
    Console.WriteLine(master);
}