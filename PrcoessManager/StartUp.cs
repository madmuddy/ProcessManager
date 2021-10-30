using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrcoessManager
{
    static class StartUp
    {
        public static int Configure()
        {
            try
            {
                Consts.programPath = Directory.GetCurrentDirectory();
                Consts.tempPath = Path.GetTempPath();
                Consts.procsFilePath = Path.Combine(Consts.tempPath, Consts.procsFileName);
                Consts.E_procsFilePath = Path.Combine(Consts.tempPath, Consts.E_procsFileName);
                Consts.procsDirFilePath = Path.Combine(Consts.tempPath, Consts.procsDirFileName);

                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
