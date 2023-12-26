using System;
using System.Text.Json;
using System.Threading;

namespace DotNetLecture
{
    internal class JsonDemo
    {
        public static void Demo()
        {
            // Creating a sample object
            Person person = new Person { Name = "John", Age = 30, IsActive = true };

            // Serializing the object to JSON
            string json = JsonSerializer.Serialize(person);

            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(json);

            // Deserializing JSON to object
            Person personDeserialized = JsonSerializer.Deserialize<Person>(json);

            Console.WriteLine("Deserialized Object:");
            Console.WriteLine($"Name: {personDeserialized.Name}, Age: {personDeserialized.Age}, IsActive: {personDeserialized.IsActive}");

        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool IsActive { get; set; }
        }
    }
}