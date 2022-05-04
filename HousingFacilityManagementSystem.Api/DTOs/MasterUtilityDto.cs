namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class MasterUtilityDto
    {
        public string Name { get; set; }
        public int BuildingId { get; set; }
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public decimal Price { get; set; }
    }
}
