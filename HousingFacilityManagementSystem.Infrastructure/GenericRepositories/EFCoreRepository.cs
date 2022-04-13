using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure.GenericRepositories
{
    public class EFCoreRepository<T> : IGenericRepository<T> where T : class, IEntity
    {

        private readonly HousingFacilityContext _housingFacilityContext;

        public EFCoreRepository(HousingFacilityContext houdingFacilityContext)
        {
            _housingFacilityContext = houdingFacilityContext;
        }

        public void Add(T entity)
        {
            _housingFacilityContext
                .Set<T>()
                .Add(entity);
            
            _housingFacilityContext
                .SaveChanges();
        }

        public void Delete(T entity)
        {
            _housingFacilityContext
                .Set<T>()
                .Remove(entity);

            _housingFacilityContext
                .SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _housingFacilityContext
                .Set<T>()
                .ToList();
        }

        public T GetById(int id)
        {
            return _housingFacilityContext
                .Set<T>()
                .Where(entity => entity.Id == id)
                .First();
        }

        public void Update(T entity)
        {
            _housingFacilityContext
                .Set<T>()
                .Update(entity);

            _housingFacilityContext
                .SaveChanges();
        }
    }
}
