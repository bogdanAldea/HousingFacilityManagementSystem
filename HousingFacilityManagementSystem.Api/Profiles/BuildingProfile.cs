using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Core.Models;

namespace HousingFacilityManagementSystem.Api.Profiles
{
    public class BuildingProfile : Profile
    {
        public BuildingProfile()
        {
            CreateMap<Building, BuildingDto>()
                .ReverseMap();
        }
    }
}
