using DesignPattern.DIContainer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DIContainer
{
    public class EmailService : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("Send Email...");

        }
    }
}
