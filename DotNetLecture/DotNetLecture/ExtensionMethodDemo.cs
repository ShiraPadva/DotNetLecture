using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLecture
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    public class ExtensionMethodDemo
    {
        public static void Demo() 
        {
            string sentence = "This is an example sentence.";
            int count = sentence.WordCount();
            Console.WriteLine($"Word count: {count}"); // Output: Word count: 5
        }
    }
}
