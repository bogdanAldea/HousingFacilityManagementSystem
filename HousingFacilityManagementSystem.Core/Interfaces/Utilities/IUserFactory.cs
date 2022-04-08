using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Interfaces
{
    public interface IUserFactory
    {
        IUser CreateUser(string firstName, string lastName, string email);
    }
}
