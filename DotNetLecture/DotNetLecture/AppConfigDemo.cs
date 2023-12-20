using System.Configuration;

namespace DotNetLecture
{
    internal class AppConfigDemo
    {
        public static void Demo()
        {
            string someSetting = ConfigurationManager.AppSettings["SomeSetting"];
            string anotherSetting = ConfigurationManager.AppSettings["AnotherSetting"];

            Console.WriteLine($"SomeSetting: {someSetting}");
            Console.WriteLine($"AnotherSetting: {anotherSetting}");
        }
    }
}
