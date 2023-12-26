using System.Reflection;
using PluginLibrary;

namespace DotNetLecture
{
    internal class ReflectionDemo
    {
        public static void Demo()
        {
            // Load the plugin assembly dynamically
            string pluginAssemblyPath = "../../../../PluginLibrary/bin/Debug/PluginLibrary.dll";
            Assembly pluginAssembly = Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pluginAssemblyPath));

            // Inspect types in the assembly
            Console.WriteLine("Types in the plugin assembly:");
            foreach (Type type in pluginAssembly.GetTypes())
            {
                Console.WriteLine(type.FullName);

                // Check if the type implements the IPlugin interface
                if (typeof(IPlugin).IsAssignableFrom(type) && !type.IsAbstract)
                {
                    // Create an instance of the plugin dynamically
                    IPlugin plugin = (IPlugin) Activator.CreateInstance(type);

                    // Invoke methods and properties dynamically
                    Console.WriteLine($"Plugin Name: {plugin.GetName()}");
                    plugin.PerformAction();
                }
            }
        }
    
    }
}