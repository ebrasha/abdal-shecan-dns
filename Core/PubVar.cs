using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Security_Group_App.Core
{
    internal class PubVar
    {
        // Get the path to the directory where the executable is located
        static public string executablePath = AppDomain.CurrentDomain.BaseDirectory;

        // Construct the full path to the config.xml file
        static public string configFilePath = Path.Combine(executablePath, "config.xml");
        static public bool debugging = false;
        static public bool cmdLogging = true;
    }
}