namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class BranchedUtilityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public bool IsBranched { get; set; } = false;
        public decimal PaymentAmount { get; set; }
        public int ApartmentId { get; set; }
    }
}
