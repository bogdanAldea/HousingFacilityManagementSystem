using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Application.Identity.Commands;

namespace HousingFacilityManagementSystem.Api.Profiles
{
    public class AdministratorProfile : Profile
    {
        public AdministratorProfile()
        {
            CreateMap<UserRegistrationDto, RegisterAdminCommand>();
            CreateMap<UserLoginDto, LoginAdminCommand>();
        }
    }
}
