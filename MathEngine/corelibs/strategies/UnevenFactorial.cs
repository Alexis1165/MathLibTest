namespace MathEngine.corelibs.strategies
{
    // Implementation for uneven factorial calculation
    public class UnevenFactorial : IFactorialStrategy
    {
        public long CalculateFactorial(int n)
        {
            if(!Utility.IsNonNegativeInteger(n)) return -1;

            return Enumerable.Range(1, n)
                             .Where(x => x % 2 != 0)  //Condition for only odd numbers
                             .Aggregate(1L, (acc, x) => acc * x);
        }
    }
}
