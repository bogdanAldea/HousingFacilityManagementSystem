using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Core.Models;

namespace HousingFacilityManagementSystem.Api.Profiles
{
    public class MasterUtilityProfile : Profile
    {
        public MasterUtilityProfile()
        {
            CreateMap<MasterConsumableUtility, MasterUtilityDto>()
                .ReverseMap();
        }
    }
}
