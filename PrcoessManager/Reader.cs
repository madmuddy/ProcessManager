using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrcoessManager
{
    static class Reader
    {
        public static int LoadData()
        {
            try
            {
                if (!File.Exists(Consts.procsFilePath))
                {
                    using (StreamWriter sw = new StreamWriter(Consts.procsFilePath))
                    {
                        sw.Close();
                    }
                }
                else
                {
                    Consts.Process = File.ReadAllLines(Consts.procsFilePath).ToList();
                }

                if (!File.Exists(Consts.E_procsFilePath))
                {
                    using (StreamWriter sw = new StreamWriter(Consts.E_procsFilePath))
                    {
                        sw.Close();
                    }
                }
                else
                {
                    Consts.E_Process = File.ReadAllLines(Consts.E_procsFilePath).ToList();
                }

                if (!File.Exists(Consts.procsDirFilePath))
                {
                    using (StreamWriter sw = new StreamWriter(Consts.procsDirFilePath))
                    {
                        sw.Close();
                    }
                }
                else
                {
                    Consts.Process_Dir = File.ReadAllLines(Consts.procsDirFilePath).ToList();
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
