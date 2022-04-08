using HousingFacilityManagementSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models
{
    public class Tenant : IUser
    {

        public Tenant(string firstName, string lastName, string emailAddress, string username)
        {
            FirstName = firstName;
            LastName = lastName;   
            EmailAddress = emailAddress;
            Username = username;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
    }
}
