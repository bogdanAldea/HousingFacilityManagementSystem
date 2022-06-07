using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs.Invoices;
using HousingFacilityManagementSystem.Core.Models;

namespace HousingFacilityManagementSystem.Api.Profiles
{
    public class InvoiceProfile : Profile
    {
        public InvoiceProfile()
        {
            CreateMap<Invoice, InvoiceDto>();
            CreateMap<InvoicePostDto, Invoice>();

        }
    }
}
