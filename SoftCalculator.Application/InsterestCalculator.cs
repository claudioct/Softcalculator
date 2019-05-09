using System;
using System.Collections.Generic;
using System.Text;

namespace SoftCalculator.Application
{
    public class InsterestCalculator : IInsterestCalculator
    {
        private decimal _juros;

        public InsterestCalculator()
        {
            _juros = 0.01M;
        }

        public decimal Calculate(decimal valorInicial, int tempo)
        {
            return 0;
        }
    }
}
