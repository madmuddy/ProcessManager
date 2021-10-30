using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrcoessManager
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartUp.Configure();
                Reader.LoadData();

                Core.EleminateProcess();
                Core.StartProcess();
            }
            catch
            {
            }
        }
    }
}
