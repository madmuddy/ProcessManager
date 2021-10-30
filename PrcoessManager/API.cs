using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrcoessManager
{
    public static class API
    {
        public static int Start()
        {
            try
            {
                StartUp.Configure();
                Reader.LoadData();
                Core.StartProcess();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int Start(Config conf)
        {
            try
            {
                Consts.programPath = conf.programPath;
                Consts.tempPath = conf.tempPath;
                Consts.procsFileName = conf.ProcessFileName;
                Consts.procsFilePath = conf.ProcessFilePath;
                Consts.E_procsFileName = conf.E_ProcessFileName;
                Consts.E_procsFilePath = conf.E_ProcessFilePath;
                Consts.procsDirFileName = conf.procsDirFileName;
                Consts.procsDirFilePath = conf.procsDirFilePath;
                Consts.Process = conf.Processes;
                Consts.E_Process = conf.E_Processes;
                Consts.Process_Dir = conf.Process_Dir;

                Reader.LoadData();
                Core.StartProcess();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int Start(List<string> processes)
        {
            try
            {
                StartUp.Configure();
                Consts.Process = processes;
                Core.StartProcess();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int Kill()
        {
            try
            {
                StartUp.Configure();
                Reader.LoadData();
                Core.EleminateProcess();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int Kill(Config conf)
        {
            try
            {
                Consts.programPath = conf.programPath;
                Consts.tempPath = conf.tempPath;
                Consts.procsFileName = conf.ProcessFileName;
                Consts.procsFilePath = conf.ProcessFilePath;
                Consts.E_procsFileName = conf.E_ProcessFileName;
                Consts.E_procsFilePath = conf.E_ProcessFilePath;
                Consts.procsDirFileName = conf.procsDirFileName;
                Consts.procsDirFilePath = conf.procsDirFilePath;
                Consts.Process = conf.Processes;
                Consts.E_Process = conf.E_Processes;
                Consts.Process_Dir = conf.Process_Dir;

                Reader.LoadData();
                Core.EleminateProcess();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int Kill(List<string> EProcesses)
        {
            try
            {
                Consts.E_Process = EProcesses;
                Core.EleminateProcess();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public struct Config
        {
            public string programPath;
            public string tempPath;
            public string ProcessFileName;
            public string ProcessFilePath;
            public string E_ProcessFileName;
            public string E_ProcessFilePath;
            public string procsDirFileName;
            public string procsDirFilePath;
            public List<string> Processes;
            public List<string> E_Processes;
            public List<string> Process_Dir;
        }
    }
}
