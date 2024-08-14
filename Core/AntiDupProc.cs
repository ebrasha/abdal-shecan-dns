using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Security_Group_App.Core
{
    internal class AntiDupProc
    {
        public static void AntiDuplicationProcess()
        {
            try
            {
                string currentProcessName = Process.GetCurrentProcess().ProcessName;



                var processes = Process.GetProcessesByName(currentProcessName).ToList();
                if (processes.Count > 1)
                {


                     Process.GetCurrentProcess().Kill();
                }
            }
            catch (Exception ex)
            {


             }




        }
    }
}
