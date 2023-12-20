using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNetLecture
{
    internal class LinqToXmlExample
    {
        public static void demo()
        {
            string filePath = @"../../../books.xml";

            try
            {
                // Load the XML file into an XDocument
                XDocument xdoc = XDocument.Load(filePath);

                // Query the XML using LINQ to XML
                var books = from book in xdoc.Descendants("book")
                            select new
                            {
                                Title = book.Element("title").Value,
                                Author = book.Element("author").Value,
                                Price = Convert.ToDouble(book.Element("price").Value)
                            };

                // Display the existing books
                Console.WriteLine("Existing Books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price:C}");
                }

                // Add a new book
                XElement newBook = new XElement("book",
                    new XElement("title", "Advanced C# Programming"),
                    new XElement("author", "Alice Johnson"),
                    new XElement("price", 49.99)
                );

                // Add the new book to the root element
                xdoc.Root.Add(newBook);

                // Save the changes back to the XML file
                xdoc.Save(filePath);

                // Display the updated list of books
                Console.WriteLine("\nUpdated Books:");
                foreach (var updatedBook in xdoc.Descendants("book"))
                {
                    Console.WriteLine($"Title: {updatedBook.Element("title").Value}, " +
                                      $"Author: {updatedBook.Element("author").Value}, " +
                                      $"Price: {Convert.ToDouble(updatedBook.Element("price").Value):C}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
