using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FinalExam2022;

namespace FinalExam2022.tests
{
    [TestClass]
    public class RentalPropertyTests
    {
        [TestMethod]
        public void TestIncreaseRentByTenPercent()
        {
            //Arrange
            decimal expectedResult = 150.00m;

            RentalProperty testProperty = new RentalProperty() { };
            testProperty.Price = 1500.00m;

            //Act
            decimal actualResult = testProperty.IncreaseRentByPercentageAmount(.10m);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
