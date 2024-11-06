namespace MathEngine.corelibs.strategies
{
    // Implementation for factorial calculation using recursive approach
    public class Factorial : IFactorialStrategy
    {
        public long CalculateFactorial(int n)
        {
            if(!Utility.IsNonNegativeInteger(n)) return -1;

            return n == 0 ? 1 : n * CalculateFactorial(n - 1);
        }
    }
}
