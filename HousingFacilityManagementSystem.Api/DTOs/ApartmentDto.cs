namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class ApartmentDto
    {
        public int Residents { get; set; }
        public double SurfaceArea { get; set; }
        public decimal PaymentDebt { get; set; }
        public int BuildingId { get; set; }
    }
}
