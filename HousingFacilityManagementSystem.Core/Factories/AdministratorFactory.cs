using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Factories
{
    internal class AdministratorFactory : IUserFactory
    {
        public IUser CreateUser(string firstName, string lastName, string email)
        {
            return new Administrator(firstName, lastName, email);
        }
    }
}
