using System;
using Xunit;
using PromedioCalculatorApp;

namespace PromedioCalculatorTests
{
    public class PromedioCalculatorTests
    {
        [Fact]
        public void CalcularPromedio_ConjuntoValido_RetornaPromedioCorrecto()
        {
            // Arrange
            var calculator = new PromedioCalculator();
            int[] conjunto = { 1, 2, 3, 4, 5 };

            // Act
            double resultado = calculator.CalcularPromedio(conjunto);

            // Assert
            Assert.Equal(3.0, resultado);
        }

        [Fact]
        public void CalcularPromedio_ConjuntoVacio_LanzaArgumentException()
        {
            // Arrange
            var calculator = new PromedioCalculator();
            int[] conjunto = { };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.CalcularPromedio(conjunto));
        }

        [Fact]
        public void CalcularPromedio_ConjuntoNulo_LanzaArgumentException()
        {
            // Arrange
            var calculator = new PromedioCalculator();
            int[] conjunto = null;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.CalcularPromedio(conjunto));
        }

        [Fact]
        public void CalcularPromedio_ConjuntoConUnElemento_RetornaElElemento()
        {
            // Arrange
            var calculator = new PromedioCalculator();
            int[] conjunto = { 42 };

            // Act
            double resultado = calculator.CalcularPromedio(conjunto);

            // Assert
            Assert.Equal(42.0, resultado);
        }

        [Fact]
        public void CalcularPromedio_ConjuntoConNumerosNegativos_RetornaPromedioCorrecto()
        {
            // Arrange
            var calculator = new PromedioCalculator();
            int[] conjunto = { -1, -2, -3, -4, -5 };

            // Act
            double resultado = calculator.CalcularPromedio(conjunto);

            // Assert
            Assert.Equal(-3.0, resultado);
        }
    }
}
