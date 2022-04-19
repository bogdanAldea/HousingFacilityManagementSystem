using HousingFacilityManagementSystem.Core.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Tests
{
    [TestFixture]
    public class BuildingTests
    {

        private Building _building;

        [SetUp]
        public void Setup()
        {
            _building = new Building(5);
        }

        [TestCase(5, 5)]
        [TestCase(4, 4)]
        [TestCase(6, 6)]
        [TestCase(7, 7)]
        [TestCase(8, 8)]
        [TestCase(9, 9)]
        public void CreateApartmentsShouldCreateApartmentsBasedOnBuildingCapacityProperty(int capacity, int expectedLength)
        {
            // Arrange
            _building.Capacity = capacity;

            // Act
            _building.CreateApartments();

            // Assert
            Assert.AreEqual(expectedLength, _building.Apartments.Count);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        public void BuildingContructorShouldAcceptCapacityGreaterOrEqualToTwo(int capacity)
        {
            // Arrange

            // Act
             
            // Assert
            Assert.Throws<ArgumentException>(() => new Building(capacity));
        }

    }
}
