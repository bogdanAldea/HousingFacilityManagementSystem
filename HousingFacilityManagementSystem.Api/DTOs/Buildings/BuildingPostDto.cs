using HousingFacilityManagementSystem.Api.DTOs.Utilities;


namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class BuildingPostDto
    {
        public int Capacity { get; set; }
        public int AdministratorId { get; set; }
        public List<MasterUtilityPostDto> MasterConsumableUtilities { get; set; }
    }
}
