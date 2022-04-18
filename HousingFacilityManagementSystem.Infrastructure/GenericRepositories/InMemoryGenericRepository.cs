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

        private readonly ICollection<T> _inMemoryContext;

        public InMemoryGenericRepository(ICollection<T> inMemoryContext)
        {
            this._inMemoryContext = inMemoryContext;
        }

        public void Add(T entity)
        {
            if (entity == null) 
            { 
                throw new ArgumentNullException(); 
            }
            entity.Id = _inMemoryContext.Count() + 1;
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

        public ICollection<T> GetAll()
        {
            return _inMemoryContext;
        }

        public T GetById(int id)
        {
            return _inMemoryContext.FirstOrDefault(entity => entity.Id == id);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            IEntity oldEntity = _inMemoryContext.Where(oldEntity => oldEntity.Id == entity.Id).First();
            if (oldEntity != null)
            {
                oldEntity = entity;
            }
            else
            {
                throw new ArgumentNullException();
            }

        }
    }
}
