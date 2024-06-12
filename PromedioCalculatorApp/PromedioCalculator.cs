using System;
using System.Linq;

namespace PromedioCalculatorApp
{
    public class PromedioCalculator
    {
        public double CalcularPromedio(int[] conjunto)
        {
            if (conjunto == null || conjunto.Length == 0)
                throw new ArgumentException("El conjunto no puede estar vacío o ser nulo.");

            return conjunto.Average();
        }
    }
}
