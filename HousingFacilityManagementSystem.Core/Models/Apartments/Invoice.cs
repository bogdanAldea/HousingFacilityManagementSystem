using HousingFacilityManagementSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models
{
    public class Invoice : IEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal Payment { get; set; }
        public decimal  Penalties { get; set; }
        public bool IsPaid { get; set; }
        public int ApartmentId { get; set; }

        public Invoice(decimal payment, int apartmentId)
        {
            Number = GenerateInvoiceNumber();
            IssueDate = DateTime.Now;
            Payment = payment;
            Penalties = 0;
            ApartmentId = apartmentId;
        }

        public int GenerateInvoiceNumber()
        {
            Random random = new Random();
            return random.Next(1000, 10000);
        }

    }
}
