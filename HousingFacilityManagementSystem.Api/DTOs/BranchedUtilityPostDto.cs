namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class BranchedUtilityPostDto
    {
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public bool IsBranched { get; set; } = false;
        public decimal PaymentAmount { get; set; }
    }
}
