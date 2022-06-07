using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Application.Identity.Commands;

namespace HousingFacilityManagementSystem.Api.Profiles
{
    public class IdentityProfile : Profile
    {
        public IdentityProfile()
        {
            CreateMap<UserRegistrationDto, RegisterAdminCommand>();
            CreateMap<UserLoginDto, LoginAdminCommand>();
        }
    }
}
