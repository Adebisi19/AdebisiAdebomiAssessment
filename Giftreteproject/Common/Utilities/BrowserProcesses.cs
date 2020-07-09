using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace Giftreteproject.Common.Utilities
{
    class BrowserProcesses
    {
        public static void Kill(string processName)
        {

            try
            {
                Process[] runingProcesses = Process.GetProcesses();
                foreach (var process in runingProcesses)
                {
                    if (process.ProcessName.Contains(processName))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception)
            {




            }
        

        }    }      }
