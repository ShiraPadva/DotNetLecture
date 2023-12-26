using System;
using System.Threading;

namespace DotNetLecture
{
    internal class TasksDemo
    {
        public static void Demo()
        {
            // Creating and starting a new task
            Task workerTask = Task.Run(() => DoWork());

            // Main thread doing some work
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main Thread: " + i);
                Task.Delay(100).Wait(); // Simulating work
            }

            // Wait for the worker task to complete
            workerTask.Wait();
        }

        static void DoWork()
        {
            // Work done by the new task
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker Task: " + i);
                Task.Delay(100).Wait(); // Simulating work
            }
        }
    }
}