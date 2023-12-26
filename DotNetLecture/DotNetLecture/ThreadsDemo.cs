using System;
using System.Threading;

namespace DotNetLecture
{
    internal class ThreadsDemo
    {
        public static void Demo()
        {
            // Creating and starting a new thread
            Thread thread = new Thread(DoWork);
            thread.Start();

            // Main thread doing some work
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main Thread: " + i);
                Thread.Sleep(100);
            }
        }

        static void DoWork()
        {
            // Work done by the new thread
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker Thread: " + i);
                Thread.Sleep(100);
            }
        }
    }
}