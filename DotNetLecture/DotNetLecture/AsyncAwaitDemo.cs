using System;
using System.Threading;

namespace DotNetLecture
{
    internal class AsyncAwaitDemo
    {
        public static async Task Demo()
        {
            Console.WriteLine("Starting the tasks...");

            // Create and start two asynchronous tasks
            Task<int> task1 = PerformAsyncTask("Task 1", 3000);
            Task<int> task2 = PerformAsyncTask("Task 2", 2000);

            // Await the completion of both tasks concurrently
            int result1 = await task1;
            int result2 = await task2;

            // Display the results
            Console.WriteLine($"Task 1 Result: {result1}");
            Console.WriteLine($"Task 2 Result: {result2}");

            Console.WriteLine("All tasks completed.");
        }

        static async Task<int> PerformAsyncTask(string taskName, int delay)
        {
            Console.WriteLine($"{taskName} started.");

            // Simulate asynchronous work
            await Task.Delay(delay);

            Console.WriteLine($"{taskName} completed.");

            return delay;
        }
    }
}