namespace HousingFacilityManagementSystem.Api.DTOs.Utilities
{
    public class MasterToBranchedDto
    {
        public int Id { get; set; }
        public int MasterConsumableUtilityId { get; set; }
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public bool IsBranched { get; set; } = false;
        public int ApartmentId { get; set; }
    }
}
