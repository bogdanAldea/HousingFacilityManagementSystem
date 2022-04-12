using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Services
{
    public class ApartmentService : IApartmentService
    {

        private readonly IGenericRepository<Apartment> _apartmentRepository;

        public ApartmentService(IGenericRepository<Apartment> apartmentRepository)
        {
            _apartmentRepository = apartmentRepository;
        }

        public void CreateAparment(int numberInBuilding)
        {
            Apartment apartment = new Apartment(numberInBuilding);
            _apartmentRepository.Add(apartment);
        }

        public void SetNumberOfResidents(int apartmentId, int numberOfResidents)
        {
            Apartment apartment = _apartmentRepository.GetById(apartmentId);
            apartment.Residents = numberOfResidents;    
            _apartmentRepository.Update(apartment);
        }

        public void SetSurfaceArea(int apartmentId, double surfaceArea)
        {
            Apartment apartment = _apartmentRepository.GetById(apartmentId);
            apartment.SurfaceArea = surfaceArea;
            _apartmentRepository.Update(apartment);
        }

        public void SetTenant(int apartmentId, Tenant tenant)
        {
            Apartment apartment = _apartmentRepository.GetById(apartmentId);
            apartment.Tenant = tenant;
            _apartmentRepository.Update(apartment);
        }
    }
}
