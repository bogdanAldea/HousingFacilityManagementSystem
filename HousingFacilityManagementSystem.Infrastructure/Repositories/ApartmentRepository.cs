using HousingFacilityManagementSystem.Core.Exceptions;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure.Repositories
{
    public class ApartmentRepository : IRepository<Apartment>
    {

        private readonly HousingFacilityContext _context;

        public ApartmentRepository(HousingFacilityContext context)
        {
            _context = context;
        }

        public void Add(Apartment entity)
        {
            _context.Apartments.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Apartment entity)
        {
            _context.Apartments.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<Apartment> GetAll()
        {
            return _context.Apartments
                    .Include(apartment => apartment.BranchedUtilities)
                    .Include(apartment => apartment.Invoices)
                    .ToList();
        }

        public Apartment GetById(int id)
        {
            Apartment apartment =  _context.Apartments
                .Include(apartment => apartment.BranchedUtilities)
                .Include(apartment => apartment.Invoices)
                .SingleOrDefault(apartment => apartment.Id == id);
            return apartment;
        }

        public void Update(Apartment entity)
        {
            Apartment? oldApartment = _context.Apartments.SingleOrDefault(apartment => apartment.Id == entity.Id);
            
            _context.Entry(oldApartment).CurrentValues.SetValues(entity);
            _context.SaveChanges();
            
        }
    }
}
