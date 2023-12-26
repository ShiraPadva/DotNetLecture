﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginLibrary
{
    public interface IPlugin
    {
        string GetName();
        void PerformAction();
    }
}
