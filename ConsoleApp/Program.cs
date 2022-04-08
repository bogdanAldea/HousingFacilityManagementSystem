using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Infrastructure;


UniversalUtility util = new UniversalUtility("Water", UtilityType.Consumable, 5.50m);

var x = util.GetType().GetProperty("Price").GetValue(util);
Console.WriteLine(x);