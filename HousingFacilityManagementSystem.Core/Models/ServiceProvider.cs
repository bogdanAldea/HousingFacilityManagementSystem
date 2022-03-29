using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core
{
    public class ServiceProvider
    {
        public ServiceProvider(string name, ProvidedServiceContract contract)
        {
            Name = name;
            Contract = contract; 
        }
        public string Name { get; set; }
        public Address Location { get; set; }
        public ProvidedServiceContract Contract { get; set; }
    }
}
