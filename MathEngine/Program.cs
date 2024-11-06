using MathEngine.corelibs;
using MathEngine.corelibs.strategies;

// Using factorial based strategy
var mathLib = new MathLib(new Factorial());
var result  = mathLib.Factorial(5);
Console.WriteLine("Factorial (recursive) of 5: " + result);

// Using List-based strategy
mathLib = new MathLib(new ListFactorial());
result  = mathLib.Factorial(5);
Console.WriteLine("Factorial (list-based) of 5: " + result);

// Using Uneven strategy
mathLib = new MathLib(new UnevenFactorial());
result  = mathLib.Factorial(5);
Console.WriteLine("Factorial (uneven) of 5: " + result);

// Using Square factorial strategy
mathLib = new MathLib(new SquareFactorial());
result  = mathLib.Factorial(5);
Console.WriteLine("Factorial (square) of 5: " + result);
