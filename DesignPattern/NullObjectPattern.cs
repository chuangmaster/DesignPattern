using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class NullObjectPattern
    {
        public static void Excute()
        {
            //想記錄
            ILogger logger1 = new MessageLoger();
            logger1.Log("正常的紀錄...");
            //不想記錄
            ILogger logger2 = new NullObjectLoger();
            logger2.Log("不想要記錄...");

            Console.ReadLine();
        }
    }

    public interface ILogger
    {
        void Log(string msg);
    }

    public class MessageLoger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg + "被記錄");
        }
    }

    public class NullObjectLoger : ILogger
    {
        public void Log(string msg)
        {
            //do notthing...
        }
    }
}
