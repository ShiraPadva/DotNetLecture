using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DotNetLecture
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Occupation { get; set; }

        public Person(string name, int age, string occupation)
        {
            Name = name;
            Age = age;
            Occupation = occupation;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Occupation: {Occupation}";
        }
    }

    class SerializationDemo
    {
        public static void Demo()
        {
            // Create a Person object
            Person person = new Person("John Doe", 30, "Software Engineer");

            // Serialize the object to a file
            SerializeObject(person, "person.bin");

            // Deserialize the object from the file
            Person deserializedPerson = DeserializeObject<Person>("person.bin");

            // Display the original and deserialized objects
            Console.WriteLine("Original Person: " + person);
            Console.WriteLine("Deserialized Person: " + deserializedPerson);
        }

        static void SerializeObject<T>(T obj, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(stream, obj);
            }
        }

        static T DeserializeObject<T>(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                return (T)formatter.Deserialize(stream);
            }
        }
    }

}
