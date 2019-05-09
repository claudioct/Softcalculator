using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftCalculator.Application.Tests
{
    [TestClass]
    public class InsterestCalculatorService_CalculateShould
    {

        [TestMethod]
        public void Return105m10GivenInitialAmount100AndMonths5()
        {
            // Arrange
            var insterestCalculatorService = new InsterestCalculatorService();

            // Act         
            var actual = insterestCalculatorService.Calculate(100, 5);

            // Assert
            Assert.AreEqual(105.10M, actual);
        }

        [TestMethod]
        public void ThrowExceptionGivenNegativeMonths()
        {
            // Arrange
            var insterestCalculatorService = new InsterestCalculatorService();

            const int NEGATIVE_MONTHS = -1;

            Action actual = () => insterestCalculatorService.Calculate(1000, NEGATIVE_MONTHS);

            Assert.ThrowsException<ArgumentOutOfRangeException>(actual);
        }

        [TestMethod]
        public void ThrowExceptionGivenNegativeInitalAmount()
        {
            // Arrange
            var insterestCalculatorService = new InsterestCalculatorService();

            const decimal NEGATIVE_INITIALAMOUNT= -0.1M;

            Action actual = () => insterestCalculatorService.Calculate(NEGATIVE_INITIALAMOUNT, 5);

            Assert.ThrowsException<ArgumentOutOfRangeException>(actual);
        }

    }
}
