using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginLibrary
{
    public class PluginOne : IPlugin
    {
        public string GetName()
        {
            return "Plugin One";
        }

        public void PerformAction()
        {
            Console.WriteLine("Plugin One is performing an action.");
        }
    }
}
