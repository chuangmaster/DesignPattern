using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;

namespace DesignPattern
{
    public class DIContainerSampleV1
    {
        public static void Excute()
        {
            IMessageService service = (ShortMessageService)DIContainerV1.Resolve("ShortMessageService");
            service.Send();
            Console.ReadLine();
        }

    }

    public static class DIContainerV1
    {
        private static Dictionary<string, Type> _TypeMap;

        static DIContainerV1()
        {
            Register();
        }
        private static void Register()
        {
            _TypeMap = new Dictionary<string, Type>();

            _TypeMap.Add("EmailService", typeof(EmailService));
            _TypeMap.Add("ShortMessageService", typeof(ShortMessageService));

        }
        public static object Resolve(string typeName)
        {
            var type = _TypeMap[typeName];
            object instance = Activator.CreateInstance(type);
            return instance;
        }

    }
}