using MathEngine.corelibs.strategies;

namespace MathEngine.corelibs
{
    public class MathLib
    {
        private readonly IFactorialStrategy _factorialStrategy;

        public MathLib(IFactorialStrategy factorialStrategy) => _factorialStrategy = factorialStrategy;

        public long Factorial(int n)
        {
            return _factorialStrategy.CalculateFactorial(n);
        }
    }
}
