using HousingFacilityManagementSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Repositories
{
    public class InMemoryGenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {

        private List<T> _inMemoryContext;

        public InMemoryGenericRepository(List<T> inMemoryContext)
        {
            _inMemoryContext = inMemoryContext;
        }

        public void Add(T entity)
        {
            if (entity == null) 
            { 
                throw new ArgumentNullException(); 
            }
            _inMemoryContext.Add(entity);
        }

        public void Delete(T entity)
        {
            if (_inMemoryContext.Count() < 1) 
            { 
                throw new InvalidOperationException(); 
            }
            _inMemoryContext.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _inMemoryContext;
        }

        public T GetById(int id)
        {
            return _inMemoryContext.FirstOrDefault(entity => entity.Id == id);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
