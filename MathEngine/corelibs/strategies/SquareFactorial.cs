namespace MathEngine.corelibs.strategies
{
    // Implementation for square factorial calculation
    public class SquareFactorial : IFactorialStrategy
    {
        public long CalculateFactorial(int n)
        {
            if(!Utility.IsNonNegativeInteger(n)) return -1;

            return Enumerable.Range(1, n)
                             .Select(x => x * x)  // Square each number
                             .Aggregate(1L, (acc, x) => acc * x);
        }
    }
}
