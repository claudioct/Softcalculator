using System;
using System.Collections.Generic;
using System.Text;

namespace SoftCalculator.Application
{
    public class InsterestCalculatorService : IInsterestCalculatorService
    {
        private decimal _interestRate;

        public InsterestCalculatorService()
        {
            _interestRate = 0.01M;
        }

        public decimal Calculate(decimal initialAmount, int months)
        {
            if (initialAmount < 0)
                throw new ArgumentOutOfRangeException();

            if (months < 0)
                throw new ArgumentOutOfRangeException();

            var interestRate = Convert.ToDouble(_interestRate + 1);
            double doubleInitialAmount = (double)initialAmount;
            var doubleFinalAmount = doubleInitialAmount * Math.Pow(interestRate, months);
            decimal decimalFinalAmount = Convert.ToDecimal(doubleFinalAmount);
            return Math.Round(decimalFinalAmount, 2);
        }
    }
}
