using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLecture
{
    internal class LambdaDemo
    {
        public static void Demo() 
        {
            // Lambda with No Parameters:
            Action printHello = () => Console.WriteLine("Hello, Lambda!");
            printHello(); // Output: Hello, Lambda!

            // Lambda with Parameters:
            Func<int, int, int> add = (x, y) => x + y;
            int result = add(3, 4); // Result: 7

            // Lambda as Argument:
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var squared = numbers.Select(x => x * x).ToList();


            // Lambda features:

            // Single Parameter Parentheses Omission:
            Action<int> printSquare1 = x => Console.WriteLine(x * x);

            // Expression vs. Statement Lambdas:
            // Expression Lambda
            Func<int, int, int> add2 = (x, y) => x + y;

            // Statement Lambda - multiple statements enclosed in curly braces
            Action<int> printSquare2 = x => { int square = x * x; Console.WriteLine(square); };

            // Capturing Variables from Outer Scope (Closures):
            int multiplier = 2;
            Func<int, int> multiply = x => x * multiplier;


        }
    }
}
