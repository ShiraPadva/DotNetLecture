using System;
using System.Threading;

namespace DotNetLecture
{
    internal class ThreadsDemo
    {
        public static void Demo()
        {
            // Create a new thread and start it
            Thread myThread = new Thread(MyThreadMethod);
            myThread.Start();

            // Continue with other work in the main thread
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main thread is running: {i}");
                Thread.Sleep(500);
            }

            // Wait for the thread to complete (optional)
            myThread.Join();

            Console.WriteLine("Main method completed.");
        }

        static void MyThreadMethod()
        {
            // Code to be executed in the new thread
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Thread is running: {i}");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Thread completed.");
        }
    }
}