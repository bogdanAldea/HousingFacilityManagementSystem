using HousingFacilityManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HousingFacilityManagementSystem.Core.Tests
{
    [TestFixture]
    public class BranchedutilityPaymentTests
    {

        private BranchedConsumableUtility _utility;

        [SetUp]
        public void Setup()
        {
            _utility = new BranchedConsumableUtility("Cold Water", Enums.UtilityType.Consumable, 563245);
            
        }

        [TestCase(5.5, 10, 55)]
        [TestCase(4.2, 8, 33.6)]
        [TestCase(10.4, 6, 62.4)]
        [TestCase(9.6, 4, 38.4)]
        public void CalculatePaymentShouldAssignValueToAmountToPayProperty(decimal price, int index, decimal expected)
        {
            // Arrange
            _utility.CurrentMonthIndex = index;

            // Act
            _utility.CalculatePayment(price);

            // Assert
            decimal actual = _utility.AmountToPay;
            Assert.AreEqual(expected, actual);

        }

        [TestCase(0)]
        [TestCase(-1)]
        public void CalculatePaymentShouldThrowExceptionIfPriceIsLessThanOne(decimal price)
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => _utility.CalculatePayment(price));
        }

        [TestCase(4.5, -1)]
        [TestCase(2.6, -2)]
        [TestCase(4.9, -3)]
        public void CalculatePaymentShouldThrowExceptionIfIndexIsLessThanZero(decimal price,int index)
        {
            // Arrange
            _utility.CurrentMonthIndex=index;
            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => _utility.CalculatePayment(price));
        }
    }
}
