namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class InvoiceDto
    {
        public int Number { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal Payment { get; set; }
        public decimal Penalties { get; set; }
        public bool IsPaid { get; set; }
        public int ApartmentId { get; set; }
    }
}
