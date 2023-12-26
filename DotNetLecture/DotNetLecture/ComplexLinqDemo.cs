using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetLecture
{
    public class ComplexLinqDemo
    {
        public static void Demo()
        {
            // Dictionary representing books with authors and publication years
            Dictionary<string, (string Author, int Year)> books = new Dictionary<string, (string, int)>
            {
                { "The Catcher in the Rye", ("J.D. Salinger", 1951) },
                { "To Kill a Mockingbird", ("Harper Lee", 1960) },
                { "1984", ("George Orwell", 1949) },
                { "The Great Gatsby", ("F. Scott Fitzgerald", 1925) },
                { "Brave New World", ("Aldous Huxley", 1932) },
                { "The Hobbit", ("J.R.R. Tolkien", 1937) },
                { "Harry Potter and the Sorcerer's Stone", ("J.K. Rowling", 1997) },
                { "The Lord of the Rings", ("J.R.R. Tolkien", 1954) }
            };

            // Array of tuples representing additional information about books
            (string Title, bool Bestseller, decimal Price)[] additionalInfo =
            {
                ("The Catcher in the Rye", true, 14.99m),
                ("To Kill a Mockingbird", true, 12.50m),
                ("1984", false, 9.99m),
                ("The Great Gatsby", true, 11.75m),
                ("Brave New World", false, 13.25m),
                ("The Hobbit", true, 17.50m),
                ("Harry Potter and the Sorcerer's Stone", true, 21.99m),
                ("The Lord of the Rings", true, 24.99m)
            };

            // Example 1: Joining - Join the books dictionary with additionalInfo array
            var joinedBooks = from book in books
                              join info in additionalInfo on book.Key equals info.Title
                              select new
                              {
                                  Title = book.Key,
                                  Author = book.Value.Author,
                                  Year = book.Value.Year,
                                  Bestseller = info.Bestseller,
                                  Price = info.Price
                              };

            Console.WriteLine("Joined information about books:");
            foreach (var bookInfo in joinedBooks)
            {
                Console.WriteLine($"{bookInfo.Title} by {bookInfo.Author} ({bookInfo.Year}) - Bestseller: {bookInfo.Bestseller}, Price: ${bookInfo.Price}");
            }

            Console.WriteLine("\n-------------------\n");

            // Example 2: Grouping - Group books by their author
            var groupedByAuthor = from book in books
                                  group book by book.Value.Author into authorGroup
                                  select new
                                  {
                                      Author = authorGroup.Key,
                                      Titles = authorGroup.Select(b => b.Key)
                                  };

            Console.WriteLine("Books grouped by author:");
            foreach (var authorGroup in groupedByAuthor)
            {
                Console.WriteLine($"{authorGroup.Author} - {string.Join(", ", authorGroup.Titles)}");
            }

            Console.WriteLine("\n-------------------\n");

            // Example 3: Aggregation - Calculate the average price of bestsellers
            var bestsellers = from info in additionalInfo
                              where info.Bestseller
                              select info.Price;

            decimal averagePrice = bestsellers.Average();

            Console.WriteLine($"Average price of bestsellers: ${averagePrice}");
        }
    }

}
