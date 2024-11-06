namespace MathEngine.corelibs.strategies
{
    // Implementation for factorial calculation using list-based approach
    public class ListFactorial : IFactorialStrategy
    {
        public long CalculateFactorial(int n)
        {
            if(!Utility.IsNonNegativeInteger(n)) return -1;

            return Enumerable.Range(1, n).Aggregate(1L, (acc, x) => acc * x);
        }
    }
}
