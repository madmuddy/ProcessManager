using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PrcoessManager
{
    static class Core
    {
        public static int StartProcess()
        {
            try
            {
                for (int i = 0; i < Consts.Process.Count; i++)
                {
                    ProcessStartInfo procInfo = new ProcessStartInfo();
                    procInfo.FileName = Consts.Process[i];
                    procInfo.WorkingDirectory = Consts.Process_Dir[i];

                    Process proc = new Process();
                    proc.StartInfo = procInfo;
                    proc.Start();
                }

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int EleminateProcess()
        {
            try
            {
                foreach (string procName in Consts.E_Process)
                {
                    foreach (Process proc in Process.GetProcessesByName(procName))
                    {
                        proc.Kill();
                    }
                }

                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
