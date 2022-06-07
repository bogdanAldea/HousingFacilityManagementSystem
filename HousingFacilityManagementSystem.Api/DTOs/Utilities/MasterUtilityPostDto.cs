namespace HousingFacilityManagementSystem.Api.DTOs.Utilities
{
    public class MasterUtilityPostDto
    {
        public string Name { get; set; }
        public int CurrentMonthIndex { get; set; }
        public int IndexMeter { get; set; }
        public decimal Price { get; set; }
    }
}
