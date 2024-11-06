using Xunit;
using MathEngine.corelibs;
using MathEngine.corelibs.strategies;

namespace MathLibTests
{
    public class MathLibTests
    {
        #region Basic Cases

        [Fact]
        public void Factorial_CalculatesCorrectly()
        {
            var strategy = new Factorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(1, mathLib.Factorial(0));
            Assert.Equal(1, mathLib.Factorial(1));
            Assert.Equal(120, mathLib.Factorial(5));
        }

        [Fact]
        public void ListFactorial_CalculatesCorrectly()
        {
            var strategy = new ListFactorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(1, mathLib.Factorial(0));
            Assert.Equal(1, mathLib.Factorial(1));
            Assert.Equal(120, mathLib.Factorial(5));
        }

        [Fact]
        public void UnevenFactorial_CalculatesCorrectly()
        {
            var strategy = new UnevenFactorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(1, mathLib.Factorial(1));
            Assert.Equal(105, mathLib.Factorial(8));
            Assert.Equal(945, mathLib.Factorial(9));
        }

        [Fact]
        public void SquareFactorial_CalculatesCorrectly()
        {
            var strategy = new SquareFactorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(1, mathLib.Factorial(0));
            Assert.Equal(576, mathLib.Factorial(4));
            Assert.Equal(14400, mathLib.Factorial(5));
        }

        #endregion Basic Cases
        
        #region Large Numbers

        [Fact]
        public void Factorial_LargeNumbers()
        {
            var strategy = new Factorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(2432902008176640000, mathLib.Factorial(20));
        }

        [Fact]
        public void ListFactorial_LargeNumbers()
        {
            var strategy = new ListFactorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(2432902008176640000, mathLib.Factorial(20));
        }

        [Fact]
        public void UnevenFactorial_LargeNumbers()
        {
            var strategy = new UnevenFactorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(2027025, mathLib.Factorial(15));
        }

        [Fact]
        public void SquareFactorial_LargeNumbers()
        {
            var strategy = new SquareFactorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(1, mathLib.Factorial(0));
        }

        #endregion Large Numbers

        #region Negative Numbers

        [Fact]
        public void Factorial_NegativeNumbers()
        {
            var strategy = new Factorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(-1, mathLib.Factorial(-1));
        }

        [Fact]
        public void ListFactorial_NegativeNumbers()
        {
            var strategy = new ListFactorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(-1, mathLib.Factorial(-1));
        }

        [Fact]
        public void UnevenFactorial_NegativeNumbers()
        {
            var strategy = new UnevenFactorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(-1, mathLib.Factorial(-1));
        }

        [Fact]
        public void SquareFactorial_NegativeNumbers()
        {
            var strategy = new SquareFactorial();
            var mathLib  = new MathLib(strategy);

            Assert.Equal(-1, mathLib.Factorial(-1));
        }

        #endregion Negative Numbers
    }
}
