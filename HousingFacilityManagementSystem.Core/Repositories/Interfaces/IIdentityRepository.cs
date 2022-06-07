using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Repositories.Interfaces
{
    public interface IIdentityRepository<T>
    {

        public Task AddIdentityProfile(T identityProfile);
        public Task<T> GetByIdentityId(string identityId);
        public DatabaseFacade Database();
        public Task<T> GetById(int id);
    }
}
