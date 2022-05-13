using HousingFacilityManagementSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Repositories
{
    public interface IIdentityRepository<IEntity>
    {
        public IEntity LoginUser(string username);
        public void RegisterUser(IEntity user);
        public bool UserEmailExists(string email);
    }
}
