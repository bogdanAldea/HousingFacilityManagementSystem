using HousingFacilityManagementSystem.Core.Models;

namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class ApartmentPutDto
    {
        public int Residents { get; set; }
        public double SurfaceArea { get; set; }
    }
}
