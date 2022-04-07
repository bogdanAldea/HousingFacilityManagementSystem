using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Address
    {

        public Address(string streetName, string streetNumber, string city, string county, string country)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            City = city;
            County = county;
            Country = country;
        }

        public int Id { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string? PostalCode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }
}
