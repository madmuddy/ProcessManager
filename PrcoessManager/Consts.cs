using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrcoessManager
{
    static class Consts
    {
        public static string programPath = "";
        public static string tempPath = "";

        public static string procsFileName = "proccess.proc";
        public static string procsFilePath = "";

        public static string procsDirFileName = "proccessDir.proc";
        public static string procsDirFilePath = "";

        public static string E_procsFileName = "eprocess.proc";
        public static string E_procsFilePath = "";

        public static List<string> Process;
        public static List<string> Process_Dir;
        public static List<string> E_Process;

        public static bool asAdmin = false;
    }
}
