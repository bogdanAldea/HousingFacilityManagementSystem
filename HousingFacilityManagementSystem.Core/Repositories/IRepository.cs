using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Repositories
{
    public interface IRepository<T>
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        ICollection<T> GetAll();
        T GetById(int id);
    }
}
