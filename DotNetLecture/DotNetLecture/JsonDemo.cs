using System;
using System.Text.Json;
using System.Threading;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using NugetJObject;

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

            //////////////////////////////////////////////////
            // JObject library

            // Convert the JSON string to a JObject
            JObject jsonObject = JObject.Parse(json);

            // Add a new key-value pair
            jsonObject["newKey"] = "newValue";

            // Convert the updated JObject back to a JSON string
            string updatedJsonString = jsonObject.ToString();

            // Print the updated JSON string
            Console.WriteLine(updatedJsonString);

        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool IsActive { get; set; }
        }
    }
}