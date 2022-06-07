using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Api.DTOs.Utilities;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;

namespace HousingFacilityManagementSystem.Api.Profiles
{
    public class MasterUtilityProfile : Profile
    {
        public MasterUtilityProfile()
        {
            CreateMap<MasterConsumableUtility, MasterUtilityDto>()
                .ReverseMap();

            CreateMap<MasterConsumableUtility, MasterUtilityPostDto>()
                .ReverseMap();
        }
    }
}
