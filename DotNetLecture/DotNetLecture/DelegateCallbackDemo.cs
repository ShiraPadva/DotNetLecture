using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLecture
{
    using System;

    // Define a delegate for the callback
    public delegate void CallbackDelegate(string message);
        

    public class DelegateCallbackDemo
    {
        // Method that performs an operation and invokes the callback
        public static void PerformOperation(int x, int y, CallbackDelegate callback)
        {
            int result = x + y;
            callback($"The result of the operation is: {result}");
        }

        // Callback method to be passed to PerformOperation
        public static void MyCallback(string message)
        {
            Console.WriteLine($"Callback received: {message}");
        }

        public static void Demo()
        {
            // Create a delegate instance pointing to the callback method
            CallbackDelegate callbackDelegate = new CallbackDelegate(MyCallback);

            // Call the method with the callback
            PerformOperation(3, 4, callbackDelegate);
        }
    }
}
