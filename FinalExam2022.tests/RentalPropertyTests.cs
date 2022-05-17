using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FinalExam2022;

namespace FinalExam2022.tests
{
    [TestClass]
    public class RentalPropertyTests
    {

        /// <summary>
        /// Tests the increase rent amount method of the Rental Property Class
        /// </summary>
        [TestMethod]
        public void TestIncreaseRentByTenPercent()
        {
            //Arrange
            decimal expectedResult = 150.00m;

            //Act
            RentalProperty testProperty = new RentalProperty() { };
            testProperty.Price = 1500.00m;
            decimal actualResult = testProperty.IncreaseRentByPercentageAmount(.10m);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        [DataRow(.10, 150.0)]
        [DataRow(.50, 750.0)]
        [DataRow(.33, 495)]
        public void TestIncreaseRentByMultiplePercentValues(double percent, double result)
        {
            //Arrange

            //Act
            RentalProperty testProperty = new RentalProperty() { };
            testProperty.Price = 1500.00m;

            //Get the result and cast to a double to meet datarow requirements
            double actualResult = (double)testProperty.IncreaseRentByPercentageAmount((decimal)percent);

            //Assert
            Assert.AreEqual(result, actualResult);
        }
    }
}
