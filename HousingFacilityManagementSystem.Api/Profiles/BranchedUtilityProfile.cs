using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Core.Models;

namespace HousingFacilityManagementSystem.Api.Profiles
{
    public class BranchedUtilityProfile : Profile
    {
        public BranchedUtilityProfile()
        {
            CreateMap<BranchedConsumableUtility, BranchedUtilityDto>()
                .ReverseMap();
        }
    }
}
