using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class AdapterPattern
    {
        public static void Excute()
        {
            ILogger adapter = new LoggerAdapter();
            adapter.Log("我是採用Adapter，由Adapter決定要呼叫誰");
            Console.ReadLine();
        }
    }

    public class LoggerAdapter : ILogger
    {
        ThirdPartLogger logger = new ThirdPartLogger();
        public void Log(string msg)
        {
            Console.WriteLine("在Adapter內，由Adapter決定要使用的Logger");
            logger.Log(msg);
        }
    }

    public class ThirdPartLogger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg + "被第三方的Logger所記錄...");
        }
    }
}
