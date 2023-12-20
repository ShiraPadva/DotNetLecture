using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLecture
{
    internal class LinqExample
    {
        public static void demo()
        {
            // Sample data
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ query expression to get even numbers
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            // Equivalent using method syntax
            // var evenNumbers = numbers.Where(num => num % 2 == 0);

            // Print the result
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
