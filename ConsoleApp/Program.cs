using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Factories;
using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Models;


List<Utility> coreUtilities = new List<Utility>() 
{ 
    new Utility(name: "Cold Water", utilityType: UtilityType.Consumable),
    new Utility(name: "Hot Water", utilityType: UtilityType.Consumable),
    new Utility(name: "Gas", utilityType: UtilityType.Consumable),
    new Utility(name: "Heat", utilityType: UtilityType.Consumable),
};

IConsumableUtilityFactory<MasterConsumableUtility> masterConsumableFactory = new MasterConsumableUtilityFactory();
IConsumableUtilityFactory<BranchedConsumableUtility> branchedConsumableFactory = new BranchedConsumableUtilityFactory();

MasterConsumableUtility hotWater = masterConsumableFactory.CreateConsumableUtility(indexMeter: 564879542, coreUtilities[1]);
