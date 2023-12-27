using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLecture
{
    internal class DelegateDemo
    {
        // Delegate Declaration
        delegate int MathOperation(int a, int b);
        public static void Demo() 
        {
            // Methods to be Used with the Delegate
            int Add(int a, int b) => a + b;
            int Subtract(int a, int b) => a - b;

            // Delegate Instances
            MathOperation addDelegate = Add;
            MathOperation subtractDelegate = Subtract;

            // Using Delegates
            int resultAdd = addDelegate(5, 3);       // resultAdd = 8
            int resultSubtract = subtractDelegate(8, 3);  // resultSubtract = 5

            // Built-In delegates:

            // Action Delegate (No return value)
            Action<string> greetAction = (name) => Console.WriteLine($"Hello, {name}!");

            // Func Delegate (With return value)
            Func<int, int, int> multiplyFunc = (x, y) => x * y;

            // Using Action and Func
            greetAction("Alice");           // Prints: Hello, Alice!
            int resultMultiply = multiplyFunc(4, 5);  // resultMultiply = 20

        }
    }
}
