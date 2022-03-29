using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core
{
    public class ProvidedServiceContract
    {
        public ProvidedServiceContract(DateOnly contractStarts, DateOnly contractsEnds, double price)
        {
            ContractStarts = contractStarts;
            ContractEnds = contractsEnds;
            Price = price;
        }
        public DateOnly ContractStarts { get; set; }
        public DateOnly ContractEnds { get; set; }
        public double Price { get; set; }
    }
}
