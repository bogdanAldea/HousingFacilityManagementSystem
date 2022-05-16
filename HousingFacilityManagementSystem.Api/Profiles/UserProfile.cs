using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Core.Models.Users;

namespace HousingFacilityManagementSystem.Api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AdministratorProfile, AdministratorProfileDto>().ReverseMap();
            CreateMap<TenantProfile, TenantProfileDto>().ReverseMap();
        }
    }
}
